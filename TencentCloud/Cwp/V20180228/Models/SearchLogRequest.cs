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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchLogRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time for logs to be searched and analyzed, which is a Unix timestamp in milliseconds
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// End time for logs to be searched and analyzed, which is a Unix timestamp in milliseconds
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Statement for search and analysis, with a maximum length of 12 KB
        /// </summary>
        [JsonProperty("QueryString")]
        public string QueryString{ get; set; }

        /// <summary>
        /// Number of raw logs returned for a single query. Maximum value: 1000. The Context parameter can be used to obtain subsequent logs.
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// Order for returning the raw logs. Valid values: asc (ascending), desc (descending). Default value: desc.
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// Pass the Context value returned by the last API call to retrieve more subsequent logs. A total of up to 10,000 raw logs can be obtained, with a validity period of 1 hour.
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "QueryString", this.QueryString);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "Context", this.Context);
        }
    }
}

