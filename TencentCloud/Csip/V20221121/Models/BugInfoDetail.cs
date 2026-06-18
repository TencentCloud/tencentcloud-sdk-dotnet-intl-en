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

    public class BugInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// PocId Corresponding to Vulnerability
        /// </summary>
        [JsonProperty("PatchId")]
        public string PatchId{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VULName")]
        public string VULName{ get; set; }

        /// <summary>
        /// Vulnerability Severity: High, Middle, Low, Info.
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// CVSS Score
        /// </summary>
        [JsonProperty("CVSSScore")]
        public string CVSSScore{ get; set; }

        /// <summary>
        /// CVE ID
        /// </summary>
        [JsonProperty("CVEId")]
        public string CVEId{ get; set; }

        /// <summary>
        /// Vulnerability tag
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// Vulnerability Type. 1: Web Application; 2: System Component Vulnerabilities; 3: Configuration Risk.
        /// </summary>
        [JsonProperty("VULCategory")]
        public ulong? VULCategory{ get; set; }

        /// <summary>
        /// Vulnerability Affected System
        /// </summary>
        [JsonProperty("ImpactOs")]
        public string ImpactOs{ get; set; }

        /// <summary>
        /// Affected component
        /// </summary>
        [JsonProperty("ImpactCOMPENT")]
        public string ImpactCOMPENT{ get; set; }

        /// <summary>
        /// Vulnerability Affected Version
        /// </summary>
        [JsonProperty("ImpactVersion")]
        public string ImpactVersion{ get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }

        /// <summary>
        /// Vulnerability description
        /// </summary>
        [JsonProperty("VULDescribe")]
        public string VULDescribe{ get; set; }

        /// <summary>
        /// Fixing suggestion
        /// </summary>
        [JsonProperty("Fix")]
        public string Fix{ get; set; }

        /// <summary>
        /// Product Support Status, returned in real time.
        /// </summary>
        [JsonProperty("ProSupport")]
        public ulong? ProSupport{ get; set; }

        /// <summary>
        /// Published or Not. 0 for No, 1 for Yes.
        /// </summary>
        [JsonProperty("IsPublish")]
        public ulong? IsPublish{ get; set; }

        /// <summary>
        /// Release time.
        /// </summary>
        [JsonProperty("ReleaseTime")]
        public string ReleaseTime{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Vulnerability Subcategory
        /// </summary>
        [JsonProperty("SubCategory")]
        public string SubCategory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "PatchId", this.PatchId);
            this.SetParamSimple(map, prefix + "VULName", this.VULName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "CVSSScore", this.CVSSScore);
            this.SetParamSimple(map, prefix + "CVEId", this.CVEId);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "VULCategory", this.VULCategory);
            this.SetParamSimple(map, prefix + "ImpactOs", this.ImpactOs);
            this.SetParamSimple(map, prefix + "ImpactCOMPENT", this.ImpactCOMPENT);
            this.SetParamSimple(map, prefix + "ImpactVersion", this.ImpactVersion);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
            this.SetParamSimple(map, prefix + "VULDescribe", this.VULDescribe);
            this.SetParamSimple(map, prefix + "Fix", this.Fix);
            this.SetParamSimple(map, prefix + "ProSupport", this.ProSupport);
            this.SetParamSimple(map, prefix + "IsPublish", this.IsPublish);
            this.SetParamSimple(map, prefix + "ReleaseTime", this.ReleaseTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "SubCategory", this.SubCategory);
        }
    }
}

