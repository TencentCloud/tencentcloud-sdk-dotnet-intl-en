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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteSchemaRequest : AbstractModel
    {
        
        /// <summary>
        /// Data catalog name
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// Database name
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// Unique id of the workspace where the call is made
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// Data source connection ID. Selectable (additional field in Fusion Edition). Schemas in the analytics edition catalog cannot be deleted. If a non-empty value is imported, the server returns the ANA_catalog_NOT_SUPPORTED error.
        /// </summary>
        [JsonProperty("ConnectionId")]
        public string ConnectionId{ get; set; }

        /// <summary>
        /// Data catalog source. Optional (additional fields added by Setats fusion). Values: METALAKE (Pro Edition tclake) / CONNECTION (Analytics Edition Linked Catalog) / SETATS (Setats metadata). Routing priority: explicit non-empty CatalogSource > non-empty ConnectionId (deemed as CONNECTION) > default METALAKE. ConnectionId will be ignored when CatalogSource is non-empty.
        /// </summary>
        [JsonProperty("CatalogSource")]
        public string CatalogSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "ConnectionId", this.ConnectionId);
            this.SetParamSimple(map, prefix + "CatalogSource", this.CatalogSource);
        }
    }
}

