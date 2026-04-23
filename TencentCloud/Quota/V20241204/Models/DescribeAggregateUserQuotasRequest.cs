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

namespace TencentCloud.Quota.V20241204.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAggregateUserQuotasRequest : AbstractModel
    {
        
        /// <summary>
        /// Member account. Can be empty. If empty, query the current account list.
        /// </summary>
        [JsonProperty("MemberUins")]
        public long?[] MemberUins{ get; set; }

        /// <summary>
        /// limit
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// offset
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Filter
        /// </summary>
        [JsonProperty("Filter")]
        public Filter[] Filter{ get; set; }

        /// <summary>
        /// sort
        /// </summary>
        [JsonProperty("Sort")]
        public Sort[] Sort{ get; set; }

        /// <summary>
        /// Product ID
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// Quota dimension
        /// </summary>
        [JsonProperty("QuotaDimensions")]
        public QuotaDimension[] QuotaDimensions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberUins.", this.MemberUins);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArrayObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamArrayObj(map, prefix + "QuotaDimensions.", this.QuotaDimensions);
        }
    }
}

