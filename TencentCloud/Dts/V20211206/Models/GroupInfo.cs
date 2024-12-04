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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GroupInfo : AbstractModel
    {
        
        /// <summary>
        /// Consumer group account
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// Consumer group name
        /// </summary>
        [JsonProperty("ConsumerGroupName")]
        public string ConsumerGroupName{ get; set; }

        /// <summary>
        /// Consumer group descriptionNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Consumer group offset. This field is for compatibility with the previous single partition scenario, where the value is the offset of the last partition. For the offset of each partition, please refer to the StateOfPartition field.
        /// </summary>
        [JsonProperty("ConsumerGroupOffset")]
        public long? ConsumerGroupOffset{ get; set; }

        /// <summary>
        /// The amount of data that has not been consumed by the consumer group. This field is for compatibility with the previous single partition scenario, where the value is the amount of unconsumed data in the last partition. For the amount of unconsumed data in each partition, refer to the StateOfPartition field.
        /// </summary>
        [JsonProperty("ConsumerGroupLag")]
        public long? ConsumerGroupLag{ get; set; }

        /// <summary>
        /// Consumption delay (in seconds)
        /// </summary>
        [JsonProperty("Latency")]
        public long? Latency{ get; set; }

        /// <summary>
        /// Consumption status of each partition
        /// </summary>
        [JsonProperty("StateOfPartition")]
        public MonitorInfo[] StateOfPartition{ get; set; }

        /// <summary>
        /// Consumer group creation time, the format is: YYYY-MM-DD hh:mm:ss.
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// Consumer group update time, the format is: YYYY-MM-DD hh:mm:ss.
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// Consumer group states, including Dead, Empty, Stable, etc. Only Dead and Empty states can perform reset operations.
        /// </summary>
        [JsonProperty("ConsumerGroupState")]
        public string ConsumerGroupState{ get; set; }

        /// <summary>
        /// The partition is being consumed by each consumer.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PartitionAssignment")]
        public PartitionAssignment[] PartitionAssignment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "ConsumerGroupName", this.ConsumerGroupName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ConsumerGroupOffset", this.ConsumerGroupOffset);
            this.SetParamSimple(map, prefix + "ConsumerGroupLag", this.ConsumerGroupLag);
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
            this.SetParamArrayObj(map, prefix + "StateOfPartition.", this.StateOfPartition);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "ConsumerGroupState", this.ConsumerGroupState);
            this.SetParamArrayObj(map, prefix + "PartitionAssignment.", this.PartitionAssignment);
        }
    }
}

