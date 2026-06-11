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

    public class SiteFailoverParameters : AbstractModel
    {
        
        /// <summary>
        /// Origin server fault migration condition status code. The origin server response status code must hit the field return to execute origin server migration as SiteFailoverParams. The parameter value is one of 4xx, 5xx.
        /// </summary>
        [JsonProperty("SiteFailoverStatusCodes")]
        public long?[] SiteFailoverStatusCodes{ get; set; }

        /// <summary>
        /// Origin server failure failover configuration parameter list. Minimum length is 1, maximum length is 2.
        /// </summary>
        [JsonProperty("SiteFailoverParams")]
        public SiteFailover[] SiteFailoverParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SiteFailoverStatusCodes.", this.SiteFailoverStatusCodes);
            this.SetParamArrayObj(map, prefix + "SiteFailoverParams.", this.SiteFailoverParams);
        }
    }
}

