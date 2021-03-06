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

    public class ModifyRoTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The original type of an RO replica. Valid values: `NORMAL` (do not support delayed replication), `DELAY_REPLICATION` (support delayed replication).
        /// </summary>
        [JsonProperty("SrcRoInstType")]
        public string SrcRoInstType{ get; set; }

        /// <summary>
        /// The target type of an RO replica. Valid values: `NORMAL` (do not support delayed replication), `DELAY_REPLICATION` (support delayed replication).
        /// </summary>
        [JsonProperty("DstRoInstType")]
        public string DstRoInstType{ get; set; }

        /// <summary>
        /// Replication delay in seconds. This parameter is required when a regular RO replica is switched to a delayed one. Value range: 1 to 259200.
        /// </summary>
        [JsonProperty("ReplicationDelay")]
        public long? ReplicationDelay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SrcRoInstType", this.SrcRoInstType);
            this.SetParamSimple(map, prefix + "DstRoInstType", this.DstRoInstType);
            this.SetParamSimple(map, prefix + "ReplicationDelay", this.ReplicationDelay);
        }
    }
}

