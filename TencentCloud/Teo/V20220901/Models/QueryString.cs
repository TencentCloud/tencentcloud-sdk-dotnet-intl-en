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

    public class QueryString : AbstractModel
    {
        
        /// <summary>
        /// Whether to use `QueryString` as part of `CacheKey`. Values:
        /// <li>`on`: Yes</li>
        /// <li>`off`: No</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// CacheKey usage via QueryString, valid values:.
        /// <li>includeCustom: use partial url parameter;</li>.
        /// <li>excludeCustom: exclude partial url parameters.</li>.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Specifies the url parameter array for usage/exclusion.
        /// </summary>
        [JsonProperty("Value")]
        public string[] Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
        }
    }
}

