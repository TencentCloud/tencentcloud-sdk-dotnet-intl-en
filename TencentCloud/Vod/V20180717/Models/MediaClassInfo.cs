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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaClassInfo : AbstractModel
    {
        
        /// <summary>
        /// Category ID.
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// Parent category ID. The parent category ID of a first-level category is -1.
        /// </summary>
        [JsonProperty("ParentId")]
        public long? ParentId{ get; set; }

        /// <summary>
        /// Category name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Category level. The first-level category is 0, and the maximum value is 3, which allows up to 4 category levels.
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// ID set of level-1 subcategories in the current category.
        /// </summary>
        [JsonProperty("SubClassIdSet")]
        public long?[] SubClassIdSet{ get; set; }

        /// <summary>
        /// Category name (this field is not recommended. Use the new category name field Name instead).
        /// </summary>
        [JsonProperty("ClassName")]
        public string ClassName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamArraySimple(map, prefix + "SubClassIdSet.", this.SubClassIdSet);
            this.SetParamSimple(map, prefix + "ClassName", this.ClassName);
        }
    }
}

