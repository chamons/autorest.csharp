// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using AutoRest.CSharp.AutoRest.Plugins;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Serialization;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Output.Models.Serialization.Json;
using AutoRest.CSharp.Output.Models.Serialization.Xml;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using AutoRest.CSharp.Utilities;

namespace AutoRest.CSharp.Generation.Writers
{
    internal class LowLevelClientWriter
    {
        public void WriteClient(CodeWriter writer, Client client, Configuration configuration)
        {
            var cs = client.Type;
            var @namespace = cs.Namespace + ".Protocol";
            using (writer.Namespace(@namespace))
            {
                writer.WriteXmlDocumentationSummary(client.Description);
                using (writer.Scope($"{client.Declaration.Accessibility} partial class {cs.Name}"))
                {
                    WriteClientFields(writer, client);
                    WriteClientCtors(writer, client);

                    foreach (var clientMethod in client.Methods)
                    {
                        WriteClientMethod(writer, clientMethod, true, false);
                        WriteClientMethod(writer, clientMethod, true, true);
                        WriteClientMethod(writer, clientMethod, false, false);
                        WriteClientMethod(writer, clientMethod, false, true);
                        WriteClientMethodRequest(writer, clientMethod);
                    }

                    writer.Line();
                    writer.Line($"private static JsonData ToJsonData(object value)");
                    writer.Line($"{{");
                    writer.Line($"    if (value is JsonData)");
                    writer.Line($"    {{");
                    writer.Line($"        return (JsonData)value;");
                    writer.Line($"    }}");
                    writer.Line($"    return new JsonData(value);");
                    writer.Line($"}}");
                }
            }
        }

        private void WriteClientMethodRequest(CodeWriter writer, ClientMethod clientMethod)
        {
            RequestClientWriter.WriteRequestCreation(writer, clientMethod.RestClientMethod, lowLevel: true);
        }

        private void WriteClientMethod(CodeWriter writer, ClientMethod clientMethod, bool async, bool useDynamic)
        {
            CSharpType? bodyType = clientMethod.RestClientMethod.ReturnType;
            string responseType = async ? "Task<DynamicResponse>" : "DynamicResponse";

            if (async)
            {
                writer.UseNamespace("System.Threading.Tasks");
            }
            writer.UseNamespace("Azure");
            writer.UseNamespace("Azure.Core");

            var parameters = clientMethod.RestClientMethod.Parameters;
            writer.WriteXmlDocumentationSummary(clientMethod.Description);

            for (int i = 0 ; i < parameters.Length; ++i)
            {
                if (i == 0)
                {
                    writer.WriteXmlDocumentationParameter("body", "The request body");
                }
                else
                {
                    Parameter parameter = parameters[i];
                    writer.WriteXmlDocumentationParameter(parameter.Name, parameter.Description);
                }
            }

            writer.WriteXmlDocumentationParameter("cancellationToken", "The cancellation token to use.");

            var methodName = CreateMethodName(clientMethod.Name, async);
            var asyncText = async ? "async" : string.Empty;
            writer.Append($"public virtual {asyncText} {responseType} {methodName}(");


            for (int i = 0 ; i < parameters.Length; ++i)
            {
                if (i == 0)
                {
                    writer.Append($"{(useDynamic ? "dynamic" : "JsonData")} body, ");
                }
                else
                {
                    Parameter parameter = parameters[i];
                    writer.WriteParameter(parameter);
                }
            }
            writer.Line($"{typeof(CancellationToken)} cancellationToken = default)");

            using (writer.Scope())
            {
                writer.Append($"DynamicRequest req = {RequestClientWriter.CreateRequestMethodName(clientMethod.Name)}(");
                foreach (var parameter in clientMethod.RestClientMethod.Parameters.Skip(1))
                {
                     writer.Append($"{parameter.Name:I}, ");
                }
                writer.RemoveTrailingComma();
                writer.Append($");");
                writer.Line();

                if (useDynamic)
                {
                    writer.Line($"req.Content = DynamicContent.Create(ToJsonData(body));");
                }
                else
                {
                    writer.Line($"req.Content = DynamicContent.Create(body);");
                }

                if (async)
                {
                    writer.Line($"return await req.SendAsync(cancellationToken).ConfigureAwait(false);");
                }
                else
                {
                    writer.Line($"return req.Send(cancellationToken);");
                }
            }

            writer.Line();
        }

