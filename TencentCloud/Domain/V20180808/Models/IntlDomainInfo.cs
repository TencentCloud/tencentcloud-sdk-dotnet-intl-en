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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntlDomainInfo : AbstractModel
    {
        
        /// <summary>
        /// The auto-renewal flag. Valid values: `0` (disabled by default), `1` (enabled), `2` (disabled).
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// The registration time.
        /// </summary>
        [JsonProperty("CreationDate")]
        public string CreationDate{ get; set; }

        /// <summary>
        /// The domain ID.
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// The DNS status. Valid values: `1` (DNSPod), `2` (others), `3` (unknown).
        /// </summary>
        [JsonProperty("DnsStatus")]
        public long? DnsStatus{ get; set; }

        /// <summary>
        /// The domains.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// The domain status.
        /// </summary>
        [JsonProperty("DomainStatus")]
        public string[] DomainStatus{ get; set; }

        /// <summary>
        /// The purchase status of the domain. Valid values:
        /// `ok`: Normal.
        /// `RegisterPending`: Pending registration.
        /// `RegisterDoing`: Registration in progress.
        /// `RegisterFailed`: Registration failed.
        /// `RenewPending`: Renewal grace period.
        /// `RenewDoing`: Renewing.
        /// `RedemptionPending`: Redemption period.
        /// `AboutToExpire`: About to expire.
        /// `TransferPending`: Pending transfer.
        /// `TransferTransing`: Transfer in progress.
        /// `TransferFailed`: Transfer failed.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// The expiration date.
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public string ExpirationDate{ get; set; }

        /// <summary>
        /// The auto-renewal flag. Valid values: `1` (enabled), `2` (disabled), `3` (disabled by default).
        /// </summary>
        [JsonProperty("ExpireMessage")]
        public long? ExpireMessage{ get; set; }

        /// <summary>
        /// Whether the domain is a premium one.
        /// </summary>
        [JsonProperty("IsPremium")]
        public bool? IsPremium{ get; set; }

        /// <summary>
        /// The DNS server of the domain.
        /// </summary>
        [JsonProperty("Dns")]
        public string[] Dns{ get; set; }

        /// <summary>
        /// The contact information.
        /// </summary>
        [JsonProperty("ContactInfo")]
        public IntlContactInfo ContactInfo{ get; set; }

        /// <summary>
        /// The number of years available for renewal. The value `0` indicates that the domain has reached its maximum validity period (10 years) and cannot be renewed.
        /// </summary>
        [JsonProperty("CanRenewYears")]
        public long? CanRenewYears{ get; set; }

        /// <summary>
        /// The registrar type. If the value is `epp`, the registration time on the page is followed by (UTC). Otherwise, it is followed by (UTC+8).
        /// </summary>
        [JsonProperty("RegistrarType")]
        public string RegistrarType{ get; set; }

        /// <summary>
        /// The account to which the domain belongs.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// The profile ID.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Whether DNSSEC is supported.
        /// </summary>
        [JsonProperty("SupportDnssec")]
        public bool? SupportDnssec{ get; set; }

        /// <summary>
        /// WHOIS privacy service status. Valid values: `1` (enabled), `2` (disabled), `3` (enabling), `4` (disabling).
        /// </summary>
        [JsonProperty("WhoisPrivacy")]
        public long? WhoisPrivacy{ get; set; }

        /// <summary>
        /// Valid values: `NotModify` (not modified), `Modifying`, `Failed` (failed to modify)
        /// </summary>
        [JsonProperty("ModifyStatus")]
        public string ModifyStatus{ get; set; }

        /// <summary>
        /// Valid values: `NotModify` (not modified), `Modifying`, `Failed` (failed to modify)
        /// </summary>
        [JsonProperty("DnsModifyStatus")]
        public string DnsModifyStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "CreationDate", this.CreationDate);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "DnsStatus", this.DnsStatus);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamArraySimple(map, prefix + "DomainStatus.", this.DomainStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamSimple(map, prefix + "ExpireMessage", this.ExpireMessage);
            this.SetParamSimple(map, prefix + "IsPremium", this.IsPremium);
            this.SetParamArraySimple(map, prefix + "Dns.", this.Dns);
            this.SetParamObj(map, prefix + "ContactInfo.", this.ContactInfo);
            this.SetParamSimple(map, prefix + "CanRenewYears", this.CanRenewYears);
            this.SetParamSimple(map, prefix + "RegistrarType", this.RegistrarType);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "SupportDnssec", this.SupportDnssec);
            this.SetParamSimple(map, prefix + "WhoisPrivacy", this.WhoisPrivacy);
            this.SetParamSimple(map, prefix + "ModifyStatus", this.ModifyStatus);
            this.SetParamSimple(map, prefix + "DnsModifyStatus", this.DnsModifyStatus);
        }
    }
}

