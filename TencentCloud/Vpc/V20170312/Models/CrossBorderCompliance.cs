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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CrossBorderCompliance : AbstractModel
    {
        
        /// <summary>
        /// Service provider. Valid values: `UNICOM`.
        /// </summary>
        [JsonProperty("ServiceProvider")]
        public string ServiceProvider{ get; set; }

        /// <summary>
        /// ID of compliance review request.
        /// </summary>
        [JsonProperty("ComplianceId")]
        public ulong? ComplianceId{ get; set; }

        /// <summary>
        /// Full company name.
        /// </summary>
        [JsonProperty("Company")]
        public string Company{ get; set; }

        /// <summary>
        /// Unified Social Credit Code.
        /// </summary>
        [JsonProperty("UniformSocialCreditCode")]
        public string UniformSocialCreditCode{ get; set; }

        /// <summary>
        /// Legal person.
        /// </summary>
        [JsonProperty("LegalPerson")]
        public string LegalPerson{ get; set; }

        /// <summary>
        /// Issuing authority.
        /// </summary>
        [JsonProperty("IssuingAuthority")]
        public string IssuingAuthority{ get; set; }

        /// <summary>
        /// Business license.
        /// </summary>
        [JsonProperty("BusinessLicense")]
        public string BusinessLicense{ get; set; }

        /// <summary>
        /// Business address.
        /// </summary>
        [JsonProperty("BusinessAddress")]
        public string BusinessAddress{ get; set; }

        /// <summary>
        /// Zip code.
        /// </summary>
        [JsonProperty("PostCode")]
        public ulong? PostCode{ get; set; }

        /// <summary>
        /// Operator.
        /// </summary>
        [JsonProperty("Manager")]
        public string Manager{ get; set; }

        /// <summary>
        /// Operator ID card number.
        /// </summary>
        [JsonProperty("ManagerId")]
        public string ManagerId{ get; set; }

        /// <summary>
        /// Operator ID card.
        /// </summary>
        [JsonProperty("ManagerIdCard")]
        public string ManagerIdCard{ get; set; }

        /// <summary>
        /// Operator address.
        /// </summary>
        [JsonProperty("ManagerAddress")]
        public string ManagerAddress{ get; set; }

        /// <summary>
        /// Operator phone number.
        /// </summary>
        [JsonProperty("ManagerTelephone")]
        public string ManagerTelephone{ get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// Service handling form.
        /// </summary>
        [JsonProperty("ServiceHandlingForm")]
        public string ServiceHandlingForm{ get; set; }

        /// <summary>
        /// Authorization letter.
        /// </summary>
        [JsonProperty("AuthorizationLetter")]
        public string AuthorizationLetter{ get; set; }

        /// <summary>
        /// Information security commitment.
        /// </summary>
        [JsonProperty("SafetyCommitment")]
        public string SafetyCommitment{ get; set; }

        /// <summary>
        /// Service start date.
        /// </summary>
        [JsonProperty("ServiceStartDate")]
        public string ServiceStartDate{ get; set; }

        /// <summary>
        /// Service end date.
        /// </summary>
        [JsonProperty("ServiceEndDate")]
        public string ServiceEndDate{ get; set; }

        /// <summary>
        /// Status. Valid values: `PENDING`, `APPROVED`, and `DENY`.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Creation time of the review form.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceProvider", this.ServiceProvider);
            this.SetParamSimple(map, prefix + "ComplianceId", this.ComplianceId);
            this.SetParamSimple(map, prefix + "Company", this.Company);
            this.SetParamSimple(map, prefix + "UniformSocialCreditCode", this.UniformSocialCreditCode);
            this.SetParamSimple(map, prefix + "LegalPerson", this.LegalPerson);
            this.SetParamSimple(map, prefix + "IssuingAuthority", this.IssuingAuthority);
            this.SetParamSimple(map, prefix + "BusinessLicense", this.BusinessLicense);
            this.SetParamSimple(map, prefix + "BusinessAddress", this.BusinessAddress);
            this.SetParamSimple(map, prefix + "PostCode", this.PostCode);
            this.SetParamSimple(map, prefix + "Manager", this.Manager);
            this.SetParamSimple(map, prefix + "ManagerId", this.ManagerId);
            this.SetParamSimple(map, prefix + "ManagerIdCard", this.ManagerIdCard);
            this.SetParamSimple(map, prefix + "ManagerAddress", this.ManagerAddress);
            this.SetParamSimple(map, prefix + "ManagerTelephone", this.ManagerTelephone);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "ServiceHandlingForm", this.ServiceHandlingForm);
            this.SetParamSimple(map, prefix + "AuthorizationLetter", this.AuthorizationLetter);
            this.SetParamSimple(map, prefix + "SafetyCommitment", this.SafetyCommitment);
            this.SetParamSimple(map, prefix + "ServiceStartDate", this.ServiceStartDate);
            this.SetParamSimple(map, prefix + "ServiceEndDate", this.ServiceEndDate);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

