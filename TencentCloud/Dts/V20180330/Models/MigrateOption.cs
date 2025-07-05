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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrateOption : AbstractModel
    {
        
        /// <summary>
        /// Task operation mode. Value range: 1 (immediate execution), 2 (scheduled execution)
        /// </summary>
        [JsonProperty("RunMode")]
        public long? RunMode{ get; set; }

        /// <summary>
        /// Expected execution time in the format of yyyy-mm-dd hh:mm:ss. If runMode=2, this field is required
        /// </summary>
        [JsonProperty("ExpectTime")]
        public string ExpectTime{ get; set; }

        /// <summary>
        /// Data migration type. Value range: 1 (structural migration), 2 (full migration), 3 (full + incremental migration)
        /// </summary>
        [JsonProperty("MigrateType")]
        public long? MigrateType{ get; set; }

        /// <summary>
        /// Migration subject. 1: entire instance; 2: specified table
        /// </summary>
        [JsonProperty("MigrateObject")]
        public long? MigrateObject{ get; set; }

        /// <summary>
        /// Parameter of spot data consistency check. 1: not configured; 2: full check; 3: spot check; 4: check inconsistent tables only; 5: no check
        /// </summary>
        [JsonProperty("ConsistencyType")]
        public long? ConsistencyType{ get; set; }

        /// <summary>
        /// Whether to overwrite the target database with the root account of the source database. Value range: 0 (no), 1 (yes). This value should be 0 for table or structural migration
        /// </summary>
        [JsonProperty("IsOverrideRoot")]
        public long? IsOverrideRoot{ get; set; }

        /// <summary>
        /// Additional parameters for different databases, which are described in JSON format. 
        /// The following parameters can be defined for Redis: 
        /// { 
        /// 	"ClientOutputBufferHardLimit":512, 	Hard capacity limit of slave buffer (MB) 
        /// 	"ClientOutputBufferSoftLimit":512, 	Soft capacity limit of slave buffer (MB) 
        /// 	"ClientOutputBufferPersistTime":60, Soft limit duration of slave buffer (s) 
        /// 	"ReplBacklogSize":512, 	Circular buffer capacity limit (MB) 
        /// 	"ReplTimeout":120, 		Replication timeout period (s) 
        /// }
        /// The following parameters can be defined for MongoDB: 
        /// {
        /// 	'SrcAuthDatabase':'admin', 
        /// 	'SrcAuthFlag': "1", 
        /// 	'SrcAuthMechanism':"SCRAM-SHA-1"
        /// }
        /// MySQL currently does not support configuring additional parameters.
        /// </summary>
        [JsonProperty("ExternParams")]
        public string ExternParams{ get; set; }

        /// <summary>
        /// Only used for "spot data consistency check". It is required if ConsistencyType is spot check
        /// </summary>
        [JsonProperty("ConsistencyParams")]
        public ConsistencyParams ConsistencyParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "ExpectTime", this.ExpectTime);
            this.SetParamSimple(map, prefix + "MigrateType", this.MigrateType);
            this.SetParamSimple(map, prefix + "MigrateObject", this.MigrateObject);
            this.SetParamSimple(map, prefix + "ConsistencyType", this.ConsistencyType);
            this.SetParamSimple(map, prefix + "IsOverrideRoot", this.IsOverrideRoot);
            this.SetParamSimple(map, prefix + "ExternParams", this.ExternParams);
            this.SetParamObj(map, prefix + "ConsistencyParams.", this.ConsistencyParams);
        }
    }
}

