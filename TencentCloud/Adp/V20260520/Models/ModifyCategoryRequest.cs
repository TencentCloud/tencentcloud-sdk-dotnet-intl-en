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

    public class ModifyCategoryRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Category ID to be modified (must be greater than 0)</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// <p>Classification type (not allowed to be 0. Value: 1=document classification, 2=QA classification)<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>CATEGORY_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>CATEGORY_TYPE_DOC</td><td>1</td><td>Document classification</td></tr><tr><td>CATEGORY_TYPE_QA</td><td>2</td><td>QA classification</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("CategoryType")]
        public long? CategoryType{ get; set; }

        /// <summary>
        /// <p>Modify field content (required, used in conjunction with update_mask)</p>
        /// </summary>
        [JsonProperty("Fields")]
        public CategoryModifyFields Fields{ get; set; }

        /// <summary>
        /// <p>ID of the knowledge base it belongs to</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>Field mask: specifies the field to modify (supported Paths: Name)</p>
        /// </summary>
        [JsonProperty("UpdateMask")]
        public FieldMask UpdateMask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "CategoryType", this.CategoryType);
            this.SetParamObj(map, prefix + "Fields.", this.Fields);
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamObj(map, prefix + "UpdateMask.", this.UpdateMask);
        }
    }
}

