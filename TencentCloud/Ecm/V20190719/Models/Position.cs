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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Position : AbstractModel
    {
        
        /// <summary>
        /// Zone information of the instance.
        /// </summary>
        [JsonProperty("ZoneInfo")]
        public ZoneInfo ZoneInfo{ get; set; }

        /// <summary>
        /// Country/Region information of the instance.
        /// </summary>
        [JsonProperty("Country")]
        public Country Country{ get; set; }

        /// <summary>
        /// Area information of the instance.
        /// </summary>
        [JsonProperty("Area")]
        public Area Area{ get; set; }

        /// <summary>
        /// Province/State information of the instance.
        /// </summary>
        [JsonProperty("Province")]
        public Province Province{ get; set; }

        /// <summary>
        /// City information of the instance.
        /// </summary>
        [JsonProperty("City")]
        public City City{ get; set; }

        /// <summary>
        /// Region information of the instance.
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ZoneInfo.", this.ZoneInfo);
            this.SetParamObj(map, prefix + "Country.", this.Country);
            this.SetParamObj(map, prefix + "Area.", this.Area);
            this.SetParamObj(map, prefix + "Province.", this.Province);
            this.SetParamObj(map, prefix + "City.", this.City);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
        }
    }
}

