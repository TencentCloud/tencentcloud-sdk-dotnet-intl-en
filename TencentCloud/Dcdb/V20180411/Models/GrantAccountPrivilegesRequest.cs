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

    public class GrantAccountPrivilegesRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of dcdbt-ow728lmc.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Login username.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Access host allowed for a user. An account is uniquely identified by username and host.
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// Database name. `\*` indicates that global permissions will be queried (i.e., `\*.\*`), in which case the `Type` and `Object ` parameters will be ignored
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// Global permission. Valid values: SELECT; INSERT; UPDATE; DELETE; CREATE; DROP; REFERENCES; INDEX; ALTER; CREATE TEMPORARY TABLES; LOCK TABLES; EXECUTE; CREATE VIEW; SHOW VIEW; CREATE ROUTINE; ALTER ROUTINE; EVENT; TRIGGER; SHOW DATABASES 
        /// Database permission. Valid values: SELECT; INSERT; UPDATE; DELETE; CREATE; DROP; REFERENCES; INDEX; ALTER; CREATE TEMPORARY TABLES; LOCK TABLES; EXECUTE; CREATE VIEW; SHOW VIEW; CREATE ROUTINE; ALTER ROUTINE; EVENT; TRIGGER 
        /// Table/view permission. Valid values: SELECT; INSERT; UPDATE; DELETE; CREATE; DROP; REFERENCES; INDEX; ALTER; CREATE VIEW; SHOW VIEW; TRIGGER 
        /// Stored procedure/function permission. Valid values: ALTER ROUTINE; EXECUTE 
        /// Field permission. Valid values: INSERT; REFERENCES; SELECT; UPDATE
        /// </summary>
        [JsonProperty("Privileges")]
        public string[] Privileges{ get; set; }

        /// <summary>
        /// Type. Valid values: table; view; proc; func; \*. If `DbName` is a specific database name and `Type` is `\*`, the permissions of the database will be set (i.e., `db.\*`), in which case the `Object` parameter will be ignored
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Type name. For example, if `Type` = table, it indicates a specific table name; if both `DbName` and `Type` are specific names, `Object` indicates a specific object name and cannot be `\*` or empty
        /// </summary>
        [JsonProperty("Object")]
        public string Object{ get; set; }

        /// <summary>
        /// If `Type` = table and `ColName` is `\*`, the permissions will be granted to the table; if `ColName` is a specific field name, the permissions will be granted to the field
        /// </summary>
        [JsonProperty("ColName")]
        public string ColName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamArraySimple(map, prefix + "Privileges.", this.Privileges);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Object", this.Object);
            this.SetParamSimple(map, prefix + "ColName", this.ColName);
        }
    }
}

