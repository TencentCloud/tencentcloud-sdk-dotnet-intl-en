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

    public class ModifyClusterSlaveZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Old replica AZ
        /// </summary>
        [JsonProperty("OldSlaveZone")]
        public string OldSlaveZone{ get; set; }

        /// <summary>
        /// New replica AZ
        /// </summary>
        [JsonProperty("NewSlaveZone")]
        public string NewSlaveZone{ get; set; }

        /// <summary>
        /// Specifies the binlog synchronization mode. the default value is async. valid values are sync, semisync, and async.
        /// </summary>
        [JsonProperty("BinlogSyncWay")]
        public string BinlogSyncWay{ get; set; }

        /// <summary>
        /// Semi-sync timeout period in ms. To ensure business stability, the semi-synchronous replication includes a degradation mechanism. If the primary AZ cluster exceeds this timeout while waiting for transaction confirmation from the secondary AZ cluster, the replication mode will fall back to asynchronous replication. Minimum setting: 1000 ms; maximum support: 4294967295 ms; default: 10000 ms.
        /// </summary>
        [JsonProperty("SemiSyncTimeout")]
        public long? SemiSyncTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "OldSlaveZone", this.OldSlaveZone);
            this.SetParamSimple(map, prefix + "NewSlaveZone", this.NewSlaveZone);
            this.SetParamSimple(map, prefix + "BinlogSyncWay", this.BinlogSyncWay);
            this.SetParamSimple(map, prefix + "SemiSyncTimeout", this.SemiSyncTimeout);
        }
    }
}

