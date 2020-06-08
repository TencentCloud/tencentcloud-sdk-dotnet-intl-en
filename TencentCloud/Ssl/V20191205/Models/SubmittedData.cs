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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmittedData : AbstractModel
    {
        
        /// <summary>
        /// CSR type. Online: CSR generated online; parse: CSR pasted.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CsrType")]
        public string CsrType{ get; set; }

        /// <summary>
        /// CSR content.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CsrContent")]
        public string CsrContent{ get; set; }

        /// <summary>
        /// Domain name information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateDomain")]
        public string CertificateDomain{ get; set; }

        /// <summary>
        /// DNS information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DomainList")]
        public string[] DomainList{ get; set; }

        /// <summary>
        /// Password of the private key.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KeyPassword")]
        public string KeyPassword{ get; set; }

        /// <summary>
        /// Enterprise or unit name.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// Division.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrganizationDivision")]
        public string OrganizationDivision{ get; set; }

        /// <summary>
        /// Address.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrganizationAddress")]
        public string OrganizationAddress{ get; set; }

        /// <summary>
        /// Country.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrganizationCountry")]
        public string OrganizationCountry{ get; set; }

        /// <summary>
        /// City.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrganizationCity")]
        public string OrganizationCity{ get; set; }

        /// <summary>
        /// Province.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrganizationRegion")]
        public string OrganizationRegion{ get; set; }

        /// <summary>
        /// Postal code.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PostalCode")]
        public string PostalCode{ get; set; }

        /// <summary>
        /// Area code of the fixed-line phone number.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneAreaCode")]
        public string PhoneAreaCode{ get; set; }

        /// <summary>
        /// Fixed-line phone number.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// First name of the admin.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdminFirstName")]
        public string AdminFirstName{ get; set; }

        /// <summary>
        /// Last name of the admin.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdminLastName")]
        public string AdminLastName{ get; set; }

        /// <summary>
        /// Phone number of the admin.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdminPhoneNum")]
        public string AdminPhoneNum{ get; set; }

        /// <summary>
        /// Email of the admin.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdminEmail")]
        public string AdminEmail{ get; set; }

        /// <summary>
        /// Position of the admin.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdminPosition")]
        public string AdminPosition{ get; set; }

        /// <summary>
        /// First name of the contact.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContactFirstName")]
        public string ContactFirstName{ get; set; }

        /// <summary>
        /// Last name of the contact.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContactLastName")]
        public string ContactLastName{ get; set; }

        /// <summary>
        /// Phone number of the contact.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContactNumber")]
        public string ContactNumber{ get; set; }

        /// <summary>
        /// Email of the contact.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContactEmail")]
        public string ContactEmail{ get; set; }

        /// <summary>
        /// Position of the contact.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContactPosition")]
        public string ContactPosition{ get; set; }

        /// <summary>
        /// Verification type.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CsrType", this.CsrType);
            this.SetParamSimple(map, prefix + "CsrContent", this.CsrContent);
            this.SetParamSimple(map, prefix + "CertificateDomain", this.CertificateDomain);
            this.SetParamArraySimple(map, prefix + "DomainList.", this.DomainList);
            this.SetParamSimple(map, prefix + "KeyPassword", this.KeyPassword);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "OrganizationDivision", this.OrganizationDivision);
            this.SetParamSimple(map, prefix + "OrganizationAddress", this.OrganizationAddress);
            this.SetParamSimple(map, prefix + "OrganizationCountry", this.OrganizationCountry);
            this.SetParamSimple(map, prefix + "OrganizationCity", this.OrganizationCity);
            this.SetParamSimple(map, prefix + "OrganizationRegion", this.OrganizationRegion);
            this.SetParamSimple(map, prefix + "PostalCode", this.PostalCode);
            this.SetParamSimple(map, prefix + "PhoneAreaCode", this.PhoneAreaCode);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "AdminFirstName", this.AdminFirstName);
            this.SetParamSimple(map, prefix + "AdminLastName", this.AdminLastName);
            this.SetParamSimple(map, prefix + "AdminPhoneNum", this.AdminPhoneNum);
            this.SetParamSimple(map, prefix + "AdminEmail", this.AdminEmail);
            this.SetParamSimple(map, prefix + "AdminPosition", this.AdminPosition);
            this.SetParamSimple(map, prefix + "ContactFirstName", this.ContactFirstName);
            this.SetParamSimple(map, prefix + "ContactLastName", this.ContactLastName);
            this.SetParamSimple(map, prefix + "ContactNumber", this.ContactNumber);
            this.SetParamSimple(map, prefix + "ContactEmail", this.ContactEmail);
            this.SetParamSimple(map, prefix + "ContactPosition", this.ContactPosition);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
        }
    }
}

