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
        /// Switch to reserve or ignore specified parameters in the query string. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Action to reserve or ignore specified parameters in the query string. Valid values:
        /// <li>includeCustom: means to reserve some parameters;</li>
        /// <li>excludeCustom: means to ignore some parameters.</li>Note: This field is required when Switch is on. When Switch is off, this field is not required and does not take effect if filled in.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// List of parameter names to reserve/ignore in the query string.<br>Note: When Switch is on, this field is required; when Switch is off, no need to specify this field, and if specified, it does not take effect.
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

