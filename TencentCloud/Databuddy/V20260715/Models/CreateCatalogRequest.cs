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

    public class CreateCatalogRequest : AbstractModel
    {
        
        /// <summary>
        /// catalog name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// catalog type. Available values: TABLE, MODEL, VOLUME
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Workspace unique id
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// ID of the connection
        /// </summary>
        [JsonProperty("ConnectionId")]
        public string ConnectionId{ get; set; }

        /// <summary>
        /// Data catalog source. Option (additional field in the fusion edition). For values, see CatalogSourceEnum: METALAKE (pro edition) / CONNECTION (analytics edition). If not specified, it is handled as METALAKE by default.
        /// </summary>
        [JsonProperty("CatalogSource")]
        public string CatalogSource{ get; set; }

        /// <summary>
        /// Catalog name or database name on the connection side. Required for three-segment data sources, not required for two-segment data sources such as MySQL. For three-segment data sources with MySQL kernels such as Doris, StarRocks, and TChouse-D, fill in the external catalog name. For three-segment data sources with PG kernels such as PostgreSQL, Tencent PG, GaussDB, and Hologres, fill in the databaseName. Not required for two-segment data sources such as MySQL.
        /// </summary>
        [JsonProperty("ConnectionCatalogName")]
        public string ConnectionCatalogName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "ConnectionId", this.ConnectionId);
            this.SetParamSimple(map, prefix + "CatalogSource", this.CatalogSource);
            this.SetParamSimple(map, prefix + "ConnectionCatalogName", this.ConnectionCatalogName);
        }
    }
}

