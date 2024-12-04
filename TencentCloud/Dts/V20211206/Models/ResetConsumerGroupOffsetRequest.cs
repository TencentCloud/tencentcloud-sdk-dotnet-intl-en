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

    public class ResetConsumerGroupOffsetRequest : AbstractModel
    {
        
        /// <summary>
        /// Subscription instance ID
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// Subscribed Kafka topic
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Consumer group name. The full name of the actual consumer group is in the form: consumer-grp-#{SubscribeId}-#{ConsumerGroupName}.
        /// </summary>
        [JsonProperty("ConsumerGroupName")]
        public string ConsumerGroupName{ get; set; }

        /// <summary>
        /// The partition number of offset needs to be modified.
        /// </summary>
        [JsonProperty("PartitionNos")]
        public long?[] PartitionNos{ get; set; }

        /// <summary>
        /// Reset mode. Valid values: earliest (start consumption from the earliest position); latest (start consumption from the latest position); datetime (start consumption from the most recent checkpoint before the specified time).
        /// </summary>
        [JsonProperty("ResetMode")]
        public string ResetMode{ get; set; }

        /// <summary>
        /// When ResetMode is datetime, this field needs to be filled in, the format is: Y-m-d h:m:s. If not filled in, the default time is 0, and the effect is the same as earliest.
        /// </summary>
        [JsonProperty("ResetDatetime")]
        public string ResetDatetime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscribeId", this.SubscribeId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "ConsumerGroupName", this.ConsumerGroupName);
            this.SetParamArraySimple(map, prefix + "PartitionNos.", this.PartitionNos);
            this.SetParamSimple(map, prefix + "ResetMode", this.ResetMode);
            this.SetParamSimple(map, prefix + "ResetDatetime", this.ResetDatetime);
        }
    }
}

