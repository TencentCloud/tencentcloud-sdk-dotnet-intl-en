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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWeeklyReportInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Account owner name.
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// Total number of servers.
        /// </summary>
        [JsonProperty("MachineNum")]
        public ulong? MachineNum{ get; set; }

        /// <summary>
        /// Number of online CWP agents
        /// </summary>
        [JsonProperty("OnlineMachineNum")]
        public ulong? OnlineMachineNum{ get; set; }

        /// <summary>
        /// Number of offline CWP agents.
        /// </summary>
        [JsonProperty("OfflineMachineNum")]
        public ulong? OfflineMachineNum{ get; set; }

        /// <summary>
        /// Number of servers on CWP Pro.
        /// </summary>
        [JsonProperty("ProVersionMachineNum")]
        public ulong? ProVersionMachineNum{ get; set; }

        /// <summary>
        /// Weekly report start time
        /// </summary>
        [JsonProperty("BeginDate")]
        public string BeginDate{ get; set; }

        /// <summary>
        /// Weekly report end time
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// Security level
        /// <li>HIGH: high</li>
        /// <li>MIDDLE: medium</li>
        /// <li>LOW: low</li>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Number of trojan records.
        /// </summary>
        [JsonProperty("MalwareNum")]
        public ulong? MalwareNum{ get; set; }

        /// <summary>
        /// Number of unusual login locations.
        /// </summary>
        [JsonProperty("NonlocalLoginNum")]
        public ulong? NonlocalLoginNum{ get; set; }

        /// <summary>
        /// Number of successful brute force attacks.
        /// </summary>
        [JsonProperty("BruteAttackSuccessNum")]
        public ulong? BruteAttackSuccessNum{ get; set; }

        /// <summary>
        /// Number of vulnerabilities.
        /// </summary>
        [JsonProperty("VulNum")]
        public ulong? VulNum{ get; set; }

        /// <summary>
        /// Download address for exported file.
        /// </summary>
        [JsonProperty("DownloadUrl")]
        public string DownloadUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "MachineNum", this.MachineNum);
            this.SetParamSimple(map, prefix + "OnlineMachineNum", this.OnlineMachineNum);
            this.SetParamSimple(map, prefix + "OfflineMachineNum", this.OfflineMachineNum);
            this.SetParamSimple(map, prefix + "ProVersionMachineNum", this.ProVersionMachineNum);
            this.SetParamSimple(map, prefix + "BeginDate", this.BeginDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "MalwareNum", this.MalwareNum);
            this.SetParamSimple(map, prefix + "NonlocalLoginNum", this.NonlocalLoginNum);
            this.SetParamSimple(map, prefix + "BruteAttackSuccessNum", this.BruteAttackSuccessNum);
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamSimple(map, prefix + "DownloadUrl", this.DownloadUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

