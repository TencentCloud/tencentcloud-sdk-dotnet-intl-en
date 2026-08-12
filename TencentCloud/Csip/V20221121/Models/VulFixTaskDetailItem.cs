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

    public class VulFixTaskDetailItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Detailed record ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>Associated repair task ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// <p>Vulnerability ID to be repaired</p>
        /// </summary>
        [JsonProperty("VulId")]
        public long? VulId{ get; set; }

        /// <summary>
        /// <p>Patch ID of the fixed KB</p>
        /// </summary>
        [JsonProperty("KBId")]
        public long? KBId{ get; set; }

        /// <summary>
        /// <p>Host instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Host name.</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>Host private IP address.</p>
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// <p>Vulnerability name</p>
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// <p>Execution status<br>Enumeration value:<br>0: Initial state<br>1: Task issued<br>11: Client confirmed<br>2: Repair completed<br>3: Client offline<br>4: Timeout<br>5: Failure<br>6: Unsupported<br>9: Waiting for snapshot creation<br>10: Snapshot creation failed</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Fix result</p><p>Enumeration values:</p><ul><li>0: initial state</li><li>1: repair successful</li><li>2: fix failure</li><li>3: fix</li></ul>
        /// </summary>
        [JsonProperty("FixStatus")]
        public long? FixStatus{ get; set; }

        /// <summary>
        /// <p>Snapshot status<br>Enumeration value:<br>-1: No need to create a snapshot<br>0: Not started<br>1: In progress<br>2: Completed<br>3: Creation failed</p>
        /// </summary>
        [JsonProperty("SnapshotStatus")]
        public long? SnapshotStatus{ get; set; }

        /// <summary>
        /// <p>Exception prompt message</p>
        /// </summary>
        [JsonProperty("ExceptionMessage")]
        public string ExceptionMessage{ get; set; }

        /// <summary>
        /// <p>Repair startup time<br>Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>Repair end time<br>Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Snapshot creation time<br>Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)</p>
        /// </summary>
        [JsonProperty("SnapshotCreateTime")]
        public string SnapshotCreateTime{ get; set; }

        /// <summary>
        /// <p>Snapshot expiration time<br>Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)</p>
        /// </summary>
        [JsonProperty("SnapshotExpireTime")]
        public string SnapshotExpireTime{ get; set; }

        /// <summary>
        /// <p>Snapshot creation failure reason (available when SnapshotStatus=3)</p>
        /// </summary>
        [JsonProperty("SnapshotFailReason")]
        public string SnapshotFailReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "KBId", this.KBId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FixStatus", this.FixStatus);
            this.SetParamSimple(map, prefix + "SnapshotStatus", this.SnapshotStatus);
            this.SetParamSimple(map, prefix + "ExceptionMessage", this.ExceptionMessage);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SnapshotCreateTime", this.SnapshotCreateTime);
            this.SetParamSimple(map, prefix + "SnapshotExpireTime", this.SnapshotExpireTime);
            this.SetParamSimple(map, prefix + "SnapshotFailReason", this.SnapshotFailReason);
        }
    }
}

