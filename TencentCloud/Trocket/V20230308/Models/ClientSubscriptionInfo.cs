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

    public class ClientSubscriptionInfo : AbstractModel
    {
        
        /// <summary>
        /// Client ID
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// Client ip address.
        /// </summary>
        [JsonProperty("ClientAddr")]
        public string ClientAddr{ get; set; }

        /// <summary>
        /// Specifies the subscribed topic.
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// Subscription expression.
        /// </summary>
        [JsonProperty("SubString")]
        public string SubString{ get; set; }

        /// <summary>
        /// Specifies the subscription method.
        /// </summary>
        [JsonProperty("ExpressionType")]
        public string ExpressionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "ClientAddr", this.ClientAddr);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "SubString", this.SubString);
            this.SetParamSimple(map, prefix + "ExpressionType", this.ExpressionType);
        }
    }
}

