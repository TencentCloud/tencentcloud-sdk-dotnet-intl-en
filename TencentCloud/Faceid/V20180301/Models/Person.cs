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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Person : AbstractModel
    {
        
        /// <summary>
        /// <p>Full name (either this or LastName is required). If FullName is filled, FirstName/MiddleName/LastName cannot be filled</p>
        /// </summary>
        [JsonProperty("FullName")]
        public string FullName{ get; set; }

        /// <summary>
        /// <p>name (either this or FullName is required)</p>
        /// </summary>
        [JsonProperty("LastName")]
        public string LastName{ get; set; }

        /// <summary>
        /// <p>First name (optional)</p>
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName{ get; set; }

        /// <summary>
        /// <p>Middle name (optional)</p>
        /// </summary>
        [JsonProperty("MiddleName")]
        public string MiddleName{ get; set; }

        /// <summary>
        /// <p>ID number (Option)</p>
        /// </summary>
        [JsonProperty("IdentityNumber")]
        public string IdentityNumber{ get; set; }

        /// <summary>
        /// <p>Date of birth, format: YYYY-MM-DD, YYYY-MM, YYYY (Year-Month-Day separated by -)</p><p>Parameter format: YYYY-MM-DD</p>
        /// </summary>
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth{ get; set; }

        /// <summary>
        /// <p>Gender: MALE / FEMALE / OTHER / NOT_KNOWN</p><p>Enumeration values:</p><ul><li>MALE: male</li><li>FEMALE: female</li><li>OTHER: OTHER</li><li>NOT_KNOWN: NOT_KNOWN</li></ul>
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// <p>Address</p>
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>Nationality, ISO 3166-1 alpha-2 country code (Option)</p>
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// <p>Country of residence, ISO 3166-1 alpha-2 country code (optional)</p>
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullName", this.FullName);
            this.SetParamSimple(map, prefix + "LastName", this.LastName);
            this.SetParamSimple(map, prefix + "FirstName", this.FirstName);
            this.SetParamSimple(map, prefix + "MiddleName", this.MiddleName);
            this.SetParamSimple(map, prefix + "IdentityNumber", this.IdentityNumber);
            this.SetParamSimple(map, prefix + "DateOfBirth", this.DateOfBirth);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "Country", this.Country);
        }
    }
}

