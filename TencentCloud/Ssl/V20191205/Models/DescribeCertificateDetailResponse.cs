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

    public class DescribeCertificateDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// Certificate belonging to user main account uin.
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
        /// Certificate source:.
        /// trustAsia.
        /// upload.
        /// wosign.
        /// sheca.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// Certificate type. `CA`: client certificate; `SVR`: server certificate
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateType")]
        public string CertificateType{ get; set; }

        /// <summary>
        /// Certificate package type:.
        /// null: user uploads a certificate (no package type),.
        /// 2: trustasia tls rsa ca,. 
        /// 3: securesite enhanced enterprise version (ev pro),. 
        /// 4: securesite enhanced (ev),. 
        /// 5: securesite enterprise pro (ov pro).
        /// 6: securesite enterprise (ov). 
        /// 7: securesite enterprise (ov) wildcard. 
        /// 8: geotrust enhanced (ev). 
        /// 9: geotrust enterprise (ov). 
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
        /// 24: globalsign enhanced multiple domain names (ev) ssl certificate.
        /// 25: wotrus domain cert.
        /// 26: wotrus multi-domain cert.
        /// 27: wotrus wildcard cert.
        /// 28: wotrus enterprise cert.
        /// 29: wotrus enterprise multi-domain cert.
        /// 30: wotrus enterprise wildcard certificate.
        /// 31: wotrus enhanced certificate.
        /// 32: wotrus enhanced multi-domain name certificate.
        /// 33: wotrus-national cryptography domain name certificate.
        /// 34: wotrus-national cryptography domain name certificate (multiple domain names).
        /// 35: wotrus-national cryptography wildcard certificate.
        /// 37: wotrus-national cryptography enterprise certificate.
        /// 38: wotrus-national cryptography enterprise certificate (multiple domain names).
        /// 39: wotrus-national cryptography enterprise certificate (wildcard).
        /// 40: wotrus-national cryptography enhanced certificate.
        /// 41: wotrus - national cryptography enhanced certificate (multiple domain names).
        /// 42: trustasia - domain name certificate (wildcard multiple domain names).
        /// 43: DNSPod - enterprise (ov) ssl certificate.
        /// 44: DNSPod - enterprise (ov) wildcard ssl certificate.
        /// 45: DNSPod - enterprise (ov) multiple domain names ssl certificate.
        /// 46: dnspod-enhanced (ev) ssl certificate.
        /// 47: dnspod-enhanced (ev) multiple domain names ssl certificate.
        /// 48: dnspod-domain name-based (dv) ssl certificate.
        /// 49: dnspod-domain name-based (dv) wildcard ssl certificate.
        /// 50: dnspod-domain name-based (dv) multiple domain names ssl certificate.
        /// 51: DNSPod (national cryptography) - enterprise (ov) ssl certificate.
        /// 52: DNSPod (national cryptography) - enterprise (ov) wildcard ssl certificate.
        /// 53: DNSPod (national cryptography) - enterprise (ov) multiple domain names ssl certificate.
        /// 54: DNSPod (national cryptography) - domain name-based (dv) ssl certificate.
        /// 55: DNSPod (national cryptography) - domain name-based (dv) wildcard ssl certificate.
        /// 56: DNSPod (national cryptography) - domain name-based (dv) multiple domain names ssl certificate.
        /// 57: securesite enterprise professional version multiple domain names (ov pro).
        /// 58: securesite enterprise multiple domain names (ov).
        /// 59: securesite enhanced professional version multiple domain names (ev pro).
        /// 60: securesite enhanced multiple domain names (ev).
        /// 61: geotrust enhanced multiple domain names (ev).
        /// 75: securesite enterprise (ov).
        /// 76: securesite enterprise (ov) wildcard.
        /// 77: securesite enhanced (ev).
        /// 78: geotrust enterprise (ov).
        /// 79: geotrust enterprise (ov) wildcard.
        /// 80: geotrust enhanced (ev).
        /// 81: globalsign enterprise (ov) ssl certificate.
        /// 82: globalsign enterprise wildcard (ov) ssl certificate.
        /// 83: trustasia c1 dv free.
        /// 85: globalsign enhanced (ev) ssl certificate.
        /// 88: globalsign enterprise wildcard multiple domain names (ov) ssl certificate.
        /// 89: globalsign enterprise multiple domain names (ov) ssl certificate.
        /// 90: globalsign enhanced multiple domain names (ev) ssl certificate.
        /// 91: geotrust enhanced multiple domain names (ev).
        /// 92: securesite enterprise ov pro for multiple domain names.
        /// 93: securesite enterprise for multiple domain names (ov).
        /// 94: securesite ev pro for multiple domain names.
        /// 95: securesite ev for multiple domain names.
        /// 96: securesite ev pro.
        /// 97: securesite enterprise professional edition (ov pro).
        /// 98: cfca enterprise (ov) ssl certificate.
        /// 99: cfca enterprise multiple domain names (ov) ssl certificate.
        /// 100: cfca enterprise wildcard (ov) ssl certificate.
        /// 101: cfca enhanced (ev) ssl certificate.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Certificate product name.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductZhName")]
        public string ProductZhName{ get; set; }

        /// <summary>
        /// Certificate binds to a common name domain.
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
        /// Certificate status: 0 = under review, 1 = approved, 2 = review failed, 3 = expired, 4 = automatically added dns records, 5 = enterprise certificate, pending document submission, 6 = order cancellation in progress, 7 = canceled, 8 = documents submitted, pending upload of confirmation letter, 9 = certificate revocation in progress, 10 = revoked, 11 = reissue in progress, 12 = pending upload of revocation confirmation letter, 13 = free certificate pending document submission, 14 = certificate has been refunded, 15 = certificate migration in progress.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Status information. valid values:.
        /// //Common status information.
        /// PRE-REVIEWING: in prereview.
        /// LEGAL-REVIEWING: in legal review.
        /// CA-REVIEWING: in ca review.
        /// PENDING-DCV: in domain verification.
        /// WAIT-ISSUE: waiting for issue (domain verification passed).
        /// Certificate review failure status information.
        /// 1. order review failed.
        /// 2. ca review failed, and the domain name did not pass the security review.
        /// 3. domain name verification timed out, and the order was automatically closed. please reapply for the certificate.
        /// 4. the certificate information did not pass the review of the certificate ca agency. the reviewer will call the contact information reserved for the certificate. please pay attention to the incoming call. subsequently, you can resubmit the information through "modify information".
        /// To be continuously improved.
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
        /// Vulnerability scanning status
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulnerabilityStatus")]
        public string VulnerabilityStatus{ get; set; }

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
        /// Certificate application time.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// CA order id.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// Extended information of the certificate
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateExtra")]
        public CertificateExtra CertificateExtra{ get; set; }

        /// <summary>
        /// Private key certificate; for Chinese SM certificates, it refers to the private key certificate in the signature certificate.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificatePrivateKey")]
        public string CertificatePrivateKey{ get; set; }

        /// <summary>
        /// Public key certificate; for Chinese SM certificate, it refers to the public key certificate in the signature certificate.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificatePublicKey")]
        public string CertificatePublicKey{ get; set; }

        /// <summary>
        /// Certificate domain name verification information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DvAuthDetail")]
        public DvAuthDetail DvAuthDetail{ get; set; }

        /// <summary>
        /// Vulnerability scanning assessment report
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulnerabilityReport")]
        public string VulnerabilityReport{ get; set; }

        /// <summary>
        /// Certificate ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// Certificate type name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// Status description
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusName")]
        public string StatusName{ get; set; }

        /// <summary>
        /// Multiple domain names included in the certificate (excluding the primary domain name, which uses the `Domain` field)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubjectAltName")]
        public string[] SubjectAltName{ get; set; }

        /// <summary>
        /// Whether the certificate is a paid one.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsVip")]
        public bool? IsVip{ get; set; }

        /// <summary>
        /// Whether the certificate is a wildcard certificate
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsWildcard")]
        public bool? IsWildcard{ get; set; }

        /// <summary>
        /// Whether the certificate is a DV certificate
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsDv")]
        public bool? IsDv{ get; set; }

        /// <summary>
        /// Whether the vulnerability scanning feature is enabled
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsVulnerability")]
        public bool? IsVulnerability{ get; set; }

        /// <summary>
        /// Profile information submitted for paid certificates.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubmittedData")]
        public SubmittedData SubmittedData{ get; set; }

        /// <summary>
        /// Whether the certificate can be renewed.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RenewAble")]
        public bool? RenewAble{ get; set; }

        /// <summary>
        /// Whether the certificate can be deployed
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Deployable")]
        public bool? Deployable{ get; set; }

        /// <summary>
        /// List of associated tags
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// Root certificate.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RootCert")]
        public RootCertificates RootCert{ get; set; }

        /// <summary>
        /// Chinese SM certificate public key, only has value for national cryptography certificates.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EncryptCert")]
        public string EncryptCert{ get; set; }

        /// <summary>
        /// Chinese SM certificate private key certificate, only has value for national cryptography certificates.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EncryptPrivateKey")]
        public string EncryptPrivateKey{ get; set; }

        /// <summary>
        /// SHA1 fingerprint of the signature certificate
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertFingerprint")]
        public string CertFingerprint{ get; set; }

        /// <summary>
        /// SHA1 fingerprint of the encryption certificate (for Chinese SM certificates only)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EncryptCertFingerprint")]
        public string EncryptCertFingerprint{ get; set; }

        /// <summary>
        /// Certificate encryption algorithm (or Chinese SM certificates only).
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EncryptAlgorithm")]
        public string EncryptAlgorithm{ get; set; }

        /// <summary>
        /// The authentication value for DV certificate revocation.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DvRevokeAuthDetail")]
        public DvAuths[] DvRevokeAuthDetail{ get; set; }

        /// <summary>
        /// Certificate chain information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertChainInfo")]
        public CertBasicInfo[] CertChainInfo{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "CertificateType", this.CertificateType);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "ProductZhName", this.ProductZhName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusMsg", this.StatusMsg);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "VulnerabilityStatus", this.VulnerabilityStatus);
            this.SetParamSimple(map, prefix + "CertBeginTime", this.CertBeginTime);
            this.SetParamSimple(map, prefix + "CertEndTime", this.CertEndTime);
            this.SetParamSimple(map, prefix + "ValidityPeriod", this.ValidityPeriod);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamObj(map, prefix + "CertificateExtra.", this.CertificateExtra);
            this.SetParamSimple(map, prefix + "CertificatePrivateKey", this.CertificatePrivateKey);
            this.SetParamSimple(map, prefix + "CertificatePublicKey", this.CertificatePublicKey);
            this.SetParamObj(map, prefix + "DvAuthDetail.", this.DvAuthDetail);
            this.SetParamSimple(map, prefix + "VulnerabilityReport", this.VulnerabilityReport);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "StatusName", this.StatusName);
            this.SetParamArraySimple(map, prefix + "SubjectAltName.", this.SubjectAltName);
            this.SetParamSimple(map, prefix + "IsVip", this.IsVip);
            this.SetParamSimple(map, prefix + "IsWildcard", this.IsWildcard);
            this.SetParamSimple(map, prefix + "IsDv", this.IsDv);
            this.SetParamSimple(map, prefix + "IsVulnerability", this.IsVulnerability);
            this.SetParamObj(map, prefix + "SubmittedData.", this.SubmittedData);
            this.SetParamSimple(map, prefix + "RenewAble", this.RenewAble);
            this.SetParamSimple(map, prefix + "Deployable", this.Deployable);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "RootCert.", this.RootCert);
            this.SetParamSimple(map, prefix + "EncryptCert", this.EncryptCert);
            this.SetParamSimple(map, prefix + "EncryptPrivateKey", this.EncryptPrivateKey);
            this.SetParamSimple(map, prefix + "CertFingerprint", this.CertFingerprint);
            this.SetParamSimple(map, prefix + "EncryptCertFingerprint", this.EncryptCertFingerprint);
            this.SetParamSimple(map, prefix + "EncryptAlgorithm", this.EncryptAlgorithm);
            this.SetParamArrayObj(map, prefix + "DvRevokeAuthDetail.", this.DvRevokeAuthDetail);
            this.SetParamArrayObj(map, prefix + "CertChainInfo.", this.CertChainInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

