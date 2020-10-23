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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollbackInstancesInfo : AbstractModel
    {
        
        /// <summary>
        /// TencentDB instance ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Rollback policy. Value range: table, db, full. Default value: full. Table: expedited rollback mode, where only the selected table-level backups and binlogs are imported; for cross-table rollback, if the associated tables are not selected simultaneously, the rollback will fail; the parameter `Databases` must be empty under this mode. db: fast rollback mode, where only the selected database-level backups and binlogs are imported; for cross-database rollback, if the associated databases are not selected simultaneously, the rollback will fail. full: ordinary rollback mode, which imports all the backups and binlogs of the instance at a relatively low speed.
        /// </summary>
        [JsonProperty("Strategy")]
        public string Strategy{ get; set; }

        /// <summary>
        /// Database rollback time in the format of yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonProperty("RollbackTime")]
        public string RollbackTime{ get; set; }

        /// <summary>
        /// Information of the databases to be rolled back, which means rollback at the database level
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Databases")]
        public RollbackDBName[] Databases{ get; set; }

        /// <summary>
        /// Information of the tables to be rolled back, which means rollback at the table level
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tables")]
        public RollbackTables[] Tables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "RollbackTime", this.RollbackTime);
            this.SetParamArrayObj(map, prefix + "Databases.", this.Databases);
            this.SetParamArrayObj(map, prefix + "Tables.", this.Tables);
        }
    }
}

