/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLiveStreamEventListRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time. 
        /// In UTC format, such as 2018-12-29T19:00:00Z.
        /// This supports querying the history of 60 days.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time.
        /// In UTC format, such as 2018-12-29T20:00:00Z.
        /// This cannot be after the current time and cannot be more than 30 days after the start time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Push path, which is the same as the AppName in push and playback addresses and is "live" by default.
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// Push domain name.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Stream name; query with wildcard (*) is not supported; fuzzy match by default.
        /// The IsStrict field can be used to change to exact query.
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// Page number to get.
        /// Default value: 1.
        /// Note: Currently, query for up to 10,000 entries is supported.
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// Number of entries per page.
        /// Maximum value: 100.
        /// Value range: any integer between 1 and 100.
        /// Default value: 10.
        /// Note: currently, query for up to 10,000 entries is supported.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Whether to filter. No filtering by default.
        /// 0: No filtering at all.
        /// 1: Filter out the failing streams and return only the successful ones.
        /// </summary>
        [JsonProperty("IsFilter")]
        public long? IsFilter{ get; set; }

        /// <summary>
        /// Whether to query exactly. Fuzzy match by default.
        /// 0: Fuzzy match.
        /// 1: Exact query.
        /// Note: This parameter takes effect when StreamName is used.
        /// </summary>
        [JsonProperty("IsStrict")]
        public long? IsStrict{ get; set; }

        /// <summary>
        /// Whether to display in ascending order by end time. Descending order by default.
        /// 0: Descending.
        /// 1: Ascending.
        /// </summary>
        [JsonProperty("IsAsc")]
        public long? IsAsc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "IsFilter", this.IsFilter);
            this.SetParamSimple(map, prefix + "IsStrict", this.IsStrict);
            this.SetParamSimple(map, prefix + "IsAsc", this.IsAsc);
        }
    }
}

