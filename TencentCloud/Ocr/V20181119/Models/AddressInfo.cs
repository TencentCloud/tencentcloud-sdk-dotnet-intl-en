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
        /// Country.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// Postal code.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PostalCode")]
        public string PostalCode{ get; set; }

        /// <summary>
        /// Specifies the sub-region.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Subdivision")]
        public string Subdivision{ get; set; }

        /// <summary>
        /// Specifies the city.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// Complete address.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FormattedAddress")]
        public string FormattedAddress{ get; set; }

        /// <summary>
        /// First line of the address bar.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LineOne")]
        public string LineOne{ get; set; }

        /// <summary>
        /// Second line of the address bar.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LineTwo")]
        public string LineTwo{ get; set; }

        /// <summary>
        /// Specifies the third line of the address bar.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LineThree")]
        public string LineThree{ get; set; }

        /// <summary>
        /// Specifies the fourth line of the address bar.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LineFour")]
        public string LineFour{ get; set; }

        /// <summary>
        /// Specifies the fifth line in the address bar.
        /// Note: This field may return null, indicating that no valid values can be obtained.
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
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "FormattedAddress", this.FormattedAddress);
            this.SetParamSimple(map, prefix + "LineOne", this.LineOne);
            this.SetParamSimple(map, prefix + "LineTwo", this.LineTwo);
            this.SetParamSimple(map, prefix + "LineThree", this.LineThree);
            this.SetParamSimple(map, prefix + "LineFour", this.LineFour);
            this.SetParamSimple(map, prefix + "LineFive", this.LineFive);
        }
    }
}

