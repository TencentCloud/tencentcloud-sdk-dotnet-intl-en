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

    public class VulHostBriefInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Cloud host instance ID<br>Parameter format: such as ins-xxxxxxxx</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>Host name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Public network IP address</p>
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// <p>Private IP address</p>
        /// </summary>
        [JsonProperty("PrivateIP")]
        public string PrivateIP{ get; set; }

        /// <summary>
        /// <p>Protection edition<br>Enumeration value:<br>NONE: No protection<br>BASIC: Basic version<br>PRO: Pro edition<br>ULTIMATE: Flagship edition<br>PRO_LH: Lightweight edition</p>
        /// </summary>
        [JsonProperty("DefendVersion")]
        public string DefendVersion{ get; set; }

        /// <summary>
        /// <p>Vulnerability defense status<br>Enumeration value:<br>ENABLED: Enabled<br>NOT_SUPPORTED: Unsupported<br>NOT_ENABLED: Not enabled</p>
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }

        /// <summary>
        /// <p>Associated account information</p>
        /// </summary>
        [JsonProperty("Account")]
        public AccountBriefInfo Account{ get; set; }

        /// <summary>
        /// <p>Cloud host instance status<br>Enumeration value:<br>RUNNING: running<br>STOPPED: stopped<br>UNKNOWN: unknown</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>Remediation status enumeration values.</p><p>Enumeration values: </p><ul><li>PENDING: To be fixed, </li><li>SCANNING: Scan in progress, </li><li>FIXED: Fixed, </li><li>IGNORED: Ignored, </li><li>FIXING: In remediation, </li><li>FIX_FAILED: Fix failure, </li><li>NEED_REBOOT: Pending restart.</li></ul>
        /// </summary>
        [JsonProperty("RiskStatus")]
        public string RiskStatus{ get; set; }

        /// <summary>
        /// <p>VPR rating information (including rating result and details in each dimension)</p>
        /// </summary>
        [JsonProperty("VPRRating")]
        public VPRRatingInfo VPRRating{ get; set; }

        /// <summary>
        /// <p>CWP Agent status<br>Enumeration value:<br>ONLINE: Online<br>OFFLINE: Offline<br>UNINSTALLED: Not installed</p>
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// <p>Asset tag list (CSIP internal asset tag)</p>
        /// </summary>
        [JsonProperty("TagItem")]
        public MiniTagItem[] TagItem{ get; set; }

        /// <summary>
        /// <p>Cloud tag list (cloud asset side Tag)</p>
        /// </summary>
        [JsonProperty("CloudTag")]
        public Tag[] CloudTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "PrivateIP", this.PrivateIP);
            this.SetParamSimple(map, prefix + "DefendVersion", this.DefendVersion);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamObj(map, prefix + "Account.", this.Account);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "RiskStatus", this.RiskStatus);
            this.SetParamObj(map, prefix + "VPRRating.", this.VPRRating);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamArrayObj(map, prefix + "TagItem.", this.TagItem);
            this.SetParamArrayObj(map, prefix + "CloudTag.", this.CloudTag);
        }
    }
}

