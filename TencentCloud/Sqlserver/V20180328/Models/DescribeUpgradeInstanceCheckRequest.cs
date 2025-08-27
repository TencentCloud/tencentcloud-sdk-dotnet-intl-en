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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUpgradeInstanceCheckRequest : AbstractModel
    {
        
        /// <summary>
        /// Database instance ID, in the format of mssql-njj2mtpl.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Number of CPU cores after instance configuration adjustment. If it is left blank, no modification is required.
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// Memory size after instance configuration adjustment, in GB. If it is left blank, no modification is required.
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Disk size after instance configuration adjustment, in GB. If it is left blank, no modification is required.
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// Instance version. If it is left blank, no modification is required.
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// Type after instance configuration adjustment. Valid values: CLUSTER - cluster. If it is left blank, no modification is required.
        /// </summary>
        [JsonProperty("HAType")]
        public string HAType{ get; set; }

        /// <summary>
        /// Cross-AZ type after instance configuration adjustment. Valid values: SameZones - change to the same AZ; MultiZones - change to cross-AZ. If it is left blank, no modification is required.
        /// </summary>
        [JsonProperty("MultiZones")]
        public string MultiZones{ get; set; }

        /// <summary>
        /// Secondary node AZ of the multi-node architecture instance. The default value is null. It should be specified when modifying the AZ of the specified secondary node needs to be performed during configuration adjustment. When MultiZones = MultiZones, the AZs of the primary nodes and secondary nodes cannot all be the same. The collection of AZs of the secondary node can include 2-5 AZs.
        /// </summary>
        [JsonProperty("DrZones")]
        public DrZoneInfo[] DrZones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "HAType", this.HAType);
            this.SetParamSimple(map, prefix + "MultiZones", this.MultiZones);
            this.SetParamArrayObj(map, prefix + "DrZones.", this.DrZones);
        }
    }
}

