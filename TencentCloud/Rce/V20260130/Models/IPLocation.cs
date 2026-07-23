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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPLocation : AbstractModel
    {
        
        /// <summary>
        /// <p>The country of the IP address</p>
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// <p>The region of the IP address</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>The city of the IP address</p>
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// <p>The district of the IP address</p>
        /// </summary>
        [JsonProperty("District")]
        public string District{ get; set; }

        /// <summary>
        /// <p>The longitude of the IP address</p>
        /// </summary>
        [JsonProperty("Longitude")]
        public string Longitude{ get; set; }

        /// <summary>
        /// <p>The latitude of the IP address</p>
        /// </summary>
        [JsonProperty("Latitude")]
        public string Latitude{ get; set; }

        /// <summary>
        /// <p>The timezone of the IP address</p>
        /// </summary>
        [JsonProperty("Timezone")]
        public string Timezone{ get; set; }

        /// <summary>
        /// <p>The zip code of the IP address</p>
        /// </summary>
        [JsonProperty("ZipCode")]
        public string ZipCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "District", this.District);
            this.SetParamSimple(map, prefix + "Longitude", this.Longitude);
            this.SetParamSimple(map, prefix + "Latitude", this.Latitude);
            this.SetParamSimple(map, prefix + "Timezone", this.Timezone);
            this.SetParamSimple(map, prefix + "ZipCode", this.ZipCode);
        }
    }
}

