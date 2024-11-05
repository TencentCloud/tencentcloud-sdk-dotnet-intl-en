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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRansomDefenseStateResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of Activated Defense Policies
        /// </summary>
        [JsonProperty("StrategyCount")]
        public ulong? StrategyCount{ get; set; }

        /// <summary>
        /// Number of Protected Machines
        /// </summary>
        [JsonProperty("MachineCount")]
        public ulong? MachineCount{ get; set; }

        /// <summary>
        /// Total snapshot capacity
        /// </summary>
        [JsonProperty("SnapshotSize")]
        public ulong? SnapshotSize{ get; set; }

        /// <summary>
        /// Number of Backup Recovery Tasks
        /// </summary>
        [JsonProperty("RollBackTaskCount")]
        public ulong? RollBackTaskCount{ get; set; }

        /// <summary>
        /// Number of Snapshot Creation Tasks in Progress
        /// </summary>
        [JsonProperty("ProgressingSnapshotTaskCount")]
        public ulong? ProgressingSnapshotTaskCount{ get; set; }

        /// <summary>
        /// Number of Backup Recovery Tasks in Progress
        /// </summary>
        [JsonProperty("ProgressingRollBackTaskCount")]
        public ulong? ProgressingRollBackTaskCount{ get; set; }

        /// <summary>
        /// Total Number of Machines
        /// </summary>
        [JsonProperty("MachineTotal")]
        public ulong? MachineTotal{ get; set; }

        /// <summary>
        /// Total number of policies
        /// </summary>
        [JsonProperty("StrategyTotal")]
        public ulong? StrategyTotal{ get; set; }

        /// <summary>
        /// Account Status. 0 - Without Overdue Payment; 1 - With Overdue Payment
        /// </summary>
        [JsonProperty("BalanceStatus")]
        public ulong? BalanceStatus{ get; set; }

        /// <summary>
        /// Number of Backed-Up Hosts
        /// </summary>
        [JsonProperty("BackupMachineCount")]
        public ulong? BackupMachineCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "StrategyCount", this.StrategyCount);
            this.SetParamSimple(map, prefix + "MachineCount", this.MachineCount);
            this.SetParamSimple(map, prefix + "SnapshotSize", this.SnapshotSize);
            this.SetParamSimple(map, prefix + "RollBackTaskCount", this.RollBackTaskCount);
            this.SetParamSimple(map, prefix + "ProgressingSnapshotTaskCount", this.ProgressingSnapshotTaskCount);
            this.SetParamSimple(map, prefix + "ProgressingRollBackTaskCount", this.ProgressingRollBackTaskCount);
            this.SetParamSimple(map, prefix + "MachineTotal", this.MachineTotal);
            this.SetParamSimple(map, prefix + "StrategyTotal", this.StrategyTotal);
            this.SetParamSimple(map, prefix + "BalanceStatus", this.BalanceStatus);
            this.SetParamSimple(map, prefix + "BackupMachineCount", this.BackupMachineCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}
