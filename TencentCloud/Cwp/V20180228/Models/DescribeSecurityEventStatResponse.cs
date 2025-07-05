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

    public class DescribeSecurityEventStatResponse : AbstractModel
    {
        
        /// <summary>
        /// Trojan event statistics
        /// </summary>
        [JsonProperty("MalwareStat")]
        public EventStat MalwareStat{ get; set; }

        /// <summary>
        /// Statistics of cross-region log-in events
        /// </summary>
        [JsonProperty("HostLoginStat")]
        public EventStat HostLoginStat{ get; set; }

        /// <summary>
        /// Statistics of brute force cracking events
        /// </summary>
        [JsonProperty("BruteAttackStat")]
        public EventStat BruteAttackStat{ get; set; }

        /// <summary>
        /// Malicious request event statistics
        /// </summary>
        [JsonProperty("MaliciousRequestStat")]
        public EventStat MaliciousRequestStat{ get; set; }

        /// <summary>
        /// Statistics of local privilege escalation events
        /// </summary>
        [JsonProperty("PrivilegeStat")]
        public EventStat PrivilegeStat{ get; set; }

        /// <summary>
        /// Reverse shell event statistics
        /// </summary>
        [JsonProperty("ReverseShellStat")]
        public EventStat ReverseShellStat{ get; set; }

        /// <summary>
        /// Statistics of high-risk command events
        /// </summary>
        [JsonProperty("HighRiskBashStat")]
        public EventStat HighRiskBashStat{ get; set; }

        /// <summary>
        /// Network attack event statistics
        /// </summary>
        [JsonProperty("AttackLogsStat")]
        public EventStat AttackLogsStat{ get; set; }

        /// <summary>
        /// Statistics of high-risk vulnerability events
        /// </summary>
        [JsonProperty("VulHighStat")]
        public EventStat VulHighStat{ get; set; }

        /// <summary>
        /// Statistics of medium-risk vulnerability events
        /// </summary>
        [JsonProperty("VulNormalStat")]
        public EventStat VulNormalStat{ get; set; }

        /// <summary>
        /// Statistics of low-risk vulnerability events
        /// </summary>
        [JsonProperty("VulLowStat")]
        public EventStat VulLowStat{ get; set; }

        /// <summary>
        /// Statistics of high-risk baseline vulnerability events
        /// </summary>
        [JsonProperty("BaselineHighStat")]
        public EventStat BaselineHighStat{ get; set; }

        /// <summary>
        /// Statistics of medium-risk baseline vulnerability events
        /// </summary>
        [JsonProperty("BaselineNormalStat")]
        public EventStat BaselineNormalStat{ get; set; }

        /// <summary>
        /// Statistics of low-risk baseline vulnerability events
        /// </summary>
        [JsonProperty("BaselineLowStat")]
        public EventStat BaselineLowStat{ get; set; }

        /// <summary>
        /// Total number of machines with unfixed security events
        /// </summary>
        [JsonProperty("MachineTotalAffectNum")]
        public ulong? MachineTotalAffectNum{ get; set; }

        /// <summary>
        /// Total number of machines with unfixed intrusion security events
        /// </summary>
        [JsonProperty("InvasionTotalAffectNum")]
        public ulong? InvasionTotalAffectNum{ get; set; }

        /// <summary>
        /// Total number of machines with unfixed vulnerability security events
        /// </summary>
        [JsonProperty("VulTotalAffectNum")]
        public ulong? VulTotalAffectNum{ get; set; }

        /// <summary>
        /// Total number of machines with unfixed baseline security events
        /// </summary>
        [JsonProperty("BaseLineTotalAffectNum")]
        public ulong? BaseLineTotalAffectNum{ get; set; }

        /// <summary>
        /// Total number of machines with unfixed network attack security events
        /// </summary>
        [JsonProperty("CyberAttackTotalAffectNum")]
        public ulong? CyberAttackTotalAffectNum{ get; set; }

        /// <summary>
        /// Critical vulnerability event statistics
        /// </summary>
        [JsonProperty("VulRiskStat")]
        public EventStat VulRiskStat{ get; set; }

        /// <summary>
        /// Statistics of critical baseline vulnerability events
        /// </summary>
        [JsonProperty("BaselineRiskStat")]
        public EventStat BaselineRiskStat{ get; set; }

        /// <summary>
        /// Statistics on the number of vulnerabilities
        /// </summary>
        [JsonProperty("VulStat")]
        public EventStat VulStat{ get; set; }

        /// <summary>
        /// Security score
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MalwareStat.", this.MalwareStat);
            this.SetParamObj(map, prefix + "HostLoginStat.", this.HostLoginStat);
            this.SetParamObj(map, prefix + "BruteAttackStat.", this.BruteAttackStat);
            this.SetParamObj(map, prefix + "MaliciousRequestStat.", this.MaliciousRequestStat);
            this.SetParamObj(map, prefix + "PrivilegeStat.", this.PrivilegeStat);
            this.SetParamObj(map, prefix + "ReverseShellStat.", this.ReverseShellStat);
            this.SetParamObj(map, prefix + "HighRiskBashStat.", this.HighRiskBashStat);
            this.SetParamObj(map, prefix + "AttackLogsStat.", this.AttackLogsStat);
            this.SetParamObj(map, prefix + "VulHighStat.", this.VulHighStat);
            this.SetParamObj(map, prefix + "VulNormalStat.", this.VulNormalStat);
            this.SetParamObj(map, prefix + "VulLowStat.", this.VulLowStat);
            this.SetParamObj(map, prefix + "BaselineHighStat.", this.BaselineHighStat);
            this.SetParamObj(map, prefix + "BaselineNormalStat.", this.BaselineNormalStat);
            this.SetParamObj(map, prefix + "BaselineLowStat.", this.BaselineLowStat);
            this.SetParamSimple(map, prefix + "MachineTotalAffectNum", this.MachineTotalAffectNum);
            this.SetParamSimple(map, prefix + "InvasionTotalAffectNum", this.InvasionTotalAffectNum);
            this.SetParamSimple(map, prefix + "VulTotalAffectNum", this.VulTotalAffectNum);
            this.SetParamSimple(map, prefix + "BaseLineTotalAffectNum", this.BaseLineTotalAffectNum);
            this.SetParamSimple(map, prefix + "CyberAttackTotalAffectNum", this.CyberAttackTotalAffectNum);
            this.SetParamObj(map, prefix + "VulRiskStat.", this.VulRiskStat);
            this.SetParamObj(map, prefix + "BaselineRiskStat.", this.BaselineRiskStat);
            this.SetParamObj(map, prefix + "VulStat.", this.VulStat);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

