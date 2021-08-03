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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductPrivilegeUnit : AbstractModel
    {
        
        /// <summary>
        /// Permission name. Valid values:
        /// GlobalPrivileges
        /// DatabasePrivileges
        /// TablePrivileges
        /// ColumnPrivileges
        /// 
        /// When the permission is `DatabasePrivileges`, the database name must be specified by the `Database` parameter;
        /// 
        /// When the permission is `TablePrivileges`, the database name and the table name in the database must be specified by the `Database` and `TableName` parameters;
        /// 
        /// When the permission is `ColumnPrivileges`, the database name, table name in the database, and column name in the table must be specified by the `Database`, `TableName`, and `ColumnName` parameters.
        /// </summary>
        [JsonProperty("PrivilegeName")]
        public string PrivilegeName{ get; set; }

        /// <summary>
        /// Permission list.
        /// For the `Mysql` service, optional permission values are:
        /// 
        /// 1. Valid values of `GlobalPrivileges`: "SELECT","INSERT","UPDATE","DELETE","CREATE", "PROCESS", "DROP","REFERENCES","INDEX","ALTER","SHOW DATABASES","CREATE TEMPORARY TABLES","LOCK TABLES","EXECUTE","CREATE VIEW","SHOW VIEW","CREATE ROUTINE","ALTER ROUTINE","EVENT","TRIGGER".
        /// Note: if this parameter is not passed in, it means to clear the permission.
        /// 
        /// 2. Valid values of `DatabasePrivileges`: "SELECT","INSERT","UPDATE","DELETE","CREATE", "DROP","REFERENCES","INDEX","ALTER","CREATE TEMPORARY TABLES","LOCK TABLES","EXECUTE","CREATE VIEW","SHOW VIEW","CREATE ROUTINE","ALTER ROUTINE","EVENT","TRIGGER".
        /// Note: if this parameter is not passed in, it means to clear the permission.
        /// 
        /// 3. Valid values of `TablePrivileges`: "SELECT","INSERT","UPDATE","DELETE","CREATE", "DROP","REFERENCES","INDEX","ALTER","CREATE VIEW","SHOW VIEW", "TRIGGER".
        /// Note: if this parameter is not passed in, it means to clear the permission.
        /// 
        /// 4. Valid values of `ColumnPrivileges`: "SELECT","INSERT","UPDATE","REFERENCES".
        /// Note: if this parameter is not passed in, it means to clear the permission.
        /// </summary>
        [JsonProperty("Privileges")]
        public string[] Privileges{ get; set; }

        /// <summary>
        /// This value takes effect only when `PrivilegeName` is `DatabasePrivileges`.
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// This value takes effect only when `PrivilegeName` is `TablePrivileges`, and the `Database` parameter is required in this case to explicitly indicate the database instance.
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// This value takes effect only when `PrivilegeName` is `ColumnPrivileges`, and the following parameters are required in this case:
        /// Database: explicitly indicate the database instance.
        /// TableName: explicitly indicate the table
        /// </summary>
        [JsonProperty("ColumnName")]
        public string ColumnName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrivilegeName", this.PrivilegeName);
            this.SetParamArraySimple(map, prefix + "Privileges.", this.Privileges);
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "ColumnName", this.ColumnName);
        }
    }
}

