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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMigrationRequest : AbstractModel
    {
        
        /// <summary>
        /// Migration task name
        /// </summary>
        [JsonProperty("MigrateName")]
        public string MigrateName{ get; set; }

        /// <summary>
        /// Migration type (1: structure migration, 2: data migration, 3: incremental sync)
        /// </summary>
        [JsonProperty("MigrateType")]
        public ulong? MigrateType{ get; set; }

        /// <summary>
        /// Migration source type. 1: TencentDB for SQL Server, 2: CVM-based self-created SQL Server database; 3: SQL Server backup restoration, 4: SQL Server backup restoration (in COS mode)
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// Migration source
        /// </summary>
        [JsonProperty("Source")]
        public MigrateSource Source{ get; set; }

        /// <summary>
        /// Migration target
        /// </summary>
        [JsonProperty("Target")]
        public MigrateTarget Target{ get; set; }

        /// <summary>
        /// Database objects to be migrated. This parameter is not used for offline migration (SourceType=4 or SourceType=5)
        /// </summary>
        [JsonProperty("MigrateDBSet")]
        public MigrateDB[] MigrateDBSet{ get; set; }

        /// <summary>
        /// Restore the databases listed in `ReNameRestoreDatabase` and rename them after restoration. If this parameter is left empty, all databases will be restored and renamed in the default format. This parameter takes effect only when `SourceType=5`.
        /// </summary>
        [JsonProperty("RenameRestore")]
        public RenameRestoreDatabase[] RenameRestore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MigrateName", this.MigrateName);
            this.SetParamSimple(map, prefix + "MigrateType", this.MigrateType);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamObj(map, prefix + "Source.", this.Source);
            this.SetParamObj(map, prefix + "Target.", this.Target);
            this.SetParamArrayObj(map, prefix + "MigrateDBSet.", this.MigrateDBSet);
            this.SetParamArrayObj(map, prefix + "RenameRestore.", this.RenameRestore);
        }
    }
}

