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

    public class PassportRecognizeInfos : AbstractModel
    {
        
        /// <summary>
        /// Document Type (Passport Information Page Recognition Result).
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Issuing Country (Passport Information Page Recognition Result).
        /// </summary>
        [JsonProperty("IssuingCountry")]
        public string IssuingCountry{ get; set; }

        /// <summary>
        /// Passport Number (Passport Information Page Recognition Result).
        /// </summary>
        [JsonProperty("PassportID")]
        public string PassportID{ get; set; }

        /// <summary>
        /// Surname (Passport Information Page Recognition Result).
        /// </summary>
        [JsonProperty("Surname")]
        public string Surname{ get; set; }

        /// <summary>
        /// Given Name (Passport Information Page Recognition Result).
        /// </summary>
        [JsonProperty("GivenName")]
        public string GivenName{ get; set; }

        /// <summary>
        /// Full Name (Passport Information Page Recognition Result).
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Nationality Information (Passport Information Page Recognition Result).
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// Date of Birth (Passport Information Page Recognition Result).
        /// </summary>
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth{ get; set; }

        /// <summary>
        /// Gender (Passport Information Page Recognition Result).
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// Date of Issue (Passport Information Page Recognition Result).
        /// </summary>
        [JsonProperty("DateOfIssuance")]
        public string DateOfIssuance{ get; set; }

        /// <summary>
        /// Expiry Date (Passport Information Page Recognition Result).
        /// </summary>
        [JsonProperty("DateOfExpiration")]
        public string DateOfExpiration{ get; set; }

        /// <summary>
        /// Cardholder Signature (Passport Information Page Recognition Result)
        /// 
        /// This field is only supported for Chinese mainland passports and not available for Hong Kong (China), Macao (China), and Taiwan (China) passports or foreign passports.
        /// </summary>
        [JsonProperty("Signature")]
        public string Signature{ get; set; }

        /// <summary>
        /// Place of Issue (Passport Information Page Recognition Result)
        /// 
        /// This field is only supported for Chinese mainland passports and not available for Hong Kong (China), Macao (China), and Taiwan (China) passports or foreign passports.
        /// </summary>
        [JsonProperty("IssuePlace")]
        public string IssuePlace{ get; set; }

        /// <summary>
        /// Issuing Authority (Passport Information Page Recognition Result)
        /// 
        /// This field is only supported for Chinese mainland passports and not available for Hong Kong (China), Macao (China), and Taiwan (China) passports or foreign passports.
        /// </summary>
        [JsonProperty("IssuingAuthority")]
        public string IssuingAuthority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IssuingCountry", this.IssuingCountry);
            this.SetParamSimple(map, prefix + "PassportID", this.PassportID);
            this.SetParamSimple(map, prefix + "Surname", this.Surname);
            this.SetParamSimple(map, prefix + "GivenName", this.GivenName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "DateOfBirth", this.DateOfBirth);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "DateOfIssuance", this.DateOfIssuance);
            this.SetParamSimple(map, prefix + "DateOfExpiration", this.DateOfExpiration);
            this.SetParamSimple(map, prefix + "Signature", this.Signature);
            this.SetParamSimple(map, prefix + "IssuePlace", this.IssuePlace);
            this.SetParamSimple(map, prefix + "IssuingAuthority", this.IssuingAuthority);
        }
    }
}

