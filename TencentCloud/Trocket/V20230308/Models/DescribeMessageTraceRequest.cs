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

    public class DescribeMessageTraceRequest : AbstractModel
    {
        
        /// <summary>
        /// TDMQ RocketMQ instance ID. It can be obtained from the API [DescribeFusionInstanceList](https://www.tencentcloud.comom/document/api/1493/106745?from_cn_redirect=1) or the console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Topic name. It can be obtained from [TopicItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#TopicItem) returned by the API [DescribeTopicList](https://www.tencentcloud.comom/document/api/1493/96030?from_cn_redirect=1) or from the console.
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// Message ID. It can be obtained from [MessageItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#MessageItem) returned by the API [DescribeMessageList](https://www.tencentcloud.comom/document/api/1493/114593?from_cn_redirect=1) or from the workload logs.
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// Whether the message is dead letter message. Default value: false.
        /// </summary>
        [JsonProperty("QueryDeadLetterMessage")]
        public bool? QueryDeadLetterMessage{ get; set; }

        /// <summary>
        /// Whether the message is delayed. Default value: false.
        /// </summary>
        [JsonProperty("QueryDelayMessage")]
        public bool? QueryDelayMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "QueryDeadLetterMessage", this.QueryDeadLetterMessage);
            this.SetParamSimple(map, prefix + "QueryDelayMessage", this.QueryDelayMessage);
        }
    }
}

