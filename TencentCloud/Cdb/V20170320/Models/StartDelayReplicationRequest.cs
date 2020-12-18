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

    public class StartDelayReplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Delayed replication mode. Valid values: `DEFAULT` (replicate according to the specified replication delay), `GTID` (replicate according to the specified GTID), `DUE_TIME` (replicate according to the specified point in time).
        /// </summary>
        [JsonProperty("DelayReplicationType")]
        public string DelayReplicationType{ get; set; }

        /// <summary>
        /// Specified point in time. Default value: 0. The maximum value cannot be later than the current time.
        /// </summary>
        [JsonProperty("DueTime")]
        public long? DueTime{ get; set; }

        /// <summary>
        /// Specified GITD. This parameter is required when the delayed replication mode is `GTID`.
        /// </summary>
        [JsonProperty("Gtid")]
        public string Gtid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DelayReplicationType", this.DelayReplicationType);
            this.SetParamSimple(map, prefix + "DueTime", this.DueTime);
            this.SetParamSimple(map, prefix + "Gtid", this.Gtid);
        }
    }
}

