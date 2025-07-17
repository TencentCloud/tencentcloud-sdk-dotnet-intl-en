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

namespace TencentCloud.Region.V20220627.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionInfo : AbstractModel
    {
        
        /// <summary>
        /// Region name, such as ap-guangzhou.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Region description, for example, South China (Guangzhou).
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// Whether the region is in an available state.
        /// </summary>
        [JsonProperty("RegionState")]
        public string RegionState{ get; set; }

        /// <summary>
        /// Console type. defaults to null when called via api.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionTypeMC")]
        public long? RegionTypeMC{ get; set; }

        /// <summary>
        /// Region for different languages.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LocationMC")]
        public string LocationMC{ get; set; }

        /// <summary>
        /// Region description on console display.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionNameMC")]
        public string RegionNameMC{ get; set; }

        /// <summary>
        /// 1
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionIdMC")]
        public string RegionIdMC{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RegionState", this.RegionState);
            this.SetParamSimple(map, prefix + "RegionTypeMC", this.RegionTypeMC);
            this.SetParamSimple(map, prefix + "LocationMC", this.LocationMC);
            this.SetParamSimple(map, prefix + "RegionNameMC", this.RegionNameMC);
            this.SetParamSimple(map, prefix + "RegionIdMC", this.RegionIdMC);
        }
    }
}

