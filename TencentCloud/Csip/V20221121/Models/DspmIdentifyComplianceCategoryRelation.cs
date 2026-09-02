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

    public class DspmIdentifyComplianceCategoryRelation : AbstractModel
    {
        
        /// <summary>
        /// <p>Category ID</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public ulong? CategoryId{ get; set; }

        /// <summary>
        /// <p>Category name</p>
        /// </summary>
        [JsonProperty("CategoryName")]
        public string CategoryName{ get; set; }

        /// <summary>
        /// <p>Parent category ID</p>
        /// </summary>
        [JsonProperty("CategoryParentId")]
        public string CategoryParentId{ get; set; }

        /// <summary>
        /// <p>is leaf node</p>
        /// </summary>
        [JsonProperty("IsLeaf")]
        public bool? IsLeaf{ get; set; }

        /// <summary>
        /// <p>Classification type</p><p>Enumeration values:</p><ul><li>0: Built-in</li><li>1: Custom</li></ul>
        /// </summary>
        [JsonProperty("CategoryType")]
        public ulong? CategoryType{ get; set; }

        /// <summary>
        /// <p>Classification levels</p><p>Unit: level</p>
        /// </summary>
        [JsonProperty("CategoryGrade")]
        public ulong? CategoryGrade{ get; set; }

        /// <summary>
        /// <p>Associated data item information</p>
        /// </summary>
        [JsonProperty("RuleRelations")]
        public DspmIdentifyComplianceRuleRelation[] RuleRelations{ get; set; }

        /// <summary>
        /// <p>Sub-node information</p>
        /// </summary>
        [JsonProperty("Children")]
        public DspmIdentifyComplianceCategoryRelation[] Children{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "CategoryName", this.CategoryName);
            this.SetParamSimple(map, prefix + "CategoryParentId", this.CategoryParentId);
            this.SetParamSimple(map, prefix + "IsLeaf", this.IsLeaf);
            this.SetParamSimple(map, prefix + "CategoryType", this.CategoryType);
            this.SetParamSimple(map, prefix + "CategoryGrade", this.CategoryGrade);
            this.SetParamArrayObj(map, prefix + "RuleRelations.", this.RuleRelations);
            this.SetParamArrayObj(map, prefix + "Children.", this.Children);
        }
    }
}

