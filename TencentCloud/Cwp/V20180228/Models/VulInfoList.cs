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

    public class VulInfoList : AbstractModel
    {
        
        /// <summary>
        /// IDs of events corresponding to a vulnerability, separated by commas (,)
        /// </summary>
        [JsonProperty("Ids")]
        public string Ids{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 0: pending; 1: ignored; 3: fixed; 5: detecting; 6: fixing; 8: fixing failed
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// Vulnerability disclosure time
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// Last detection time
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// Number of affected hosts
        /// </summary>
        [JsonProperty("HostCount")]
        public ulong? HostCount{ get; set; }

        /// <summary>
        /// Vulnerability level. 1: low-risk; 2: medium-risk; 3: high-risk; 4: critical.
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// This field has been deprecated.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("From")]
        public ulong? From{ get; set; }

        /// <summary>
        /// Description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Descript")]
        public string Descript{ get; set; }

        /// <summary>
        /// This field has been deprecated.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublishTimeWisteria")]
        public string PublishTimeWisteria{ get; set; }

        /// <summary>
        /// This field has been deprecated.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NameWisteria")]
        public string NameWisteria{ get; set; }

        /// <summary>
        /// This field has been deprecated.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DescriptWisteria")]
        public string DescriptWisteria{ get; set; }

        /// <summary>
        /// Event status after aggregation
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusStr")]
        public string StatusStr{ get; set; }

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
        /// Vulnerability tags, separated by multiple commas
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Labels")]
        public string Labels{ get; set; }

        /// <summary>
        /// Whether automatic fixing is supported and hosts that support automatic fixing are included. 0: no; 1: yes.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FixSwitch")]
        public ulong? FixSwitch{ get; set; }

        /// <summary>
        /// ID of the last scan task
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// Whether defense is supported. 0: not supported; 1: supported.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsSupportDefense")]
        public ulong? IsSupportDefense{ get; set; }

        /// <summary>
        /// Number of attacks defended
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefenseAttackCount")]
        public ulong? DefenseAttackCount{ get; set; }

        /// <summary>
        /// First occurrence time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FirstAppearTime")]
        public string FirstAppearTime{ get; set; }

        /// <summary>
        /// Vulnerability category. 1: web CMS vulnerability; 2: application vulnerability; 4: Linux software vulnerability; 5: Windows system vulnerability.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulCategory")]
        public ulong? VulCategory{ get; set; }

        /// <summary>
        /// Attack intensity
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AttackLevel")]
        public ulong? AttackLevel{ get; set; }

        /// <summary>
        /// Whether a restart is required after the vulnerability is fixed
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FixNoNeedRestart")]
        public bool? FixNoNeedRestart{ get; set; }

        /// <summary>
        /// Detection method. 0: version comparison; 1: POC verification.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Method")]
        public ulong? Method{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ids", this.Ids);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "Descript", this.Descript);
            this.SetParamSimple(map, prefix + "PublishTimeWisteria", this.PublishTimeWisteria);
            this.SetParamSimple(map, prefix + "NameWisteria", this.NameWisteria);
            this.SetParamSimple(map, prefix + "DescriptWisteria", this.DescriptWisteria);
            this.SetParamSimple(map, prefix + "StatusStr", this.StatusStr);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "CvssScore", this.CvssScore);
            this.SetParamSimple(map, prefix + "Labels", this.Labels);
            this.SetParamSimple(map, prefix + "FixSwitch", this.FixSwitch);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "IsSupportDefense", this.IsSupportDefense);
            this.SetParamSimple(map, prefix + "DefenseAttackCount", this.DefenseAttackCount);
            this.SetParamSimple(map, prefix + "FirstAppearTime", this.FirstAppearTime);
            this.SetParamSimple(map, prefix + "VulCategory", this.VulCategory);
            this.SetParamSimple(map, prefix + "AttackLevel", this.AttackLevel);
            this.SetParamSimple(map, prefix + "FixNoNeedRestart", this.FixNoNeedRestart);
            this.SetParamSimple(map, prefix + "Method", this.Method);
        }
    }
}

