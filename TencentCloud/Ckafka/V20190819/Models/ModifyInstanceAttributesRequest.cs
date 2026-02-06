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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// ckafka cluster instance Id. obtain through the API [DescribeInstances](https://www.tencentcloud.com/document/product/597/40835?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Maximum retention time of instance logs, in minutes, with a value range of 1min to 90 days.
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// Specifies the Name of the ckafka cluster instance.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance configuration
        /// </summary>
        [JsonProperty("Config")]
        public ModifyInstanceAttributesConfig Config{ get; set; }

        /// <summary>
        /// Dynamic message retention policy configuration
        /// </summary>
        [JsonProperty("DynamicRetentionConfig")]
        public DynamicRetentionTime DynamicRetentionConfig{ get; set; }

        /// <summary>
        /// Specifies the execution time of a scheduled task for edition upgrade or configuration upgrade in Unix timestamp, accurate to the second.
        /// </summary>
        [JsonProperty("RebalanceTime")]
        public long? RebalanceTime{ get; set; }

        /// <summary>
        /// Public network bandwidth. minimum 3 Mbps. maximum 999 Mbps. only the pro edition supports filling in.
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public long? PublicNetwork{ get; set; }

        /// <summary>
        /// Dynamic disk expansion policy configuration.
        /// </summary>
        [JsonProperty("DynamicDiskConfig")]
        [System.Obsolete]
        public DynamicDiskConfig DynamicDiskConfig{ get; set; }

        /// <summary>
        /// Single message size at the instance level (unit: byte). value range: 1024 (excluding) to 12582912 (excluding).
        /// </summary>
        [JsonProperty("MaxMessageByte")]
        public ulong? MaxMessageByte{ get; set; }

        /// <summary>
        /// Whether to allow unsynchronized replicas to be elected as leader. valid values: 1 (enable), 0 (disable).
        /// </summary>
        [JsonProperty("UncleanLeaderElectionEnable")]
        public long? UncleanLeaderElectionEnable{ get; set; }

        /// <summary>
        /// Instance deletion protection switch. 1: enabled; 0: disabled.
        /// </summary>
        [JsonProperty("DeleteProtectionEnable")]
        public long? DeleteProtectionEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MsgRetentionTime", this.MsgRetentionTime);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "DynamicRetentionConfig.", this.DynamicRetentionConfig);
            this.SetParamSimple(map, prefix + "RebalanceTime", this.RebalanceTime);
            this.SetParamSimple(map, prefix + "PublicNetwork", this.PublicNetwork);
            this.SetParamObj(map, prefix + "DynamicDiskConfig.", this.DynamicDiskConfig);
            this.SetParamSimple(map, prefix + "MaxMessageByte", this.MaxMessageByte);
            this.SetParamSimple(map, prefix + "UncleanLeaderElectionEnable", this.UncleanLeaderElectionEnable);
            this.SetParamSimple(map, prefix + "DeleteProtectionEnable", this.DeleteProtectionEnable);
        }
    }
}

