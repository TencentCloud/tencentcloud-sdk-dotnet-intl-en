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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrateOption : AbstractModel
    {
        
        /// <summary>
        /// Migration object options, which tell DTS which database/table objects should be migrated.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatabaseTable")]
        public DatabaseTableObject DatabaseTable{ get; set; }

        /// <summary>
        /// Migration type. Valid values: `full`, `structure`, `fullAndIncrement`. Default value: `fullAndIncrement`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MigrateType")]
        public string MigrateType{ get; set; }

        /// <summary>
        /// Data consistency check option. Data consistency check is disabled by default.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Consistency")]
        public ConsistencyOption Consistency{ get; set; }

        /// <summary>
        /// Whether to migrate accounts. Valid values: `yes`, `no`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsMigrateAccount")]
        public bool? IsMigrateAccount{ get; set; }

        /// <summary>
        /// Whether to use the `Root` account in the source database to overwrite that in the target database. Valid values: `false`, `true`. For database/table or structural migration, you should specify `false`. Note that this parameter takes effect only for OldDTS.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsOverrideRoot")]
        public bool? IsOverrideRoot{ get; set; }

        /// <summary>
        /// Whether to set the target database to read-only during migration, which takes effect only for MySQL databases. Valid values: `true`, `false`. Default value: `false`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsDstReadOnly")]
        public bool? IsDstReadOnly{ get; set; }

        /// <summary>
        /// Additional information. You can set additional parameters for certain database types. For Redis, you can define the following parameters: 
        /// ["DstWriteMode": `normal`. 	Target database write mode. Valid values: `clearData` (Clear the target instance data), overwrite` (Execute the task in overwriting mode), `normal` (Follow the normal steps) 	"IsDstReadOnly": `true`. 	Whether to set the target database to read-only for a migration task. Valid values: `true` (Yes), `false` (No) 	"ClientOutputBufferHardLimit": 512. 	Hard limit of the replica buffer zone capacity in MB. 	"ClientOutputBufferSoftLimit": 512. 	Soft limit of the replica buffer zone capacity in MB. 	"ClientOutputBufferPersistTime": 60. Soft limit duration of the replica buffer zone in seconds. 	"ReplBacklogSize": 512, 	Limit of the circular buffer zone capacity in MB. 	"ReplTimeout":120,		Replication timeout period in seconds]
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtraAttr")]
        public KeyValuePairOption[] ExtraAttr{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MigrateWay")]
        public string MigrateWay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DatabaseTable.", this.DatabaseTable);
            this.SetParamSimple(map, prefix + "MigrateType", this.MigrateType);
            this.SetParamObj(map, prefix + "Consistency.", this.Consistency);
            this.SetParamSimple(map, prefix + "IsMigrateAccount", this.IsMigrateAccount);
            this.SetParamSimple(map, prefix + "IsOverrideRoot", this.IsOverrideRoot);
            this.SetParamSimple(map, prefix + "IsDstReadOnly", this.IsDstReadOnly);
            this.SetParamArrayObj(map, prefix + "ExtraAttr.", this.ExtraAttr);
            this.SetParamSimple(map, prefix + "MigrateWay", this.MigrateWay);
        }
    }
}

