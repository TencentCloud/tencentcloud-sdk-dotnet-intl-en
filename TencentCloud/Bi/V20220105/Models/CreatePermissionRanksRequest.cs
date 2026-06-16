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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePermissionRanksRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>page number</p>
        /// </summary>
        [JsonProperty("TableId")]
        public long? TableId{ get; set; }

        /// <summary>
        /// <p>Mode</p><p>Enumeration value:</p><ul><li>ALL: All</li><li>Specify: Specify</li><li>TAG: Tag</li></ul><p>Default value: ALL</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>Role type</p><p>Enumeration value:</p><ul><li>ROLES: By role</li><li>Others: Other</li></ul><p>Default value: Others</p>
        /// </summary>
        [JsonProperty("RoleType")]
        public string RoleType{ get; set; }

        /// <summary>
        /// <p>All page numbers</p>
        /// </summary>
        [JsonProperty("RoleId")]
        public long? RoleId{ get; set; }

        /// <summary>
        /// <p>Rule information</p>
        /// </summary>
        [JsonProperty("RulerInfo")]
        public string RulerInfo{ get; set; }

        /// <summary>
        /// <p>Type</p><p>Enumeration value:</p><ul><li>ROW: row permission</li><li>COLUMN: column permission</li></ul><p>Default value: ROW</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Enabled status</p><p>Enumeration value:</p><ul><li>Open: Turn on</li><li>Close: Turn off</li></ul><p>Default value: Close</p>
        /// </summary>
        [JsonProperty("OpenStatus")]
        public string OpenStatus{ get; set; }

        /// <summary>
        /// <p>Project ID.</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>Row/column permission configuration</p>
        /// </summary>
        [JsonProperty("RowColumnConfigList")]
        public RowColumnConfig[] RowColumnConfigList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "RoleType", this.RoleType);
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamSimple(map, prefix + "RulerInfo", this.RulerInfo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "OpenStatus", this.OpenStatus);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "RowColumnConfigList.", this.RowColumnConfigList);
        }
    }
}

