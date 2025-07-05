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

    public class RocketMQGroup : AbstractModel
    {
        
        /// <summary>
        /// Consumer group name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The number of online consumers.
        /// </summary>
        [JsonProperty("ConsumerNum")]
        public ulong? ConsumerNum{ get; set; }

        /// <summary>
        /// Consumption TPS.
        /// </summary>
        [JsonProperty("TPS")]
        public ulong? TPS{ get; set; }

        /// <summary>
        /// The total number of heaped messages.
        /// </summary>
        [JsonProperty("TotalAccumulative")]
        public long? TotalAccumulative{ get; set; }

        /// <summary>
        /// 0: Cluster consumption mode; 1: Broadcast consumption mode; -1: Unknown.
        /// </summary>
        [JsonProperty("ConsumptionMode")]
        public long? ConsumptionMode{ get; set; }

        /// <summary>
        /// Whether to allow consumption.
        /// </summary>
        [JsonProperty("ReadEnabled")]
        public bool? ReadEnabled{ get; set; }

        /// <summary>
        /// The number of partitions in a retry topic.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RetryPartitionNum")]
        public ulong? RetryPartitionNum{ get; set; }

        /// <summary>
        /// Creation time in milliseconds.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Modification time in milliseconds.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// Client protocol.
        /// </summary>
        [JsonProperty("ClientProtocol")]
        public string ClientProtocol{ get; set; }

        /// <summary>
        /// Description.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Consumer type. Enumerated values: `ACTIVELY` or `PASSIVELY`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumerType")]
        public string ConsumerType{ get; set; }

        /// <summary>
        /// Whether to enable broadcast consumption.
        /// </summary>
        [JsonProperty("BroadcastEnabled")]
        public bool? BroadcastEnabled{ get; set; }

        /// <summary>
        /// Group type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// The number of retries
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RetryMaxTimes")]
        public ulong? RetryMaxTimes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ConsumerNum", this.ConsumerNum);
            this.SetParamSimple(map, prefix + "TPS", this.TPS);
            this.SetParamSimple(map, prefix + "TotalAccumulative", this.TotalAccumulative);
            this.SetParamSimple(map, prefix + "ConsumptionMode", this.ConsumptionMode);
            this.SetParamSimple(map, prefix + "ReadEnabled", this.ReadEnabled);
            this.SetParamSimple(map, prefix + "RetryPartitionNum", this.RetryPartitionNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ClientProtocol", this.ClientProtocol);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ConsumerType", this.ConsumerType);
            this.SetParamSimple(map, prefix + "BroadcastEnabled", this.BroadcastEnabled);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "RetryMaxTimes", this.RetryMaxTimes);
        }
    }
}

