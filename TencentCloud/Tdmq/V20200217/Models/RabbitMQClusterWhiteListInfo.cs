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

    public class RabbitMQClusterWhiteListInfo : AbstractModel
    {
        
        /// <summary>
        /// Deprecated.
        /// </summary>
        [JsonProperty("WhiteList")]
        public string WhiteList{ get; set; }

        /// <summary>
        /// Public network console allowlist.
        /// </summary>
        [JsonProperty("PublicControlConsoleWhiteList")]
        public string PublicControlConsoleWhiteList{ get; set; }

        /// <summary>
        /// Public network data flow allowlist.
        /// </summary>
        [JsonProperty("PublicDataStreamWhiteList")]
        public string PublicDataStreamWhiteList{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PublicControlConsoleWhiteListStatus")]
        public string PublicControlConsoleWhiteListStatus{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PublicDataStreamWhiteListStatus")]
        public string PublicDataStreamWhiteListStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WhiteList", this.WhiteList);
            this.SetParamSimple(map, prefix + "PublicControlConsoleWhiteList", this.PublicControlConsoleWhiteList);
            this.SetParamSimple(map, prefix + "PublicDataStreamWhiteList", this.PublicDataStreamWhiteList);
            this.SetParamSimple(map, prefix + "PublicControlConsoleWhiteListStatus", this.PublicControlConsoleWhiteListStatus);
            this.SetParamSimple(map, prefix + "PublicDataStreamWhiteListStatus", this.PublicDataStreamWhiteListStatus);
        }
    }
}

