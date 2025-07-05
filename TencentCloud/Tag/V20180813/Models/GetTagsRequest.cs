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

namespace TencentCloud.Tag.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetTagsRequest : AbstractModel
    {
        
        /// <summary>
        /// The token value of the next page obtained from the response of the previous page.
        /// Leave it empty for the first request.
        /// </summary>
        [JsonProperty("PaginationToken")]
        public string PaginationToken{ get; set; }

        /// <summary>
        /// Number of data entries to return per page (up to 1,000).
        /// Default value: 50.
        /// </summary>
        [JsonProperty("MaxResults")]
        public ulong? MaxResults{ get; set; }

        /// <summary>
        /// Tag key.
        /// All tags corresponding to the list of tag keys.
        /// Maximum length: 20
        /// </summary>
        [JsonProperty("TagKeys")]
        public string[] TagKeys{ get; set; }

        /// <summary>
        /// Tag type. Valid values: Custom: custom tag; System: system tag; All: all tags. Default value: All.
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PaginationToken", this.PaginationToken);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamArraySimple(map, prefix + "TagKeys.", this.TagKeys);
            this.SetParamSimple(map, prefix + "Category", this.Category);
        }
    }
}

