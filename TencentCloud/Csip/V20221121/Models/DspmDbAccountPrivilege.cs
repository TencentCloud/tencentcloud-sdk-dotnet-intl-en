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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmDbAccountPrivilege : AbstractModel
    {
        
        /// <summary>
        /// Use the default permission. 0: inactive; 1: read-only permission, that is, SELECT permission; 2: all permissions, that is, all permissions at the global level.
        /// </summary>
        [JsonProperty("UseDefaultPrivilege")]
        public long? UseDefaultPrivilege{ get; set; }

        /// <summary>
        /// Global permission array.
        /// </summary>
        [JsonProperty("GlobalPrivileges")]
        public string[] GlobalPrivileges{ get; set; }

        /// <summary>
        /// Database permission array.
        /// </summary>
        [JsonProperty("DatabasePrivilegesList")]
        public DspmDatabasePrivilege[] DatabasePrivilegesList{ get; set; }

        /// <summary>
        /// Array of table permissions in the database.
        /// </summary>
        [JsonProperty("TablePrivileges")]
        public DspmTablePrivilege[] TablePrivileges{ get; set; }

        /// <summary>
        /// Column permission array in the database table.
        /// </summary>
        [JsonProperty("ColumnPrivileges")]
        public DspmColumnPrivilege[] ColumnPrivileges{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UseDefaultPrivilege", this.UseDefaultPrivilege);
            this.SetParamArraySimple(map, prefix + "GlobalPrivileges.", this.GlobalPrivileges);
            this.SetParamArrayObj(map, prefix + "DatabasePrivilegesList.", this.DatabasePrivilegesList);
            this.SetParamArrayObj(map, prefix + "TablePrivileges.", this.TablePrivileges);
            this.SetParamArrayObj(map, prefix + "ColumnPrivileges.", this.ColumnPrivileges);
        }
    }
}

