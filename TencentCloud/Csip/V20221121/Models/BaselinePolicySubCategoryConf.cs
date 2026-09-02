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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselinePolicySubCategoryConf : AbstractModel
    {
        
        /// <summary>
        /// <p>Baseline subcategory ID.</p>
        /// </summary>
        [JsonProperty("CategoryID")]
        public ulong? CategoryID{ get; set; }

        /// <summary>
        /// <p>Whether to select all detection items under this subcategory. true: select all; false: take effect based on the ItemIDList details.</p>
        /// </summary>
        [JsonProperty("AllSelect")]
        public bool? AllSelect{ get; set; }

        /// <summary>
        /// <p>List of selected testing item IDs, which take effect by this detail when AllSelect=false.</p>
        /// </summary>
        [JsonProperty("ItemIDList")]
        public ulong?[] ItemIDList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CategoryID", this.CategoryID);
            this.SetParamSimple(map, prefix + "AllSelect", this.AllSelect);
            this.SetParamArraySimple(map, prefix + "ItemIDList.", this.ItemIDList);
        }
    }
}

