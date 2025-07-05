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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CountryAreaMap : AbstractModel
    {
        
        /// <summary>
        /// Country name.
        /// </summary>
        [JsonProperty("NationCountryName")]
        public string NationCountryName{ get; set; }

        /// <summary>
        /// Country code.
        /// </summary>
        [JsonProperty("NationCountryInnerCode")]
        public string NationCountryInnerCode{ get; set; }

        /// <summary>
        /// Region name.
        /// </summary>
        [JsonProperty("GeographicalZoneName")]
        public string GeographicalZoneName{ get; set; }

        /// <summary>
        /// Region code.
        /// </summary>
        [JsonProperty("GeographicalZoneInnerCode")]
        public string GeographicalZoneInnerCode{ get; set; }

        /// <summary>
        /// Continent name.
        /// </summary>
        [JsonProperty("ContinentName")]
        public string ContinentName{ get; set; }

        /// <summary>
        /// Continent code.
        /// </summary>
        [JsonProperty("ContinentInnerCode")]
        public string ContinentInnerCode{ get; set; }

        /// <summary>
        /// Remark information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NationCountryName", this.NationCountryName);
            this.SetParamSimple(map, prefix + "NationCountryInnerCode", this.NationCountryInnerCode);
            this.SetParamSimple(map, prefix + "GeographicalZoneName", this.GeographicalZoneName);
            this.SetParamSimple(map, prefix + "GeographicalZoneInnerCode", this.GeographicalZoneInnerCode);
            this.SetParamSimple(map, prefix + "ContinentName", this.ContinentName);
            this.SetParamSimple(map, prefix + "ContinentInnerCode", this.ContinentInnerCode);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

