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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainInfo : AbstractModel
    {
        
        /// <summary>
        /// Domain ID
        /// </summary>
        [JsonProperty("DomainId")]
        public ulong? DomainId{ get; set; }

        /// <summary>
        /// Domain status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// DNS plan level
        /// </summary>
        [JsonProperty("Grade")]
        public string Grade{ get; set; }

        /// <summary>
        /// Domain group ID
        /// </summary>
        [JsonProperty("GroupId")]
        public ulong? GroupId{ get; set; }

        /// <summary>
        /// Whether the domain is starred
        /// </summary>
        [JsonProperty("IsMark")]
        public string IsMark{ get; set; }

        /// <summary>
        /// TTL (DNS record cache time)
        /// </summary>
        [JsonProperty("TTL")]
        public ulong? TTL{ get; set; }

        /// <summary>
        /// Whether CNAME flattening is enabled
        /// </summary>
        [JsonProperty("CnameSpeedup")]
        public string CnameSpeedup{ get; set; }

        /// <summary>
        /// Domain remarks
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Domain Punycode
        /// </summary>
        [JsonProperty("Punycode")]
        public string Punycode{ get; set; }

        /// <summary>
        /// DNS status of the domain
        /// </summary>
        [JsonProperty("DnsStatus")]
        public string DnsStatus{ get; set; }

        /// <summary>
        /// NS list of the domain
        /// </summary>
        [JsonProperty("DnspodNsList")]
        public string[] DnspodNsList{ get; set; }

        /// <summary>
        /// Domain
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Domain level ID
        /// </summary>
        [JsonProperty("GradeLevel")]
        public ulong? GradeLevel{ get; set; }

        /// <summary>
        /// Domain user ID
        /// </summary>
        [JsonProperty("UserId")]
        public ulong? UserId{ get; set; }

        /// <summary>
        /// Whether the domain is a VIP domain
        /// </summary>
        [JsonProperty("IsVip")]
        public string IsVip{ get; set; }

        /// <summary>
        /// Domain owner account
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// Domain level description
        /// </summary>
        [JsonProperty("GradeTitle")]
        public string GradeTitle{ get; set; }

        /// <summary>
        /// Domain creation time
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// Last update time
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }

        /// <summary>
        /// Tencent Cloud account `Uin`
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// NS list actually used by the domain
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActualNsList")]
        public string[] ActualNsList{ get; set; }

        /// <summary>
        /// Number of domain records
        /// </summary>
        [JsonProperty("RecordCount")]
        public ulong? RecordCount{ get; set; }

        /// <summary>
        /// Alias of the domain account owner
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OwnerNick")]
        public string OwnerNick{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Grade", this.Grade);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "IsMark", this.IsMark);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "CnameSpeedup", this.CnameSpeedup);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Punycode", this.Punycode);
            this.SetParamSimple(map, prefix + "DnsStatus", this.DnsStatus);
            this.SetParamArraySimple(map, prefix + "DnspodNsList.", this.DnspodNsList);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "GradeLevel", this.GradeLevel);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "IsVip", this.IsVip);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "GradeTitle", this.GradeTitle);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamArraySimple(map, prefix + "ActualNsList.", this.ActualNsList);
            this.SetParamSimple(map, prefix + "RecordCount", this.RecordCount);
            this.SetParamSimple(map, prefix + "OwnerNick", this.OwnerNick);
        }
    }
}

