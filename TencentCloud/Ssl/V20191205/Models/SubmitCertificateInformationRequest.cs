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

    public class SubmitCertificateInformationRequest : AbstractModel
    {
        
        /// <summary>
        /// Certificate ID
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// CSR generation mode. `online`: generated online; `parse`: uploaded manually
        /// </summary>
        [JsonProperty("CsrType")]
        public string CsrType{ get; set; }

        /// <summary>
        /// Uploaded CSR content
        /// </summary>
        [JsonProperty("CsrContent")]
        public string CsrContent{ get; set; }

        /// <summary>
        /// Domain name bound with the certificate
        /// </summary>
        [JsonProperty("CertificateDomain")]
        public string CertificateDomain{ get; set; }

        /// <summary>
        /// Uploaded domain name array (can be uploaded for a multi-domain certificate)
        /// </summary>
        [JsonProperty("DomainList")]
        public string[] DomainList{ get; set; }

        /// <summary>
        /// Password of the private key
        /// </summary>
        [JsonProperty("KeyPassword")]
        public string KeyPassword{ get; set; }

        /// <summary>
        /// Organization name
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// Division name
        /// </summary>
        [JsonProperty("OrganizationDivision")]
        public string OrganizationDivision{ get; set; }

        /// <summary>
        /// Detailed address of the organization
        /// </summary>
        [JsonProperty("OrganizationAddress")]
        public string OrganizationAddress{ get; set; }

        /// <summary>
        /// Country where the organization is located, for example, CN (China)
        /// </summary>
        [JsonProperty("OrganizationCountry")]
        public string OrganizationCountry{ get; set; }

        /// <summary>
        /// City where the organization is located
        /// </summary>
        [JsonProperty("OrganizationCity")]
        public string OrganizationCity{ get; set; }

        /// <summary>
        /// Province where the organization is located
        /// </summary>
        [JsonProperty("OrganizationRegion")]
        public string OrganizationRegion{ get; set; }

        /// <summary>
        /// Postal code of the organization
        /// </summary>
        [JsonProperty("PostalCode")]
        public string PostalCode{ get; set; }

        /// <summary>
        /// Area code of the fixed-line phone number of the organization
        /// </summary>
        [JsonProperty("PhoneAreaCode")]
        public string PhoneAreaCode{ get; set; }

        /// <summary>
        /// Fixed-line phone number of the organization
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// Certificate validation method
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// Last name of the administrator
        /// </summary>
        [JsonProperty("AdminFirstName")]
        public string AdminFirstName{ get; set; }

        /// <summary>
        /// First name of the administrator
        /// </summary>
        [JsonProperty("AdminLastName")]
        public string AdminLastName{ get; set; }

        /// <summary>
        /// Mobile number of the administrator
        /// </summary>
        [JsonProperty("AdminPhoneNum")]
        public string AdminPhoneNum{ get; set; }

        /// <summary>
        /// Email of the administrator
        /// </summary>
        [JsonProperty("AdminEmail")]
        public string AdminEmail{ get; set; }

        /// <summary>
        /// Position of the administrator
        /// </summary>
        [JsonProperty("AdminPosition")]
        public string AdminPosition{ get; set; }

        /// <summary>
        /// Last name of the contact
        /// </summary>
        [JsonProperty("ContactFirstName")]
        public string ContactFirstName{ get; set; }

        /// <summary>
        /// First name of the contact
        /// </summary>
        [JsonProperty("ContactLastName")]
        public string ContactLastName{ get; set; }

        /// <summary>
        /// Email of the contact
        /// </summary>
        [JsonProperty("ContactEmail")]
        public string ContactEmail{ get; set; }

        /// <summary>
        /// Mobile number of the contact
        /// </summary>
        [JsonProperty("ContactNumber")]
        public string ContactNumber{ get; set; }

        /// <summary>
        /// Position of the contact
        /// </summary>
        [JsonProperty("ContactPosition")]
        public string ContactPosition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
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
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "AdminFirstName", this.AdminFirstName);
            this.SetParamSimple(map, prefix + "AdminLastName", this.AdminLastName);
            this.SetParamSimple(map, prefix + "AdminPhoneNum", this.AdminPhoneNum);
            this.SetParamSimple(map, prefix + "AdminEmail", this.AdminEmail);
            this.SetParamSimple(map, prefix + "AdminPosition", this.AdminPosition);
            this.SetParamSimple(map, prefix + "ContactFirstName", this.ContactFirstName);
            this.SetParamSimple(map, prefix + "ContactLastName", this.ContactLastName);
            this.SetParamSimple(map, prefix + "ContactEmail", this.ContactEmail);
            this.SetParamSimple(map, prefix + "ContactNumber", this.ContactNumber);
            this.SetParamSimple(map, prefix + "ContactPosition", this.ContactPosition);
        }
    }
}

