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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Whether to only perform pre-check without actually executing the configuration change. true: only return the configuration change plan and pre-check result; false: actually execute the configuration change (default)</p>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>Number of CPU cores of peer nodes. If not passed, maintain current value unchanged</p>
        /// </summary>
        [JsonProperty("HybridNodeCpu")]
        public long? HybridNodeCpu{ get; set; }

        /// <summary>
        /// <p>Peer-to-peer node memory size in GB. If not passed, maintain current value unchanged</p>
        /// </summary>
        [JsonProperty("HybridNodeMem")]
        public long? HybridNodeMem{ get; set; }

        /// <summary>
        /// <p>Number of peer nodes. If not passed, maintain current value unchanged</p>
        /// </summary>
        [JsonProperty("HybridNodeNum")]
        public long? HybridNodeNum{ get; set; }

        /// <summary>
        /// <p>Peer-to-peer node disk capacity in GB. If not passed, maintain current value unchanged</p>
        /// </summary>
        [JsonProperty("Disk")]
        public long? Disk{ get; set; }

        /// <summary>
        /// <p>Storage type. Available values: CLOUD_HSSD (enhanced SSD cloud disk), CLOUD_TCS (local disk), CLOUD_BSSD (universal SSD cloud disk). If not specified, the current value remains unchanged.</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>Specification code, for example, 4c8g, 16c32g</p>
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// <p>Target AZ list. If not passed, maintain current value unchanged</p>
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// <p>Availability zone mode. 1: single availability zone. 3: multi-availability zone primary AZ mode</p>
        /// </summary>
        [JsonProperty("AZMode")]
        public long? AZMode{ get; set; }

        /// <summary>
        /// <p>Primary AZ. This parameter is valid only when AZMode is 3</p>
        /// </summary>
        [JsonProperty("PrimaryAZ")]
        public string PrimaryAZ{ get; set; }

        /// <summary>
        /// <p>Number of replicas, value ranges from 1 to 3</p>
        /// </summary>
        [JsonProperty("FullReplications")]
        public long? FullReplications{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "HybridNodeCpu", this.HybridNodeCpu);
            this.SetParamSimple(map, prefix + "HybridNodeMem", this.HybridNodeMem);
            this.SetParamSimple(map, prefix + "HybridNodeNum", this.HybridNodeNum);
            this.SetParamSimple(map, prefix + "Disk", this.Disk);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "AZMode", this.AZMode);
            this.SetParamSimple(map, prefix + "PrimaryAZ", this.PrimaryAZ);
            this.SetParamSimple(map, prefix + "FullReplications", this.FullReplications);
        }
    }
}

