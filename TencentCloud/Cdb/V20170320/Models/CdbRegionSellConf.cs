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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CdbRegionSellConf : AbstractModel
    {
        
        /// <summary>
        /// Region name
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// Area
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Whether it is a default region
        /// </summary>
        [JsonProperty("IsDefaultRegion")]
        public long? IsDefaultRegion{ get; set; }

        /// <summary>
        /// Region name
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// The purchasable configuration in an AZ in a region
        /// </summary>
        [JsonProperty("RegionConfig")]
        public CdbZoneSellConf[] RegionConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "IsDefaultRegion", this.IsDefaultRegion);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "RegionConfig.", this.RegionConfig);
        }
    }
}

