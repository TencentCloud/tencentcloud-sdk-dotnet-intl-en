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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainListItem : AbstractModel
    {
        
        /// <summary>
        /// Unique ID assigned to the domain by the system
        /// </summary>
        [JsonProperty("DomainId")]
        public ulong? DomainId{ get; set; }

        /// <summary>
        /// Original format of the domain
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Domain status. Valid values: `ENABLE` (normal), `PAUSE` (suspended), `SPAM` (blocked).
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Default TTL of the default DNS record of the domain
        /// </summary>
        [JsonProperty("TTL")]
        public ulong? TTL{ get; set; }

        /// <summary>
        /// Whether CNAME flattening is enabled. Valid values: `ENABLE` (enabled); `DISABLE` (disabled).
        /// </summary>
        [JsonProperty("CNAMESpeedup")]
        public string CNAMESpeedup{ get; set; }

        /// <summary>
        /// DNS configuration status. Valid values: `DNSERROR` (error), an empty string (normal).
        /// </summary>
        [JsonProperty("DNSStatus")]
        public string DNSStatus{ get; set; }

        /// <summary>
        /// Plan level code of the domain
        /// </summary>
        [JsonProperty("Grade")]
        public string Grade{ get; set; }

        /// <summary>
        /// Group ID of the domain
        /// </summary>
        [JsonProperty("GroupId")]
        public ulong? GroupId{ get; set; }

        /// <summary>
        /// Whether search engine push optimization is enabled. Valid values: `YES` (yes), `NO` (no).
        /// </summary>
        [JsonProperty("SearchEnginePush")]
        public string SearchEnginePush{ get; set; }

        /// <summary>
        /// Domain remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Punycode-encoded domain format
        /// </summary>
        [JsonProperty("Punycode")]
        public string Punycode{ get; set; }

        /// <summary>
        /// Effective DNS assigned to the domain by the system
        /// </summary>
        [JsonProperty("EffectiveDNS")]
        public string[] EffectiveDNS{ get; set; }

        /// <summary>
        /// Number corresponding to the plan level of the domain
        /// </summary>
        [JsonProperty("GradeLevel")]
        public ulong? GradeLevel{ get; set; }

        /// <summary>
        /// Plan name
        /// </summary>
        [JsonProperty("GradeTitle")]
        public string GradeTitle{ get; set; }

        /// <summary>
        /// Whether it is a paid plan
        /// </summary>
        [JsonProperty("IsVip")]
        public string IsVip{ get; set; }

        /// <summary>
        /// Activation time of the paid plan
        /// </summary>
        [JsonProperty("VipStartAt")]
        public string VipStartAt{ get; set; }

        /// <summary>
        /// Expiry time of the paid plan
        /// </summary>
        [JsonProperty("VipEndAt")]
        public string VipEndAt{ get; set; }

        /// <summary>
        /// Whether VIP automatic renewal is enabled for the domain. Valid values: `YES` (yes); `NO` (no). Default value: `DEFAULT`.
        /// </summary>
        [JsonProperty("VipAutoRenew")]
        public string VipAutoRenew{ get; set; }

        /// <summary>
        /// Number of records under the domain
        /// </summary>
        [JsonProperty("RecordCount")]
        public ulong? RecordCount{ get; set; }

        /// <summary>
        /// Domain adding time
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// Domain update time
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }

        /// <summary>
        /// Account of the domain
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "CNAMESpeedup", this.CNAMESpeedup);
            this.SetParamSimple(map, prefix + "DNSStatus", this.DNSStatus);
            this.SetParamSimple(map, prefix + "Grade", this.Grade);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "SearchEnginePush", this.SearchEnginePush);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Punycode", this.Punycode);
            this.SetParamArraySimple(map, prefix + "EffectiveDNS.", this.EffectiveDNS);
            this.SetParamSimple(map, prefix + "GradeLevel", this.GradeLevel);
            this.SetParamSimple(map, prefix + "GradeTitle", this.GradeTitle);
            this.SetParamSimple(map, prefix + "IsVip", this.IsVip);
            this.SetParamSimple(map, prefix + "VipStartAt", this.VipStartAt);
            this.SetParamSimple(map, prefix + "VipEndAt", this.VipEndAt);
            this.SetParamSimple(map, prefix + "VipAutoRenew", this.VipAutoRenew);
            this.SetParamSimple(map, prefix + "RecordCount", this.RecordCount);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
        }
    }
}

