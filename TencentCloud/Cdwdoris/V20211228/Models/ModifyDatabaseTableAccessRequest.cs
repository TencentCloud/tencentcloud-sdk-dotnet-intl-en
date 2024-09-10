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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDatabaseTableAccessRequest : AbstractModel
    {
        
        /// <summary>
        /// Database name
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// Table name. If it is null, it indicates that the entire database is authorized.
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// Permission list
        /// </summary>
        [JsonProperty("Privileges")]
        public string[] Privileges{ get; set; }

        /// <summary>
        /// Role name, if authorized to the role
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// Operation type: GRANT or REVOKE
        /// </summary>
        [JsonProperty("GrantOrRevoke")]
        public string GrantOrRevoke{ get; set; }

        /// <summary>
        /// Use the user who has corresponding permissions for operations. If the TCHouse-D cluster uses a kernel account registered by a CAM user, you do not need to fill it in.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Password corresponding to the user. If the TCHouse-D cluster uses a kernel account registered by a CAM user, you do not need to fill it in.
        /// </summary>
        [JsonProperty("PassWord")]
        public string PassWord{ get; set; }

        /// <summary>
        /// Catalog name, defaults to internal if not specified.
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// InstanceId
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Machine Group, defaults to % if not specified.
        /// </summary>
        [JsonProperty("WhiteHost")]
        public string WhiteHost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamArraySimple(map, prefix + "Privileges.", this.Privileges);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "GrantOrRevoke", this.GrantOrRevoke);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PassWord", this.PassWord);
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "WhiteHost", this.WhiteHost);
        }
    }
}

