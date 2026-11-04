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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillSummary : AbstractModel
    {
        
        /// <summary>
        /// Classification information
        /// </summary>
        [JsonProperty("ClassificationInfo")]
        public SkillClassification ClassificationInfo{ get; set; }

        /// <summary>
        /// Current version information
        /// </summary>
        [JsonProperty("CurrentVersionInfo")]
        public SkillVersion CurrentVersionInfo{ get; set; }

        /// <summary>
        /// Whether the current user collects it
        /// </summary>
        [JsonProperty("IsFavorite")]
        public bool? IsFavorite{ get; set; }

        /// <summary>
        /// Basic information
        /// </summary>
        [JsonProperty("Profile")]
        public SkillProfile Profile{ get; set; }

        /// <summary>
        /// Skill ID
        /// </summary>
        [JsonProperty("SkillId")]
        public string SkillId{ get; set; }

        /// <summary>
        /// Skill exception notification list
        /// </summary>
        [JsonProperty("NoticeList")]
        public SkillNotice[] NoticeList{ get; set; }

        /// <summary>
        /// List of resource operation permission bits of the current user for this Skill. This parameter is fixed as an empty array for built-in or shared skills.
        /// </summary>
        [JsonProperty("PermissionIdList")]
        public string[] PermissionIdList{ get; set; }

        /// <summary>
        /// Share information; there may be two entries, one is shared and the other is under review.
        /// </summary>
        [JsonProperty("ShareList")]
        public SkillShare[] ShareList{ get; set; }

        /// <summary>
        /// Skill status 
        /// 
        /// Enumeration values:
        /// | uint | Description |
        /// | --- | --- |
        /// | 0 | Initialization (no published versions, and the latest version is in INITIALIZED/UNRELEASED) |
        /// Security detection in progress (no published versions, and the latest version is in AUDITING)
        /// | 2 | To be released (no published versions, and the latest version is in PENDING_RELEASE) |
        /// | 3 | Released (any RELEASED version exists, absorbent state) |
        /// </summary>
        [JsonProperty("SkillStatus")]
        public long? SkillStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ClassificationInfo.", this.ClassificationInfo);
            this.SetParamObj(map, prefix + "CurrentVersionInfo.", this.CurrentVersionInfo);
            this.SetParamSimple(map, prefix + "IsFavorite", this.IsFavorite);
            this.SetParamObj(map, prefix + "Profile.", this.Profile);
            this.SetParamSimple(map, prefix + "SkillId", this.SkillId);
            this.SetParamArrayObj(map, prefix + "NoticeList.", this.NoticeList);
            this.SetParamArraySimple(map, prefix + "PermissionIdList.", this.PermissionIdList);
            this.SetParamArrayObj(map, prefix + "ShareList.", this.ShareList);
            this.SetParamSimple(map, prefix + "SkillStatus", this.SkillStatus);
        }
    }
}

