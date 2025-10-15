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

    public class ListTaskVersions : AbstractModel
    {
        
        /// <summary>
        /// Record list	
        /// 	
        /// </summary>
        [JsonProperty("Items")]
        public TaskVersion[] Items{ get; set; }

        /// <summary>
        /// Total number of records that meet the query condition.
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// Total number of pages that meet the query condition.
        /// </summary>
        [JsonProperty("TotalPageNumber")]
        public ulong? TotalPageNumber{ get; set; }

        /// <summary>
        /// Number of records on current page.
        /// </summary>
        [JsonProperty("PageCount")]
        public ulong? PageCount{ get; set; }

        /// <summary>
        /// Specifies the number of entries in the current request data page.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Specifies the data page number of the current request.
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "TotalPageNumber", this.TotalPageNumber);
            this.SetParamSimple(map, prefix + "PageCount", this.PageCount);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
        }
    }
}

