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

    public class DescribeRocketMQMsgRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Namespace ID
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Topic name. Pass in the group ID when querying a dead letter queue.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Message ID
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// ID of a TDMQ for Pulsar message
        /// </summary>
        [JsonProperty("PulsarMsgId")]
        public string PulsarMsgId{ get; set; }

        /// <summary>
        /// The value of this parameter is `true` when you query a dead letter queue. It only applies to TDMQ for RocketMQ.
        /// </summary>
        [JsonProperty("QueryDlqMsg")]
        [System.Obsolete]
        public bool? QueryDlqMsg{ get; set; }

        /// <summary>
        /// The value is true when querying dead letters, and only valid for RocketMQ.
        /// </summary>
        [JsonProperty("QueryDeadLetterMessage")]
        public bool? QueryDeadLetterMessage{ get; set; }

        /// <summary>
        /// Pagination offset
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Pagination limit
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filters consumption details based on the consumer group name.
        /// </summary>
        [JsonProperty("FilterTrackGroup")]
        public string FilterTrackGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "PulsarMsgId", this.PulsarMsgId);
            this.SetParamSimple(map, prefix + "QueryDlqMsg", this.QueryDlqMsg);
            this.SetParamSimple(map, prefix + "QueryDeadLetterMessage", this.QueryDeadLetterMessage);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "FilterTrackGroup", this.FilterTrackGroup);
        }
    }
}

