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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntlContactInfo : AbstractModel
    {
        
        /// <summary>
        /// The city name.
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// The country or region name.
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// The domain registrant.
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// The province or state name.
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// The name of the registrant.
        /// </summary>
        [JsonProperty("RegistrantName")]
        public string RegistrantName{ get; set; }

        /// <summary>
        /// The registrant type. Valid values: `I` (individual), `E` (organization).
        /// </summary>
        [JsonProperty("RegistrantType")]
        public string RegistrantType{ get; set; }

        /// <summary>
        /// The detailed address.
        /// </summary>
        [JsonProperty("Street")]
        public string Street{ get; set; }

        /// <summary>
        /// The mobile number.
        /// </summary>
        [JsonProperty("Telephone")]
        public string Telephone{ get; set; }

        /// <summary>
        /// The zip code.
        /// </summary>
        [JsonProperty("ZipCode")]
        public string ZipCode{ get; set; }

        /// <summary>
        /// The first name.
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName{ get; set; }

        /// <summary>
        /// The last name.
        /// </summary>
        [JsonProperty("LastName")]
        public string LastName{ get; set; }

        /// <summary>
        /// The company name.
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "RegistrantName", this.RegistrantName);
            this.SetParamSimple(map, prefix + "RegistrantType", this.RegistrantType);
            this.SetParamSimple(map, prefix + "Street", this.Street);
            this.SetParamSimple(map, prefix + "Telephone", this.Telephone);
            this.SetParamSimple(map, prefix + "ZipCode", this.ZipCode);
            this.SetParamSimple(map, prefix + "FirstName", this.FirstName);
            this.SetParamSimple(map, prefix + "LastName", this.LastName);
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
        }
    }
}

