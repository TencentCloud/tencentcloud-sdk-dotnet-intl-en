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
        /// User uin.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Project id.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Certificate source:.
        /// trustasia.
        /// upload.
        /// wosign.
        /// sheca.
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// Certificate package type:.
        /// Null: user uploads a certificate (without package type),.
        /// 2: trustasia tls rsa ca,. 
        /// 3: securesite enhanced enterprise edition (ev pro),. 
        /// 4: securesite enhanced (ev). 
        /// 5: securesite enterprise professional edition (ov pro).
        /// 6: securesite enterprise (ov). 
        /// 7: securesite enterprise (ov) wildcard. 
        /// 8: geotrust enhanced (ev). 
        /// 9: geotrust enterprise (ov) cert. 
        /// 10: geotrust enterprise (ov) wildcard cert. 
        /// 11: trustasia domain name-based multiple domain names ssl certificate. 
        /// 12: trustasia domain name-based (dv) wildcard cert. 
        /// 13: trustasia enterprise wildcard (ov) ssl certificate (d3). 
        /// 14: trustasia enterprise (ov) ssl certificate (d3). 
        /// 15: trustasia enterprise multiple domain names (ov) ssl certificate (d3). 
        /// 16: trustasia enhanced (ev) ssl certificate (d3). 
        /// 17: trustasia enhanced multiple domain names (ev) ssl certificate (d3). 
        /// 18: globalsign enterprise (ov) ssl certificate. 
        /// 19: globalsign enterprise wildcard (ov) ssl certificate. 
        /// 20: globalsign enhanced (ev) ssl certificate. 
        /// 21: trustasia enterprise wildcard multiple domain names (ov) ssl certificate (d3). 
        /// 22: globalsign enterprise multiple domain names (ov) ssl certificate. 
        /// 23: globalsign enterprise wildcard multiple domain names (ov) ssl certificate.
        /// 24: globalsign enhanced multiple domain name (ev) ssl certificate.
        /// 25: wotrus domain name cert.
        /// 26: wotrus domain name multiple domain name cert.
        /// 27: wotrus domain name wildcard cert.
        /// 28: wotrus enterprise cert.
        /// 29: wotrus enterprise multi - domain name certificate.
        /// 30: wotrus enterprise wildcard certificate.
        /// 31: wotrus enhanced certificate.
        /// 32: wotrus enhanced multi - domain name certificate.
        /// 33: wotrus - national cryptography domain - type certificate.
        /// 34: wotrus-national cryptography domain certificate (multiple domain names).
        /// 35: wotrus-national cryptography domain certificate (wildcard).
        /// 37: wotrus-national cryptography enterprise certificate.
        /// 38: wotrus-national cryptography enterprise certificate (multiple domain names).
        /// 39: wotrus-national cryptography enterprise certificate (wildcard).
        /// 40: wotrus - enhanced national cryptography certificate.
        /// 41: wotrus - enhanced national cryptography certificate (multiple domain names).
        /// 42: trustasia - domain name type certificate (wildcard multiple domain names).
        /// 43: DNSPod - enterprise (ov) ssl certificate.
        /// 44: DNSPod - enterprise (ov) wildcard ssl certificate.
        /// 45: DNSPod - enterprise (ov) multiple domain names ssl certificate.
        /// 46: DNSPod - enhanced (ev) ssl certificate.
        /// 47: DNSPod - enhanced (ev) multiple domain names ssl certificate.
        /// 48: DNSPod - domain name-based (dv) ssl certificate.
        /// 49: DNSPod - domain name-based (dv) wildcard ssl certificate.
        /// 50: DNSPod - domain name-based (dv) multiple domain names ssl certificate.
        /// 51: DNSPod (national cryptography) - enterprise (ov) ssl certificate.
        /// 52: DNSPod (national cryptography) - enterprise (ov) wildcard ssl certificate.
        /// 53: DNSPod (national cryptography) - enterprise (ov) multiple domain names ssl certificate.
        /// 54: DNSPod (national cryptography) - domain name-based (dv) ssl certificate.
        /// 55: DNSPod (national cryptography) - domain name-based (dv) wildcard ssl certificate.
        /// 56: DNSPod (national cryptography) - domain name-based (dv) multiple domain names ssl certificate.
        /// 57: securesite enterprise professional edition multiple domain names (ov pro).
        /// 58: securesite enterprise multiple domain names (ov).
        /// 59: securesite enhanced professional edition multiple domain names (ev pro).
        /// 60: securesite enhanced multiple domain names (ev).
        /// 61: geotrust enhanced multiple domain names (ev).
        /// 75: securesite enterprise (ov).
        /// 76: securesite enterprise (ov) wildcard.
        /// 77: securesite enhanced (ev).
        /// 78: geotrust enterprise (ov).
        /// 79: geotrust enterprise wildcard (ov).
        /// 80: geotrust enhanced (ev).
        /// 81: globalsign enterprise (ov) ssl certificate.
        /// 82: globalsign enterprise wildcard (ov) ssl certificate.
        /// 83: trustasia c1 dv free.
        /// 85: globalsign enhanced (ev) ssl certificate.
        /// 88: globalsign enterprise wildcard multiple domain names (ov) ssl certificate.
        /// 89: globalsign enterprise multiple domain names (ov) ssl certificate.
        /// 90: globalsign enhanced multiple domain names (ev) ssl certificate.
        /// 91: geotrust enhanced multiple domain names (ev).
        /// 92: securesite enterprise pro multiple domain names (ov pro).
        /// 93: securesite enterprise multiple domain names (ov).
        /// 94: securesite enhanced pro multiple domain names (ev pro).
        /// 95: securesite enhanced multiple domain names (ev).
        /// 96: securesite ev pro.
        /// 97: securesite enterprise professional edition (ov pro).
        /// 98: cfca enterprise (ov) ssl certificate.
        /// 99: cfca enterprise ov ssl certificate for multiple domain names.
        /// 100: cfca ov wildcard ssl certificate.
        /// 101: cfca enhanced (ev) ssl certificate.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Certificate type. ca = client certificate; svr = server certificate.
        /// </summary>
        [JsonProperty("CertificateType")]
        public string CertificateType{ get; set; }

        /// <summary>
        /// Certificate product name.
        /// </summary>
        [JsonProperty("ProductZhName")]
        public string ProductZhName{ get; set; }

        /// <summary>
        /// Primary domain name.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Remark name.
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// Certificate status: 0 = under review, 1 = approved, 2 = review failed, 3 = expired, 4 = dns record added automatically, 5 = enterprise certificate, pending documentation submission, 6 = order cancellation in progress, 7 = canceled, 8 = documents submitted, pending upload of confirmation letter, 9 = certificate revocation in progress, 10 = revoked, 11 = reissue in progress, 12 = pending upload of revocation confirmation letter, 13 = free certificate pending documentation submission, 14 = certificate refunded, 15 = certificate migration in progress.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Certificate extended information.
        /// </summary>
        [JsonProperty("CertificateExtra")]
        public CertificateExtra CertificateExtra{ get; set; }

        /// <summary>
        /// Vulnerability scanning status: INACTIVE = not enabled, ACTIVE = enabled.
        /// </summary>
        [JsonProperty("VulnerabilityStatus")]
        public string VulnerabilityStatus{ get; set; }

        /// <summary>
        /// Status information.
        /// </summary>
        [JsonProperty("StatusMsg")]
        public string StatusMsg{ get; set; }

        /// <summary>
        /// Validation type: DNS_AUTO = automatic dns validation, DNS = manual dns validation, FILE = file verification, DNS_PROXY = dns proxy validation, FILE_PROXY = file proxy verification.
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// Certificate validation time.
        /// </summary>
        [JsonProperty("CertBeginTime")]
        public string CertBeginTime{ get; set; }

        /// <summary>
        /// Certificate expiration time.
        /// </summary>
        [JsonProperty("CertEndTime")]
        public string CertEndTime{ get; set; }

        /// <summary>
        /// Certificate validity period (month).
        /// </summary>
        [JsonProperty("ValidityPeriod")]
        public string ValidityPeriod{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// Certificate id.
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// Multiple domain names contained in the certificate (including the primary domain name).
        /// </summary>
        [JsonProperty("SubjectAltName")]
        public string[] SubjectAltName{ get; set; }

        /// <summary>
        /// Certificate type name.
        /// </summary>
        [JsonProperty("PackageTypeName")]
        public string PackageTypeName{ get; set; }

        /// <summary>
        /// Status name.
        /// </summary>
        [JsonProperty("StatusName")]
        public string StatusName{ get; set; }

        /// <summary>
        /// Specifies whether the customer is a vip customer. true indicates yes and false indicates no.
        /// </summary>
        [JsonProperty("IsVip")]
        public bool? IsVip{ get; set; }

        /// <summary>
        /// Specifies whether it is a dv version certificate. true indicates yes and false indicates no.
        /// </summary>
        [JsonProperty("IsDv")]
        public bool? IsDv{ get; set; }

        /// <summary>
        /// Specifies whether it is a wildcard domain name certificate. true indicates yes and false indicates no.
        /// </summary>
        [JsonProperty("IsWildcard")]
        public bool? IsWildcard{ get; set; }

        /// <summary>
        /// Whether the vulnerability scanning feature is enabled.
        /// </summary>
        [JsonProperty("IsVulnerability")]
        public bool? IsVulnerability{ get; set; }

        /// <summary>
        /// Whether it is renewable.
        /// </summary>
        [JsonProperty("RenewAble")]
        public bool? RenewAble{ get; set; }

        /// <summary>
        /// Project information.
        /// </summary>
        [JsonProperty("ProjectInfo")]
        public ProjectInfo ProjectInfo{ get; set; }

        /// <summary>
        /// Associated cloud resources are temporarily unavailable.
        /// </summary>
        [JsonProperty("BoundResource")]
        public string[] BoundResource{ get; set; }

        /// <summary>
        /// Whether it can be deployed.
        /// </summary>
        [JsonProperty("Deployable")]
        public bool? Deployable{ get; set; }

        /// <summary>
        /// Tag list.
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// Whether expiration notice has been ignored.
        /// </summary>
        [JsonProperty("IsIgnore")]
        public bool? IsIgnore{ get; set; }

        /// <summary>
        /// Whether it is a China SM certificate.
        /// </summary>
        [JsonProperty("IsSM")]
        public bool? IsSM{ get; set; }

        /// <summary>
        /// Certificate algorithm.
        /// </summary>
        [JsonProperty("EncryptAlgorithm")]
        public string EncryptAlgorithm{ get; set; }

        /// <summary>
        /// Encryption algorithm for upload ca certificate.
        /// </summary>
        [JsonProperty("CAEncryptAlgorithms")]
        public string[] CAEncryptAlgorithms{ get; set; }

        /// <summary>
        /// Expiration time for upload ca certificate.
        /// </summary>
        [JsonProperty("CAEndTimes")]
        public string[] CAEndTimes{ get; set; }

        /// <summary>
        /// Common name of the upload ca certificate.
        /// </summary>
        [JsonProperty("CACommonNames")]
        public string[] CACommonNames{ get; set; }

        /// <summary>
        /// Certificate prereview information.
        /// </summary>
        [JsonProperty("PreAuditInfo")]
        public PreAuditInfo PreAuditInfo{ get; set; }

        /// <summary>
        /// Whether to auto-renew.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Hosting status: 0, hosting; 5, resource replacement; 10, hosting completed; -1, not hosted. 
        /// </summary>
        [JsonProperty("HostingStatus")]
        public long? HostingStatus{ get; set; }

        /// <summary>
        /// Hosting completion time.
        /// </summary>
        [JsonProperty("HostingCompleteTime")]
        public string HostingCompleteTime{ get; set; }

        /// <summary>
        /// Manage the new certificate id.
        /// </summary>
        [JsonProperty("HostingRenewCertId")]
        public string HostingRenewCertId{ get; set; }

        /// <summary>
        /// Existing renewal certificate id.
        /// </summary>
        [JsonProperty("HasRenewOrder")]
        public string HasRenewOrder{ get; set; }

        /// <summary>
        /// Indicates whether the original certificate is deleted during reissue.
        /// </summary>
        [JsonProperty("ReplaceOriCertIsDelete")]
        public bool? ReplaceOriCertIsDelete{ get; set; }

        /// <summary>
        /// Indicates whether it is about to expire. a certificate is about to expire if it will expire within 30 days.
        /// </summary>
        [JsonProperty("IsExpiring")]
        public bool? IsExpiring{ get; set; }

        /// <summary>
        /// Add validation expiration date for DV certificate
        /// </summary>
        [JsonProperty("DVAuthDeadline")]
        public string DVAuthDeadline{ get; set; }

        /// <summary>
        /// Domain verification passed time.
        /// </summary>
        [JsonProperty("ValidationPassedTime")]
        public string ValidationPassedTime{ get; set; }

        /// <summary>
        /// Multiple domain names associated with the certificate.
        /// </summary>
        [JsonProperty("CertSANs")]
        public string[] CertSANs{ get; set; }

        /// <summary>
        /// Domain verification rejection information.
        /// </summary>
        [JsonProperty("AwaitingValidationMsg")]
        public string AwaitingValidationMsg{ get; set; }

        /// <summary>
        /// Whether to allow downloading.
        /// </summary>
        [JsonProperty("AllowDownload")]
        public bool? AllowDownload{ get; set; }

        /// <summary>
        /// Whether all certificate domain names are managed and resolved by dnspod.
        /// </summary>
        [JsonProperty("IsDNSPODResolve")]
        public bool? IsDNSPODResolve{ get; set; }

        /// <summary>
        /// Whether the certificate is purchased with benefit points.
        /// </summary>
        [JsonProperty("IsPackage")]
        public bool? IsPackage{ get; set; }

        /// <summary>
        /// Whether there is a private key password.
        /// </summary>
        [JsonProperty("KeyPasswordCustomFlag")]
        public bool? KeyPasswordCustomFlag{ get; set; }

        /// <summary>
        /// Types of web servers supported for download: nginx, apache, iis, tomcat, jks, root, other.
        /// </summary>
        [JsonProperty("SupportDownloadType")]
        public SupportDownloadType SupportDownloadType{ get; set; }

        /// <summary>
        /// Certificate revocation completion time.
        /// </summary>
        [JsonProperty("CertRevokedTime")]
        public string CertRevokedTime{ get; set; }

        /// <summary>
        /// Hosted resource type list.
        /// </summary>
        [JsonProperty("HostingResourceTypes")]
        public string[] HostingResourceTypes{ get; set; }

        /// <summary>
        /// Managed configuration information.
        /// </summary>
        [JsonProperty("HostingConfig")]
        public HostingConfig HostingConfig{ get; set; }


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
            this.SetParamSimple(map, prefix + "CertRevokedTime", this.CertRevokedTime);
            this.SetParamArraySimple(map, prefix + "HostingResourceTypes.", this.HostingResourceTypes);
            this.SetParamObj(map, prefix + "HostingConfig.", this.HostingConfig);
        }
    }
}

