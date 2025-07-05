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
        /// Whether to enable standard debugging. values:.
        /// <Li>`On`: enable;</li>
        /// .
        /// <Li>Off: disable.</li>.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// The client ip to allow. it can be an ipv4/ipv6 address or a cidr block. 0.0.0.0/0 means to allow all ipv4 clients for debugging; ::/0 means to allow all ipv6 clients for debugging; 127.0.0.1 is not allowed. <br>note: this field is required when `switch=on` and the number of entries should be 1-100. when `switch=off`, this field is not required and any value specified will not take effect.
        /// </summary>
        [JsonProperty("AllowClientIPList")]
        public string[] AllowClientIPList{ get; set; }

        /// <summary>
        /// Debug feature expiration time. the feature will be disabled after the set time. <br>note: this field is required when `switch=on`. when `switch=off`, this field is not required and any value specified will not take effect.
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

