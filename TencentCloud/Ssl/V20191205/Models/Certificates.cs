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

    public class Certificates : AbstractModel
    {
        
        /// <summary>
        /// User UIN
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Project ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Certificate source
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// The certificate plan type. Valid values:
        /// null: Certificates uploaded by users (no plan type)
        /// `1`: GeoTrust DV SSL CA - G3; `2`: TrustAsia TLS RSA CA; `3`: SecureSite EV Pro; `4`: SecureSite EV; `5`: SecureSite OV Pro; `6`: SecureSite OV; `7`: SecureSite OV wildcard; `8`: GeoTrust EV; `9`: GeoTrust OV; `10`: GeoTrust OV wildcard; `11`: TrustAsia DV multi-domain; `12`: TrustAsia DV wildcard; `13`: TrustAsia OV wildcard D3; `14`: TrustAsia OV D3; `15`: TrustAsia OV multi-domain D3; `16`: TrustAsia EV D3; `17`: TrustAsia EV multi-domain D3; `18`: GlobalSign OV; `19`: GlobalSign OV wildcard; `20`: GlobalSign EV; `21`: TrustAsia OV wildcard multi-domain D3; `22`: GlobalSign OV multi-domain; `23`: GlobalSign OV wildcard multi-domain; `24`: GlobalSign EV multi-domain
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Certificate type. `CA`: client certificate; `SVR`: server certificate
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateType")]
        public string CertificateType{ get; set; }

        /// <summary>
        /// Issuer
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductZhName")]
        public string ProductZhName{ get; set; }

        /// <summary>
        /// Primary domain name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Alias
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// Status. `0`: Reviewing; `1`: Approved; `2`: Unapproved; `3`: Expired; `4`: DNS record added for domain names of the DNS_AUTO verification type; `5`: Enterprise-grade certificate, pending submission; `6`: Canceling order; `7`: Canceled; `8`: Information submitted, pending confirmation letter upload; `9`: Revoking certificate; `10`: Revoked; `11`: Reissuing; `12`: Pending revocation confirmation letter upload; `13`: Pending information submission for the free certificate; `14`: Refunded.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Extended information of the certificate
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateExtra")]
        public CertificateExtra CertificateExtra{ get; set; }

        /// <summary>
        /// Vulnerability scanning status. `INACTIVE`: not activated; `ACTIVE`: activated
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulnerabilityStatus")]
        public string VulnerabilityStatus{ get; set; }

        /// <summary>
        /// Status information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusMsg")]
        public string StatusMsg{ get; set; }

        /// <summary>
        /// Validation type. `DNS_AUTO`: automatic DNS validation; `DNS`: manual DNS validation; `FILE`: file validation; `EMAIL`: email validation
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// Time when the certificate takes effect
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertBeginTime")]
        public string CertBeginTime{ get; set; }

        /// <summary>
        /// Time when the certificate expires
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertEndTime")]
        public string CertEndTime{ get; set; }

        /// <summary>
        /// Validity period of the certificate, in months
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ValidityPeriod")]
        public string ValidityPeriod{ get; set; }

        /// <summary>
        /// Creation time
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// Certificate ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// Domain names associated with the certificate (including the primary domain name)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubjectAltName")]
        public string[] SubjectAltName{ get; set; }

        /// <summary>
        /// Certificate type name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageTypeName")]
        public string PackageTypeName{ get; set; }

        /// <summary>
        /// Status description
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusName")]
        public string StatusName{ get; set; }

        /// <summary>
        /// Whether the customer is a VIP customer
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsVip")]
        public bool? IsVip{ get; set; }

        /// <summary>
        /// Whether the certificate is a DV certificate
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsDv")]
        public bool? IsDv{ get; set; }

        /// <summary>
        /// Whether the certificate is a wildcard certificate
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsWildcard")]
        public bool? IsWildcard{ get; set; }

        /// <summary>
        /// Whether the vulnerability scanning feature is enabled
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsVulnerability")]
        public bool? IsVulnerability{ get; set; }

        /// <summary>
        /// Whether it can be renewed 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RenewAble")]
        public bool? RenewAble{ get; set; }

        /// <summary>
        /// Project information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectInfo")]
        public ProjectInfo ProjectInfo{ get; set; }

        /// <summary>
        /// Associated Tencent Cloud services. Currently, this parameter is unavailable.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BoundResource")]
        public string[] BoundResource{ get; set; }

        /// <summary>
        /// Whether the certificate can be deployed
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Deployable")]
        public bool? Deployable{ get; set; }

        /// <summary>
        /// List of tags
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// Whether the expiration notification was ignored
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsIgnore")]
        public bool? IsIgnore{ get; set; }

        /// <summary>
        /// Whether the certificate is a Chinese SM certificate
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsSM")]
        public bool? IsSM{ get; set; }

        /// <summary>
        /// Certificate algorithm
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EncryptAlgorithm")]
        public string EncryptAlgorithm{ get; set; }

        /// <summary>
        /// Encryption algorithm of the uploaded CA certificate
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CAEncryptAlgorithms")]
        public string[] CAEncryptAlgorithms{ get; set; }

        /// <summary>
        /// Expiration time of the uploaded CA certificate
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CAEndTimes")]
        public string[] CAEndTimes{ get; set; }

        /// <summary>
        /// Generic name of the uploaded CA certificate
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CACommonNames")]
        public string[] CACommonNames{ get; set; }

        /// <summary>
        /// Prereview information of the certificate
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PreAuditInfo")]
        public PreAuditInfo PreAuditInfo{ get; set; }

        /// <summary>
        /// Whether auto-renewal is enabled.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// The hosting status. Valid values: `0` (hosting), `5` (replacing resources), `10` (hosting completed), and `-1` (not hosted). 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostingStatus")]
        public long? HostingStatus{ get; set; }

        /// <summary>
        /// The hosting completion time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostingCompleteTime")]
        public string HostingCompleteTime{ get; set; }

        /// <summary>
        /// The hosted new certificate ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostingRenewCertId")]
        public string HostingRenewCertId{ get; set; }

        /// <summary>
        /// Existing renewed certificate ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("HasRenewOrder")]
        public string HasRenewOrder{ get; set; }

        /// <summary>
        /// Whether the original certificate is deleted when a certificate is reissued.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ReplaceOriCertIsDelete")]
        public bool? ReplaceOriCertIsDelete{ get; set; }

        /// <summary>
        /// Whether the certificate is expiring soon. A certificate is considered to be expiring soon when there are 30 days or less left.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IsExpiring")]
        public bool? IsExpiring{ get; set; }

        /// <summary>
        /// Validation expiration time for the addition of the DV certificate
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DVAuthDeadline")]
        public string DVAuthDeadline{ get; set; }

        /// <summary>
        /// Domain name validation pass time
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ValidationPassedTime")]
        public string ValidationPassedTime{ get; set; }

        /// <summary>
        /// Multiple domain names with which the certificate is associated
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CertSANs")]
        public string[] CertSANs{ get; set; }

        /// <summary>
        /// Domain name validation rejection information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AwaitingValidationMsg")]
        public string AwaitingValidationMsg{ get; set; }

        /// <summary>
        /// Whether downloading is allowed
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AllowDownload")]
        public bool? AllowDownload{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsDNSPODResolve")]
        public bool? IsDNSPODResolve{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsPackage")]
        public bool? IsPackage{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("KeyPasswordCustomFlag")]
        public bool? KeyPasswordCustomFlag{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SupportDownloadType")]
        public SupportDownloadType SupportDownloadType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "CertificateType", this.CertificateType);
            this.SetParamSimple(map, prefix + "ProductZhName", this.ProductZhName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "CertificateExtra.", this.CertificateExtra);
            this.SetParamSimple(map, prefix + "VulnerabilityStatus", this.VulnerabilityStatus);
            this.SetParamSimple(map, prefix + "StatusMsg", this.StatusMsg);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "CertBeginTime", this.CertBeginTime);
            this.SetParamSimple(map, prefix + "CertEndTime", this.CertEndTime);
            this.SetParamSimple(map, prefix + "ValidityPeriod", this.ValidityPeriod);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamArraySimple(map, prefix + "SubjectAltName.", this.SubjectAltName);
            this.SetParamSimple(map, prefix + "PackageTypeName", this.PackageTypeName);
            this.SetParamSimple(map, prefix + "StatusName", this.StatusName);
            this.SetParamSimple(map, prefix + "IsVip", this.IsVip);
            this.SetParamSimple(map, prefix + "IsDv", this.IsDv);
            this.SetParamSimple(map, prefix + "IsWildcard", this.IsWildcard);
            this.SetParamSimple(map, prefix + "IsVulnerability", this.IsVulnerability);
            this.SetParamSimple(map, prefix + "RenewAble", this.RenewAble);
            this.SetParamObj(map, prefix + "ProjectInfo.", this.ProjectInfo);
            this.SetParamArraySimple(map, prefix + "BoundResource.", this.BoundResource);
            this.SetParamSimple(map, prefix + "Deployable", this.Deployable);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "IsIgnore", this.IsIgnore);
            this.SetParamSimple(map, prefix + "IsSM", this.IsSM);
            this.SetParamSimple(map, prefix + "EncryptAlgorithm", this.EncryptAlgorithm);
            this.SetParamArraySimple(map, prefix + "CAEncryptAlgorithms.", this.CAEncryptAlgorithms);
            this.SetParamArraySimple(map, prefix + "CAEndTimes.", this.CAEndTimes);
            this.SetParamArraySimple(map, prefix + "CACommonNames.", this.CACommonNames);
            this.SetParamObj(map, prefix + "PreAuditInfo.", this.PreAuditInfo);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "HostingStatus", this.HostingStatus);
            this.SetParamSimple(map, prefix + "HostingCompleteTime", this.HostingCompleteTime);
            this.SetParamSimple(map, prefix + "HostingRenewCertId", this.HostingRenewCertId);
            this.SetParamSimple(map, prefix + "HasRenewOrder", this.HasRenewOrder);
            this.SetParamSimple(map, prefix + "ReplaceOriCertIsDelete", this.ReplaceOriCertIsDelete);
            this.SetParamSimple(map, prefix + "IsExpiring", this.IsExpiring);
            this.SetParamSimple(map, prefix + "DVAuthDeadline", this.DVAuthDeadline);
            this.SetParamSimple(map, prefix + "ValidationPassedTime", this.ValidationPassedTime);
            this.SetParamArraySimple(map, prefix + "CertSANs.", this.CertSANs);
            this.SetParamSimple(map, prefix + "AwaitingValidationMsg", this.AwaitingValidationMsg);
            this.SetParamSimple(map, prefix + "AllowDownload", this.AllowDownload);
            this.SetParamSimple(map, prefix + "IsDNSPODResolve", this.IsDNSPODResolve);
            this.SetParamSimple(map, prefix + "IsPackage", this.IsPackage);
            this.SetParamSimple(map, prefix + "KeyPasswordCustomFlag", this.KeyPasswordCustomFlag);
            this.SetParamObj(map, prefix + "SupportDownloadType.", this.SupportDownloadType);
        }
    }
}

