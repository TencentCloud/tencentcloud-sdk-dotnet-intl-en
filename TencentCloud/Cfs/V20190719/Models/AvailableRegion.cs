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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AvailableRegion : AbstractModel
    {
        
        /// <summary>
        /// Region name, such as "ap-beijing"
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Region name, such as "bj"
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// Region availability. If a region has at least one AZ where resources are purchasable, this value will be `AVAILABLE`; otherwise, it will be `UNAVAILABLE`
        /// </summary>
        [JsonProperty("RegionStatus")]
        public string RegionStatus{ get; set; }

        /// <summary>
        /// Array of AZs
        /// </summary>
        [JsonProperty("Zones")]
        public AvailableZone[] Zones{ get; set; }

        /// <summary>
        /// Region name, such as "Guangzhou"
        /// </summary>
        [JsonProperty("RegionCnName")]
        public string RegionCnName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RegionStatus", this.RegionStatus);
            this.SetParamArrayObj(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "RegionCnName", this.RegionCnName);
        }
    }
}

