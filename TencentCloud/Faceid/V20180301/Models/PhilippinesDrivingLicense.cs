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

    public class PhilippinesDrivingLicense : AbstractModel
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [JsonProperty("LastName")]
        public string LastName{ get; set; }

        /// <summary>
        /// First name
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName{ get; set; }

        /// <summary>
        /// Middle name
        /// </summary>
        [JsonProperty("MiddleName")]
        public string MiddleName{ get; set; }

        /// <summary>
        /// Nationality
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// Sex
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// ID number
        /// </summary>
        [JsonProperty("LicenseNo")]
        public string LicenseNo{ get; set; }

        /// <summary>
        /// Validity period.
        /// </summary>
        [JsonProperty("ExpiresDate")]
        public string ExpiresDate{ get; set; }

        /// <summary>
        /// Organization code
        /// </summary>
        [JsonProperty("AgencyCode")]
        public string AgencyCode{ get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "LastName", this.LastName);
            this.SetParamSimple(map, prefix + "FirstName", this.FirstName);
            this.SetParamSimple(map, prefix + "MiddleName", this.MiddleName);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "LicenseNo", this.LicenseNo);
            this.SetParamSimple(map, prefix + "ExpiresDate", this.ExpiresDate);
            this.SetParamSimple(map, prefix + "AgencyCode", this.AgencyCode);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
        }
    }
}

