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

    public class ReceiveMessageRequest : AbstractModel
    {
        
        /// <summary>
        /// Name of the topic which receives the message. It is better to be the full path of the topic, such as `tenant/namespace/topic`. If it is not specified, `public/default` will be used by default.
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// Subscriber name
        /// </summary>
        [JsonProperty("SubscriptionName")]
        public string SubscriptionName{ get; set; }

        /// <summary>
        /// Default value: 1000. Messages received by the consumer will first be stored in the `receiverQueueSize` queue to tune the message receiving rate.
        /// </summary>
        [JsonProperty("ReceiverQueueSize")]
        public long? ReceiverQueueSize{ get; set; }

        /// <summary>
        /// A parameter used to determine the position where the consumer initially receives messages. Valid values: `Earliest` (default), `Latest`.
        /// </summary>
        [JsonProperty("SubInitialPosition")]
        public string SubInitialPosition{ get; set; }

        /// <summary>
        /// This parameter is used to specify the maximum number of received messages in a batch for `BatchReceivePolicy`. The default value is 0, indicating that `BatchReceivePolicy` is disabled.
        /// </summary>
        [JsonProperty("MaxNumMessages")]
        public long? MaxNumMessages{ get; set; }

        /// <summary>
        /// This parameter is used to specify the maximum body size (in bytes) of received messages in a batch for `BatchReceivePolicy`. The default value is 0, indicating that `BatchReceivePolicy` is disabled.
        /// </summary>
        [JsonProperty("MaxNumBytes")]
        public long? MaxNumBytes{ get; set; }

        /// <summary>
        /// This parameter is used to specify the maximum wait timeout (in milliseconds) for receiving a batch of messages for `BatchReceivePolicy`. The default value is 0, indicating that `BatchReceivePolicy` is disabled.
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "SubscriptionName", this.SubscriptionName);
            this.SetParamSimple(map, prefix + "ReceiverQueueSize", this.ReceiverQueueSize);
            this.SetParamSimple(map, prefix + "SubInitialPosition", this.SubInitialPosition);
            this.SetParamSimple(map, prefix + "MaxNumMessages", this.MaxNumMessages);
            this.SetParamSimple(map, prefix + "MaxNumBytes", this.MaxNumBytes);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
        }
    }
}

