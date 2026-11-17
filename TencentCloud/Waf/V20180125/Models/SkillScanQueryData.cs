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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillScanQueryData : AbstractModel
    {
        
        /// <summary>
        /// <p>Detection status: success (detection completed with results), scanning (detection in progress), not_found (no record), or failed (detection failed)</p><p>Valid values:</p><ul><li>success: detection completed with results</li><li>scanning: detection in progress</li><li>not_found: no record</li><li>failed: detection failed</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Skill name, used for page display, result list presentation, and manual analysis</p>
        /// </summary>
        [JsonProperty("SkillName")]
        public string SkillName{ get; set; }

        /// <summary>
        /// <p>Skill description, usually from Skill metadata or instructions, used to help callers understand the purpose of the Skill</p>
        /// </summary>
        [JsonProperty("SkillDescription")]
        public string SkillDescription{ get; set; }

        /// <summary>
        /// <p>SHA256 hash of the ZIP file, in the format of sha256:hex_digest</p>
        /// </summary>
        [JsonProperty("ContentHash")]
        public string ContentHash{ get; set; }

        /// <summary>
        /// <p>Risk level: malicious, suspicious, or benign</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>Comprehensive handling suggestion field, located at the top level of data, used to provide overall remediation, mitigation, or manual handling suggestions for this detection result</p>
        /// </summary>
        [JsonProperty("Mitigation")]
        public string Mitigation{ get; set; }

        /// <summary>
        /// <p>Security score (0-100, the higher the score, the more secure)</p><p>Value range: [0, 100]</p>
        /// </summary>
        [JsonProperty("SecurityScore")]
        public ulong? SecurityScore{ get; set; }

        /// <summary>
        /// <p>Engine version used for this scan</p>
        /// </summary>
        [JsonProperty("EngineVersion")]
        public ulong? EngineVersion{ get; set; }

        /// <summary>
        /// <p>List of capability tags of the Skill. The fixed external return format is [{id,name}]. This field describes the capability features or applicable scenarios of the Skill, facilitating retrieval, display, or classification by callers. It is not equivalent to risk tags, nor does it indicate risk level or rule hit results. When lang=en, only name is switched to English, and id remains unchanged</p>
        /// </summary>
        [JsonProperty("CapabilityTags")]
        public SkillScanCapabilityTag[] CapabilityTags{ get; set; }

        /// <summary>
        /// <p>Complete set of fusion rule categories. The key is the fusion rule_id (9xxxx), and the value is the risk category name. It contains all fusion rule categories, allowing callers to display category labels without maintaining a local mapping table. When lang=en is passed, English names are returned. This object is a name mapping table and does not express the priority of primary tags</p>
        /// </summary>
        [JsonProperty("RuleCatalog")]
        public SkillRuleCatalogItem[] RuleCatalog{ get; set; }

        /// <summary>
        /// <p>Scan result details, grouped by sub-engine. Each element contains scan_type (engine type) and rule_list (list of hit rules). The rule_id in the rules uses fusion encoding (9xxxx) and can be cross-referenced with rule_catalog. When lang=en is passed, description returns English text</p>
        /// </summary>
        [JsonProperty("ScanItems")]
        public SkillScanItem[] ScanItems{ get; set; }

        /// <summary>
        /// <p>URL of the comprehensive security audit report. Callers can specify the validity period through report_url_expire_hours. If not passed, a URL with a 1-year validity period is returned by default</p>
        /// </summary>
        [JsonProperty("ReportUrl")]
        public string ReportUrl{ get; set; }

        /// <summary>
        /// <p>Scan completion time</p>
        /// </summary>
        [JsonProperty("ScannedAt")]
        public string ScannedAt{ get; set; }

        /// <summary>
        /// <p>Task creation time</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>Failure time</p>
        /// </summary>
        [JsonProperty("FailedAt")]
        public string FailedAt{ get; set; }

        /// <summary>
        /// <p>Description of the failure reason</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SkillName", this.SkillName);
            this.SetParamSimple(map, prefix + "SkillDescription", this.SkillDescription);
            this.SetParamSimple(map, prefix + "ContentHash", this.ContentHash);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Mitigation", this.Mitigation);
            this.SetParamSimple(map, prefix + "SecurityScore", this.SecurityScore);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamArrayObj(map, prefix + "CapabilityTags.", this.CapabilityTags);
            this.SetParamArrayObj(map, prefix + "RuleCatalog.", this.RuleCatalog);
            this.SetParamArrayObj(map, prefix + "ScanItems.", this.ScanItems);
            this.SetParamSimple(map, prefix + "ReportUrl", this.ReportUrl);
            this.SetParamSimple(map, prefix + "ScannedAt", this.ScannedAt);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "FailedAt", this.FailedAt);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

