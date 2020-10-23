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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceSpecRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of cmgo-p8vnipr5. It is the same as the instance ID displayed on the TencentDB Console page
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Memory size after instance configuration change in GB. Memory and disk must be upgraded or degraded simultaneously
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Disk size after instance configuration change in GB. Memory and disk must be upgraded or degraded simultaneously. For degradation, the new disk capacity must be greater than 1.2 times the used disk capacity
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// Oplog size after instance configuration change in GB, which ranges from 10% to 90% of the disk capacity and is 10% of the disk capacity by default
        /// </summary>
        [JsonProperty("OplogSize")]
        public ulong? OplogSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "OplogSize", this.OplogSize);
        }
    }
}

