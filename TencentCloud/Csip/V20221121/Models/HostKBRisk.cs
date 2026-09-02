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

    public class HostKBRisk : AbstractModel
    {
        
        /// <summary>
        /// <p>Risk record ID (kb_risk.id)</p>
        /// </summary>
        [JsonProperty("RiskID")]
        public ulong? RiskID{ get; set; }

        /// <summary>
        /// <p>Windows KB patch detailed information</p>
        /// </summary>
        [JsonProperty("KBDetail")]
        public KBDetail KBDetail{ get; set; }

        /// <summary>
        /// <p>Number of affected hosts.</p>
        /// </summary>
        [JsonProperty("EffectHostCount")]
        public ulong? EffectHostCount{ get; set; }

        /// <summary>
        /// <p>Latest scan time<br>Parameter format: YYYY-MM-DDTHH:mm:ssZ</p>
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// <p>Associated account list</p>
        /// </summary>
        [JsonProperty("Account")]
        public AccountBriefInfo[] Account{ get; set; }

        /// <summary>
        /// <p>Remediation status<br>Enumeration values:<br>PENDING: To be fixed<br>SCANNING: Scan in progress<br>FIXED: Fixed<br>IGNORED: Allowlisted<br>FIXING: In remediation<br>FIX_FAILED: Fix failure</p>
        /// </summary>
        [JsonProperty("RiskStatus")]
        public string RiskStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskID", this.RiskID);
            this.SetParamObj(map, prefix + "KBDetail.", this.KBDetail);
            this.SetParamSimple(map, prefix + "EffectHostCount", this.EffectHostCount);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamArrayObj(map, prefix + "Account.", this.Account);
            this.SetParamSimple(map, prefix + "RiskStatus", this.RiskStatus);
        }
    }
}

