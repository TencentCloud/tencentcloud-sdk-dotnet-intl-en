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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetaValue : AbstractModel
    {
        
        /// <summary>
        /// <p>Metadata value name (for display only).</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Whether to refer to all values of this type (when true, ref_value_id should be 0)</p>
        /// </summary>
        [JsonProperty("RefAll")]
        public bool? RefAll{ get; set; }

        /// <summary>
        /// <p>Business ID referenced by metadata (property ID, category ID, etc.); this field should be 0 when ref_all=true</p>
        /// </summary>
        [JsonProperty("RefValueId")]
        public string RefValueId{ get; set; }

        /// <summary>
        /// <p>Metadata usage scenario: 1=retrieve only, 2=both retrieve and generate<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>META_SCENE_UNKNOWN</td><td>0</td><td>Unknown</td></tr><tr><td>META_SCENE_SEARCH_ONLY</td><td>1</td><td>Retrieve only</td></tr><tr><td>META_SCENE_ALL</td><td>2</td><td>Both retrieve and generate</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("Scene")]
        public long? Scene{ get; set; }

        /// <summary>
        /// <p>Metadata value type: 1=property tag, 2=document classification, 3=QA classification<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>META_VALUE_TYPE_UNKNOWN</td><td>0</td><td>Unknown</td></tr><tr><td>META_VALUE_TYPE_TAG</td><td>1</td><td>Property tag</td></tr><tr><td>META_VALUE_TYPE_DOC_CATEGORY</td><td>2</td><td>Document classification</td></tr><tr><td>META_VALUE_TYPE_QA_CATEGORY</td><td>3</td><td>QA classification</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("ValueType")]
        public long? ValueType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RefAll", this.RefAll);
            this.SetParamSimple(map, prefix + "RefValueId", this.RefValueId);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
        }
    }
}

