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
        /// Obsolete
        /// </summary>
        [JsonProperty("From")]
        public ulong? From{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Descript")]
        public string Descript{ get; set; }

        /// <summary>
        /// Obsolete
        /// </summary>
        [JsonProperty("PublishTimeWisteria")]
        public string PublishTimeWisteria{ get; set; }

        /// <summary>
        /// Obsolete
        /// </summary>
        [JsonProperty("NameWisteria")]
        public string NameWisteria{ get; set; }

        /// <summary>
        /// Obsolete
        /// </summary>
        [JsonProperty("DescriptWisteria")]
        public string DescriptWisteria{ get; set; }

        /// <summary>
        /// Event status after aggregation
        /// </summary>
        [JsonProperty("StatusStr")]
        public string StatusStr{ get; set; }

        /// <summary>
        /// CVE ID
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// CVSS score
        /// </summary>
        [JsonProperty("CvssScore")]
        public float? CvssScore{ get; set; }

        /// <summary>
        /// Vulnerability Tags, Separated by Multiple Commas
        /// 
        /// EXP exists
        /// Wild Attacks: KNOWN_EXPLOITED
        /// LOCAL: Local use
        /// Mandatory vulnerabilities: NEED_FIX
        /// RemoteExploit:NETWORK
        /// POC exists: POC
        /// System RESTART
        /// </summary>
        [JsonProperty("Labels")]
        public string Labels{ get; set; }

        /// <summary>
        /// Whether automatic fixing is supported and hosts that support automatic fixing, 0=No 1=Yes
        /// </summary>
        [JsonProperty("FixSwitch")]
        public ulong? FixSwitch{ get; set; }

        /// <summary>
        /// id of the last scan task
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// Support defense, 0: no support 1: support
        /// </summary>
        [JsonProperty("IsSupportDefense")]
        public ulong? IsSupportDefense{ get; set; }

        /// <summary>
        /// Number of Attacks Defended
        /// </summary>
        [JsonProperty("DefenseAttackCount")]
        public ulong? DefenseAttackCount{ get; set; }

        /// <summary>
        /// first occurrence time
        /// </summary>
        [JsonProperty("FirstAppearTime")]
        public string FirstAppearTime{ get; set; }

        /// <summary>
        /// Vulnerability Category 1: web-cms Vulnerability 2: Application Vulnerability 4: Linux Software Vulnerability 5: Windows System Vulnerability
        /// </summary>
        [JsonProperty("VulCategory")]
        public ulong? VulCategory{ get; set; }

        /// <summary>
        /// Attack intensity level.
        /// </summary>
        [JsonProperty("AttackLevel")]
        public ulong? AttackLevel{ get; set; }

        /// <summary>
        /// Whether a restart is required after vulnerability repair.
        /// </summary>
        [JsonProperty("FixNoNeedRestart")]
        public bool? FixNoNeedRestart{ get; set; }

        /// <summary>
        /// Detection method. 0: version comparison, 1: POC verification.
        /// </summary>
        [JsonProperty("Method")]
        public ulong? Method{ get; set; }

        /// <summary>
        /// Whether vulnerability fixing is supported. 0: not supported; 1: supported.
        /// </summary>
        [JsonProperty("VulFixSwitch")]
        public ulong? VulFixSwitch{ get; set; }

        /// <summary>
        /// Latest remediation time
        /// </summary>
        [JsonProperty("LatestFixTime")]
        public string LatestFixTime{ get; set; }

        /// <summary>
        /// Number of application protection activations for machines with vulnerability correspondence
        /// </summary>
        [JsonProperty("RaspOpenNodeCount")]
        public long? RaspOpenNodeCount{ get; set; }

        /// <summary>
        /// Number of application protection deactivations for machines with vulnerability correspondence
        /// </summary>
        [JsonProperty("RaspClosedNodeCount")]
        public long? RaspClosedNodeCount{ get; set; }


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
            this.SetParamSimple(map, prefix + "VulFixSwitch", this.VulFixSwitch);
            this.SetParamSimple(map, prefix + "LatestFixTime", this.LatestFixTime);
            this.SetParamSimple(map, prefix + "RaspOpenNodeCount", this.RaspOpenNodeCount);
            this.SetParamSimple(map, prefix + "RaspClosedNodeCount", this.RaspClosedNodeCount);
        }
    }
}

