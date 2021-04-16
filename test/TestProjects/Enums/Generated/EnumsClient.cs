// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Enums.Models;

namespace Enums
{
    /// <summary> The Enums service client. </summary>
    public partial class EnumsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal EnumsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of EnumsClient for mocking. </summary>
        protected EnumsClient()
        {
        }

        /// <summary> Initializes a new instance of EnumsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal EnumsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new EnumsRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <param name="body"> The MyType to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> OperationAsync(MyType? body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumsClient.Operation");
            scope.Start();
            try
            {
                return await RestClient.OperationAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> 
        /// The MyType to use. 
        /// &apos;value1&apos;: Description about value1
        /// &apos;value2&apos;: Descripiton about value2.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Operation(MyType? body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumsClient.Operation");
            scope.Start();
            try
            {
                return RestClient.Operation(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}