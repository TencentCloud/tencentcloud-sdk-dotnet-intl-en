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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSAllowBlockRule : AbstractModel
    {
        
        /// <summary>
        /// The client IP, which can be a single IP, IP range, or subnet range, such as "1.1.1.1", "1.1.1.2-1.1.1.3", and "1.2.1.0/24-1.2.2.0/24".
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// The type. Values:
        /// <li>`block`: Blocklist</li><li>`allow`: Allowlist</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The 10-digit timestamp, such as `1199116800`. The current time will be used if this field is not specified.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

