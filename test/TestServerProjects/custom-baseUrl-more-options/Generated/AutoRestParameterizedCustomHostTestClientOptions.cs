// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace custom_baseUrl_more_options
{
    /// <summary> Client options for AutoRestParameterizedCustomHostTestClient. </summary>
    public class AutoRestParameterizedCustomHostTestClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V1_0_0;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "1.0.0". </summary>
            V1_0_0 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of AutoRestParameterizedCustomHostTestClientOptions. </summary>
        public AutoRestParameterizedCustomHostTestClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V1_0_0 => "1.0.0",
                _ => throw new NotSupportedException()
            };
        }
    }
}