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

    public class VulDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Vulnerability ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>Vulnerability name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>CveID</p>
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// Vulnerability category
        /// Enumeration values:
        /// LINUX: Linux software vulnerability
        /// WINDOWS: Windows systems patch
        /// WEB_CMS: Web-CMS vulnerabilities
        /// APPLICATION: Application vulnerability
        /// EMERGENCY: Urgent vulnerability
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// Vulnerability disclosure time
        /// Parameter format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// <p>Detection mode</p><p>Enumeration value:</p><ul><li>VersionCompare: Version comparison</li><li>POC: POC detection</li></ul>
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// Vulnerability defense status
        /// Enumeration values:
        /// ENABLED: On
        /// NOT_SUPPORTED: Not supported
        /// NOT_ENABLED: not enabled
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }

        /// <summary>
        /// Whether one-click repair is supported
        /// Enumeration values:
        /// true: Support
        /// false: Not supported
        /// </summary>
        [JsonProperty("SupportFix")]
        public bool? SupportFix{ get; set; }

        /// <summary>
        /// VPR rating information (including rating result, description, and phased score)
        /// </summary>
        [JsonProperty("VRPRatingInfo")]
        public VPRRatingInfo VRPRatingInfo{ get; set; }

        /// <summary>
        /// CVSS score
        /// Valid values: [0.0, 10.0]
        /// </summary>
        [JsonProperty("CvssScore")]
        public float? CvssScore{ get; set; }

        /// <summary>
        /// VPR risk tag list (such as exploitation in the wild, EXP available, POC available, public network exposure, no restart required)
        /// </summary>
        [JsonProperty("Label")]
        public VPRLabel[] Label{ get; set; }

        /// <summary>
        /// Vulnerability remark
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Vulnerability overview
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// Number of hosts with vulnerability protection enabled
        /// </summary>
        [JsonProperty("DefendHostCount")]
        public ulong? DefendHostCount{ get; set; }

        /// <summary>
        /// Number of hosts with vulnerability defense disabled
        /// </summary>
        [JsonProperty("NotDefendHostCount")]
        public ulong? NotDefendHostCount{ get; set; }

        /// <summary>
        /// Last scan time
        /// Parameter format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// CVSS severity level
        /// Enumeration values:
        /// INVALID: Invalid
        /// INFO: Notification
        /// LOW: low-risk
        /// MEDIUM: Medium risk
        /// HIGH: High risk
        /// CRITICAL
        /// </summary>
        [JsonProperty("CVSSLevel")]
        public string CVSSLevel{ get; set; }

        /// <summary>
        /// Description list of affected software (each item such as openssl < 1.1.1k)
        /// </summary>
        [JsonProperty("VulAffect")]
        public string[] VulAffect{ get; set; }

        /// <summary>
        /// Whether included in the KVE (Known Vulnerability Exploitation) library
        /// Enumeration values:
        /// true: Recorded
        /// false: Not recorded
        /// </summary>
        [JsonProperty("KVERecord")]
        public bool? KVERecord{ get; set; }

        /// <summary>
        /// KVE collection time
        /// Parameter format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("KVERecordTime")]
        public string KVERecordTime{ get; set; }

        /// <summary>
        /// EPSS score (vulnerability type probability prediction)
        /// Valid values: [0.0, 1.0]
        /// </summary>
        [JsonProperty("EPSSScore")]
        public float? EPSSScore{ get; set; }

        /// <summary>
        /// Affected vendor list
        /// </summary>
        [JsonProperty("AffectVendor")]
        public string[] AffectVendor{ get; set; }

        /// <summary>
        /// List of affected products
        /// </summary>
        [JsonProperty("AffectProduct")]
        public string[] AffectProduct{ get; set; }

        /// <summary>
        /// Vulnerability type mechanism description
        /// </summary>
        [JsonProperty("Mechanism")]
        public string Mechanism{ get; set; }

        /// <summary>
        /// Pre-deployment instructions for vulnerability type
        /// </summary>
        [JsonProperty("Precondition")]
        public string Precondition{ get; set; }

        /// <summary>
        /// Latest vulnerability spread trend data list (by date)
        /// </summary>
        [JsonProperty("LatestTrend")]
        public VulSpreadTrend[] LatestTrend{ get; set; }

        /// <summary>
        /// <p>Solution</p>
        /// </summary>
        [JsonProperty("FixSolution")]
        public string FixSolution{ get; set; }

        /// <summary>
        /// <p>Reference link</p>
        /// </summary>
        [JsonProperty("RefLink")]
        public string RefLink{ get; set; }

        /// <summary>
        /// <p>Vulnerability severity description</p>
        /// </summary>
        [JsonProperty("HarmDescription")]
        public string HarmDescription{ get; set; }

        /// <summary>
        /// <p>Vulnerability Impact product</p>
        /// </summary>
        [JsonProperty("AffectVendorProduct")]
        public VulVendorProduct[] AffectVendorProduct{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "CheckMethod", this.CheckMethod);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamSimple(map, prefix + "SupportFix", this.SupportFix);
            this.SetParamObj(map, prefix + "VRPRatingInfo.", this.VRPRatingInfo);
            this.SetParamSimple(map, prefix + "CvssScore", this.CvssScore);
            this.SetParamArrayObj(map, prefix + "Label.", this.Label);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamSimple(map, prefix + "DefendHostCount", this.DefendHostCount);
            this.SetParamSimple(map, prefix + "NotDefendHostCount", this.NotDefendHostCount);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "CVSSLevel", this.CVSSLevel);
            this.SetParamArraySimple(map, prefix + "VulAffect.", this.VulAffect);
            this.SetParamSimple(map, prefix + "KVERecord", this.KVERecord);
            this.SetParamSimple(map, prefix + "KVERecordTime", this.KVERecordTime);
            this.SetParamSimple(map, prefix + "EPSSScore", this.EPSSScore);
            this.SetParamArraySimple(map, prefix + "AffectVendor.", this.AffectVendor);
            this.SetParamArraySimple(map, prefix + "AffectProduct.", this.AffectProduct);
            this.SetParamSimple(map, prefix + "Mechanism", this.Mechanism);
            this.SetParamSimple(map, prefix + "Precondition", this.Precondition);
            this.SetParamArrayObj(map, prefix + "LatestTrend.", this.LatestTrend);
            this.SetParamSimple(map, prefix + "FixSolution", this.FixSolution);
            this.SetParamSimple(map, prefix + "RefLink", this.RefLink);
            this.SetParamSimple(map, prefix + "HarmDescription", this.HarmDescription);
            this.SetParamArrayObj(map, prefix + "AffectVendorProduct.", this.AffectVendorProduct);
        }
    }
}

