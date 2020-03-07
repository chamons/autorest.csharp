// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> UrlPathMaps give a url path to the backend mapping information for PathBasedRouting. </summary>
    public partial class ApplicationGatewayUrlPathMap : SubResource
    {
        /// <summary> Name of the URL path map that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; internal set; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; internal set; }
        /// <summary> Default backend address pool resource of URL path map. </summary>
        public SubResource DefaultBackendAddressPool { get; set; }
        /// <summary> Default backend http settings resource of URL path map. </summary>
        public SubResource DefaultBackendHttpSettings { get; set; }
        /// <summary> Default Rewrite rule set resource of URL path map. </summary>
        public SubResource DefaultRewriteRuleSet { get; set; }
        /// <summary> Default redirect configuration resource of URL path map. </summary>
        public SubResource DefaultRedirectConfiguration { get; set; }
        /// <summary> Path rule of URL path map resource. </summary>
        public ICollection<ApplicationGatewayPathRule> PathRules { get; set; }
        /// <summary> The provisioning state of the URL path map resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}