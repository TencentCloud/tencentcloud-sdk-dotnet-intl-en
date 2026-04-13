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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DatabasePrivilege : AbstractModel
    {
        
        /// <summary>
        /// The database object. when ObjectType is database, DatabaseName/SchemaName/TableName can be empty. when ObjectType is schema, SchemaName/TableName can be empty. when ObjectType is column, TableName cannot be empty. other cases can be empty.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Object")]
        public DatabaseObject Object{ get; set; }

        /// <summary>
        /// Specifies the permission list of the specified account for the database object.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PrivilegeSet")]
        public string[] PrivilegeSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Object.", this.Object);
            this.SetParamArraySimple(map, prefix + "PrivilegeSet.", this.PrivilegeSet);
        }
    }
}

