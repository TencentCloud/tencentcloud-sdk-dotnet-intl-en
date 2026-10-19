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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosPolicyInfo : AbstractModel
    {
        
        /// <summary>
        /// Policy name.
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Policy type
        /// PolicyType: 1 alarm policy 2 risk policy 3 allowlist policy 4 ip hiding policy
        /// </summary>
        [JsonProperty("PolicyType")]
        public long? PolicyType{ get; set; }

        /// <summary>
        /// system: system built-in user: user-customized
        /// </summary>
        [JsonProperty("PolicySource")]
        public long? PolicySource{ get; set; }

        /// <summary>
        /// Policy content
        /// </summary>
        [JsonProperty("PolicyContent")]
        public string PolicyContent{ get; set; }

        /// <summary>
        /// 0: disabled
        /// 1: enabled.
        /// </summary>
        [JsonProperty("PolicyStatus")]
        public long? PolicyStatus{ get; set; }

        /// <summary>
        /// Policy classification
        /// </summary>
        [JsonProperty("PolicyAbnormalType")]
        public long? PolicyAbnormalType{ get; set; }

        /// <summary>
        /// Risk level
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("PolicyCreateTime")]
        public long? PolicyCreateTime{ get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [JsonProperty("PolicyUpdateTime")]
        public long? PolicyUpdateTime{ get; set; }

        /// <summary>
        /// Number of policy hits in the last 7 days
        /// </summary>
        [JsonProperty("PolicyHitCount")]
        public long? PolicyHitCount{ get; set; }

        /// <summary>
        /// Alarm content hash
        /// </summary>
        [JsonProperty("PolicyContentHash")]
        public string PolicyContentHash{ get; set; }

        /// <summary>
        /// Number of associated accounts.
        /// </summary>
        [JsonProperty("RelAccountCount")]
        public long? RelAccountCount{ get; set; }

        /// <summary>
        /// Associated account UIN
        /// </summary>
        [JsonProperty("RelAccountUin")]
        public string RelAccountUin{ get; set; }

        /// <summary>
        /// Name of the associated account
        /// </summary>
        [JsonProperty("RelAccountName")]
        public string RelAccountName{ get; set; }

        /// <summary>
        /// Description information
        /// </summary>
        [JsonProperty("PolicyDescription")]
        public string PolicyDescription{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("PolicyMarker")]
        public string PolicyMarker{ get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// id set in a multi-account scenario
        /// </summary>
        [JsonProperty("PolicyIdSet")]
        public long?[] PolicyIdSet{ get; set; }

        /// <summary>
        /// Whether to dispose of historical data status. 0: no disposal required. 1: disposal required. 2: processed
        /// </summary>
        [JsonProperty("PolicyHistoryHandleStatus")]
        public ulong? PolicyHistoryHandleStatus{ get; set; }

        /// <summary>
        /// System policy edit status
        /// </summary>
        [JsonProperty("SystemPolicyEditStatus")]
        public long? SystemPolicyEditStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicySource", this.PolicySource);
            this.SetParamSimple(map, prefix + "PolicyContent", this.PolicyContent);
            this.SetParamSimple(map, prefix + "PolicyStatus", this.PolicyStatus);
            this.SetParamSimple(map, prefix + "PolicyAbnormalType", this.PolicyAbnormalType);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyCreateTime", this.PolicyCreateTime);
            this.SetParamSimple(map, prefix + "PolicyUpdateTime", this.PolicyUpdateTime);
            this.SetParamSimple(map, prefix + "PolicyHitCount", this.PolicyHitCount);
            this.SetParamSimple(map, prefix + "PolicyContentHash", this.PolicyContentHash);
            this.SetParamSimple(map, prefix + "RelAccountCount", this.RelAccountCount);
            this.SetParamSimple(map, prefix + "RelAccountUin", this.RelAccountUin);
            this.SetParamSimple(map, prefix + "RelAccountName", this.RelAccountName);
            this.SetParamSimple(map, prefix + "PolicyDescription", this.PolicyDescription);
            this.SetParamSimple(map, prefix + "PolicyMarker", this.PolicyMarker);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamArraySimple(map, prefix + "PolicyIdSet.", this.PolicyIdSet);
            this.SetParamSimple(map, prefix + "PolicyHistoryHandleStatus", this.PolicyHistoryHandleStatus);
            this.SetParamSimple(map, prefix + "SystemPolicyEditStatus", this.SystemPolicyEditStatus);
        }
    }
}

