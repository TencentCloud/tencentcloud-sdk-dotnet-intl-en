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
        /// Document type, obtained from passport visual zone
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Issuing country, obtained from passport visual zone
        /// </summary>
        [JsonProperty("IssuingCountry")]
        public string IssuingCountry{ get; set; }

        /// <summary>
        /// Unique serial number / identification number of the passport, obtained from passport visual zone
        /// </summary>
        [JsonProperty("PassportID")]
        public string PassportID{ get; set; }

        /// <summary>
        /// Last name, obtained from passport visual zone
        /// </summary>
        [JsonProperty("Surname")]
        public string Surname{ get; set; }

        /// <summary>
        /// First name, obtained from passport visual zone
        /// </summary>
        [JsonProperty("GivenName")]
        public string GivenName{ get; set; }

        /// <summary>
        /// Full name, obtained from passport visual zone
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Nationality, obtained from passport visual zone
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// Date of birth, obtained from passport visual zone
        /// </summary>
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth{ get; set; }

        /// <summary>
        /// Gender, obtained from passport visual zone
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// Date of issue, obtained from passport visual zone
        /// </summary>
        [JsonProperty("DateOfIssuance")]
        public string DateOfIssuance{ get; set; }

        /// <summary>
        /// Passport expiry date, obtained from passport visual zone
        /// </summary>
        [JsonProperty("DateOfExpiration")]
        public string DateOfExpiration{ get; set; }

        /// <summary>
        /// Holder's signature, obtained from passport visual zone
        /// (Note: Only returned for PRC passport)
        /// </summary>
        [JsonProperty("Signature")]
        public string Signature{ get; set; }

        /// <summary>
        /// Place of issue, obtained from passport visual zone
        /// (Note: Only returned for PRC passport)
        /// </summary>
        [JsonProperty("IssuePlace")]
        public string IssuePlace{ get; set; }

        /// <summary>
        /// Issuing Authority, obtained from passport visual zone
        /// (Note: Only returned for PRC passport)
        /// </summary>
        [JsonProperty("IssuingAuthority")]
        public string IssuingAuthority{ get; set; }

        /// <summary>
        /// Place of birth, obtained from passport visual zone
        /// </summary>
        [JsonProperty("BirthPlace")]
        public string BirthPlace{ get; set; }

        /// <summary>
        /// Passport flag, obtained from passport visual zone
        /// </summary>
        [JsonProperty("PassportFlag")]
        public string PassportFlag{ get; set; }

        /// <summary>
        /// Middle name, obtained from passport visual zone
        /// </summary>
        [JsonProperty("MiddleName")]
        public string MiddleName{ get; set; }

        /// <summary>
        /// Father's name, obtained from passport visual zone
        /// </summary>
        [JsonProperty("FatherName")]
        public string FatherName{ get; set; }

        /// <summary>
        /// Mother's name, obtained from passport visual zone
        /// </summary>
        [JsonProperty("MotherName")]
        public string MotherName{ get; set; }

        /// <summary>
        /// Title, obtained from passport visual zone
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// Name suffix, obtained from passport visual zone
        /// </summary>
        [JsonProperty("Postname")]
        public string Postname{ get; set; }


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
            this.SetParamSimple(map, prefix + "BirthPlace", this.BirthPlace);
            this.SetParamSimple(map, prefix + "PassportFlag", this.PassportFlag);
            this.SetParamSimple(map, prefix + "MiddleName", this.MiddleName);
            this.SetParamSimple(map, prefix + "FatherName", this.FatherName);
            this.SetParamSimple(map, prefix + "MotherName", this.MotherName);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Postname", this.Postname);
        }
    }
}

