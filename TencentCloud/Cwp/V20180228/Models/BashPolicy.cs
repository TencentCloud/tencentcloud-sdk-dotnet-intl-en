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

    public class BashPolicy : AbstractModel
    {
        
        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 1: valid; 0: invalid
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 0: blocklist; 1: allowlist
        /// </summary>
        [JsonProperty("White")]
        public long? White{ get; set; }

        /// <summary>
        /// 0: alarm; 1: allowlist; 2: intercept
        /// </summary>
        [JsonProperty("BashAction")]
        public long? BashAction{ get; set; }

        /// <summary>
        /// Regular expression
        /// </summary>
        [JsonProperty("Rule")]
        public string Rule{ get; set; }

        /// <summary>
        /// Risk level (0: none; 1: high-risk; 2: medium-risk; 3: low-risk)
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// Effective scope (0: a group of QUUID; 1: all professional editions (including ultimate edition); 2: all ultimate editions; 3: all hosts)
        /// </summary>
        [JsonProperty("Scope")]
        public long? Scope{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Policy description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Descript")]
        public string Descript{ get; set; }

        /// <summary>
        /// When it is added to the allowlist, the EventId needs to be passed in.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// Whether to process old events as allowlisted ones: 0 - no; 1 - yes
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DealOldEvents")]
        public long? DealOldEvents{ get; set; }

        /// <summary>
        /// A collection of QUUIDs for effective hosts
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }

        /// <summary>
        /// Policy type: 0 - system; 1 - user
        /// </summary>
        [JsonProperty("Category")]
        public long? Category{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Modification time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Compatibility with older versions may be needed.
        /// </summary>
        [JsonProperty("Uuids")]
        public string[] Uuids{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "White", this.White);
            this.SetParamSimple(map, prefix + "BashAction", this.BashAction);
            this.SetParamSimple(map, prefix + "Rule", this.Rule);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Descript", this.Descript);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "DealOldEvents", this.DealOldEvents);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamArraySimple(map, prefix + "Uuids.", this.Uuids);
        }
    }
}

