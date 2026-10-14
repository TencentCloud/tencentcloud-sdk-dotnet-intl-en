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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddressInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Country</p>
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// <p>Postal code</p>
        /// </summary>
        [JsonProperty("PostalCode")]
        public string PostalCode{ get; set; }

        /// <summary>
        /// <p>Sub-region</p>
        /// </summary>
        [JsonProperty("Subdivision")]
        public string Subdivision{ get; set; }

        /// <summary>
        /// <p>District</p>
        /// </summary>
        [JsonProperty("District")]
        public string District{ get; set; }

        /// <summary>
        /// <p>City</p>
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// <p>Sub-district office</p>
        /// </summary>
        [JsonProperty("Subdistrict")]
        public string Subdistrict{ get; set; }

        /// <summary>
        /// <p>Complete address</p>
        /// </summary>
        [JsonProperty("FormattedAddress")]
        public string FormattedAddress{ get; set; }

        /// <summary>
        /// <p>First line of the address bar</p>
        /// </summary>
        [JsonProperty("LineOne")]
        public string LineOne{ get; set; }

        /// <summary>
        /// <p>Second line of the address bar</p>
        /// </summary>
        [JsonProperty("LineTwo")]
        public string LineTwo{ get; set; }

        /// <summary>
        /// <p>Third line of the address bar</p>
        /// </summary>
        [JsonProperty("LineThree")]
        public string LineThree{ get; set; }

        /// <summary>
        /// <p>Fourth line of the address bar</p>
        /// </summary>
        [JsonProperty("LineFour")]
        public string LineFour{ get; set; }

        /// <summary>
        /// <p>Fifth line of the address bar</p>
        /// </summary>
        [JsonProperty("LineFive")]
        public string LineFive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "PostalCode", this.PostalCode);
            this.SetParamSimple(map, prefix + "Subdivision", this.Subdivision);
            this.SetParamSimple(map, prefix + "District", this.District);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Subdistrict", this.Subdistrict);
            this.SetParamSimple(map, prefix + "FormattedAddress", this.FormattedAddress);
            this.SetParamSimple(map, prefix + "LineOne", this.LineOne);
            this.SetParamSimple(map, prefix + "LineTwo", this.LineTwo);
            this.SetParamSimple(map, prefix + "LineThree", this.LineThree);
            this.SetParamSimple(map, prefix + "LineFour", this.LineFour);
            this.SetParamSimple(map, prefix + "LineFive", this.LineFive);
        }
    }
}

