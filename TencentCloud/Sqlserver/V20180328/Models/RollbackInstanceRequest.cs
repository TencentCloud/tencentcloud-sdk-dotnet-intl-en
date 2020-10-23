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

    public class RollbackInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Rollback type. 0: the database rolled back overwrites the original database; 1: the database rolled back is renamed and does not overwrite the original database
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Database to be rolled back
        /// </summary>
        [JsonProperty("DBs")]
        public string[] DBs{ get; set; }

        /// <summary>
        /// Target time point for rollback
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// ID of the target instance to which the backup is restored. The target instance should be under the same `APPID`. If this parameter is left empty, ID of the source instance will be used.
        /// </summary>
        [JsonProperty("TargetInstanceId")]
        public string TargetInstanceId{ get; set; }

        /// <summary>
        /// Rename the databases listed in `ReNameRestoreDatabase`. This parameter takes effect only when `Type = 1` which indicates that backup rollback supports renaming databases. If it is left empty, databases will be renamed in the default format and the `DBs` parameter specifies the databases to be restored.
        /// </summary>
        [JsonProperty("RenameRestore")]
        public RenameRestoreDatabase[] RenameRestore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "DBs.", this.DBs);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "TargetInstanceId", this.TargetInstanceId);
            this.SetParamArrayObj(map, prefix + "RenameRestore.", this.RenameRestore);
        }
    }
}

