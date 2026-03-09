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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListQualityRuleTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// Workspace ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Current page, which is 1 by default.
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// Number of records per page, which is 10 by default.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Common sort.
        /// Supported sorting fields:.
        /// CitationCount - sort by number of references.
        /// UpdateTime - sort by update time.
        /// Sorting order:.
        /// 1 - ascending (ASC).
        /// 2 - descending (DESC).
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderField[] OrderFields{ get; set; }

        /// <summary>
        /// Universal filter criteria.
        /// 1. Id
        /// Description: template ID.
        /// Value: unique identifier of the template.
        /// 
        /// 2. Keyword
        /// Description: search by keyword, supports template name fuzzy search.
        /// Value: string.
        /// 
        /// 3. Type
        /// Description: template type.
        /// Value: 1 - system template; 2 - custom template; support multiple values (OR relationship).
        /// 
        /// 4. QualityDim
        /// Describes the quality detection dimension.
        /// Valid values: 1 - accuracy; 2 - uniqueness; 3 - integrity; 4 - consistency; 5 - timeliness; 6 - validity. support multiple values (OR relationship).
        /// 
        /// 5. SourceObjectType
        /// Describes the applicable source data object type for rule.
        /// Value: 1 - constant; 2 - offline table level; 3 - offline field level; 4 - database level. supports multiple values (OR relationship).
        /// 
        /// 6. SourceEngineTypes
        /// Description: specifies the source data engine type to which the template applies.
        /// Value: 1 - MySQL; 2 - Hive; 4 - Spark; 8 - Livy; 16 - DLC; 32 - Gbase; 64 - TCHouse-P; 128 - Doris; 256 - TCHouse-D; 512 - EMR_StarRocks; 1024 - TCHouse-X. supports multiple values (OR relationship).
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArrayObj(map, prefix + "OrderFields.", this.OrderFields);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

