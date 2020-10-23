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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecurityTrendsResponse : AbstractModel
    {
        
        /// <summary>
        /// Trojan event statistics array.
        /// </summary>
        [JsonProperty("Malwares")]
        public SecurityTrend[] Malwares{ get; set; }

        /// <summary>
        /// Unusual login location event statistics array.
        /// </summary>
        [JsonProperty("NonLocalLoginPlaces")]
        public SecurityTrend[] NonLocalLoginPlaces{ get; set; }

        /// <summary>
        /// Brute force attack event statistics array.
        /// </summary>
        [JsonProperty("BruteAttacks")]
        public SecurityTrend[] BruteAttacks{ get; set; }

        /// <summary>
        /// Vulnerability statistics array.
        /// </summary>
        [JsonProperty("Vuls")]
        public SecurityTrend[] Vuls{ get; set; }

        /// <summary>
        /// Baseline statistics array.
        /// </summary>
        [JsonProperty("BaseLines")]
        public SecurityTrend[] BaseLines{ get; set; }

        /// <summary>
        /// Statistics array of malicious requests.
        /// </summary>
        [JsonProperty("MaliciousRequests")]
        public SecurityTrend[] MaliciousRequests{ get; set; }

        /// <summary>
        /// Statistics array of high-risk commands.
        /// </summary>
        [JsonProperty("HighRiskBashs")]
        public SecurityTrend[] HighRiskBashs{ get; set; }

        /// <summary>
        /// Statistics array of reverse shells.
        /// </summary>
        [JsonProperty("ReverseShells")]
        public SecurityTrend[] ReverseShells{ get; set; }

        /// <summary>
        /// Statistics array of local privilege escalations.
        /// </summary>
        [JsonProperty("PrivilegeEscalations")]
        public SecurityTrend[] PrivilegeEscalations{ get; set; }

        /// <summary>
        /// Statistics array of network attacks.
        /// </summary>
        [JsonProperty("CyberAttacks")]
        public SecurityTrend[] CyberAttacks{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Malwares.", this.Malwares);
            this.SetParamArrayObj(map, prefix + "NonLocalLoginPlaces.", this.NonLocalLoginPlaces);
            this.SetParamArrayObj(map, prefix + "BruteAttacks.", this.BruteAttacks);
            this.SetParamArrayObj(map, prefix + "Vuls.", this.Vuls);
            this.SetParamArrayObj(map, prefix + "BaseLines.", this.BaseLines);
            this.SetParamArrayObj(map, prefix + "MaliciousRequests.", this.MaliciousRequests);
            this.SetParamArrayObj(map, prefix + "HighRiskBashs.", this.HighRiskBashs);
            this.SetParamArrayObj(map, prefix + "ReverseShells.", this.ReverseShells);
            this.SetParamArrayObj(map, prefix + "PrivilegeEscalations.", this.PrivilegeEscalations);
            this.SetParamArrayObj(map, prefix + "CyberAttacks.", this.CyberAttacks);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

