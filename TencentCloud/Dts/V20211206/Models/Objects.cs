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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Objects : AbstractModel
    {
        
        /// <summary>
        /// <p>Sync object type Partial (partial objects)</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>Sync object, not empty when Mode is Partial</p>
        /// </summary>
        [JsonProperty("Databases")]
        public Database[] Databases{ get; set; }

        /// <summary>
        /// <p>Advanced object types, such as function and procedure. Note: If you need to migrate and synchronize advanced objects, this configuration should contain the corresponding advanced object type. When synchronization of advanced objects is required, the initialization type must contain the structure initialization type, that is, the field value of task Options.InitType must be Structure or Full.</p>
        /// </summary>
        [JsonProperty("AdvancedObjects")]
        public string[] AdvancedObjects{ get; set; }

        /// <summary>
        /// <p>This field is deprecated. For temporary table synchronization, use Objects.Databases[n].Tables[n].TmpTables to import.</p>
        /// </summary>
        [JsonProperty("OnlineDDL")]
        public OnlineDDL OnlineDDL{ get; set; }

        /// <summary>
        /// <p>Database/Table/View-level DML/DDL allowlist</p>
        /// </summary>
        [JsonProperty("DatabasesOpFilter")]
        public DBOpFilter[] DatabasesOpFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "Databases.", this.Databases);
            this.SetParamArraySimple(map, prefix + "AdvancedObjects.", this.AdvancedObjects);
            this.SetParamObj(map, prefix + "OnlineDDL.", this.OnlineDDL);
            this.SetParamArrayObj(map, prefix + "DatabasesOpFilter.", this.DatabasesOpFilter);
        }
    }
}

