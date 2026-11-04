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

    public class SkillVersion : AbstractModel
    {
        
        /// <summary>
        /// <p>Detection information</p>
        /// </summary>
        [JsonProperty("AnalysisInfo")]
        public SkillAnalysisInfo AnalysisInfo{ get; set; }

        /// <summary>
        /// <p>Current effective version number.</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>Current effective version ID</p>
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// <p>Skill version RELEASE process status:</p><pre><code>  - 0 INITIALIZED      initialization (initial version state)  - 1 AUDITING         under review (f_analysis_status ∈ {PENDING, RUNNING})  - 2 PENDING_RELEASE  awaiting RELEASE (low/medium-risk, waiting for user confirmation to publish)  - 3 RELEASED         RELEASED  - 4 UNRELEASED       not RELEASED (HIGH / UNAVAILABLE / FAILED / user give up, including the semantics of historical "not approved")Decoupled from SkillAnalysisStatus: the former is the RELEASE lifecycle from the user perspective, while the latter is the security detection stage.</code></pre>
        /// </summary>
        [JsonProperty("VersionStatus")]
        public long? VersionStatus{ get; set; }

        /// <summary>
        /// <p>md5 information of the Skill package</p>
        /// </summary>
        [JsonProperty("SkillMd5")]
        public string SkillMd5{ get; set; }

        /// <summary>
        /// <p>Version package address</p>
        /// </summary>
        [JsonProperty("SkillUrl")]
        public string SkillUrl{ get; set; }

        /// <summary>
        /// <p>Version creation time (Unix seconds).</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>skill md document</p>
        /// </summary>
        [JsonProperty("SkillMarkdownUrl")]
        public string SkillMarkdownUrl{ get; set; }

        /// <summary>
        /// <p>Version change description</p>
        /// </summary>
        [JsonProperty("UpdateDesc")]
        public string UpdateDesc{ get; set; }

        /// <summary>
        /// <p>Change user.</p>
        /// </summary>
        [JsonProperty("Updater")]
        public string Updater{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AnalysisInfo.", this.AnalysisInfo);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "VersionStatus", this.VersionStatus);
            this.SetParamSimple(map, prefix + "SkillMd5", this.SkillMd5);
            this.SetParamSimple(map, prefix + "SkillUrl", this.SkillUrl);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SkillMarkdownUrl", this.SkillMarkdownUrl);
            this.SetParamSimple(map, prefix + "UpdateDesc", this.UpdateDesc);
            this.SetParamSimple(map, prefix + "Updater", this.Updater);
        }
    }
}

