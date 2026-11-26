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

    public class CacheKeyCookie : AbstractModel
    {
        
        /// <summary>
        /// Function switch. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Cache action, with values:
        /// <li>full: retain all;</li>
        /// <li> ignore: ignore all;</li>
        /// <li> includeCustom: retain specified parameters;</li>
        /// <li>excludeCustom: ignore specified parameter.</li>Note: When Switch is on, this field is required; when Switch is off, no need to specify this field. If specified, it does not take effect.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// List of custom Cache Key Cookie names.<br>Note: This field is required when Action is includeCustom or excludeCustom. It is not required when Action is full or ignore, and will not take effect if specified.
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

