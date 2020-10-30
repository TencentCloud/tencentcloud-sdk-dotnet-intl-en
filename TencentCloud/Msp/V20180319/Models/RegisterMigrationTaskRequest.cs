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

namespace TencentCloud.Msp.V20180319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterMigrationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Task type, valid values include `database` (database migration), `file` (file migration) or `host` (host migration).
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Task name
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Service supplier name
        /// </summary>
        [JsonProperty("ServiceSupplier")]
        public string ServiceSupplier{ get; set; }

        /// <summary>
        /// Migration task creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Migration task update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Migration type, for example `mysql:mysql` in database migration means migration from mysql to mysql and `oss:cos` in file migration means migration from Alibaba Cloud OSS to Tencent COS.
        /// </summary>
        [JsonProperty("MigrateClass")]
        public string MigrateClass{ get; set; }

        /// <summary>
        /// Migration task source information
        /// </summary>
        [JsonProperty("SrcInfo")]
        public SrcInfo SrcInfo{ get; set; }

        /// <summary>
        /// Migration task destination information
        /// </summary>
        [JsonProperty("DstInfo")]
        public DstInfo DstInfo{ get; set; }

        /// <summary>
        /// Source instance access type. Valid values for database migration include `extranet` (public network), `cvm` (CVM-created instance), `dcg` (Direct Connect-enabled instance), `vpncloud` (Tencent Cloud VPN-enabled instance), `vpnselfbuild` (self-built VPN-enabled instance), `cdb` (TencentDB instance)
        /// </summary>
        [JsonProperty("SrcAccessType")]
        public string SrcAccessType{ get; set; }

        /// <summary>
        /// Database type of the source instance. Valid values for database migration: `mysql`, `redis`, `percona`, `mongodb`, `postgresql`, `sqlserver`, `mariadb`
        /// </summary>
        [JsonProperty("SrcDatabaseType")]
        public string SrcDatabaseType{ get; set; }

        /// <summary>
        /// Target instance access type. Valid values for database migration include `extranet` (public network), `cvm` (CVM-created instance), `dcg` (Direct Connect-enabled instance), `vpncloud` (Tencent Cloud VPN-enabled instance), `vpnselfbuild` (self-built VPN-enabled instance), `cdb` (TencentDB instance)
        /// </summary>
        [JsonProperty("DstAccessType")]
        public string DstAccessType{ get; set; }

        /// <summary>
        /// Database type of the target instance. Valid values for database migration: `mysql`, `redis`, `percona`, `mongodb`, `postgresql`, `sqlserver`, `mariadb`
        /// </summary>
        [JsonProperty("DstDatabaseType")]
        public string DstDatabaseType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "ServiceSupplier", this.ServiceSupplier);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "MigrateClass", this.MigrateClass);
            this.SetParamObj(map, prefix + "SrcInfo.", this.SrcInfo);
            this.SetParamObj(map, prefix + "DstInfo.", this.DstInfo);
            this.SetParamSimple(map, prefix + "SrcAccessType", this.SrcAccessType);
            this.SetParamSimple(map, prefix + "SrcDatabaseType", this.SrcDatabaseType);
            this.SetParamSimple(map, prefix + "DstAccessType", this.DstAccessType);
            this.SetParamSimple(map, prefix + "DstDatabaseType", this.DstDatabaseType);
        }
    }
}