        private string CreateMethodName(string name, bool async) => $"{name}{(async ? "Async" : string.Empty)}";

        private const string EndpointProperty = "endpoint";
        private const string EndpointParameter = "endpoint";
        private const string PipelineVariable = "pipeline";
        private const string PipelineField = "_" + PipelineVariable;
        private const string KeyCredentialVariable = "credential";
        private const string ProtocolOptions = "options";

        private void WriteClientFields(CodeWriter writer, Client client)
        {
            writer.AppendRaw($"public virtual string {EndpointProperty} {{ get; }}");
            writer.Line($"private readonly {typeof(HttpPipeline)} {PipelineField};");

            // HACK - Where is this supposed to come from? Scope variable?
            writer.Line($"private const string AuthorizationHeader = \"Ocp-Apim-Subscription-Key\";\n");
        }

        private void WriteClientCtors(CodeWriter writer, Client client)
        {
            // Write the protected mock ctor
            writer.WriteXmlDocumentationSummary($"Initializes a new instance of {client.Type.Name} for mocking.");
            using (writer.Scope($"protected {client.Type.Name:D}()"))
            {
            }
            writer.Line();

            // Write the simplified 2 param ctor
            writer.WriteXmlDocumentationSummary($"Initializes a new instance of {client.Type.Name}");
            foreach (Parameter parameter in client.RestClient.Parameters)
            {
                writer.WriteXmlDocumentationParameter(parameter.Name, parameter.Description);
            }
            writer.WriteXmlDocumentationParameter(KeyCredentialVariable, "The credentials to use.");

            writer.Append($"public {client.Type.Name:D}(");
            foreach (Parameter parameter in client.RestClient.Parameters)
            {
                writer.WriteParameter(parameter);
            }
            // Hamons - Hack - Should use typeof here
            writer.RemoveTrailingComma();
            writer.Append($", AzureKeyCredential {KeyCredentialVariable}");
            writer.Line($") : this(endpoint, credential, new Azure.Core.ProtocolClientOptions())");
            using (writer.Scope())
            {
            }
            writer.Line();

            // Write the full 3param ctor
            writer.WriteXmlDocumentationSummary($"Initializes a new instance of {client.Type.Name}");
            foreach (Parameter parameter in client.RestClient.Parameters)
            {
                writer.WriteXmlDocumentationParameter(parameter.Name, parameter.Description);
            }
            writer.WriteXmlDocumentationParameter(KeyCredentialVariable, "The credentials to use.");
            writer.WriteXmlDocumentationParameter(ProtocolOptions, "Options to control the underlying operations.");

            writer.Append($"internal {client.Type.Name:D}(");
            foreach (Parameter parameter in client.RestClient.Parameters)
            {
                writer.WriteParameter(parameter);
            }
            // Hack - Should use typeof here
            writer.RemoveTrailingComma();
            writer.Append($", AzureKeyCredential {KeyCredentialVariable}");
            writer.Append($", Azure.Core.ProtocolClientOptions {ProtocolOptions}");
            writer.Line($")");

            using (writer.Scope())
            {
                writer.WriteParameterNullChecks (client.RestClient.Parameters);
                using (writer.Scope($"if ({KeyCredentialVariable} == null)"))
                {
                    writer.Line($"throw new {typeof(ArgumentNullException)}(nameof({KeyCredentialVariable}));");
                }
                // HACK - Should be named so not this.
                writer.Line($"this.{EndpointProperty} = {EndpointParameter};");
                writer.Line($"{PipelineField} = HttpPipelineBuilder.Build({ProtocolOptions}, new AzureKeyCredentialPolicy({KeyCredentialVariable}, AuthorizationHeader));");
            }
            writer.Line();
        }
    }
}
