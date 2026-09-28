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

    public class LoadBalancer : AbstractModel
    {
        
        /// <summary>
        /// Access log configuration architecture.
        /// </summary>
        [JsonProperty("AccessLogConfig")]
        public AccessLogConfig AccessLogConfig{ get; set; }

        /// <summary>
        /// IP address version. Value: IPv4 or IPv6.
        /// </summary>
        [JsonProperty("AddressIpVersion")]
        public string AddressIpVersion{ get; set; }

        /// <summary>
        /// LoadBalancer address type. Valid values:
        /// 
        /// - **Internet**: The load balancing has a public IP address, and the DNS domain name is resolved to the public IP, so it can be accessed via the public network.
        /// 
        /// - **Intranet**: The load balancer only has a private IP address, and the DNS domain name resolves to the private IP, so it can only be accessed from the private network environment of the VPC where the load balancer is located.
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// Resource creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Deletion protection setting information.
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public DeletionProtectionConfig DeletionProtection{ get; set; }

        /// <summary>
        /// DNS domain name.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Billing configuration of a load balancing instance.
        /// </summary>
        [JsonProperty("LoadBalancerBillingConfig")]
        public LoadBalancerBillingConfig LoadBalancerBillingConfig{ get; set; }

        /// <summary>
        /// CLB instance ID, in the format of "alb-" followed by 8 alphanumeric characters.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// Load balancing instance name.
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// Load balancer operation lock configuration.
        /// </summary>
        [JsonProperty("LoadBalancerOperationLocks")]
        public LoadBalancerOperationLocksItem[] LoadBalancerOperationLocks{ get; set; }

        /// <summary>
        /// Application CLB instance status. Valid values:
        /// 
        /// - **Provisioning**: Under creation.
        /// - **Active**: Running.
        /// - **Configuring**: The configuration is being changed.
        /// - **Deleting**: Deleting.
        /// - **ProvisionFailed**: Creation failed.
        /// - **ConfigureFailed**: Configuration adjustment failure.
        /// - **DeletionFailed**: deletion failed.
        /// - **Abnormal**: abnormal status. For the specific exception reason, see the LoadBalancerOperationLocks field.
        /// </summary>
        [JsonProperty("LoadBalancerStatus")]
        public string LoadBalancerStatus{ get; set; }

        /// <summary>
        /// Modification protection setting information.
        /// </summary>
        [JsonProperty("ModificationProtection")]
        public ModificationProtectionInfo ModificationProtection{ get; set; }

        /// <summary>
        /// Tag list.
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// Virtual Private Cloud (VPC) ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AccessLogConfig.", this.AccessLogConfig);
            this.SetParamSimple(map, prefix + "AddressIpVersion", this.AddressIpVersion);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "DeletionProtection.", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamObj(map, prefix + "LoadBalancerBillingConfig.", this.LoadBalancerBillingConfig);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamArrayObj(map, prefix + "LoadBalancerOperationLocks.", this.LoadBalancerOperationLocks);
            this.SetParamSimple(map, prefix + "LoadBalancerStatus", this.LoadBalancerStatus);
            this.SetParamObj(map, prefix + "ModificationProtection.", this.ModificationProtection);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
        }
    }
}

