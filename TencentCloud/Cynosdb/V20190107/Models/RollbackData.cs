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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollbackData : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OriginalClusterId")]
        public string OriginalClusterId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OriginalClusterName")]
        public string OriginalClusterName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RollbackStrategy")]
        public string RollbackStrategy{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SnapshotTime")]
        public string SnapshotTime{ get; set; }

        /// <summary>
        /// Minimum CPU when rolling back to a serverlessls cluster.
        /// </summary>
        [JsonProperty("MinCpu")]
        public long? MinCpu{ get; set; }

        /// <summary>
        /// Maximum CPU when rolling back to a serverlessls cluster.
        /// </summary>
        [JsonProperty("MaxCpu")]
        public long? MaxCpu{ get; set; }

        /// <summary>
        /// Snapshot ID.
        /// </summary>
        [JsonProperty("SnapShotId")]
        public ulong? SnapShotId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RollbackDatabases")]
        public RollbackDatabase[] RollbackDatabases{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RollbackTables")]
        public RollbackTable[] RollbackTables{ get; set; }

        /// <summary>
        /// Specifies the backup file name.
        /// </summary>
        [JsonProperty("BackupFileName")]
        public string BackupFileName{ get; set; }

        /// <summary>
        /// Rollback process.
        /// </summary>
        [JsonProperty("RollbackProcess")]
        public RollbackProcessInfo RollbackProcess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "OriginalClusterId", this.OriginalClusterId);
            this.SetParamSimple(map, prefix + "OriginalClusterName", this.OriginalClusterName);
            this.SetParamSimple(map, prefix + "RollbackStrategy", this.RollbackStrategy);
            this.SetParamSimple(map, prefix + "SnapshotTime", this.SnapshotTime);
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
            this.SetParamSimple(map, prefix + "SnapShotId", this.SnapShotId);
            this.SetParamArrayObj(map, prefix + "RollbackDatabases.", this.RollbackDatabases);
            this.SetParamArrayObj(map, prefix + "RollbackTables.", this.RollbackTables);
            this.SetParamSimple(map, prefix + "BackupFileName", this.BackupFileName);
            this.SetParamObj(map, prefix + "RollbackProcess.", this.RollbackProcess);
        }
    }
}

