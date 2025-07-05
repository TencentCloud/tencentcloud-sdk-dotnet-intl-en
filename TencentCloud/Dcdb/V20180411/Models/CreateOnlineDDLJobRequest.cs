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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOnlineDDLJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Specifies the DDL statement to be executed. Common online DDL refer to this API documentation example section.
        /// </summary>
        [JsonProperty("Alter")]
        public string Alter{ get; set; }

        /// <summary>
        /// Specifies the database to be modified.	
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// Specifies the table to be modified.
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// Specifies the account to execute DDL. Ensure the account has ALTER, CREATE, INSERT, UPDATE, DROP, DELETE, INDEX, CREATE TEMPORARY TABLES, LOCK TABLES, TRIGGER, REPLICATION CLIENT, REPLICATION SLAVE permissions. If not specified, the system account will be used by default.
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Specifies the password for the account.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Indicates that DDL will terminate if the number of running threads exceeds this value. Default is 58 if not specified.
        /// </summary>
        [JsonProperty("CriticalLoad")]
        public long? CriticalLoad{ get; set; }

        /// <summary>
        /// Specifies whether to check auto-increment fields. If set to 1, modification of auto-increment fields is not allowed; if set to 0 or left empty, no check is performed.
        /// </summary>
        [JsonProperty("CheckAutoInc")]
        public long? CheckAutoInc{ get; set; }

        /// <summary>
        /// Allowed primary-secondary delay time (in seconds). If set to 0 or left empty, do not check delay.
        /// </summary>
        [JsonProperty("MaxDelay")]
        public long? MaxDelay{ get; set; }

        /// <summary>
        /// Indicates whether to use pt-osc tool for DDL.
        /// </summary>
        [JsonProperty("UsePt")]
        public long? UsePt{ get; set; }

        /// <summary>
        /// Start Execution Time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Alter", this.Alter);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "CriticalLoad", this.CriticalLoad);
            this.SetParamSimple(map, prefix + "CheckAutoInc", this.CheckAutoInc);
            this.SetParamSimple(map, prefix + "MaxDelay", this.MaxDelay);
            this.SetParamSimple(map, prefix + "UsePt", this.UsePt);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
        }
    }
}

