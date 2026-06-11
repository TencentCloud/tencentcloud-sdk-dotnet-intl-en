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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTopicsRequest : AbstractModel
    {
        
        /// <summary>
        /// <ul><li>Filter topicName by [topic name]. The default is fuzzy matching. You can set the PreciseSearch parameter to exact match. Type: String. Required: No</li>
        /// <li>logsetName filters by [logset name], defaults to fuzzy matching, and can be set to exact match using the PreciseSearch parameter. Type: String. Required: No</li>
        /// <li>topicId filters by [topic ID]. Type: String. Required: No</li>
        /// <li>logsetId filters by [logset ID]. You can call the <a href="https://www.tencentcloud.com/document/product/614/58624?from_cn_redirect=1">DescribeLogsets</a> API to query the list of created logsets or log in to the console to view. You can also call the <a href="https://www.tencentcloud.com/document/product/614/58626?from_cn_redirect=1">CreateLogset</a> API to create logset. Type: String. Required: No</li>
        /// <li>tagKey Filter by [tag key]. Type: String. Required: No</li>
        /// <li>tag:tagKey - filter by [tag key-value pair]. Replace tagKey with a specific tag key, such as tag:exampleKey. Type: String. Required: no</li>
        /// <li>storageType filters by [storage type of the topic]. Value range: hot (standard storage), cold (infrequent storage). Type: String. Required: No</li></ul>
        /// Note: Each request can have up to 10 Filters. The upper limit of Filter.Values is 100.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Page offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Maximum number of entries per page. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Control whether the related fields in Filters are exact matches.
        /// <ul><li>0: Default value. topicName and logsetName use fuzzy matching</li>
        /// <li>1: topicName   Exact match</li>
        /// <li>2: Exact match by logsetName</li>
        /// <li>3: Exact match by both topicName and logsetName</li></ul>
        /// </summary>
        [JsonProperty("PreciseSearch")]
        public ulong? PreciseSearch{ get; set; }

        /// <summary>
        /// Topic type
        /// -0: Log topic, default value
        /// -Metric topic
        /// </summary>
        [JsonProperty("BizType")]
        public ulong? BizType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "PreciseSearch", this.PreciseSearch);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
        }
    }
}

