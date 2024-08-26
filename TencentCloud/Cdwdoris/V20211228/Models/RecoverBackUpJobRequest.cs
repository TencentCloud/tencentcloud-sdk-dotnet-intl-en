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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecoverBackUpJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("BackUpJobId")]
        public long? BackUpJobId{ get; set; }

        /// <summary>
        /// Number of new table replicas recovered
        /// </summary>
        [JsonProperty("ReplicationNum")]
        public long? ReplicationNum{ get; set; }

        /// <summary>
        /// Whether to retain the configuration in the source table during recovery. 1 indicates that the configurations in the source table are retained.
        /// </summary>
        [JsonProperty("ReserveSourceConfig")]
        public long? ReserveSourceConfig{ get; set; }

        /// <summary>
        /// 0: default; 1: cos recovery
        /// </summary>
        [JsonProperty("RecoverType")]
        public long? RecoverType{ get; set; }

        /// <summary>
        /// CosSourceInfo object
        /// </summary>
        [JsonProperty("CosSourceInfo")]
        public CosSourceInfo CosSourceInfo{ get; set; }

        /// <summary>
        /// 0: default; 1: regular execution
        /// </summary>
        [JsonProperty("ScheduleType")]
        public long? ScheduleType{ get; set; }

        /// <summary>
        /// YY-MM-DD Hour : Minute : Second
        /// </summary>
        [JsonProperty("NextTime")]
        public string NextTime{ get; set; }

        /// <summary>
        /// Scheduling name
        /// </summary>
        [JsonProperty("ScheduleName")]
        public string ScheduleName{ get; set; }

        /// <summary>
        /// create update
        /// </summary>
        [JsonProperty("OperationType")]
        public string OperationType{ get; set; }

        /// <summary>
        /// Recovery granularity: All, Database, and Table
        /// </summary>
        [JsonProperty("RecoverScope")]
        public string RecoverScope{ get; set; }

        /// <summary>
        /// Recover database: If you back up by database, this field is required. Use commas to separate databases.
        /// </summary>
        [JsonProperty("RecoverDatabase")]
        public string RecoverDatabase{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackUpJobId", this.BackUpJobId);
            this.SetParamSimple(map, prefix + "ReplicationNum", this.ReplicationNum);
            this.SetParamSimple(map, prefix + "ReserveSourceConfig", this.ReserveSourceConfig);
            this.SetParamSimple(map, prefix + "RecoverType", this.RecoverType);
            this.SetParamObj(map, prefix + "CosSourceInfo.", this.CosSourceInfo);
            this.SetParamSimple(map, prefix + "ScheduleType", this.ScheduleType);
            this.SetParamSimple(map, prefix + "NextTime", this.NextTime);
            this.SetParamSimple(map, prefix + "ScheduleName", this.ScheduleName);
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
            this.SetParamSimple(map, prefix + "RecoverScope", this.RecoverScope);
            this.SetParamSimple(map, prefix + "RecoverDatabase", this.RecoverDatabase);
        }
    }
}

