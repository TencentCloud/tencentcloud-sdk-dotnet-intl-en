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

    public class DescribeConcurrencyLimitDetailListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Query time range (Unix seconds)</p>
        /// </summary>
        [JsonProperty("TimeRange")]
        public TimeRange TimeRange{ get; set; }

        /// <summary>
        /// <p>View scope: business view / space view / application view</p>
        /// </summary>
        [JsonProperty("ViewScope")]
        public ViewScope ViewScope{ get; set; }

        /// <summary>
        /// <p>Extended filtering. Filter combination rule: multiple items use AND, and value_list within the same item uses OR. Supported Names: concurrency_type (qpm_tpm/dedicated, default qpm_tpm), model_name (required), space_id, app_id/resource_id/source_id (application ID, multiple selection), metric_source_type (METRIC_SOURCE_TYPE_* Enumeration Name or integer)</p>
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }

        /// <summary>
        /// <p>Page number, starting from 0</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// <p>Number of items per page. Maximum value: 100.</p>
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

