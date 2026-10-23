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

    public class UpstreamRequestParameters : AbstractModel
    {
        
        /// <summary>
        /// Query string configuration. Optional configuration, leave blank for no configuration.
        /// </summary>
        [JsonProperty("QueryString")]
        public UpstreamRequestQueryString QueryString{ get; set; }

        /// <summary>
        /// Cookie configuration. Optional configuration. Leave it blank for no configuration.
        /// </summary>
        [JsonProperty("Cookie")]
        public UpstreamRequestCookie Cookie{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
            this.SetParamObj(map, prefix + "Cookie.", this.Cookie);
        }
    }
}

