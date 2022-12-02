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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableItem : AbstractModel
    {
        
        /// <summary>
        /// Name of the table to be migrated
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Name of the table after migration, which is required if `TableEditMode` is `rename`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NewTableName")]
        public string NewTableName{ get; set; }

        /// <summary>
        /// Temp table to be migrated, which is required if `TableEditMode` is `pt`. To sync temp tables that may be generated during migration by tools such as pt-online-schema-change, you can use this parameter to configure the temp table names.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TmpTables")]
        public string[] TmpTables{ get; set; }

        /// <summary>
        /// Table editing type. Valid values: `rename` (table mapping); `pt` (additional table sync).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableEditMode")]
        public string TableEditMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "NewTableName", this.NewTableName);
            this.SetParamArraySimple(map, prefix + "TmpTables.", this.TmpTables);
            this.SetParamSimple(map, prefix + "TableEditMode", this.TableEditMode);
        }
    }
}

