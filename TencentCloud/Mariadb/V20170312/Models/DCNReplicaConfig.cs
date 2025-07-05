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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DCNReplicaConfig : AbstractModel
    {
        
        /// <summary>
        /// DCN running status. Valid values: `START` (running), `STOP` (pause)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RoReplicationMode")]
        public string RoReplicationMode{ get; set; }

        /// <summary>
        /// Delayed replication type. Valid values: `DEFAULT` (no delay), `DUE_TIME` (specified replication time)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DelayReplicationType")]
        public string DelayReplicationType{ get; set; }

        /// <summary>
        /// Specified time for delayed replication
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DueTime")]
        public string DueTime{ get; set; }

        /// <summary>
        /// The number of seconds to delay the replication
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReplicationDelay")]
        public long? ReplicationDelay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoReplicationMode", this.RoReplicationMode);
            this.SetParamSimple(map, prefix + "DelayReplicationType", this.DelayReplicationType);
            this.SetParamSimple(map, prefix + "DueTime", this.DueTime);
            this.SetParamSimple(map, prefix + "ReplicationDelay", this.ReplicationDelay);
        }
    }
}

