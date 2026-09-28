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
        /// <p>Cluster Id.</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Old secondary AZ</p>
        /// </summary>
        [JsonProperty("OldSlaveZone")]
        public string OldSlaveZone{ get; set; }

        /// <summary>
        /// <p>New secondary AZ</p>
        /// </summary>
        [JsonProperty("NewSlaveZone")]
        public string NewSlaveZone{ get; set; }

        /// <summary>
        /// <p>binlog synchronization mode. Default value: async. Available values: sync, semisync, async</p>
        /// </summary>
        [JsonProperty("BinlogSyncWay")]
        public string BinlogSyncWay{ get; set; }

        /// <summary>
        /// <p>Semi-sync timeout period, in milliseconds. To ensure business stability, semi-sync replication has a degradation logic. If the primary AZ cluster exceeds this timeout period while waiting for the standby AZ cluster to confirm a transaction, the replication method degrades to asynchronous replication. The minimum is set to 1000 ms, with support up to 4294967295 ms. Default: 10000 ms.</p>
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

