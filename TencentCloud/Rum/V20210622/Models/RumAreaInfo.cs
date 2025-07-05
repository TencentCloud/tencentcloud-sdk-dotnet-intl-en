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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RumAreaInfo : AbstractModel
    {
        
        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("AreaId")]
        public long? AreaId{ get; set; }

        /// <summary>
        /// Region status (1: valid; 2: invalid)
        /// </summary>
        [JsonProperty("AreaStatus")]
        public long? AreaStatus{ get; set; }

        /// <summary>
        /// Region name
        /// </summary>
        [JsonProperty("AreaName")]
        public string AreaName{ get; set; }

        /// <summary>
        /// Region key
        /// </summary>
        [JsonProperty("AreaKey")]
        public string AreaKey{ get; set; }

        /// <summary>
        /// Region ID.
        /// </summary>
        [JsonProperty("AreaRegionID")]
        public string AreaRegionID{ get; set; }

        /// <summary>
        /// Region code, such as “ap-xxx” (xxx is the region name).
        /// </summary>
        [JsonProperty("AreaRegionCode")]
        public string AreaRegionCode{ get; set; }

        /// <summary>
        /// Region abbreviation.
        /// </summary>
        [JsonProperty("AreaAbbr")]
        public string AreaAbbr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AreaId", this.AreaId);
            this.SetParamSimple(map, prefix + "AreaStatus", this.AreaStatus);
            this.SetParamSimple(map, prefix + "AreaName", this.AreaName);
            this.SetParamSimple(map, prefix + "AreaKey", this.AreaKey);
            this.SetParamSimple(map, prefix + "AreaRegionID", this.AreaRegionID);
            this.SetParamSimple(map, prefix + "AreaRegionCode", this.AreaRegionCode);
            this.SetParamSimple(map, prefix + "AreaAbbr", this.AreaAbbr);
        }
    }
}

