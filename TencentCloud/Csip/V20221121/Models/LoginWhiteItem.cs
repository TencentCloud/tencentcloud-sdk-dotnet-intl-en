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

    public class LoginWhiteItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Allowlist type: Custom - custom allowlist; Learn - self-learning allowlist</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>AppId of the account associated with the policy, used to distinguish and locate for subsequent editing in multi-account scenarios</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>Rule ID; for self-learning, it is the rule group ID (minimum line ID in the group)</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>Login source IP (comma-separated); self-learning allowlist is always empty</p>
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// <p>Login usernames (separate with commas); self-learning allowlist is always empty</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>Starting HH:MM when logging in; the self-learning allowlist is always empty</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>Login period ends at HH:MM; self-learning allowlist is always empty</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Common login location list</p>
        /// </summary>
        [JsonProperty("Places")]
        public LoginWhitePlace[] Places{ get; set; }

        /// <summary>
        /// <p>Common login location display copy (comma-separated) for direct display in the list</p>
        /// </summary>
        [JsonProperty("Locations")]
        public string Locations{ get; set; }

        /// <summary>
        /// <p>Effective asset scope: 0-specified hosts (host or tag hit) 1-all hosts</p>
        /// </summary>
        [JsonProperty("Scope")]
        public long? Scope{ get; set; }

        /// <summary>
        /// <p>Effective host QUUID list (one-to-one correspondence with InstanceIDs)</p>
        /// </summary>
        [JsonProperty("QUUIDS")]
        public string[] QUUIDS{ get; set; }

        /// <summary>
        /// <p>List of host instance IDs that take effect (one-to-one correspondence with QUUIDS)</p>
        /// </summary>
        [JsonProperty("InstanceIDs")]
        public string[] InstanceIDs{ get; set; }

        /// <summary>
        /// <p>Remove host QUUID list</p>
        /// </summary>
        [JsonProperty("ExcludeQUUIDS")]
        public string[] ExcludeQUUIDS{ get; set; }

        /// <summary>
        /// <p>Host instance ID list for removal</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDs")]
        public string[] ExcludeInstanceIDs{ get; set; }

        /// <summary>
        /// <p>List of effective tag details.</p>
        /// </summary>
        [JsonProperty("TagItems")]
        public EDRRuleTagItem[] TagItems{ get; set; }

        /// <summary>
        /// <p>Hosts: custom to the specified number of hosts (0 when Scope=1, all hosts displayed on the front-end); self-learning is the number of deduplicated hosts in the group</p>
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// <p>Remarks.</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Creation time, format 2006-01-02 15:04:05</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Last modification time, format 2006-01-02 15:04:05</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "Places.", this.Places);
            this.SetParamSimple(map, prefix + "Locations", this.Locations);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamArraySimple(map, prefix + "QUUIDS.", this.QUUIDS);
            this.SetParamArraySimple(map, prefix + "InstanceIDs.", this.InstanceIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeQUUIDS.", this.ExcludeQUUIDS);
            this.SetParamArraySimple(map, prefix + "ExcludeInstanceIDs.", this.ExcludeInstanceIDs);
            this.SetParamArrayObj(map, prefix + "TagItems.", this.TagItems);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

