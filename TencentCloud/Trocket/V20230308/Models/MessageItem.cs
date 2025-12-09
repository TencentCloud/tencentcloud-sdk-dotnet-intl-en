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

    public class MessageItem : AbstractModel
    {
        
        /// <summary>
        /// Message ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// Message tag
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// Message key.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Keys")]
        public string Keys{ get; set; }

        /// <summary>
        /// Client address.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProducerAddr")]
        public string ProducerAddr{ get; set; }

        /// <summary>
        /// Message Sending Time	
        /// 	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProduceTime")]
        public string ProduceTime{ get; set; }

        /// <summary>
        /// Dead-letter resend count	
        /// 	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeadLetterResendTimes")]
        public long? DeadLetterResendTimes{ get; set; }

        /// <summary>
        /// Dead Letter Resend Success Count
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeadLetterResendSuccessTimes")]
        public long? DeadLetterResendSuccessTimes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamSimple(map, prefix + "Keys", this.Keys);
            this.SetParamSimple(map, prefix + "ProducerAddr", this.ProducerAddr);
            this.SetParamSimple(map, prefix + "ProduceTime", this.ProduceTime);
            this.SetParamSimple(map, prefix + "DeadLetterResendTimes", this.DeadLetterResendTimes);
            this.SetParamSimple(map, prefix + "DeadLetterResendSuccessTimes", this.DeadLetterResendSuccessTimes);
        }
    }
}

