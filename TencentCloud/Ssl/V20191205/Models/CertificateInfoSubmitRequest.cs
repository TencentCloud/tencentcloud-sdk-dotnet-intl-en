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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CertificateInfoSubmitRequest : AbstractModel
    {
        
        /// <summary>
        /// Paid SSL certificate ID of materials to be submitted.	
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// This field is required. CSR generation method, value is:
        /// -online: Tencent Cloud submits the filled parameter information to generate a CSR and private key, and by Tencent Cloud for encrypted storage.
        /// -parse: Generate CSR and private key manually, and apply for a certificate by uploading CSR.
        /// </summary>
        [JsonProperty("GenCsrType")]
        public string GenCsrType{ get; set; }

        /// <summary>
        /// Common name for certificate binding. If an uploaded CSR is used, that domain name must match the common name resolved by the CSR.
        /// </summary>
        [JsonProperty("CertCommonName")]
        public string CertCommonName{ get; set; }

        /// <summary>
        /// Organization information type. Valid values:
        /// 1 (Personal): Only DV-type certificates can be set to 1. For personal-type certificates, organization information fields (Org, Admin, Tech) can be omitted.
        /// 2 (Company): All types of certificates can be set to 2. Pass organization information fields as needed.
        /// </summary>
        [JsonProperty("CompanyType")]
        public ulong? CompanyType{ get; set; }

        /// <summary>
        /// Company ID can be viewed in the [Tencent Cloud Console](https://console.cloud.tencent.com/ssl/info). If no company information is found, set this parameter to 0. If company information matching the current order exists, you can view the company ID via [DescribeCompanies](https://www.tencentcloud.com/document/product/400/90375?from_cn_redirect=1). If a company ID is provided, parameters starting with "Org" can be omitted.
        /// 
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// Company document type. Valid values:
        /// TYDMZ (unified social credit code): This field is required only for CFCA certificates, not required for other types.
        /// OTHERS
        /// </summary>
        [JsonProperty("OrgIdType")]
        public string OrgIdType{ get; set; }

        /// <summary>
        /// Company identification number, value ranges from...to...
        /// TYDMZ (unified social credit code): 11532xxxxxxxx24820
        /// </summary>
        [JsonProperty("OrgIdNumber")]
        public string OrgIdNumber{ get; set; }

        /// <summary>
        /// Document type of the manager. Valid values:
        /// SFZ (ID card): This field is required only for CFCA certs, not required for other types.
        /// HZ (passport): This field is required only for CFCA certs and not required for other types.
        /// </summary>
        [JsonProperty("AdminIdType")]
        public string AdminIdType{ get; set; }

        /// <summary>
        /// ID number of the manager. This field is required only for CFCA certificates, not required for other types. Value ranges from...to...
        /// ID card: 110000xxxxxxxx1242
        /// HZ (Passport): EFxxxxxxx
        /// </summary>
        [JsonProperty("AdminIdNumber")]
        public string AdminIdNumber{ get; set; }

        /// <summary>
        /// Contact person document type. Valid values:
        /// SFZ (ID card): This field is required only for CFCA certs, not required for other types.
        /// HZ (passport): This field is required only for CFCA certs and not required for other types.
        /// </summary>
        [JsonProperty("TechIdType")]
        public string TechIdType{ get; set; }

        /// <summary>
        /// ID number of the contact person. This field is required only for CFCA certs and not required for other types. Value ranges from...to...
        /// ID card: 110000xxxxxxxx1242
        /// HZ (Passport): EFxxxxxxx
        /// </summary>
        [JsonProperty("TechIdNumber")]
        public string TechIdNumber{ get; set; }

        /// <summary>
        /// Uploaded CSR content.
        /// If GenCsrType is parse, this field is required.
        /// </summary>
        [JsonProperty("Csr")]
        public string Csr{ get; set; }

        /// <summary>
        /// Other domains bound to the certificate. No need to provide for single domain or wildcard certificates. Required for multi-domain names and multiple wildcard certificates.
        /// </summary>
        [JsonProperty("DnsNames")]
        public string[] DnsNames{ get; set; }

        /// <summary>
        /// Private key password. Currently used only when generating certs in jks or pfx format; private key certificates in other formats are unencrypted.	
        /// </summary>
        [JsonProperty("KeyPass")]
        public string KeyPass{ get; set; }

        /// <summary>
        /// Company name. This field is required if CompanyId or ManagerId is not provided.
        /// </summary>
        [JsonProperty("OrgOrganization")]
        public string OrgOrganization{ get; set; }

        /// <summary>
        /// Department name. If not passing CompanyId or ManagerId, this field is required.
        /// </summary>
        [JsonProperty("OrgDivision")]
        public string OrgDivision{ get; set; }

        /// <summary>
        /// Company detailed address. If not pass CompanyId or ManagerId, this field is required.
        /// </summary>
        [JsonProperty("OrgAddress")]
        public string OrgAddress{ get; set; }

        /// <summary>
        /// Country/region name, for example China: CN. If not passing CompanyId or ManagerId, this field is required.
        /// </summary>
        [JsonProperty("OrgCountry")]
        public string OrgCountry{ get; set; }

        /// <summary>
        /// Located city. If not pass CompanyId or ManagerId, this field is required.
        /// </summary>
        [JsonProperty("OrgCity")]
        public string OrgCity{ get; set; }

        /// <summary>
        /// Province where the company is located. If not passing CompanyId or ManagerId, this field is required.
        /// </summary>
        [JsonProperty("OrgRegion")]
        public string OrgRegion{ get; set; }

        /// <summary>
        /// Area code of the company. If not passing CompanyId or ManagerId, this field is required.
        /// For example: 021. Pass 86 as the mobile number.
        /// </summary>
        [JsonProperty("OrgPhoneArea")]
        public string OrgPhoneArea{ get; set; }

        /// <summary>
        /// Company number. If CompanyId or ManagerId is not provided, this field is required.
        /// </summary>
        [JsonProperty("OrgPhoneNumber")]
        public string OrgPhoneNumber{ get; set; }

        /// <summary>
        /// Domain validation method of the certificate
        /// DNS: Manually add domain DNS validation. The user needs to manually add the verification value at the DNS service provider.
        /// FILE: Manual addition of domain name FILE verification. Users are advised to manually add a specified path FILE in the root directory of the domain site to perform FILE verification. Either http or https passing is sufficient. The domain site must be accessible by overseas certificate authorities. The specific access allowlist is: 64.78.193.238, 216.168.247.9, 216.168.249.9, 54.189.196.217.
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// Manage name. If not passing ManagerId, this field is required.
        /// </summary>
        [JsonProperty("AdminFirstName")]
        public string AdminFirstName{ get; set; }

        /// <summary>
        /// Manager name. If not, this field is required when ManagerId is not passed.
        /// </summary>
        [JsonProperty("AdminLastName")]
        public string AdminLastName{ get; set; }

        /// <summary>
        /// Manager mobile number. If not passing ManagerId, this field is required.
        /// </summary>
        [JsonProperty("AdminPhone")]
        public string AdminPhone{ get; set; }

        /// <summary>
        /// Manager email address. If not passing ManagerId, this field is required.
        /// </summary>
        [JsonProperty("AdminEmail")]
        public string AdminEmail{ get; set; }

        /// <summary>
        /// Manager position. If not passing ManagerId, this field is required.
        /// </summary>
        [JsonProperty("AdminTitle")]
        public string AdminTitle{ get; set; }

        /// <summary>
        /// Contact name. If not passing ManagerId, this field is required.
        /// </summary>
        [JsonProperty("TechFirstName")]
        public string TechFirstName{ get; set; }

        /// <summary>
        /// Last name of the contact. If not, this field is required when ManagerId is not passed.
        /// </summary>
        [JsonProperty("TechLastName")]
        public string TechLastName{ get; set; }

        /// <summary>
        /// Contact email address. This field is required when CompanyType is 1.
        /// </summary>
        [JsonProperty("ContactEmail")]
        public string ContactEmail{ get; set; }

        /// <summary>
        /// Whether to enable auto-renewal: 0, not enabled; 1, enabled; defaults to 0.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Key pair parameters. RSA supports 2048 and 4096. ECC is only supported for prime256v1. This parameter is required when the CSR generation method is online.
        /// </summary>
        [JsonProperty("CsrKeyParameter")]
        public string CsrKeyParameter{ get; set; }

        /// <summary>
        /// Encryption algorithm, value is ECC or RSA, defaults to RSA. This parameter is required when CSR generation method is online.
        /// </summary>
        [JsonProperty("CsrEncryptAlgo")]
        public string CsrEncryptAlgo{ get; set; }

        /// <summary>
        /// Manager ID can be viewed in the [Tencent Cloud Console](https://console.cloud.tencent.com/ssl/info). If no administrator information is found, pass 0 for this parameter. If administrator information exists that meets the current order, the manager ID can be selected based on [DescribeManagers](https://www.tencentcloud.com/document/product/400/52672?from_cn_redirect=1). If the manager ID is passed, parameters beginning with Org, Admin, or Tech can be omitted. The manager ID includes company information.
        /// </summary>
        [JsonProperty("ManagerId")]
        public string ManagerId{ get; set; }

        /// <summary>
        /// Contact phone. If not passing ManagerId, this field is required.
        /// </summary>
        [JsonProperty("TechPhone")]
        public string TechPhone{ get; set; }

        /// <summary>
        /// contact email
        /// </summary>
        [JsonProperty("TechEmail")]
        public string TechEmail{ get; set; }

        /// <summary>
        /// Contact person position. If not passing ManagerId, this field is required.
        /// </summary>
        [JsonProperty("TechTitle")]
        public string TechTitle{ get; set; }

        /// <summary>
        /// Certificate type
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Valid only for Dnspod series certs. ca organization kind can be sectigo and digicert.
        /// </summary>
        [JsonProperty("CaType")]
        public string CaType{ get; set; }

        /// <summary>
        /// signature algorithm
        /// </summary>
        [JsonProperty("SignAlgo")]
        public string SignAlgo{ get; set; }

        /// <summary>
        /// Whether to use intersect root certificate
        /// </summary>
        [JsonProperty("UseCrossSignRoot")]
        public bool? UseCrossSignRoot{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "GenCsrType", this.GenCsrType);
            this.SetParamSimple(map, prefix + "CertCommonName", this.CertCommonName);
            this.SetParamSimple(map, prefix + "CompanyType", this.CompanyType);
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "OrgIdType", this.OrgIdType);
            this.SetParamSimple(map, prefix + "OrgIdNumber", this.OrgIdNumber);
            this.SetParamSimple(map, prefix + "AdminIdType", this.AdminIdType);
            this.SetParamSimple(map, prefix + "AdminIdNumber", this.AdminIdNumber);
            this.SetParamSimple(map, prefix + "TechIdType", this.TechIdType);
            this.SetParamSimple(map, prefix + "TechIdNumber", this.TechIdNumber);
            this.SetParamSimple(map, prefix + "Csr", this.Csr);
            this.SetParamArraySimple(map, prefix + "DnsNames.", this.DnsNames);
            this.SetParamSimple(map, prefix + "KeyPass", this.KeyPass);
            this.SetParamSimple(map, prefix + "OrgOrganization", this.OrgOrganization);
            this.SetParamSimple(map, prefix + "OrgDivision", this.OrgDivision);
            this.SetParamSimple(map, prefix + "OrgAddress", this.OrgAddress);
            this.SetParamSimple(map, prefix + "OrgCountry", this.OrgCountry);
            this.SetParamSimple(map, prefix + "OrgCity", this.OrgCity);
            this.SetParamSimple(map, prefix + "OrgRegion", this.OrgRegion);
            this.SetParamSimple(map, prefix + "OrgPhoneArea", this.OrgPhoneArea);
            this.SetParamSimple(map, prefix + "OrgPhoneNumber", this.OrgPhoneNumber);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "AdminFirstName", this.AdminFirstName);
            this.SetParamSimple(map, prefix + "AdminLastName", this.AdminLastName);
            this.SetParamSimple(map, prefix + "AdminPhone", this.AdminPhone);
            this.SetParamSimple(map, prefix + "AdminEmail", this.AdminEmail);
            this.SetParamSimple(map, prefix + "AdminTitle", this.AdminTitle);
            this.SetParamSimple(map, prefix + "TechFirstName", this.TechFirstName);
            this.SetParamSimple(map, prefix + "TechLastName", this.TechLastName);
            this.SetParamSimple(map, prefix + "ContactEmail", this.ContactEmail);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "CsrKeyParameter", this.CsrKeyParameter);
            this.SetParamSimple(map, prefix + "CsrEncryptAlgo", this.CsrEncryptAlgo);
            this.SetParamSimple(map, prefix + "ManagerId", this.ManagerId);
            this.SetParamSimple(map, prefix + "TechPhone", this.TechPhone);
            this.SetParamSimple(map, prefix + "TechEmail", this.TechEmail);
            this.SetParamSimple(map, prefix + "TechTitle", this.TechTitle);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CaType", this.CaType);
            this.SetParamSimple(map, prefix + "SignAlgo", this.SignAlgo);
            this.SetParamSimple(map, prefix + "UseCrossSignRoot", this.UseCrossSignRoot);
        }
    }
}

