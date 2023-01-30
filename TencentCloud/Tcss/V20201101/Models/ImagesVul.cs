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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImagesVul : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Component
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Category
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// Category 2
        /// </summary>
        [JsonProperty("CategoryType")]
        public string CategoryType{ get; set; }

        /// <summary>
        /// Risk level
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Des")]
        public string Des{ get; set; }

        /// <summary>
        /// Solution
        /// </summary>
        [JsonProperty("OfficialSolution")]
        public string OfficialSolution{ get; set; }

        /// <summary>
        /// Reference
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }

        /// <summary>
        /// Defense solution
        /// </summary>
        [JsonProperty("DefenseSolution")]
        public string DefenseSolution{ get; set; }

        /// <summary>
        /// Submission time
        /// </summary>
        [JsonProperty("SubmitTime")]
        public string SubmitTime{ get; set; }

        /// <summary>
        /// CVSS V3 score
        /// </summary>
        [JsonProperty("CVSSV3Score")]
        public float? CVSSV3Score{ get; set; }

        /// <summary>
        /// CVSS V3 description
        /// </summary>
        [JsonProperty("CVSSV3Desc")]
        public string CVSSV3Desc{ get; set; }

        /// <summary>
        /// Whether it is of high priority. Valid values: `true` (yes); `false` (no).
        /// </summary>
        [JsonProperty("IsSuggest")]
        public bool? IsSuggest{ get; set; }

        /// <summary>
        /// Number of the fixed version
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FixedVersions")]
        public string FixedVersions{ get; set; }

        /// <summary>
        /// Vulnerability tag. Valid values: `CanBeFixed`, `DynamicLevelPoc`, `DynamicLevelExp`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tag")]
        public string[] Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "CategoryType", this.CategoryType);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Des", this.Des);
            this.SetParamSimple(map, prefix + "OfficialSolution", this.OfficialSolution);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
            this.SetParamSimple(map, prefix + "DefenseSolution", this.DefenseSolution);
            this.SetParamSimple(map, prefix + "SubmitTime", this.SubmitTime);
            this.SetParamSimple(map, prefix + "CVSSV3Score", this.CVSSV3Score);
            this.SetParamSimple(map, prefix + "CVSSV3Desc", this.CVSSV3Desc);
            this.SetParamSimple(map, prefix + "IsSuggest", this.IsSuggest);
            this.SetParamSimple(map, prefix + "FixedVersions", this.FixedVersions);
            this.SetParamArraySimple(map, prefix + "Tag.", this.Tag);
        }
    }
}

