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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollbackInstancesInfo : AbstractModel
    {
        
        /// <summary>
        /// Cloud database instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Rollback strategy. Optional values: table, db, full. table - Ultra-fast rollback mode, only imports selected table-level backups and binlog. If there are cross-table operations and the associated table hasn't been selected, it will cause rollback failure. In this mode, parameter Databases must be empty. db - Quick mode, only imports selected database-level backups and binlog. If there are cross-database operations and the associated database hasn't been selected, it will cause rollback failure. full - Standard rollback mode, imports backups and binlog of the entire instance, speed is not as fast.
        /// </summary>
        [JsonProperty("Strategy")]
        public string Strategy{ get; set; }

        /// <summary>
        /// Database rollback time in the format of yyyy-mm-dd hh:mm:ss.
        /// </summary>
        [JsonProperty("RollbackTime")]
        public string RollbackTime{ get; set; }

        /// <summary>
        /// Database information to be rolled back, which means database rollback.
        /// </summary>
        [JsonProperty("Databases")]
        public RollbackDBName[] Databases{ get; set; }

        /// <summary>
        /// Database table information to be rolled back, which means rollback by table.
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

