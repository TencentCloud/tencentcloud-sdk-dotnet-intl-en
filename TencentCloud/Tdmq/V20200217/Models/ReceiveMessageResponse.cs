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

    public class ReceiveMessageResponse : AbstractModel
    {
        
        /// <summary>
        /// Unique primary key used to identify the message
        /// </summary>
        [JsonProperty("MessageID")]
        public string MessageID{ get; set; }

        /// <summary>
        /// Content of the received message
        /// </summary>
        [JsonProperty("MessagePayload")]
        public string MessagePayload{ get; set; }

        /// <summary>
        /// Provided to the `Ack` API and used to acknowledge messages in the topic
        /// </summary>
        [JsonProperty("AckTopic")]
        public string AckTopic{ get; set; }

        /// <summary>
        /// Returned error message. If it is an empty string, no error occurred.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

        /// <summary>
        /// Returned subscriber name, which will be used when an acknowledgment consumer is created.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubName")]
        public string SubName{ get; set; }

        /// <summary>
        /// MessageIDs returned by `BatchReceivePolicy` at a time, which are separated by “###”.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessageIDList")]
        public string MessageIDList{ get; set; }

        /// <summary>
        /// Message contents returned by `BatchReceivePolicy` at a time, which are separated by “###”.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessagesPayload")]
        public string MessagesPayload{ get; set; }

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
            this.SetParamSimple(map, prefix + "MessageID", this.MessageID);
            this.SetParamSimple(map, prefix + "MessagePayload", this.MessagePayload);
            this.SetParamSimple(map, prefix + "AckTopic", this.AckTopic);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamSimple(map, prefix + "SubName", this.SubName);
            this.SetParamSimple(map, prefix + "MessageIDList", this.MessageIDList);
            this.SetParamSimple(map, prefix + "MessagesPayload", this.MessagesPayload);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

