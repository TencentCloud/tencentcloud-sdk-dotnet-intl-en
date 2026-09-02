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

    public class ModifyAILinkSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>0: Turn off the AI-Link engine, 1: Turn on the AI-Link engine</p>
        /// </summary>
        [JsonProperty("AILinkEnable")]
        public ulong? AILinkEnable{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Deep mode 0-Off 1-On</p>
        /// </summary>
        [JsonProperty("RuleScopeDeep")]
        public ulong? RuleScopeDeep{ get; set; }

        /// <summary>
        /// <p>Balanced mode. 0: off; 1: on</p>
        /// </summary>
        [JsonProperty("RuleScopeBalanced")]
        public ulong? RuleScopeBalanced{ get; set; }

        /// <summary>
        /// <p>Precision mode 0-Disable 1-Enable</p>
        /// </summary>
        [JsonProperty("RuleScopePrecise")]
        public ulong? RuleScopePrecise{ get; set; }

        /// <summary>
        /// <p>1 for all professional/flagship edition hosts, 0 for the selected host list</p>
        /// </summary>
        [JsonProperty("Scope")]
        public ulong? Scope{ get; set; }

        /// <summary>
        /// <p>Selected host Quuid list (required when Scope=0)</p>
        /// </summary>
        [JsonProperty("Quuids")]
        [System.Obsolete]
        public string[] Quuids{ get; set; }

        /// <summary>
        /// <p>Exclusion host Quuid list (this parameter is valid only when Scope=1)</p>
        /// </summary>
        [JsonProperty("ExcludeQuuids")]
        [System.Obsolete]
        public string[] ExcludeQuuids{ get; set; }

        /// <summary>
        /// <p>Automatic inclusion of new assets: 0 excludes, 1 includes</p>
        /// </summary>
        [JsonProperty("AutoInclude")]
        public ulong? AutoInclude{ get; set; }

        /// <summary>
        /// <p>Tag ID</p>
        /// </summary>
        [JsonProperty("TagIDs")]
        public string[] TagIDs{ get; set; }

        /// <summary>
        /// <p>0,1</p><p>Enumeration values:</p><ul><li>0: Partial</li><li>1: All</li></ul>
        /// </summary>
        [JsonProperty("TCSSScope")]
        public ulong? TCSSScope{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterIDs")]
        public string[] ClusterIDs{ get; set; }

        /// <summary>
        /// <p>Exclude Cluster ID</p>
        /// </summary>
        [JsonProperty("ExcludeClusterIDs")]
        public string[] ExcludeClusterIDs{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>Instance ID exclusion</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIds")]
        public string[] ExcludeInstanceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AILinkEnable", this.AILinkEnable);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "RuleScopeDeep", this.RuleScopeDeep);
            this.SetParamSimple(map, prefix + "RuleScopeBalanced", this.RuleScopeBalanced);
            this.SetParamSimple(map, prefix + "RuleScopePrecise", this.RuleScopePrecise);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
            this.SetParamArraySimple(map, prefix + "ExcludeQuuids.", this.ExcludeQuuids);
            this.SetParamSimple(map, prefix + "AutoInclude", this.AutoInclude);
            this.SetParamArraySimple(map, prefix + "TagIDs.", this.TagIDs);
            this.SetParamSimple(map, prefix + "TCSSScope", this.TCSSScope);
            this.SetParamArraySimple(map, prefix + "ClusterIDs.", this.ClusterIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeClusterIDs.", this.ExcludeClusterIDs);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "ExcludeInstanceIds.", this.ExcludeInstanceIds);
        }
    }
}

