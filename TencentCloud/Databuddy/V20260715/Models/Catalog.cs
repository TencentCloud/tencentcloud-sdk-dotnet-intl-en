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

    public class Catalog : AbstractModel
    {
        
        /// <summary>
        /// <p>Unique id of the data catalog.</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>Data catalog name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Data catalog type</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Data catalog description</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Status info: being registered 0, trial 1, connected successfully 2, connection failure 3, deleting 4, deleted 5</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Data catalog properties</p>
        /// </summary>
        [JsonProperty("Properties")]
        public KVPair[] Properties{ get; set; }

        /// <summary>
        /// <p>Operator</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// <p>Responsible person information.</p>
        /// </summary>
        [JsonProperty("MetaOwner")]
        public MetaOwner MetaOwner{ get; set; }

        /// <summary>
        /// <p>Audit information</p>
        /// </summary>
        [JsonProperty("Audit")]
        public Audit Audit{ get; set; }

        /// <summary>
        /// <p>Globally unique ID of the asset</p>
        /// </summary>
        [JsonProperty("AssetGuid")]
        public string AssetGuid{ get; set; }

        /// <summary>
        /// <p>Current workspace permission level. The value corresponds to PermissionLevel: 0 - no permission, 1 - read-only, 2 - read-write</p>
        /// </summary>
        [JsonProperty("CurrentWorkspacePermissionLevel")]
        public long? CurrentWorkspacePermissionLevel{ get; set; }

        /// <summary>
        /// <p>tccatalog.identifier in tccatalog properties</p>
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// <p>Permission information of the current user for this entity.</p>
        /// </summary>
        [JsonProperty("PermissionDetail")]
        public PermissionDetail PermissionDetail{ get; set; }

        /// <summary>
        /// <p>Whether it is an external data Catalog (a Catalog created based on a data source connection, such as MYSQL, EMR_HIVE, TCHOUSE_D, POSTGRESQL, DLC). true: external Catalog, false: built-in Catalog (TABLE/MODEL/VOLUME)</p>
        /// </summary>
        [JsonProperty("IsExternal")]
        public bool? IsExternal{ get; set; }

        /// <summary>
        /// <p>Tag information list. Note: It is returned only when FetchTags=true in the request. By default, it is not returned.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public CommonTagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>Data catalog source</p>
        /// </summary>
        [JsonProperty("CatalogSource")]
        public string CatalogSource{ get; set; }

        /// <summary>
        /// <p>The data catalog name or database name on the connection side (only available for three-segment data sources in the analytics edition; empty string for two-segment data sources). For MySQL-kernel three-segment data sources such as Doris/StarRocks/TChouse-D: external catalog name; for PG-kernel three-segment data sources such as PostgreSQL/Tencent PG/GaussDB/Hologres: databaseName; for two-segment data sources such as MySQL: empty string. Note: This field is only valid for the analytics edition (CatalogSource=CONNECTION) and is not filled for the pro edition (METALAKE).</p>
        /// </summary>
        [JsonProperty("ConnectionCatalogName")]
        public string ConnectionCatalogName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamObj(map, prefix + "MetaOwner.", this.MetaOwner);
            this.SetParamObj(map, prefix + "Audit.", this.Audit);
            this.SetParamSimple(map, prefix + "AssetGuid", this.AssetGuid);
            this.SetParamSimple(map, prefix + "CurrentWorkspacePermissionLevel", this.CurrentWorkspacePermissionLevel);
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamObj(map, prefix + "PermissionDetail.", this.PermissionDetail);
            this.SetParamSimple(map, prefix + "IsExternal", this.IsExternal);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CatalogSource", this.CatalogSource);
            this.SetParamSimple(map, prefix + "ConnectionCatalogName", this.ConnectionCatalogName);
        }
    }
}

