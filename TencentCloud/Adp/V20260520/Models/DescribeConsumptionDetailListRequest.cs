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

    public class DescribeConsumptionDetailListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Query time range (Unix seconds)</p>
        /// </summary>
        [JsonProperty("TimeRange")]
        public TimeRange TimeRange{ get; set; }

        /// <summary>
        /// <p>View scope: business view / space view</p>
        /// </summary>
        [JsonProperty("ViewScope")]
        public ViewScope ViewScope{ get; set; }

        /// <summary>
        /// <p>Extended filtering. Filter combination rule: multiple conditions use AND, values within the same condition use OR. Supported Name: metric_source_type (metric_source_type_* OR integer), source_ids (multi-option source ID), resource_ID/source_ID (select one source ID, this parameter is valid only when source_ids is not passed), space_ID, user_ID</p>
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }

        /// <summary>
        /// <p>Page number, starting from 0</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// <p>Number of items per page. Maximum: 100.</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TimeRange.", this.TimeRange);
            this.SetParamObj(map, prefix + "ViewScope.", this.ViewScope);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

