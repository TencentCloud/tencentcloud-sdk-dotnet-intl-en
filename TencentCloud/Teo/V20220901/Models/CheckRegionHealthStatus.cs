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

    public class CheckRegionHealthStatus : AbstractModel
    {
        
        /// <summary>
        /// Health check region, which is a two-letter code according to ISO-3166-1.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Health status of origin servers in a single health check region. Valid values:
        /// <li>Healthy: healthy.</li>
        /// <li>Unhealthy: unhealthy.</li>
        /// <li>Undetected: no data detected.</li>Note: If all origin servers in a single health check region are healthy, the status is healthy; otherwise, it is unhealthy.
        /// </summary>
        [JsonProperty("Healthy")]
        public string Healthy{ get; set; }

        /// <summary>
        /// Origin server health status.
        /// </summary>
        [JsonProperty("OriginHealthStatus")]
        public OriginHealthStatus[] OriginHealthStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Healthy", this.Healthy);
            this.SetParamArrayObj(map, prefix + "OriginHealthStatus.", this.OriginHealthStatus);
        }
    }
}

