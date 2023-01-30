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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVirusScanTaskStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of scanned containers
        /// </summary>
        [JsonProperty("ContainerTotal")]
        public ulong? ContainerTotal{ get; set; }

        /// <summary>
        /// Number of containers at risk
        /// </summary>
        [JsonProperty("RiskContainerCnt")]
        public ulong? RiskContainerCnt{ get; set; }

        /// <summary>
        /// Scan task status:
        /// `SCAN_NONE`: None. 
        /// `SCAN_SCANNING`: Scanning.
        /// `SCAN_FINISH`: Scanned. 
        /// `SCAN_TIMEOUT`: Scan timed out.
        /// `SCAN_CANCELING`: Canceling.
        /// `SCAN_CANCELED`: Canceled.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Scanning progress
        /// </summary>
        [JsonProperty("Schedule")]
        public ulong? Schedule{ get; set; }

        /// <summary>
        /// Number of scanned containers
        /// </summary>
        [JsonProperty("ContainerScanCnt")]
        public ulong? ContainerScanCnt{ get; set; }

        /// <summary>
        /// Number of risks
        /// </summary>
        [JsonProperty("RiskCnt")]
        public ulong? RiskCnt{ get; set; }

        /// <summary>
        /// Remaining scan time
        /// </summary>
        [JsonProperty("LeftSeconds")]
        public ulong? LeftSeconds{ get; set; }

        /// <summary>
        /// Scan start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Scan end time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Scan type. Valid values: `CYCLE` (periodic scan); `MANUAL` (manual scan).
        /// </summary>
        [JsonProperty("ScanType")]
        public string ScanType{ get; set; }

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
            this.SetParamSimple(map, prefix + "ContainerTotal", this.ContainerTotal);
            this.SetParamSimple(map, prefix + "RiskContainerCnt", this.RiskContainerCnt);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Schedule", this.Schedule);
            this.SetParamSimple(map, prefix + "ContainerScanCnt", this.ContainerScanCnt);
            this.SetParamSimple(map, prefix + "RiskCnt", this.RiskCnt);
            this.SetParamSimple(map, prefix + "LeftSeconds", this.LeftSeconds);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ScanType", this.ScanType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

