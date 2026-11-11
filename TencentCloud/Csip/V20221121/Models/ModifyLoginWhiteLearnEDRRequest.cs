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

    public class ModifyLoginWhiteLearnEDRRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Rule ID; for self-learning, it is the rule group ID (minimum line ID in the group)</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>List of common login locations. Required. 1-200 entries. It is the unique content dimension of the self-learning rule.</p>
        /// </summary>
        [JsonProperty("Places")]
        public LoginWhitePlaceInput[] Places{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>AppId of the account associated with the policy (obtained from the list output parameter AppId); if empty, the current account is used; non-current accounts must pass ownership verification</p>
        /// </summary>
        [JsonProperty("RuleAppId")]
        public ulong? RuleAppId{ get; set; }

        /// <summary>
        /// <p>Remark, up to 255 characters</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Effective asset scope: 0-specified hosts (host or tag hit) 1-all hosts</p>
        /// </summary>
        [JsonProperty("Scope")]
        public long? Scope{ get; set; }

        /// <summary>
        /// <p>List of specified hosts (in instance ID form), up to 10,000 items. The server translates them to QUUIDs via idmap, then merges and deduplicates them with QUUIDSWithAppId.</p>
        /// </summary>
        [JsonProperty("InstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] InstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>List of hosts (instance ID form) to remove, up to 10,000 items</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] ExcludeInstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Security center tag ID list, up to 100. When Scope=0, it is in an OR relationship with the host. Self-learning allowlist does not support taking effect by tag (a non-empty value will be rejected).</p>
        /// </summary>
        [JsonProperty("TagIDs")]
        public string[] TagIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "Places.", this.Places);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "RuleAppId", this.RuleAppId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamArrayObj(map, prefix + "InstanceIDsWithAppId.", this.InstanceIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ExcludeInstanceIDsWithAppId.", this.ExcludeInstanceIDsWithAppId);
            this.SetParamArraySimple(map, prefix + "TagIDs.", this.TagIDs);
        }
    }
}

