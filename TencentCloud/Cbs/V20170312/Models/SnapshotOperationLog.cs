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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SnapshotOperationLog : AbstractModel
    {
        
        /// <summary>
        /// Status of operation. Value range:
        /// SUCCESS: Operation successful 
        /// FAILED: Operation failed 
        /// PROCESSING: Operation in process
        /// </summary>
        [JsonProperty("OperationState")]
        public string OperationState{ get; set; }

        /// <summary>
        /// Start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// UIN of operator.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// ID of snapshot being operated.
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// Operation type. Value range:
        /// SNAP_OPERATION_DELETE: Delete snapshot
        /// SNAP_OPERATION_ROLLBACK: Roll back snapshot
        /// SNAP_OPERATION_MODIFY: Modify snapshot attributes
        /// SNAP_OPERATION_CREATE: Create snapshot
        /// SNAP_OPERATION_COPY: Cross-region replication of snapshot
        /// ASP_OPERATION_CREATE_SNAP: Create snapshot with scheduled snapshot policy
        /// ASP_OPERATION_DELETE_SNAP: Delete snapshot from scheduled snapshot policy
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// End time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OperationState", this.OperationState);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

