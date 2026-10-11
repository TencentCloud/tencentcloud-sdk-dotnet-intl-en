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

    public class GetCatalogRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Data catalog name.</p>
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// <p>Unique id of the workspace where the call is made.</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Data directory id</p>
        /// </summary>
        [JsonProperty("CatalogId")]
        public string CatalogId{ get; set; }

        /// <summary>
        /// <p>Data access option. Selectable. Controls whether to return permission information and filter by permission.</p>
        /// </summary>
        [JsonProperty("FetchOption")]
        public FetchOption FetchOption{ get; set; }

        /// <summary>
        /// <p>Data source connection ID, selectable (additional field in fusion edition). Non-empty → use the analytical path; empty/default → use the professional edition TcLake path</p>
        /// </summary>
        [JsonProperty("ConnectionId")]
        public string ConnectionId{ get; set; }

        /// <summary>
        /// <p>Data Catalog source, selectable (additional field for Setats fusion). Value: METALAKE (pro edition tclake) / CONNECTION (analytical edition Linked Catalog) / Setats (Setats metadata). Routing priority: explicit non-empty CatalogSource > non-empty ConnectionId (deem as CONNECTION) > default METALAKE; ConnectionId will be ignored when CatalogSource is non-empty.</p>
        /// </summary>
        [JsonProperty("CatalogSource")]
        public string CatalogSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "CatalogId", this.CatalogId);
            this.SetParamObj(map, prefix + "FetchOption.", this.FetchOption);
            this.SetParamSimple(map, prefix + "ConnectionId", this.ConnectionId);
            this.SetParamSimple(map, prefix + "CatalogSource", this.CatalogSource);
        }
    }
}

