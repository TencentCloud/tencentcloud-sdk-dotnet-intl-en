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

    public class ModifyTopicRequest : AbstractModel
    {
        
        /// <summary>
        /// Environment (namespace) name.
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Topic name.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Specifies the number of partitions, which must be greater than or equal to the original partition count. if you want to maintain the original number of partitions, please enter the original number. changing the number of partitions is only effective for non-global sequential messages and cannot exceed 32 partitions.
        /// </summary>
        [JsonProperty("Partitions")]
        public ulong? Partitions{ get; set; }

        /// <summary>
        /// Pulsar cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Remarks (up to 128 characters).
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Unconsumed message expiration time. measurement unit: seconds. value range: 60 seconds to 15 days.
        /// </summary>
        [JsonProperty("MsgTTL")]
        public ulong? MsgTTL{ get; set; }

        /// <summary>
        /// Default if not passed is native policy. DefaultPolicy means when the subscription reaches the maximum unacknowledged messages of 5000, the server will stop pushing messages to all consumers under the current subscription. DynamicPolicy refers to dynamically adjusting the maximum unacknowledged messages under the subscription, with the specific quota being the maximum between 5000 and the number of consumers multiplied by 20. the default maximum unacknowledged message count per consumer is 20. exceeding this limit only affects that consumer and does not affect other consumers.
        /// </summary>
        [JsonProperty("UnackPolicy")]
        public string UnackPolicy{ get; set; }

        /// <summary>
        /// Whether exception consumer isolation is enabled.
        /// </summary>
        [JsonProperty("IsolateConsumerEnable")]
        public bool? IsolateConsumerEnable{ get; set; }

        /// <summary>
        /// Consumer Ack timeout period in seconds. value range: 60-(3600*24).
        /// </summary>
        [JsonProperty("AckTimeOut")]
        public long? AckTimeOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Partitions", this.Partitions);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "MsgTTL", this.MsgTTL);
            this.SetParamSimple(map, prefix + "UnackPolicy", this.UnackPolicy);
            this.SetParamSimple(map, prefix + "IsolateConsumerEnable", this.IsolateConsumerEnable);
            this.SetParamSimple(map, prefix + "AckTimeOut", this.AckTimeOut);
        }
    }
}

