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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRocketMQMsgResponse : AbstractModel
    {
        
        /// <summary>
        /// Message body
        /// </summary>
        [JsonProperty("Body")]
        public string Body{ get; set; }

        /// <summary>
        /// Details parameter
        /// </summary>
        [JsonProperty("Properties")]
        public string Properties{ get; set; }

        /// <summary>
        /// Production time
        /// </summary>
        [JsonProperty("ProduceTime")]
        public string ProduceTime{ get; set; }

        /// <summary>
        /// Message ID
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// Producer address
        /// </summary>
        [JsonProperty("ProducerAddr")]
        public string ProducerAddr{ get; set; }

        /// <summary>
        /// Consumption details of a consumer group
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessageTracks")]
        public RocketMQMessageTrack[] MessageTracks{ get; set; }

        /// <summary>
        /// Topic name displayed on the details page
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShowTopicName")]
        public string ShowTopicName{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamSimple(map, prefix + "Properties", this.Properties);
            this.SetParamSimple(map, prefix + "ProduceTime", this.ProduceTime);
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "ProducerAddr", this.ProducerAddr);
            this.SetParamArrayObj(map, prefix + "MessageTracks.", this.MessageTracks);
            this.SetParamSimple(map, prefix + "ShowTopicName", this.ShowTopicName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

