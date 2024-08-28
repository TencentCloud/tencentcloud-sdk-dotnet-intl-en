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

    public class EmergencyVul : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// Vulnerability level
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// Release date
        /// </summary>
        [JsonProperty("PublishDate")]
        public string PublishDate{ get; set; }

        /// <summary>
        /// Vulnerability category
        /// </summary>
        [JsonProperty("Category")]
        public ulong? Category{ get; set; }

        /// <summary>
        /// Vulnerability status. 0: not detected; 1: at risk; 2: not at risk; 3: show progress during check
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Last scan time
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// Scan progress
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// CVE ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// CVSS score
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CvssScore")]
        public float? CvssScore{ get; set; }

        /// <summary>
        /// Vulnerability Tags, Separated by Multiple Commas
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Labels")]
        public string Labels{ get; set; }

        /// <summary>
        /// Number of affected machines
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostCount")]
        public ulong? HostCount{ get; set; }

        /// <summary>
        /// Whether to support defense: 0: no; 1: yes
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsSupportDefense")]
        public ulong? IsSupportDefense{ get; set; }

        /// <summary>
        /// Number of Attacks Defended
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefenseAttackCount")]
        public ulong? DefenseAttackCount{ get; set; }

        /// <summary>
        /// Detection rule: 0: version comparison; 1: POC verification
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Method")]
        public ulong? Method{ get; set; }

        /// <summary>
        /// Attack intensity level
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AttackLevel")]
        public ulong? AttackLevel{ get; set; }

        /// <summary>
        /// Whether vulnerability defense is enabled on hosts with vulnerabilities
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefenseState")]
        public bool? DefenseState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "PublishDate", this.PublishDate);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "CvssScore", this.CvssScore);
            this.SetParamSimple(map, prefix + "Labels", this.Labels);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "IsSupportDefense", this.IsSupportDefense);
            this.SetParamSimple(map, prefix + "DefenseAttackCount", this.DefenseAttackCount);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "AttackLevel", this.AttackLevel);
            this.SetParamSimple(map, prefix + "DefenseState", this.DefenseState);
        }
    }
}

