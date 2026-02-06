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

    public class GeneralCard : AbstractModel
    {
        
        /// <summary>
        /// License number
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LicenseNumber")]
        public string LicenseNumber{ get; set; }

        /// <summary>
        /// Personal number, which is returned when it is a passport
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PersonalNumber")]
        public string PersonalNumber{ get; set; }

        /// <summary>
        /// The first line of passport machine reading code
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PassportCodeFirst")]
        public string PassportCodeFirst{ get; set; }

        /// <summary>
        /// The first line of passport machine reading code
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PassportCodeSecond")]
        public string PassportCodeSecond{ get; set; }

        /// <summary>
        /// Date of expiry in the format of YYYY-MM-DD
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public string ExpirationDate{ get; set; }

        /// <summary>
        /// Valid date in the format of YYYY-MM-DD
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DueDate")]
        public string DueDate{ get; set; }

        /// <summary>
        /// Date of issue in the format of YYYY-MM-DD
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IssuedDate")]
        public string IssuedDate{ get; set; }

        /// <summary>
        /// Issuing authority
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IssuedAuthority")]
        public string IssuedAuthority{ get; set; }

        /// <summary>
        /// Issuing country, which is returned following the ISO 3166 country coding specification
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// Example: MYS
        /// </summary>
        [JsonProperty("IssuedCountry")]
        public string IssuedCountry{ get; set; }

        /// <summary>
        /// Full Name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FullName")]
        public string FullName{ get; set; }

        /// <summary>
        /// First name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName{ get; set; }

        /// <summary>
        /// Last name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastName")]
        public string LastName{ get; set; }

        /// <summary>
        /// Gender on the license
        /// - M: male
        /// - F: female
        /// - X: other gender
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// Example: M
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// Age. 0 indicates that no valid information is obtained.
        /// Example: 0
        /// </summary>
        [JsonProperty("Age")]
        public string Age{ get; set; }

        /// <summary>
        /// Birthday
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// Birth place
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BirthPlace")]
        public string BirthPlace{ get; set; }

        /// <summary>
        /// Nationality, which is returned following the ISO 3166 country coding specification
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// Example: IND
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// Registration number
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegistrationNumber")]
        public string RegistrationNumber{ get; set; }

        /// <summary>
        /// Address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Address")]
        public Address Address{ get; set; }

        /// <summary>
        /// Localized name.
        /// </summary>
        [JsonProperty("FullNameLocal")]
        public string FullNameLocal{ get; set; }

        /// <summary>
        /// Localization.
        /// </summary>
        [JsonProperty("FirstNameLocal")]
        public string FirstNameLocal{ get; set; }

        /// <summary>
        /// Localized surname.
        /// </summary>
        [JsonProperty("LastNameLocal")]
        public string LastNameLocal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LicenseNumber", this.LicenseNumber);
            this.SetParamSimple(map, prefix + "PersonalNumber", this.PersonalNumber);
            this.SetParamSimple(map, prefix + "PassportCodeFirst", this.PassportCodeFirst);
            this.SetParamSimple(map, prefix + "PassportCodeSecond", this.PassportCodeSecond);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamSimple(map, prefix + "DueDate", this.DueDate);
            this.SetParamSimple(map, prefix + "IssuedDate", this.IssuedDate);
            this.SetParamSimple(map, prefix + "IssuedAuthority", this.IssuedAuthority);
            this.SetParamSimple(map, prefix + "IssuedCountry", this.IssuedCountry);
            this.SetParamSimple(map, prefix + "FullName", this.FullName);
            this.SetParamSimple(map, prefix + "FirstName", this.FirstName);
            this.SetParamSimple(map, prefix + "LastName", this.LastName);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "BirthPlace", this.BirthPlace);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "RegistrationNumber", this.RegistrationNumber);
            this.SetParamObj(map, prefix + "Address.", this.Address);
            this.SetParamSimple(map, prefix + "FullNameLocal", this.FullNameLocal);
            this.SetParamSimple(map, prefix + "FirstNameLocal", this.FirstNameLocal);
            this.SetParamSimple(map, prefix + "LastNameLocal", this.LastNameLocal);
        }
    }
}

