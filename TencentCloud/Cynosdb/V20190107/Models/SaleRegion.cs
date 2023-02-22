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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SaleRegion : AbstractModel
    {
        
        /// <summary>
        /// Region name
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Numeric ID of a region
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// Region name
        /// </summary>
        [JsonProperty("RegionZh")]
        public string RegionZh{ get; set; }

        /// <summary>
        /// List of purchasable AZs
        /// </summary>
        [JsonProperty("ZoneSet")]
        public SaleZone[] ZoneSet{ get; set; }

        /// <summary>
        /// Engine type
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// Supported modules in a region
        /// </summary>
        [JsonProperty("Modules")]
        public Module[] Modules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "RegionZh", this.RegionZh);
            this.SetParamArrayObj(map, prefix + "ZoneSet.", this.ZoneSet);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamArrayObj(map, prefix + "Modules.", this.Modules);
        }
    }
}

