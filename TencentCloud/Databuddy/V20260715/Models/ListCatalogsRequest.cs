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

    public class ListCatalogsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Workspace unique id</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Maximum number of result entries</p>
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// <p>Pagination token</p>
        /// </summary>
        [JsonProperty("PageToken")]
        public string PageToken{ get; set; }

        /// <summary>
        /// <p>catalog type. Valid values: TABLE, MODEL, VOLUME</p>
        /// </summary>
        [JsonProperty("Types")]
        public string[] Types{ get; set; }

        /// <summary>
        /// <p>Whether to return only those in the current workspace that are authorized. If false, it additionally returns the catalogs that the current user has permission to manage.</p>
        /// </summary>
        [JsonProperty("CurrentWorkspaceOnly")]
        public bool? CurrentWorkspaceOnly{ get; set; }

        /// <summary>
        /// <p>Data access option. Selectable. Controls whether to return permission information and filter by permission.</p>
        /// </summary>
        [JsonProperty("FetchOption")]
        public FetchOption FetchOption{ get; set; }

        /// <summary>
        /// Data catalog source filter criteria (additional field in Fusion Edition). For values, see CatalogSourceEnum. Empty array or not passed: only tclake is queried. ["METALAKE"]: only tclake is queried. ["CONNECTION"]: only the analytics edition ana_catalog is queried. ["METALAKE","CONNECTION"]: merged and returned.
        /// </summary>
        [JsonProperty("CatalogSources")]
        public string[] CatalogSources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "PageToken", this.PageToken);
            this.SetParamArraySimple(map, prefix + "Types.", this.Types);
            this.SetParamSimple(map, prefix + "CurrentWorkspaceOnly", this.CurrentWorkspaceOnly);
            this.SetParamObj(map, prefix + "FetchOption.", this.FetchOption);
            this.SetParamArraySimple(map, prefix + "CatalogSources.", this.CatalogSources);
        }
    }
}

