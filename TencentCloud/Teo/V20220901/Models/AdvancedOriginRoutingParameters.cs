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

    public class AdvancedOriginRoutingParameters : AbstractModel
    {
        
        /// <summary>
        /// <p>Origin optimization direction. Valid values:</p><li>MainlandChinaAndGlobalAdaptive: Self adaptive. The domain name must enable "smart acceleration" simultaneously to take effect. EdgeOne will automatically match the optimal origin-pull optimization direction based on the actual geographic location of the client and origin server, without the need to manually specify. For example, if www.example.com enables "advanced origin optimization" but "smart acceleration" is turned off or only partial match conditions are enabled, "advanced origin optimization" will not be effective.</li>
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

