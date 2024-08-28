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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileTamperRuleDetail : AbstractModel
    {
        
        /// <summary>
        /// Rule name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Status. 0: Enabled; 1: Disabled
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Rule
        /// </summary>
        [JsonProperty("Rule")]
        public FileTamperRule[] Rule{ get; set; }

        /// <summary>
        /// Effective Host UUID. Empty means all hosts, and returned number of entries can be controlled through parameters.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uuids")]
        public string[] Uuids{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Global Rule or Not (No by Default). 0: No; 1: Yes
        /// </summary>
        [JsonProperty("IsGlobal")]
        public ulong? IsGlobal{ get; set; }

        /// <summary>
        /// Risk Level. 0: None; 1: High-Risk; 2: Medium-Risk; 3: Low-Risk
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// Total Number of Effective Hosts
        /// </summary>
        [JsonProperty("UuidTotalCount")]
        public ulong? UuidTotalCount{ get; set; }

        /// <summary>
        /// Allowlisted processing type
        /// <li>cur: add the current items to the allowlist</li>
        /// <li>all: add all items that meet the conditions to the allowlist</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AddWhiteType")]
        public string AddWhiteType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Rule.", this.Rule);
            this.SetParamArraySimple(map, prefix + "Uuids.", this.Uuids);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "UuidTotalCount", this.UuidTotalCount);
            this.SetParamSimple(map, prefix + "AddWhiteType", this.AddWhiteType);
        }
    }
}

