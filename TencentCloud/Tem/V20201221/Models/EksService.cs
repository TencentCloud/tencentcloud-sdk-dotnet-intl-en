/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tem.V20201221.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EksService : AbstractModel
    {
        
        /// <summary>
        /// Service name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Available ports
        /// </summary>
        [JsonProperty("Ports")]
        public long?[] Ports{ get; set; }

        /// <summary>
        /// Yaml contents
        /// </summary>
        [JsonProperty("Yaml")]
        public string Yaml{ get; set; }

        /// <summary>
        /// Service name
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// Version name
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// Private IP
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClusterIp")]
        public string[] ClusterIp{ get; set; }

        /// <summary>
        /// Public IP
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExternalIp")]
        public string ExternalIp{ get; set; }

        /// <summary>
        /// The access type. Valid values:
        /// - EXTERNAL (internet access)
        /// - VPC（Intra-VPC access)
        /// - CLUSTER (Intra-cluster access)
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Subnet ID. It is filled when the access type is `VPC`.
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Load balancer ID. It is filled when the access type is `EXTERNAL` or `CLUSTER`. It’s created automatically by default.
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("LoadBalanceId")]
        public string LoadBalanceId{ get; set; }

        /// <summary>
        /// Port Mapping
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PortMappings")]
        public PortMapping[] PortMappings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "Yaml", this.Yaml);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamArraySimple(map, prefix + "ClusterIp.", this.ClusterIp);
            this.SetParamSimple(map, prefix + "ExternalIp", this.ExternalIp);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "LoadBalanceId", this.LoadBalanceId);
            this.SetParamArrayObj(map, prefix + "PortMappings.", this.PortMappings);
        }
    }
}

