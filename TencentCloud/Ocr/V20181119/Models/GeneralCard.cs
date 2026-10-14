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

    public class GeneralCard : AbstractModel
    {
        
        /// <summary>
        /// <p>ID number</p>
        /// </summary>
        [JsonProperty("LicenseNumber")]
        public string LicenseNumber{ get; set; }

        /// <summary>
        /// <p>Personal number, returned when the identity document type is passport</p>
        /// </summary>
        [JsonProperty("PersonalNumber")]
        public string PersonalNumber{ get; set; }

        /// <summary>
        /// <p>Name</p>
        /// </summary>
        [JsonProperty("FullName")]
        public string FullName{ get; set; }

        /// <summary>
        /// <p>Localized name</p>
        /// </summary>
        [JsonProperty("FullNameLocal")]
        public string FullNameLocal{ get; set; }

        /// <summary>
        /// <p>Name</p>
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName{ get; set; }

        /// <summary>
        /// <p>Localized name</p>
        /// </summary>
        [JsonProperty("FirstNameLocal")]
        public string FirstNameLocal{ get; set; }

        /// <summary>
        /// <p>Middle name</p>
        /// </summary>
        [JsonProperty("MiddleName")]
        public string MiddleName{ get; set; }

        /// <summary>
        /// <p>Localized middle name</p>
        /// </summary>
        [JsonProperty("MiddleNameLocal")]
        public string MiddleNameLocal{ get; set; }

        /// <summary>
        /// <p>Last name</p>
        /// </summary>
        [JsonProperty("LastName")]
        public string LastName{ get; set; }

        /// <summary>
        /// <p>Localized last name</p>
        /// </summary>
        [JsonProperty("LastNameLocal")]
        public string LastNameLocal{ get; set; }

        /// <summary>
        /// <p>Gender on the document</p><ul><li>M: man</li><li>F: woman</li><li>X: other gender identity</li></ul>
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// <p>Date of birth</p>
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// <p>Birth place</p>
        /// </summary>
        [JsonProperty("BirthPlace")]
        public string BirthPlace{ get; set; }

        /// <summary>
        /// <p>Issue date, in YYYY-MM-DD format</p>
        /// </summary>
        [JsonProperty("IssuedDate")]
        public string IssuedDate{ get; set; }

        /// <summary>
        /// <p>Issuing authority</p>
        /// </summary>
        [JsonProperty("IssuedAuthority")]
        public string IssuedAuthority{ get; set; }

        /// <summary>
        /// <p>Place where the specified file is issued</p>
        /// </summary>
        [JsonProperty("IssuedPlace")]
        public string IssuedPlace{ get; set; }

        /// <summary>
        /// <p>Issuing country</p>
        /// </summary>
        [JsonProperty("IssuedCountry")]
        public string IssuedCountry{ get; set; }

        /// <summary>
        /// <p>Country code of the country that issued the file, ISO ALPHA-3 country/region code</p>
        /// </summary>
        [JsonProperty("IssuedCountryCode")]
        public string IssuedCountryCode{ get; set; }

        /// <summary>
        /// <p>Expiration date, in YYYY-MM-DD format</p>
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public string ExpirationDate{ get; set; }

        /// <summary>
        /// <p>Content of the single-line machine-readable zone (MRZ) on the document. The number represents the order in which the line appears in the MRZ</p>
        /// </summary>
        [JsonProperty("MRZLine1")]
        public string MRZLine1{ get; set; }

        /// <summary>
        /// <p>Content of the single-line machine-readable zone (MRZ) on the document. The number represents the line count in the order of the MRZ</p>
        /// </summary>
        [JsonProperty("MRZLine2")]
        public string MRZLine2{ get; set; }

        /// <summary>
        /// <p>Document nationality, returned following the ISO 3166 country coding specification</p>
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// <p>Address information on the document</p>
        /// </summary>
        [JsonProperty("Address")]
        public AddressInfo Address{ get; set; }

        /// <summary>
        /// <p>Religious belief</p>
        /// </summary>
        [JsonProperty("Religion")]
        public string Religion{ get; set; }

        /// <summary>
        /// <p>Document type</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Blood type</p>
        /// </summary>
        [JsonProperty("BloodType")]
        public string BloodType{ get; set; }

        /// <summary>
        /// <p>Height</p>
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// <p>Weight</p>
        /// </summary>
        [JsonProperty("Weight")]
        public string Weight{ get; set; }

        /// <summary>
        /// <p>Driver's license vehicle type (for example, A/B/C)</p>
        /// </summary>
        [JsonProperty("VehicleClass")]
        public string VehicleClass{ get; set; }

        /// <summary>
        /// <p>Driver's license restriction condition</p>
        /// </summary>
        [JsonProperty("Restrictions")]
        public string Restrictions{ get; set; }

        /// <summary>
        /// <p>Driver's license extra records</p>
        /// </summary>
        [JsonProperty("Endorsement")]
        public string Endorsement{ get; set; }

        /// <summary>
        /// <p>Additional field</p>
        /// </summary>
        [JsonProperty("Others")]
        public string Others{ get; set; }

        /// <summary>
        /// <p>MRZ line 1 of the passport</p>
        /// </summary>
        [JsonProperty("PassportCodeFirst")]
        [System.Obsolete]
        public string PassportCodeFirst{ get; set; }

        /// <summary>
        /// <p>MRZ line 2 of the passport</p>
        /// </summary>
        [JsonProperty("PassportCodeSecond")]
        [System.Obsolete]
        public string PassportCodeSecond{ get; set; }

        /// <summary>
        /// <p>Validity date, in YYYY-MM-DD format</p>
        /// </summary>
        [JsonProperty("DueDate")]
        [System.Obsolete]
        public string DueDate{ get; set; }

        /// <summary>
        /// <p>Age. 0 means no valid info is obtained</p>
        /// </summary>
        [JsonProperty("Age")]
        [System.Obsolete]
        public string Age{ get; set; }

        /// <summary>
        /// <p>Registration number</p>
        /// </summary>
        [JsonProperty("RegistrationNumber")]
        [System.Obsolete]
        public string RegistrationNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LicenseNumber", this.LicenseNumber);
            this.SetParamSimple(map, prefix + "PersonalNumber", this.PersonalNumber);
            this.SetParamSimple(map, prefix + "FullName", this.FullName);
            this.SetParamSimple(map, prefix + "FullNameLocal", this.FullNameLocal);
            this.SetParamSimple(map, prefix + "FirstName", this.FirstName);
            this.SetParamSimple(map, prefix + "FirstNameLocal", this.FirstNameLocal);
            this.SetParamSimple(map, prefix + "MiddleName", this.MiddleName);
            this.SetParamSimple(map, prefix + "MiddleNameLocal", this.MiddleNameLocal);
            this.SetParamSimple(map, prefix + "LastName", this.LastName);
            this.SetParamSimple(map, prefix + "LastNameLocal", this.LastNameLocal);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "BirthPlace", this.BirthPlace);
            this.SetParamSimple(map, prefix + "IssuedDate", this.IssuedDate);
            this.SetParamSimple(map, prefix + "IssuedAuthority", this.IssuedAuthority);
            this.SetParamSimple(map, prefix + "IssuedPlace", this.IssuedPlace);
            this.SetParamSimple(map, prefix + "IssuedCountry", this.IssuedCountry);
            this.SetParamSimple(map, prefix + "IssuedCountryCode", this.IssuedCountryCode);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamSimple(map, prefix + "MRZLine1", this.MRZLine1);
            this.SetParamSimple(map, prefix + "MRZLine2", this.MRZLine2);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamObj(map, prefix + "Address.", this.Address);
            this.SetParamSimple(map, prefix + "Religion", this.Religion);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "BloodType", this.BloodType);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "VehicleClass", this.VehicleClass);
            this.SetParamSimple(map, prefix + "Restrictions", this.Restrictions);
            this.SetParamSimple(map, prefix + "Endorsement", this.Endorsement);
            this.SetParamSimple(map, prefix + "Others", this.Others);
            this.SetParamSimple(map, prefix + "PassportCodeFirst", this.PassportCodeFirst);
            this.SetParamSimple(map, prefix + "PassportCodeSecond", this.PassportCodeSecond);
            this.SetParamSimple(map, prefix + "DueDate", this.DueDate);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "RegistrationNumber", this.RegistrationNumber);
        }
    }
}

