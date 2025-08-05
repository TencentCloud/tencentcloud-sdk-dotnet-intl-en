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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJustInTimeTranscodeTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The maximum number of Filters is 20. the upper limit for Filters.Values is 20. if this parameter is left empty, it returns the authorized just-in-time transcoding templates in the current ZoneId by default. detailed filter criteria: <li>template-name: filter by template name in batch. example: mytemplate;</li> <li>template-type: filter by template type in batch. example: preset or custom.</li> <li>template-id: filter by template id in batch. example: C1LZ7982VgTpYhJ7M.</li> empty by default.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Sorting field. valid values: <li>createTime: template creation time.</li> default value: createTime.
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// Sorting method. valid values: <li>`asc`: ascending order;</li><li>`desc`: descending order.</li> default value: `desc`.
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// Paging offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned entries. default value: 20. maximum value: 1000.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

