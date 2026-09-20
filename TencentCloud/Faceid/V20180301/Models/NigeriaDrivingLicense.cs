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

    public class NigeriaDrivingLicense : AbstractModel
    {
        
        /// <summary>
        /// Last name
        /// </summary>
        [JsonProperty("LastName")]
        public string LastName{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName{ get; set; }

        /// <summary>
        /// Identity card
        /// </summary>
        [JsonProperty("LicenseNumber")]
        public string LicenseNumber{ get; set; }

        /// <summary>
        /// Age
        /// </summary>
        [JsonProperty("Age")]
        public string Age{ get; set; }

        /// <summary>
        /// Birthday
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// City of issuance
        /// </summary>
        [JsonProperty("IssuedCountry")]
        public string IssuedCountry{ get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public string ExpirationDate{ get; set; }

        /// <summary>
        /// Issue date
        /// </summary>
        [JsonProperty("IssuedDate")]
        public string IssuedDate{ get; set; }

        /// <summary>
        /// Sex
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LastName", this.LastName);
            this.SetParamSimple(map, prefix + "FirstName", this.FirstName);
            this.SetParamSimple(map, prefix + "LicenseNumber", this.LicenseNumber);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "IssuedCountry", this.IssuedCountry);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamSimple(map, prefix + "IssuedDate", this.IssuedDate);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
        }
    }
}

