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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageVul : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// viewpoint validation program ID
        /// </summary>
        [JsonProperty("POCID")]
        public string POCID{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Component Information
        /// </summary>
        [JsonProperty("Components")]
        public ComponentsInfo[] Components{ get; set; }

        /// <summary>
        /// category
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
        public string Level{ get; set; }

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
        /// Refer
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }

        /// <summary>
        /// defense solution
        /// </summary>
        [JsonProperty("DefenseSolution")]
        public string DefenseSolution{ get; set; }

        /// <summary>
        /// Submission time
        /// </summary>
        [JsonProperty("SubmitTime")]
        public string SubmitTime{ get; set; }

        /// <summary>
        /// CVSS Score
        /// </summary>
        [JsonProperty("CvssScore")]
        public string CvssScore{ get; set; }

        /// <summary>
        /// CVSS information.
        /// </summary>
        [JsonProperty("CvssVector")]
        public string CvssVector{ get; set; }

        /// <summary>
        /// Whether repair is suggested.
        /// </summary>
        [JsonProperty("IsSuggest")]
        public string IsSuggest{ get; set; }

        /// <summary>
        /// Repair Version Number
        /// </summary>
        [JsonProperty("FixedVersions")]
        public string FixedVersions{ get; set; }

        /// <summary>
        /// Vulnerability Tag: "CanBeFixed", "DynamicLevelPoc", and "DynamicLevelExp"
        /// </summary>
        [JsonProperty("Tag")]
        public string[] Tag{ get; set; }

        /// <summary>
        /// Component name.
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// Component version
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Attack Heat 0-3
        /// </summary>
        [JsonProperty("AttackLevel")]
        public long? AttackLevel{ get; set; }

        /// <summary>
        /// Image Layer Information List
        /// </summary>
        [JsonProperty("LayerInfos")]
        public ImageVulLayerInfo[] LayerInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "POCID", this.POCID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Components.", this.Components);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "CategoryType", this.CategoryType);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Des", this.Des);
            this.SetParamSimple(map, prefix + "OfficialSolution", this.OfficialSolution);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
            this.SetParamSimple(map, prefix + "DefenseSolution", this.DefenseSolution);
            this.SetParamSimple(map, prefix + "SubmitTime", this.SubmitTime);
            this.SetParamSimple(map, prefix + "CvssScore", this.CvssScore);
            this.SetParamSimple(map, prefix + "CvssVector", this.CvssVector);
            this.SetParamSimple(map, prefix + "IsSuggest", this.IsSuggest);
            this.SetParamSimple(map, prefix + "FixedVersions", this.FixedVersions);
            this.SetParamArraySimple(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "AttackLevel", this.AttackLevel);
            this.SetParamArrayObj(map, prefix + "LayerInfos.", this.LayerInfos);
        }
    }
}

