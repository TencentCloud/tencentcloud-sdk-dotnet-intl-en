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

    public class ModifyAccountPrivilegesRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of cdb-c1nl9rpv. It is the same as the instance ID displayed on the TencentDB Console page.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Database account, including username and domain name.
        /// </summary>
        [JsonProperty("Accounts")]
        public Account[] Accounts{ get; set; }

        /// <summary>
        /// Global permission. Valid values: "SELECT", "INSERT", "UPDATE", "DELETE", "CREATE", "PROCESS", "DROP", "REFERENCES", "INDEX", "ALTER", "SHOW DATABASES", "CREATE TEMPORARY TABLES", "LOCK TABLES", "EXECUTE", "CREATE VIEW", "SHOW VIEW", "CREATE ROUTINE", "ALTER ROUTINE", "EVENT", "TRIGGER", "CREATE USER", "RELOAD", "REPLICATION CLIENT", "REPLICATION SLAVE".
        /// Note: When “ModifyAction” is empty, if `GlobalPrivileges` is not passed in, it indicates the global permission will become ineffective.
        /// </summary>
        [JsonProperty("GlobalPrivileges")]
        public string[] GlobalPrivileges{ get; set; }

        /// <summary>
        /// Database permission. Valid values: "SELECT", "INSERT", "UPDATE", "DELETE", "CREATE", "DROP", "REFERENCES", "INDEX", "ALTER", "CREATE TEMPORARY TABLES", "LOCK TABLES", "EXECUTE", "CREATE VIEW", "SHOW VIEW", "CREATE ROUTINE", "ALTER ROUTINE", "EVENT", "TRIGGER".
        /// Note: When “ModifyAction” is empty, if `DatabasePrivileges` is not passed in, it indicates the permission of the database will become ineffective.
        /// </summary>
        [JsonProperty("DatabasePrivileges")]
        public DatabasePrivilege[] DatabasePrivileges{ get; set; }

        /// <summary>
        /// Table permission in the database. Valid values: "SELECT", "INSERT", "UPDATE", "DELETE", "CREATE", "DROP", "REFERENCES", "INDEX", "ALTER", "CREATE VIEW", "SHOW VIEW", "TRIGGER".
        /// Note: When “ModifyAction” is empty, if `TablePrivileges` is not passed in, it indicates the permission of the table will become ineffective.
        /// </summary>
        [JsonProperty("TablePrivileges")]
        public TablePrivilege[] TablePrivileges{ get; set; }

        /// <summary>
        /// Column permission in the table. Valid values: "SELECT", "INSERT", "UPDATE", "REFERENCES".
        /// Note: When “ModifyAction” is empty, if `ColumnPrivileges` is not passed in, it indicates the permission of the column will become ineffective.
        /// </summary>
        [JsonProperty("ColumnPrivileges")]
        public ColumnPrivilege[] ColumnPrivileges{ get; set; }

        /// <summary>
        /// When this parameter is not empty, it indicates that the permission will be modified. Valid values: `grant` (grant permission), `revoke` (revoke permission)
        /// </summary>
        [JsonProperty("ModifyAction")]
        public string ModifyAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Accounts.", this.Accounts);
            this.SetParamArraySimple(map, prefix + "GlobalPrivileges.", this.GlobalPrivileges);
            this.SetParamArrayObj(map, prefix + "DatabasePrivileges.", this.DatabasePrivileges);
            this.SetParamArrayObj(map, prefix + "TablePrivileges.", this.TablePrivileges);
            this.SetParamArrayObj(map, prefix + "ColumnPrivileges.", this.ColumnPrivileges);
            this.SetParamSimple(map, prefix + "ModifyAction", this.ModifyAction);
        }
    }
}

