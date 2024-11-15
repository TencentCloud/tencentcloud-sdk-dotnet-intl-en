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

    public class OriginGroupHealthStatusDetail : AbstractModel
    {
        
        /// <summary>
        /// Origin server group ID.
        /// </summary>
        [JsonProperty("OriginGroupId")]
        public string OriginGroupId{ get; set; }

        /// <summary>
        /// The health status of each origin server in an origin server group, which is comprehensively decided based on the results of all detection regions. If more than half of the regions determine that the origin server is unhealthy, the corresponding status is unhealthy; otherwise, it is healthy.
        /// </summary>
        [JsonProperty("OriginHealthStatus")]
        public OriginHealthStatus[] OriginHealthStatus{ get; set; }

        /// <summary>
        /// Health status of origin servers in each health check region.
        /// </summary>
        [JsonProperty("CheckRegionHealthStatus")]
        public CheckRegionHealthStatus[] CheckRegionHealthStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginGroupId", this.OriginGroupId);
            this.SetParamArrayObj(map, prefix + "OriginHealthStatus.", this.OriginHealthStatus);
            this.SetParamArrayObj(map, prefix + "CheckRegionHealthStatus.", this.CheckRegionHealthStatus);
        }
    }
}

