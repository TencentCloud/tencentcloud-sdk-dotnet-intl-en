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

    public class CacheKeyQueryString : AbstractModel
    {
        
        /// <summary>
        /// Query string retain/ignore specified parameter switch. valid values are:.
        /// <Li>`On`: enable;</li>
        /// .
        /// <Li>Off: disable.</li>.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Actions to retain/ignore specified parameters in the query string. values:.
        /// <Li>`IncludeCustom`: retain partial parameters.</li>.
        /// <Li>`ExcludeCustom`: ignore partial parameters.</li> note: this field is required when `switch` is on. when `switch` is off, this field is not required and will not take effect if filled.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// List of parameter names to be retained/ignored in the query string. <br>note: this field is required when `switch` is on. when `switch` is off, this field is not required and will not take effect if filled.
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

