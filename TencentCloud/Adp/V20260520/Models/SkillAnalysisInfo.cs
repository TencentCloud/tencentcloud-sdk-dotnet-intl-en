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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillAnalysisInfo : AbstractModel
    {
        
        /// <summary>
        /// Safety detection status
        /// 
        /// Enumeration values:
        /// | uint | Description |
        /// | --- | --- |
        /// | 0 | To be checked |
        /// | 1 | detecting |
        /// | 2 | Available |
        /// | 3 | Unavailable |
        /// | 4 | Detection failed |
        /// </summary>
        [JsonProperty("AnalysisStatus")]
        public long? AnalysisStatus{ get; set; }

        /// <summary>
        /// Risk description
        /// </summary>
        [JsonProperty("RiskDescription")]
        public string RiskDescription{ get; set; }

        /// <summary>
        /// Risk level
        /// 
        /// Enumeration values:
        /// | uint | Description |
        /// | --- | --- |
        /// | 0 | risk-free |
        /// | 1 | Low risk |
        /// | 2 | Medium-risk |
        /// | 3 | High-risk |
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// Security report redirection url
        /// </summary>
        [JsonProperty("SecurityReportUrl")]
        public string SecurityReportUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AnalysisStatus", this.AnalysisStatus);
            this.SetParamSimple(map, prefix + "RiskDescription", this.RiskDescription);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "SecurityReportUrl", this.SecurityReportUrl);
        }
    }
}

