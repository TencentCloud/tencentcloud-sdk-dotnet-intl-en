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

    public class FileConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Advanced running parameter, used for variable replacement, map-json String,String</p>
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }

        /// <summary>
        /// <p>Execution resource ID. Source: ResourceId returned by the ListComputeResources API</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>Default catalog</p>
        /// </summary>
        [JsonProperty("DefaultCatalog")]
        public string DefaultCatalog{ get; set; }

        /// <summary>
        /// <p>Default schema</p>
        /// </summary>
        [JsonProperty("DefaultSchema")]
        public string DefaultSchema{ get; set; }

        /// <summary>
        /// <p>Advanced configuration, JSON string</p>
        /// </summary>
        [JsonProperty("AdvanceConfig")]
        public string AdvanceConfig{ get; set; }

        /// <summary>
        /// <p>Extended parameter, JSON string</p>
        /// </summary>
        [JsonProperty("ExtraParams")]
        public string ExtraParams{ get; set; }

        /// <summary>
        /// <p>Notebook interactive control definition, JSON string</p>
        /// </summary>
        [JsonProperty("Widgets")]
        public string Widgets{ get; set; }

        /// <summary>
        /// <p>Output configuration of each cell. Returned only in Get output parameters; input parameters are ignored.</p>
        /// </summary>
        [JsonProperty("OutputConf")]
        public FileOutputConf[] OutputConf{ get; set; }

        /// <summary>
        /// <p>SQL script grammar tag</p>
        /// </summary>
        [JsonProperty("SqlSyntax")]
        public string SqlSyntax{ get; set; }

        /// <summary>
        /// <p>Platform cluster id</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>The source type of the default Catalog, used to identify which Catalog system the default Catalog belongs to. Selectable. Maximum length: 32. Values: METALAKE - TC Catalog (metadata lake Catalog); SETATS - Setats Catalog. If the value is empty or illegal, the backend falls back to METALAKE.</p>
        /// </summary>
        [JsonProperty("DefaultCatalogSource")]
        public string DefaultCatalogSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Params", this.Params);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "DefaultCatalog", this.DefaultCatalog);
            this.SetParamSimple(map, prefix + "DefaultSchema", this.DefaultSchema);
            this.SetParamSimple(map, prefix + "AdvanceConfig", this.AdvanceConfig);
            this.SetParamSimple(map, prefix + "ExtraParams", this.ExtraParams);
            this.SetParamSimple(map, prefix + "Widgets", this.Widgets);
            this.SetParamArrayObj(map, prefix + "OutputConf.", this.OutputConf);
            this.SetParamSimple(map, prefix + "SqlSyntax", this.SqlSyntax);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "DefaultCatalogSource", this.DefaultCatalogSource);
        }
    }
}

