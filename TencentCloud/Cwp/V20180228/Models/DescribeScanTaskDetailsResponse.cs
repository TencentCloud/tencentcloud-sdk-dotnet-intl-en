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

    public class DescribeScanTaskDetailsResponse : AbstractModel
    {
        
        /// <summary>
        /// List of scan task information
        /// </summary>
        [JsonProperty("ScanTaskDetailList")]
        public ScanTaskDetails[] ScanTaskDetailList{ get; set; }

        /// <summary>
        /// Total number
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// Total number of scanned machines
        /// </summary>
        [JsonProperty("ScanMachineCount")]
        public ulong? ScanMachineCount{ get; set; }

        /// <summary>
        /// Number of machines with risks detected
        /// </summary>
        [JsonProperty("RiskMachineCount")]
        public ulong? RiskMachineCount{ get; set; }

        /// <summary>
        /// Scan start time
        /// </summary>
        [JsonProperty("ScanBeginTime")]
        public string ScanBeginTime{ get; set; }

        /// <summary>
        /// Scan end time
        /// </summary>
        [JsonProperty("ScanEndTime")]
        public string ScanEndTime{ get; set; }

        /// <summary>
        /// Scan time
        /// </summary>
        [JsonProperty("ScanTime")]
        public ulong? ScanTime{ get; set; }

        /// <summary>
        /// Scan progress
        /// </summary>
        [JsonProperty("ScanProgress")]
        public ulong? ScanProgress{ get; set; }

        /// <summary>
        /// Remaining scan time
        /// </summary>
        [JsonProperty("ScanLeftTime")]
        public ulong? ScanLeftTime{ get; set; }

        /// <summary>
        /// Scan content
        /// </summary>
        [JsonProperty("ScanContent")]
        public string[] ScanContent{ get; set; }

        /// <summary>
        /// Vulnerability information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulInfo")]
        public VulDetailInfo[] VulInfo{ get; set; }

        /// <summary>
        /// Number of risk events
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskEventCount")]
        public ulong? RiskEventCount{ get; set; }

        /// <summary>
        /// 0: one-click scan; 1: scheduled scan.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Whether all tasks are being stopped. true: yes.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StoppingAll")]
        public bool? StoppingAll{ get; set; }

        /// <summary>
        /// Number of vulnerabilities scanned
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulCount")]
        public ulong? VulCount{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "ScanTaskDetailList.", this.ScanTaskDetailList);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "ScanMachineCount", this.ScanMachineCount);
            this.SetParamSimple(map, prefix + "RiskMachineCount", this.RiskMachineCount);
            this.SetParamSimple(map, prefix + "ScanBeginTime", this.ScanBeginTime);
            this.SetParamSimple(map, prefix + "ScanEndTime", this.ScanEndTime);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "ScanProgress", this.ScanProgress);
            this.SetParamSimple(map, prefix + "ScanLeftTime", this.ScanLeftTime);
            this.SetParamArraySimple(map, prefix + "ScanContent.", this.ScanContent);
            this.SetParamArrayObj(map, prefix + "VulInfo.", this.VulInfo);
            this.SetParamSimple(map, prefix + "RiskEventCount", this.RiskEventCount);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "StoppingAll", this.StoppingAll);
            this.SetParamSimple(map, prefix + "VulCount", this.VulCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

