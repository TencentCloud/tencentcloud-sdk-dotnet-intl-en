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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulIgnoreRule : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability rule ID.
        /// </summary>
        [JsonProperty("VulID")]
        public ulong? VulID{ get; set; }

        /// <summary>
        /// <li>0: all hosts</li>
        /// <li>1: Optional host</li>
        /// </summary>
        [JsonProperty("AssetScopeType")]
        public ulong? AssetScopeType{ get; set; }

        /// <summary>
        /// List of QUUIDs for custom-selected hosts when custom hosts are used.
        /// </summary>
        [JsonProperty("IncludeQuuidList")]
        public string[] IncludeQuuidList{ get; set; }

        /// <summary>
        /// Hosts excluded when all hosts are selected.
        /// </summary>
        [JsonProperty("ExcludeQuuidList")]
        public string[] ExcludeQuuidList{ get; set; }

        /// <summary>
        /// Reason for ignoring.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Number of configured hosts.
        /// </summary>
        [JsonProperty("ConfigHostCount")]
        public ulong? ConfigHostCount{ get; set; }

        /// <summary>
        /// Number of hosts actually affected.
        /// </summary>
        [JsonProperty("AffectedHostCount")]
        public ulong? AffectedHostCount{ get; set; }

        /// <summary>
        /// Vulnerability name.
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// Ignore rule ID.
        /// </summary>
        [JsonProperty("RuleID")]
        public ulong? RuleID{ get; set; }

        /// <summary>
        /// Latest update time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulID", this.VulID);
            this.SetParamSimple(map, prefix + "AssetScopeType", this.AssetScopeType);
            this.SetParamArraySimple(map, prefix + "IncludeQuuidList.", this.IncludeQuuidList);
            this.SetParamArraySimple(map, prefix + "ExcludeQuuidList.", this.ExcludeQuuidList);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ConfigHostCount", this.ConfigHostCount);
            this.SetParamSimple(map, prefix + "AffectedHostCount", this.AffectedHostCount);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

