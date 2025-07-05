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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PermissionHostInfo : AbstractModel
    {
        
        /// <summary>
        /// A list of user permissions in the global scope, which can be applied to all databases and tables.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GlobalPermissions")]
        public string[] GlobalPermissions{ get; set; }

        /// <summary>
        /// The key is the database name, and the value is the permission list of the user on the database.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatabasePermissions")]
        public DatabasePermissions[] DatabasePermissions{ get; set; }

        /// <summary>
        /// The key is the full name of the table, and the value is the permission list of the user on the table.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TablePermissions")]
        public TablePermissions[] TablePermissions{ get; set; }

        /// <summary>
        /// The key is the full name of the catalog, and the value is the permission list of the user on the catalog.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CatalogPermissions")]
        public CatalogPermission[] CatalogPermissions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "GlobalPermissions.", this.GlobalPermissions);
            this.SetParamArrayObj(map, prefix + "DatabasePermissions.", this.DatabasePermissions);
            this.SetParamArrayObj(map, prefix + "TablePermissions.", this.TablePermissions);
            this.SetParamArrayObj(map, prefix + "CatalogPermissions.", this.CatalogPermissions);
        }
    }
}

