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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceHAConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// Primary-standby sync mode. Valid values:
        /// <li>`Semi-sync`
        /// <li>`Async`
        /// </summary>
        [JsonProperty("SyncMode")]
        public string SyncMode{ get; set; }

        /// <summary>
        /// Maximum data lag for high-availability standby server. The standby node can be promoted to the primary node when its data lag and the delay time are both less than the value of `MaxStandbyLatency` and `MaxStandbyLag` respectively.
        /// <li>Unit: byte
        /// <li>Value range: 1073741824-322122547200
        /// </summary>
        [JsonProperty("MaxStandbyLatency")]
        public ulong? MaxStandbyLatency{ get; set; }

        /// <summary>
        /// The maximum delay for high-availability standby server The standby node can be promoted to the primary node when its data lag and the delay time are both less or equals to the value of `MaxStandbyLatency` and `MaxStandbyLag` respectively.
        /// <li>Unit: s
        /// <li>Value range: 5-10
        /// </summary>
        [JsonProperty("MaxStandbyLag")]
        public ulong? MaxStandbyLag{ get; set; }

        /// <summary>
        /// Maximum data sync lag for standby server. If data lag of the standby node and the delay ime are both less than or equals to the values of `MaxSyncStandbyLatency` and `MaxSyncStandbyLag`, the standby server adopts semi-sync replication; if not, it adopts async replication.
        /// This value is only valid for the instance with `SyncMode` set to `Semi-sync`.
        /// When the semi-sync replication mode of the instance is not allowed to downgrade to async replication, `MaxSyncStandbyLatency` and `MaxSyncStandbyLag` are not required.
        /// When the semi-sync instance is allowed to downgrade to async replication, `MaxSyncStandbyLatency` is required and `MaxSyncStandbyLag` must be left empty for PostgreSQL 9; `MaxSyncStandbyLatency` and MaxSyncStandbyLag` are required for PostgreSQL 10 and later.
        /// </summary>
        [JsonProperty("MaxSyncStandbyLatency")]
        public ulong? MaxSyncStandbyLatency{ get; set; }

        /// <summary>
        /// Maximum delay for sync standby server. If the delay time for standby server and the data lag are both less than or equals to the value of `MaxSyncStandbyLag` and `MaxSyncStandbyLatency` respectively, the standby server adopts sync replication mode; if not, it adopts async replication.
        /// This value is only valid for the instance with `SyncMode` set to `Semi-sync`.
        /// When the semi-sync replication mode of the instance is not allowed to downgrade to async replication, `MaxSyncStandbyLatency` and `MaxSyncStandbyLag` are not required.
        /// When the semi-sync instance is allowed to downgrade to async replication, `MaxSyncStandbyLatency` is required and `MaxSyncStandbyLag` must be left empty for PostgreSQL 9; `MaxSyncStandbyLatency` and MaxSyncStandbyLag` are required for PostgreSQL 10 and later.
        /// </summary>
        [JsonProperty("MaxSyncStandbyLag")]
        public ulong? MaxSyncStandbyLag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "MaxStandbyLatency", this.MaxStandbyLatency);
            this.SetParamSimple(map, prefix + "MaxStandbyLag", this.MaxStandbyLag);
            this.SetParamSimple(map, prefix + "MaxSyncStandbyLatency", this.MaxSyncStandbyLatency);
            this.SetParamSimple(map, prefix + "MaxSyncStandbyLag", this.MaxSyncStandbyLag);
        }
    }
}

