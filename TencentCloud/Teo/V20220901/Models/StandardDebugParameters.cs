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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StandardDebugParameters : AbstractModel
    {
        
        /// <summary>
        /// Debug feature switch. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Allowed client source. Supports filling in IPv4 and IPv6 IP ranges. 0.0.0.0/0 indicates permission for all IPv4 clients to debug; ::/0 indicates permission for all IPv6 clients to debug; 127.0.0.1 cannot be filled in.<br>Note: When the Switch field is on, this field is required, and the number of writes is 1–100; when Switch is off, no need to specify this field, and if filled in, it does not take effect.
        /// </summary>
        [JsonProperty("AllowClientIPList")]
        public string[] AllowClientIPList{ get; set; }

        /// <summary>
        /// Expiration time of the Debug feature. If the set time is exceeded, the feature becomes invalid.<br>Note: When Switch is on, this field is required; when Switch is off, this field is not required. If filled in, it does not take effect.
        /// </summary>
        [JsonProperty("Expires")]
        public string Expires{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "AllowClientIPList.", this.AllowClientIPList);
            this.SetParamSimple(map, prefix + "Expires", this.Expires);
        }
    }
}

