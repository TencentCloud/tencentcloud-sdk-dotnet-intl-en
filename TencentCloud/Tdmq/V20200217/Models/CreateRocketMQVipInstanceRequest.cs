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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRocketMQVipInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Cluster specification. Supported specifications: 1. 	General: rocket-vip-basic-0; 2. Basic: rocket-vip-basic-1; 3. Standard: rocket-vip-basic-2; 4. Advanced I: rocket-vip-basic-3; 5. Advanced II: rocket-vip-basic-4.
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// Number of nodes. Value range: 2–20.
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// Single-node storage space, in GB. The minimum space is 200 GB.
        /// </summary>
        [JsonProperty("StorageSize")]
        public long? StorageSize{ get; set; }

        /// <summary>
        /// The zone ID list for node deployment. For example, the ID of Guangzhou Zone 1 is 100001. For details, see the official website of the cloud platform.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Describes the VPC information.
        /// </summary>
        [JsonProperty("VpcInfo")]
        public VpcInfo VpcInfo{ get; set; }

        /// <summary>
        /// Purchase duration, in months.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// Whether it is used for cloud migration. The default value is false.
        /// </summary>
        [JsonProperty("SupportsMigrateToCloud")]
        public bool? SupportsMigrateToCloud{ get; set; }

        /// <summary>
        /// Specifies whether public network access is enabled.
        /// </summary>
        [JsonProperty("EnablePublic")]
        public bool? EnablePublic{ get; set; }

        /// <summary>
        /// Public network bandwidth, a required field when the public network is enabled.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// Public network allowlist.
        /// </summary>
        [JsonProperty("IpRules")]
        public PublicAccessRule[] IpRules{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamObj(map, prefix + "VpcInfo.", this.VpcInfo);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "SupportsMigrateToCloud", this.SupportsMigrateToCloud);
            this.SetParamSimple(map, prefix + "EnablePublic", this.EnablePublic);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamArrayObj(map, prefix + "IpRules.", this.IpRules);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

