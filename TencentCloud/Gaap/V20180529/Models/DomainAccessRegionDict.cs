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

    public class DomainAccessRegionDict : AbstractModel
    {
        
        /// <summary>
        /// Nearest access region
        /// </summary>
        [JsonProperty("NationCountryInnerList")]
        public NationCountryInnerInfo[] NationCountryInnerList{ get; set; }

        /// <summary>
        /// Acceleration region connection list
        /// </summary>
        [JsonProperty("ProxyList")]
        public ProxyIdDict[] ProxyList{ get; set; }

        /// <summary>
        /// Acceleration region ID
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// Acceleration region internal code
        /// </summary>
        [JsonProperty("GeographicalZoneInnerCode")]
        public string GeographicalZoneInnerCode{ get; set; }

        /// <summary>
        /// Internal code of the continent to which the acceleration region belongs
        /// </summary>
        [JsonProperty("ContinentInnerCode")]
        public string ContinentInnerCode{ get; set; }

        /// <summary>
        /// Acceleration region alias
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "NationCountryInnerList.", this.NationCountryInnerList);
            this.SetParamArrayObj(map, prefix + "ProxyList.", this.ProxyList);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "GeographicalZoneInnerCode", this.GeographicalZoneInnerCode);
            this.SetParamSimple(map, prefix + "ContinentInnerCode", this.ContinentInnerCode);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
        }
    }
}

