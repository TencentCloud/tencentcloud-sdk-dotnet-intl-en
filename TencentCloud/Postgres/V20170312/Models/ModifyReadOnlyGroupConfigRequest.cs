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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyReadOnlyGroupConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Read-Only group ID.
        /// </summary>
        [JsonProperty("ReadOnlyGroupId")]
        public string ReadOnlyGroupId{ get; set; }

        /// <summary>
        /// Read-Only group name. only supports chinese, english, digits, "_", or "-" with length less than 60.
        /// </summary>
        [JsonProperty("ReadOnlyGroupName")]
        public string ReadOnlyGroupName{ get; set; }

        /// <summary>
        /// Whether to remove a read-only replica from an RO group if the delay between the read-only replica and the primary instance exceeds the threshold. Valid values: `0` (no), `1` (yes).
        /// </summary>
        [JsonProperty("ReplayLagEliminate")]
        public ulong? ReplayLagEliminate{ get; set; }

        /// <summary>
        /// Whether to remove a read-only replica from an RO group if the sync log size difference between the read-only replica and the primary instance exceeds the threshold. Valid values: `0` (no), `1` (yes).
        /// </summary>
        [JsonProperty("ReplayLatencyEliminate")]
        public ulong? ReplayLatencyEliminate{ get; set; }

        /// <summary>
        /// Delay log size threshold in MB. specifies a positive integer when enabling the delay log size configuration.
        /// </summary>
        [JsonProperty("MaxReplayLatency")]
        public ulong? MaxReplayLatency{ get; set; }

        /// <summary>
        /// Delay time size threshold, unit: s. when enabling the delay time configuration, manually input a positive integer.
        /// </summary>
        [JsonProperty("MaxReplayLag")]
        public ulong? MaxReplayLag{ get; set; }

        /// <summary>
        /// Whether to enable automatic load balancing. Valid values: `0` (disable), `1` (enable).
        /// </summary>
        [JsonProperty("Rebalance")]
        public ulong? Rebalance{ get; set; }

        /// <summary>
        /// Specifies the minimum number of instances to retain with delay removal. value range [0,100].
        /// </summary>
        [JsonProperty("MinDelayEliminateReserve")]
        public ulong? MinDelayEliminateReserve{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReadOnlyGroupId", this.ReadOnlyGroupId);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupName", this.ReadOnlyGroupName);
            this.SetParamSimple(map, prefix + "ReplayLagEliminate", this.ReplayLagEliminate);
            this.SetParamSimple(map, prefix + "ReplayLatencyEliminate", this.ReplayLatencyEliminate);
            this.SetParamSimple(map, prefix + "MaxReplayLatency", this.MaxReplayLatency);
            this.SetParamSimple(map, prefix + "MaxReplayLag", this.MaxReplayLag);
            this.SetParamSimple(map, prefix + "Rebalance", this.Rebalance);
            this.SetParamSimple(map, prefix + "MinDelayEliminateReserve", this.MinDelayEliminateReserve);
        }
    }
}

