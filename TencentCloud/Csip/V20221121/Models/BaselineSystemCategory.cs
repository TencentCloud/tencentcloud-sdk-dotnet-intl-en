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

    public class BaselineSystemCategory : AbstractModel
    {
        
        /// <summary>
        /// <p>List of subcategories under the parent category (each subcategory includes its built-in detection item ID list).</p>
        /// </summary>
        [JsonProperty("SubCategoryList")]
        public BaselineSubCategory[] SubCategoryList{ get; set; }

        /// <summary>
        /// <p>System parent category basic information (ID, name, description, CheckAssetType).</p>
        /// </summary>
        [JsonProperty("Category")]
        public BaselineCategory Category{ get; set; }

        /// <summary>
        /// <p>Detection item count</p>
        /// </summary>
        [JsonProperty("ItemCount")]
        public ulong? ItemCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SubCategoryList.", this.SubCategoryList);
            this.SetParamObj(map, prefix + "Category.", this.Category);
            this.SetParamSimple(map, prefix + "ItemCount", this.ItemCount);
        }
    }
}

