/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// Address type of the application CLB.
        /// 
        /// - **Internet**: The load balancing has a public IP address, and the DNS domain name is resolved to the public IP, so it can be accessed via the public network.
        /// 
        /// - **Intranet**: The load balancer has only a private IP address, and the DNS domain name is resolved to the private IP, so it can only be accessed from the private network environment of the VPC where the load balancer resides.
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// Billing configuration of an application CLB instance.
        /// </summary>
        [JsonProperty("LoadBalancerBillingConfig")]
        public LoadBalancerBillingConfig LoadBalancerBillingConfig{ get; set; }

        /// <summary>
        /// Virtual Private Cloud (VPC) ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// AZ and private network subnet mapping list. A maximum of 10 AZs can be added. If the current region supports 2 or more AZs, a minimum of 2 AZs are required.
        /// </summary>
        [JsonProperty("ZoneMappings")]
        public ZoneMappingsItem[] ZoneMappings{ get; set; }

        /// <summary>
        /// IP address version. Value: IPv4 or IPv6.
        /// </summary>
        [JsonProperty("AddressIpVersion")]
        public string AddressIpVersion{ get; set; }

        /// <summary>
        /// Client Token, used for ensuring the idempotency of requests.
        /// 
        /// Generate a parameter value from your client to underwrite the uniqueness of the value for different requests. ClientToken supports only ASCII characters.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Deletion protection configuration.
        /// </summary>
        [JsonProperty("DeleteProtection")]
        public DeletionProtectionConfig DeleteProtection{ get; set; }

        /// <summary>
        /// Whether to only precheck this request. Parameter Value:
        /// 
        /// - **true**: Send a check request without creating an application CLB instance. Check items include whether required parameters are filled in, request format, and service limits. If the check fails, return the corresponding error. If the check passes, return the error code `DryRunOperation`.
        /// 
        /// - **false** (default value): Send a normal request. After the check is passed, return HTTP 2xx status code and directly perform the operation.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// EIP address type. Valid values:
        /// - **EIP**: Ordinary Elastic IP
        /// - **AntiDDoSEIP**: Anti-DDoS EIP
        /// - **AnycastEIP**: Accelerated EIP
        /// -**HighQualityEIP**: High Quality IP. High Quality IP is supported only in Singapore and Hong Kong (China).
        /// - **ResidentialEIP**: natively assigned IP
        /// 
        /// Default if not passed: EIP.
        /// </summary>
        [JsonProperty("InternetAddressType")]
        public string InternetAddressType{ get; set; }

        /// <summary>
        /// Application CLB instance name. It contains 1-80 characters, including Chinese characters, letters, digits, dashes (-), forward slashes (/), half-width periods (.), and underscores (_).
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamObj(map, prefix + "LoadBalancerBillingConfig.", this.LoadBalancerBillingConfig);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArrayObj(map, prefix + "ZoneMappings.", this.ZoneMappings);
            this.SetParamSimple(map, prefix + "AddressIpVersion", this.AddressIpVersion);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamObj(map, prefix + "DeleteProtection.", this.DeleteProtection);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "InternetAddressType", this.InternetAddressType);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

