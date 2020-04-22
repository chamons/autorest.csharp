// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace azure_special_properties
{
    /// <summary> The XMsClientRequestId service client. </summary>
    public partial class XMsClientRequestIdClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal XMsClientRequestIdRestClient RestClient { get; }
        /// <summary> Initializes a new instance of XMsClientRequestIdClient for mocking. </summary>
        protected XMsClientRequestIdClient()
        {
        }
        /// <summary> Initializes a new instance of XMsClientRequestIdClient. </summary>
        internal XMsClientRequestIdClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new XMsClientRequestIdRestClient(clientDiagnostics, pipeline, host);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get method that overwrites x-ms-client-request header with value 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get method that overwrites x-ms-client-request header with value 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get(CancellationToken cancellationToken = default)
        {
            return RestClient.Get(cancellationToken);
        }

        /// <summary> Get method that overwrites x-ms-client-request header with value 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </summary>
        /// <param name="xMsClientRequestId"> This should appear as a method parameter, use value &apos;9C4D50EE-2D56-4CD3-8152-34347DC9F2B0&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ParamGetAsync(string xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.ParamGetAsync(xMsClientRequestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get method that overwrites x-ms-client-request header with value 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </summary>
        /// <param name="xMsClientRequestId"> This should appear as a method parameter, use value &apos;9C4D50EE-2D56-4CD3-8152-34347DC9F2B0&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ParamGet(string xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.ParamGet(xMsClientRequestId, cancellationToken);
        }
    }
}