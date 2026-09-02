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

    public class ImageVulBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Affected component information</p>
        /// </summary>
        [JsonProperty("AffectedComponents")]
        public VulAffectedComponent[] AffectedComponents{ get; set; }

        /// <summary>
        /// <p>Vulnerability name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Vulnerability CVEID</p>
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// <p>Vulnerability category</p>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>Vulnerability release time</p>
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// <p>Vulnerability detection method</p>
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// <p>Whether the defense is supported</p><p>Enumeration value:</p><ul><li>ENABLED: support defense</li><li>NOT_ENABLED: defense not supported</li></ul>
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }

        /// <summary>
        /// <p>Whether repair is supported</p>
        /// </summary>
        [JsonProperty("SupportFix")]
        public bool? SupportFix{ get; set; }

        /// <summary>
        /// <p>CVSS score</p>
        /// </summary>
        [JsonProperty("CvssScore")]
        public string CvssScore{ get; set; }

        /// <summary>
        /// <p>Vulnerability severity description</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Vulnerability description</p>
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// <p>Severity level</p>
        /// </summary>
        [JsonProperty("CVSSLevel")]
        public string CVSSLevel{ get; set; }

        /// <summary>
        /// <p>Primary impact type</p>
        /// </summary>
        [JsonProperty("VulAffect")]
        public string VulAffect{ get; set; }

        /// <summary>
        /// <p>Existence of exploitation in the wild</p>
        /// </summary>
        [JsonProperty("KVERecord")]
        public bool? KVERecord{ get; set; }

        /// <summary>
        /// <p>EPSS probability score</p>
        /// </summary>
        [JsonProperty("EPSSScore")]
        public float? EPSSScore{ get; set; }

        /// <summary>
        /// <p>Impacted manufacturer</p>
        /// </summary>
        [JsonProperty("AffectVendor")]
        public string AffectVendor{ get; set; }

        /// <summary>
        /// <p>Impact on the target product</p>
        /// </summary>
        [JsonProperty("AffectProduct")]
        public string AffectProduct{ get; set; }

        /// <summary>
        /// <p>Vulnerability principle</p>
        /// </summary>
        [JsonProperty("Mechanism")]
        public string Mechanism{ get; set; }

        /// <summary>
        /// <p>Prerequisites for an attack</p>
        /// </summary>
        [JsonProperty("Precondition")]
        public string Precondition{ get; set; }

        /// <summary>
        /// <p>Vulnerability remediation suggestions</p>
        /// </summary>
        [JsonProperty("FixSolution")]
        public string FixSolution{ get; set; }

        /// <summary>
        /// <p>Vulnerability-related link</p>
        /// </summary>
        [JsonProperty("RefLink")]
        public string RefLink{ get; set; }

        /// <summary>
        /// <p>Vulnerability tag</p>
        /// </summary>
        [JsonProperty("Label")]
        public string[] Label{ get; set; }

        /// <summary>
        /// <p>Vulnerability Id</p>
        /// </summary>
        [JsonProperty("PocId")]
        public string PocId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "AffectedComponents.", this.AffectedComponents);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "CheckMethod", this.CheckMethod);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamSimple(map, prefix + "SupportFix", this.SupportFix);
            this.SetParamSimple(map, prefix + "CvssScore", this.CvssScore);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamSimple(map, prefix + "CVSSLevel", this.CVSSLevel);
            this.SetParamSimple(map, prefix + "VulAffect", this.VulAffect);
            this.SetParamSimple(map, prefix + "KVERecord", this.KVERecord);
            this.SetParamSimple(map, prefix + "EPSSScore", this.EPSSScore);
            this.SetParamSimple(map, prefix + "AffectVendor", this.AffectVendor);
            this.SetParamSimple(map, prefix + "AffectProduct", this.AffectProduct);
            this.SetParamSimple(map, prefix + "Mechanism", this.Mechanism);
            this.SetParamSimple(map, prefix + "Precondition", this.Precondition);
            this.SetParamSimple(map, prefix + "FixSolution", this.FixSolution);
            this.SetParamSimple(map, prefix + "RefLink", this.RefLink);
            this.SetParamArraySimple(map, prefix + "Label.", this.Label);
            this.SetParamSimple(map, prefix + "PocId", this.PocId);
        }
    }
}

