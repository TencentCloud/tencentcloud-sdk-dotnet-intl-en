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

    public class SendBatchMessagesRequest : AbstractModel
    {
        
        /// <summary>
        /// Name of the topic to which to send the message. It is better to be the full path of the topic, such as `tenant/namespace/topic`. If it is not specified, `public/default` will be used by default.
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// Content of the message to be sent
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// String-Type token, which is optional and will be automatically obtained by the system.
        /// </summary>
        [JsonProperty("StringToken")]
        public string StringToken{ get; set; }

        /// <summary>
        /// Producer name, which must be globally unique. If it is not configured, the system will automatically generate one.
        /// </summary>
        [JsonProperty("ProducerName")]
        public string ProducerName{ get; set; }

        /// <summary>
        /// Message sending timeout period in seconds. Default value: 30s
        /// </summary>
        [JsonProperty("SendTimeout")]
        public long? SendTimeout{ get; set; }

        /// <summary>
        /// Maximum number of produced messages which can be cached in the memory. Default value: 1000
        /// </summary>
        [JsonProperty("MaxPendingMessages")]
        public long? MaxPendingMessages{ get; set; }

        /// <summary>
        /// Maximum number of messages in each batch. Default value: 1000 messages/batch
        /// </summary>
        [JsonProperty("BatchingMaxMessages")]
        public long? BatchingMaxMessages{ get; set; }

        /// <summary>
        /// Maximum wait time for each batch, after which the batch will be sent no matter whether the specified number or size of messages in the batch is reached. Default value: 10 ms
        /// </summary>
        [JsonProperty("BatchingMaxPublishDelay")]
        public long? BatchingMaxPublishDelay{ get; set; }

        /// <summary>
        /// Maximum allowed size of messages in each batch. Default value: 128 KB
        /// </summary>
        [JsonProperty("BatchingMaxBytes")]
        public long? BatchingMaxBytes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "StringToken", this.StringToken);
            this.SetParamSimple(map, prefix + "ProducerName", this.ProducerName);
            this.SetParamSimple(map, prefix + "SendTimeout", this.SendTimeout);
            this.SetParamSimple(map, prefix + "MaxPendingMessages", this.MaxPendingMessages);
            this.SetParamSimple(map, prefix + "BatchingMaxMessages", this.BatchingMaxMessages);
            this.SetParamSimple(map, prefix + "BatchingMaxPublishDelay", this.BatchingMaxPublishDelay);
            this.SetParamSimple(map, prefix + "BatchingMaxBytes", this.BatchingMaxBytes);
        }
    }
}

