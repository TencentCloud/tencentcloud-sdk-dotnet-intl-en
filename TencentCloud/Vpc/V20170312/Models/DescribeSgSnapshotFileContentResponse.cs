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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSgSnapshotFileContentResponse : AbstractModel
    {
        
        /// <summary>
        /// Security group ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Snapshot policy IDs
        /// </summary>
        [JsonProperty("SnapshotPolicyId")]
        public string SnapshotPolicyId{ get; set; }

        /// <summary>
        /// Snapshot file ID
        /// </summary>
        [JsonProperty("SnapshotFileId")]
        public string SnapshotFileId{ get; set; }

        /// <summary>
        /// Backup time
        /// </summary>
        [JsonProperty("BackupTime")]
        public string BackupTime{ get; set; }

        /// <summary>
        /// Operator
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Original data
        /// </summary>
        [JsonProperty("OriginalData")]
        public SecurityGroupPolicy[] OriginalData{ get; set; }

        /// <summary>
        /// Backup data
        /// </summary>
        [JsonProperty("BackupData")]
        public SecurityGroupPolicy[] BackupData{ get; set; }

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
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SnapshotPolicyId", this.SnapshotPolicyId);
            this.SetParamSimple(map, prefix + "SnapshotFileId", this.SnapshotFileId);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamArrayObj(map, prefix + "OriginalData.", this.OriginalData);
            this.SetParamArrayObj(map, prefix + "BackupData.", this.BackupData);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

