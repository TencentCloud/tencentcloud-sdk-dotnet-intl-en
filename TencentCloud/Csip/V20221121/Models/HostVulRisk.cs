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

    public class HostVulRisk : AbstractModel
    {
        
        /// <summary>
        /// <p>Risk record ID (host_vul_risk.id)</p>
        /// </summary>
        [JsonProperty("RiskID")]
        public ulong? RiskID{ get; set; }

        /// <summary>
        /// <p>Number of affected hosts</p>
        /// </summary>
        [JsonProperty("EffectHostCount")]
        public ulong? EffectHostCount{ get; set; }

        /// <summary>
        /// <p>Latest scan time<br>Parameter format: YYYY-MM-DD HH:mm:ss</p>
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// <p>Account list it belongs to</p>
        /// </summary>
        [JsonProperty("Account")]
        public AccountBriefInfo[] Account{ get; set; }

        /// <summary>
        /// <p>Vulnerability defense status<br>Enumeration value:<br>ENABLED: Enabled<br>NOT_SUPPORTED: Unsupported<br>NOT_ENABLED: Not enabled</p>
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }

        /// <summary>
        /// <p>Remediation status<br>Enumeration values:<br>PENDING: to be fixed<br>SCANNING: scan in progress<br>FIXED: fixed<br>IGNORED: whitelisted<br>FIXING: fix<br>FIX_FAILED: FIX_FAILURE<br>NOTSCAN: unscanned<br>WITHOUT_RISK: no risk<br>NEED_REBOOT: pending restart</p>
        /// </summary>
        [JsonProperty("RiskStatus")]
        public string RiskStatus{ get; set; }

        /// <summary>
        /// <p>Vulnerability details</p>
        /// </summary>
        [JsonProperty("VulDetail")]
        public VulDetailInfo VulDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskID", this.RiskID);
            this.SetParamSimple(map, prefix + "EffectHostCount", this.EffectHostCount);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamArrayObj(map, prefix + "Account.", this.Account);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamSimple(map, prefix + "RiskStatus", this.RiskStatus);
            this.SetParamObj(map, prefix + "VulDetail.", this.VulDetail);
        }
    }
}

