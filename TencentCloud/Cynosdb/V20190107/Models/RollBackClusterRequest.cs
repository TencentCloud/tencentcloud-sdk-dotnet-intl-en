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

    public class RollBackClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Rollback policy. timeRollback - roll back by time point; snapRollback - roll back by backup file.
        /// </summary>
        [JsonProperty("RollbackStrategy")]
        public string RollbackStrategy{ get; set; }

        /// <summary>
        /// Backup file ID. This parameter is required when the rollback policy is rolling back by backup file.
        /// </summary>
        [JsonProperty("RollbackId")]
        public ulong? RollbackId{ get; set; }

        /// <summary>
        /// Expected rollback time. This parameter is required when the rollback policy is timeRollback (roll back by time point).
        /// </summary>
        [JsonProperty("ExpectTime")]
        public string ExpectTime{ get; set; }

        /// <summary>
        /// Expected threshold (deprecated).
        /// </summary>
        [JsonProperty("ExpectTimeThresh")]
        public ulong? ExpectTimeThresh{ get; set; }

        /// <summary>
        /// List of rollback databases.
        /// </summary>
        [JsonProperty("RollbackDatabases")]
        public RollbackDatabase[] RollbackDatabases{ get; set; }

        /// <summary>
        /// List of rollback databases and tables.
        /// </summary>
        [JsonProperty("RollbackTables")]
        public RollbackTable[] RollbackTables{ get; set; }

        /// <summary>
        /// Mode of rolling back by time point. full: normal; db: fast; table: ultra-fast (the default value is normal).
        /// </summary>
        [JsonProperty("RollbackMode")]
        public string RollbackMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "RollbackStrategy", this.RollbackStrategy);
            this.SetParamSimple(map, prefix + "RollbackId", this.RollbackId);
            this.SetParamSimple(map, prefix + "ExpectTime", this.ExpectTime);
            this.SetParamSimple(map, prefix + "ExpectTimeThresh", this.ExpectTimeThresh);
            this.SetParamArrayObj(map, prefix + "RollbackDatabases.", this.RollbackDatabases);
            this.SetParamArrayObj(map, prefix + "RollbackTables.", this.RollbackTables);
            this.SetParamSimple(map, prefix + "RollbackMode", this.RollbackMode);
        }
    }
}

