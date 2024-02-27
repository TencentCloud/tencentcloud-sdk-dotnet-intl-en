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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Address : AbstractModel
    {
        
        /// <summary>
        /// Nationality.
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// Post code.
        /// </summary>
        [JsonProperty("PostalCode")]
        public string PostalCode{ get; set; }

        /// <summary>
        /// Subregion.
        /// </summary>
        [JsonProperty("Subdivision")]
        public string Subdivision{ get; set; }

        /// <summary>
        /// City.
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// Complete address.
        /// </summary>
        [JsonProperty("FormattedAddress")]
        public string FormattedAddress{ get; set; }

        /// <summary>
        /// The first line of address.
        /// </summary>
        [JsonProperty("LineOne")]
        public string LineOne{ get; set; }

        /// <summary>
        /// The second line of address.
        /// </summary>
        [JsonProperty("LineTwo")]
        public string LineTwo{ get; set; }

        /// <summary>
        /// The third line of address.
        /// </summary>
        [JsonProperty("LineThree")]
        public string LineThree{ get; set; }

        /// <summary>
        /// The fourth line of address.
        /// </summary>
        [JsonProperty("LineFour")]
        public string LineFour{ get; set; }

        /// <summary>
        /// The fifth line of address.
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

