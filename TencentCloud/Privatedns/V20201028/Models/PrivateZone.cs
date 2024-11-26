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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrivateZone : AbstractModel
    {
        
        /// <summary>
        /// Private domain ID, which is in zone-xxxxxxxx format.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// UIN of the domain name owner.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public long? OwnerUin{ get; set; }

        /// <summary>
        /// Private domain name.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// Modification time
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }

        /// <summary>
        /// Number of records.
        /// </summary>
        [JsonProperty("RecordCount")]
        public long? RecordCount{ get; set; }

        /// <summary>
        /// Remarks.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// List of bound VPCs.
        /// </summary>
        [JsonProperty("VpcSet")]
        public VpcInfo[] VpcSet{ get; set; }

        /// <summary>
        /// Status of the VPC bound with the private domain. SUSPEND: The VPC is not associated; ENABLED: the VPC has been associated.
        /// , FAILED: the VPC fails to be associated.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Recursive resolution status of the domain name. ENABLED: enabled; DISABLED: disabled.
        /// </summary>
        [JsonProperty("DnsForwardStatus")]
        public string DnsForwardStatus{ get; set; }

        /// <summary>
        /// Tag key-value pair collection.
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// List of bound VPCs of the associated account.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccountVpcSet")]
        public AccountVpcInfoOutput[] AccountVpcSet{ get; set; }

        /// <summary>
        /// Whether the TLD is a custom one.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsCustomTld")]
        public bool? IsCustomTld{ get; set; }

        /// <summary>
        /// CNAME acceleration status. ENABLED: enabled; DISABLED: disabled.
        /// </summary>
        [JsonProperty("CnameSpeedupStatus")]
        public string CnameSpeedupStatus{ get; set; }

        /// <summary>
        /// Forwarding rule name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ForwardRuleName")]
        public string ForwardRuleName{ get; set; }

        /// <summary>
        /// Forwarding rule type. DOWN: from cloud to off-cloud; UP: from off-cloud to cloud. Currently, only DOWN is supported.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ForwardRuleType")]
        public string ForwardRuleType{ get; set; }

        /// <summary>
        /// Forwarding address.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ForwardAddress")]
        public string ForwardAddress{ get; set; }

        /// <summary>
        /// Endpoint name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndPointName")]
        public string EndPointName{ get; set; }

        /// <summary>
        /// Deleted VPC.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeletedVpcSet")]
        public VpcInfo[] DeletedVpcSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
            this.SetParamSimple(map, prefix + "RecordCount", this.RecordCount);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "VpcSet.", this.VpcSet);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DnsForwardStatus", this.DnsForwardStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "AccountVpcSet.", this.AccountVpcSet);
            this.SetParamSimple(map, prefix + "IsCustomTld", this.IsCustomTld);
            this.SetParamSimple(map, prefix + "CnameSpeedupStatus", this.CnameSpeedupStatus);
            this.SetParamSimple(map, prefix + "ForwardRuleName", this.ForwardRuleName);
            this.SetParamSimple(map, prefix + "ForwardRuleType", this.ForwardRuleType);
            this.SetParamSimple(map, prefix + "ForwardAddress", this.ForwardAddress);
            this.SetParamSimple(map, prefix + "EndPointName", this.EndPointName);
            this.SetParamArrayObj(map, prefix + "DeletedVpcSet.", this.DeletedVpcSet);
        }
    }
}

