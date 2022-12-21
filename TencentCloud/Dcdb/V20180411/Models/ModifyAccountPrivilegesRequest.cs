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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAccountPrivilegesRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of tdsql-c1nl9rpv. It is the same as the instance ID displayed in the TencentDB console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Database account, including username and host address.
        /// </summary>
        [JsonProperty("Accounts")]
        public Account[] Accounts{ get; set; }

        /// <summary>
        /// Global permission. Valid values: "SELECT", "INSERT", "UPDATE", "DELETE", "CREATE", "PROCESS", "DROP", "REFERENCES", "INDEX", "ALTER", "SHOW DATABASES", "CREATE TEMPORARY TABLES", "LOCK TABLES", "EXECUTE", "CREATE VIEW", "SHOW VIEW", "CREATE ROUTINE", "ALTER ROUTINE", "EVENT", "TRIGGER".
        /// Note: If the parameter is left empty, no change will be made to the granted global permissions. To clear the granted global permissions, set the parameter to an empty array.
        /// </summary>
        [JsonProperty("GlobalPrivileges")]
        public string[] GlobalPrivileges{ get; set; }

        /// <summary>
        /// Database permission. Value range: "SELECT", "INSERT", "UPDATE", "DELETE", "CREATE", "DROP", "REFERENCES", "INDEX", "ALTER", "CREATE TEMPORARY TABLES", "LOCK TABLES", "EXECUTE", "CREATE VIEW", "SHOW VIEW", "CREATE ROUTINE", "ALTER ROUTINE", "EVENT", "TRIGGER".	
        /// Note: If the parameter is not passed in, no change will be made to the granted stored procedure permissions. To clear the granted database permissions, set `Privileges` to an empty array.
        /// </summary>
        [JsonProperty("DatabasePrivileges")]
        public DatabasePrivilege[] DatabasePrivileges{ get; set; }

        /// <summary>
        /// Database table permission. Valid values of `Privileges`: `SELECT`, `INSERT`, `UPDATE`, `DELETE`, `CREATE`, `DROP`, `REFERENCES`, `INDEX`, `ALTER`, `CREATE VIEW`, `SHOW VIEW`, `TRIGGER`.
        /// Note: If the parameter is not passed in, no change will be made to the granted view permissions. To clear the granted table permissions, set `Privileges` to an empty array.
        /// </summary>
        [JsonProperty("TablePrivileges")]
        public TablePrivilege[] TablePrivileges{ get; set; }

        /// <summary>
        /// Column permission in the table. Valid values: "SELECT", "INSERT", "UPDATE", "REFERENCES".
        /// Note: If the parameter is not passed in, no change will be made to the granted column permissions. To clear the granted column permissions, set `Privileges` to an empty array.
        /// </summary>
        [JsonProperty("ColumnPrivileges")]
        public ColumnPrivilege[] ColumnPrivileges{ get; set; }

        /// <summary>
        /// Database view permission. Valid values of `Privileges`: `SELECT`, `INSERT`, `UPDATE`, `DELETE`, `CREATE`, `DROP`, `REFERENCES`, `INDEX`, `ALTER`, `CREATE VIEW`, `SHOW VIEW`, `TRIGGER`.
        /// Note: If the parameter is not passed in, no change will be made to the granted table permissions. To clear the granted view permissions, set `Privileges` to an empty array.
        /// </summary>
        [JsonProperty("ViewPrivileges")]
        public ViewPrivileges[] ViewPrivileges{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "ViewPrivileges.", this.ViewPrivileges);
        }
    }
}

