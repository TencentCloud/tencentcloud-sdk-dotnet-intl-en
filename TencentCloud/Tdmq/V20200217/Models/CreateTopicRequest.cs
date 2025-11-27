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

    public class CreateTopicRequest : AbstractModel
    {
        
        /// <summary>
        /// Environment (namespace) name.
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Topic name, which can contain up to 64 letters, digits, hyphens, and underscores.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// The input parameter is 1, which means creating a non-partitioned topic with no partition. if the input parameter is greater than 1, it indicates the number of partitions for a partitioned topic, and the maximum cannot exceed 32.
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
        /// This input parameter will be disused soon. You can use `PulsarTopicType` instead.
        /// 0: General message;
        /// 1: Globally sequential message;
        /// 2: Partitionally sequential message;
        /// 3: Retry letter topic;
        /// 4: Dead letter topic.
        /// </summary>
        [JsonProperty("TopicType")]
        public ulong? TopicType{ get; set; }

        /// <summary>
        /// Pulsar topic type.
        /// `0`: Non-persistent and non-partitioned
        /// `1`: Non-persistent and partitioned
        /// `2`: Persistent and non-partitioned
        /// `3`: Persistent and partitioned
        /// </summary>
        [JsonProperty("PulsarTopicType")]
        public long? PulsarTopicType{ get; set; }

        /// <summary>
        /// Retention period for unconsumed messages in seconds. value ranges from 60 seconds to 15 days.
        /// </summary>
        [JsonProperty("MsgTTL")]
        public ulong? MsgTTL{ get; set; }

        /// <summary>
        /// Default if not passed is native policy. DefaultPolicy means when the subscription reaches the maximum unacknowledged messages of 5000, the server will stop pushing messages to all consumers under the current subscription. DynamicPolicy means dynamically adjust the maximum unacknowledged messages of the subscription, with the specific quota being the maximum between 5000 and the number of consumers multiplied by 20. the default maximum unacknowledged message count per consumer is 20. exceeding this limit only affects that consumer and does not affect other consumers.
        /// </summary>
        [JsonProperty("UnackPolicy")]
        public string UnackPolicy{ get; set; }

        /// <summary>
        /// Whether exception consumer isolation is enabled.
        /// </summary>
        [JsonProperty("IsolateConsumerEnable")]
        public bool? IsolateConsumerEnable{ get; set; }

        /// <summary>
        /// Specifies the consumer Ack timeout period in seconds. value range: 60-(3600*24).
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
            this.SetParamSimple(map, prefix + "TopicType", this.TopicType);
            this.SetParamSimple(map, prefix + "PulsarTopicType", this.PulsarTopicType);
            this.SetParamSimple(map, prefix + "MsgTTL", this.MsgTTL);
            this.SetParamSimple(map, prefix + "UnackPolicy", this.UnackPolicy);
            this.SetParamSimple(map, prefix + "IsolateConsumerEnable", this.IsolateConsumerEnable);
            this.SetParamSimple(map, prefix + "AckTimeOut", this.AckTimeOut);
        }
    }
}

