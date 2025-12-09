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

    public class RocketMQMsgLog : AbstractModel
    {
        
        /// <summary>
        /// Message ID
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// Message tag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgTag")]
        public string MsgTag{ get; set; }

        /// <summary>
        /// Message key.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgKey")]
        public string MsgKey{ get; set; }

        /// <summary>
        /// Specifies the client ip address.
        /// </summary>
        [JsonProperty("ProducerAddr")]
        public string ProducerAddr{ get; set; }

        /// <summary>
        /// Message Sending Time
        /// </summary>
        [JsonProperty("ProduceTime")]
        public string ProduceTime{ get; set; }

        /// <summary>
        /// Pulsar Message ID
        /// </summary>
        [JsonProperty("PulsarMsgId")]
        public string PulsarMsgId{ get; set; }

        /// <summary>
        /// Dead-letter resend count
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeadLetterResendTimes")]
        public long? DeadLetterResendTimes{ get; set; }

        /// <summary>
        /// Dead Letter Resend Success Count
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResendSuccessCount")]
        public long? ResendSuccessCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "MsgTag", this.MsgTag);
            this.SetParamSimple(map, prefix + "MsgKey", this.MsgKey);
            this.SetParamSimple(map, prefix + "ProducerAddr", this.ProducerAddr);
            this.SetParamSimple(map, prefix + "ProduceTime", this.ProduceTime);
            this.SetParamSimple(map, prefix + "PulsarMsgId", this.PulsarMsgId);
            this.SetParamSimple(map, prefix + "DeadLetterResendTimes", this.DeadLetterResendTimes);
            this.SetParamSimple(map, prefix + "ResendSuccessCount", this.ResendSuccessCount);
        }
    }
}

