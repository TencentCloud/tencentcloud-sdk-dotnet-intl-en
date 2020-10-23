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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSyncJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Disaster recovery sync task name
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// Configuration options of a disaster recovery sync task
        /// </summary>
        [JsonProperty("SyncOption")]
        public SyncOption SyncOption{ get; set; }

        /// <summary>
        /// Source instance database type, which currently only supports mysql
        /// </summary>
        [JsonProperty("SrcDatabaseType")]
        public string SrcDatabaseType{ get; set; }

        /// <summary>
        /// Source instance access type, which currently only supports cdb (TencentDB instances)
        /// </summary>
        [JsonProperty("SrcAccessType")]
        public string SrcAccessType{ get; set; }

        /// <summary>
        /// Source instance information
        /// </summary>
        [JsonProperty("SrcInfo")]
        public SyncInstanceInfo SrcInfo{ get; set; }

        /// <summary>
        /// Target instance access type, which currently only supports mysql
        /// </summary>
        [JsonProperty("DstDatabaseType")]
        public string DstDatabaseType{ get; set; }

        /// <summary>
        /// Target instance access type, which currently only supports cdb (TencentDB instances)
        /// </summary>
        [JsonProperty("DstAccessType")]
        public string DstAccessType{ get; set; }

        /// <summary>
        /// Target instance information
        /// </summary>
        [JsonProperty("DstInfo")]
        public SyncInstanceInfo DstInfo{ get; set; }

        /// <summary>
        /// Information of the source table to be synced, which is described in JSON string format.
        /// For databases with a database-table structure:
        /// [{Database:db1,Table:[table1,table2]},{Database:db2}]
        /// </summary>
        [JsonProperty("DatabaseInfo")]
        public string DatabaseInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamObj(map, prefix + "SyncOption.", this.SyncOption);
            this.SetParamSimple(map, prefix + "SrcDatabaseType", this.SrcDatabaseType);
            this.SetParamSimple(map, prefix + "SrcAccessType", this.SrcAccessType);
            this.SetParamObj(map, prefix + "SrcInfo.", this.SrcInfo);
            this.SetParamSimple(map, prefix + "DstDatabaseType", this.DstDatabaseType);
            this.SetParamSimple(map, prefix + "DstAccessType", this.DstAccessType);
            this.SetParamObj(map, prefix + "DstInfo.", this.DstInfo);
            this.SetParamSimple(map, prefix + "DatabaseInfo", this.DatabaseInfo);
        }
    }
}

