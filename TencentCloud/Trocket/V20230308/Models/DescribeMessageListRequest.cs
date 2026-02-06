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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMessageListRequest : AbstractModel
    {
        
        /// <summary>
        /// TDMQ RocketMQ instance ID. It can be obtained from the API [DescribeFusionInstanceList](https://www.tencentcloud.com/document/api/1493/106745?from_cn_redirect=1) or the console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Topic name. It can be obtained from [TopicItem](https://www.tencentcloud.com/document/api/1493/96031?from_cn_redirect=1#TopicItem) returned by the API [DescribeTopicList](https://www.tencentcloud.com/document/api/1493/96030?from_cn_redirect=1) or from the console.
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// Start time for querying messages. **It is a Unix timestamp (ms).**
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// End time for querying messages. **It is a Unix timestamp (ms).**
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Query identifier. For the first query, input a null string. If the query results involve pagination, use the TaskRequestId value in the previous request response as the value of this input parameter for requesting data on the next page.
        /// </summary>
        [JsonProperty("TaskRequestId")]
        public string TaskRequestId{ get; set; }

        /// <summary>
        /// Starting position of the query. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Maximum number of queried results. Default value: 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Consumer group name. It can be obtained from [ConsumeGroupItem](https://www.tencentcloud.com/document/api/1493/96031?from_cn_redirect=1#ConsumeGroupItem) returned by the API [DescribeConsumerGroupList](https://www.tencentcloud.com/document/api/1493/101535?from_cn_redirect=1) or from the console.
        /// </summary>
        [JsonProperty("ConsumerGroup")]
        public string ConsumerGroup{ get; set; }

        /// <summary>
        /// Message ID. It can be obtained from [MessageItem](https://www.tencentcloud.com/document/api/1493/96031?from_cn_redirect=1#MessageItem) returned by the API [DescribeMessageList](https://www.tencentcloud.com/document/api/1493/114593?from_cn_redirect=1) or from the workload logs.
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// Message key. It can be obtained from [MessageItem](https://www.tencentcloud.com/document/api/1493/96031?from_cn_redirect=1#MessageItem) returned by the API [DescribeMessageList](https://www.tencentcloud.com/document/api/1493/114593?from_cn_redirect=1) or from workload logs.
        /// </summary>
        [JsonProperty("MsgKey")]
        public string MsgKey{ get; set; }

        /// <summary>
        /// Query the last N messages. The value of N cannot exceed 1024. By default, -1 indicates other query conditions.
        /// </summary>
        [JsonProperty("RecentMessageNum")]
        public long? RecentMessageNum{ get; set; }

        /// <summary>
        /// Whether to query dead letter messages. Default value: false.
        /// </summary>
        [JsonProperty("QueryDeadLetterMessage")]
        public bool? QueryDeadLetterMessage{ get; set; }

        /// <summary>
        /// Message tag. It can be obtained from [MessageItem](https://www.tencentcloud.com/document/api/1493/96031?from_cn_redirect=1#MessageItem) returned by the API [DescribeMessageList](https://www.tencentcloud.com/document/api/1493/114593?from_cn_redirect=1) or from workload logs.
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskRequestId", this.TaskRequestId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ConsumerGroup", this.ConsumerGroup);
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "MsgKey", this.MsgKey);
            this.SetParamSimple(map, prefix + "RecentMessageNum", this.RecentMessageNum);
            this.SetParamSimple(map, prefix + "QueryDeadLetterMessage", this.QueryDeadLetterMessage);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
        }
    }
}

