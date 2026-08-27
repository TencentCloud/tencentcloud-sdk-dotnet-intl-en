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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsageStats : AbstractModel
    {
        
        /// <summary>
        /// <p>Total tokens accumulated within a time period.</p>
        /// </summary>
        [JsonProperty("TotalToken")]
        public long? TotalToken{ get; set; }

        /// <summary>
        /// <p>[tokens family] Total input tokens within a time period.</p>
        /// </summary>
        [JsonProperty("InputTotalToken")]
        public long? InputTotalToken{ get; set; }

        /// <summary>
        /// <p>[tokens family] Total output tokens within a time period.</p>
        /// </summary>
        [JsonProperty("OutputTotalToken")]
        public long? OutputTotalToken{ get; set; }

        /// <summary>
        /// <p>[token family] Cumulative number of tokens read from the cache within a time period (cache hit part)</p>
        /// </summary>
        [JsonProperty("CacheTotalToken")]
        public long? CacheTotalToken{ get; set; }

        /// <summary>
        /// <p>Total online search requests in the [search group]</p>
        /// </summary>
        [JsonProperty("SearchRequestCount")]
        public long? SearchRequestCount{ get; set; }

        /// <summary>
        /// <p>[search family] Total search engine calls</p>
        /// </summary>
        [JsonProperty("SearchCount")]
        public long? SearchCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalToken", this.TotalToken);
            this.SetParamSimple(map, prefix + "InputTotalToken", this.InputTotalToken);
            this.SetParamSimple(map, prefix + "OutputTotalToken", this.OutputTotalToken);
            this.SetParamSimple(map, prefix + "CacheTotalToken", this.CacheTotalToken);
            this.SetParamSimple(map, prefix + "SearchRequestCount", this.SearchRequestCount);
            this.SetParamSimple(map, prefix + "SearchCount", this.SearchCount);
        }
    }
}

