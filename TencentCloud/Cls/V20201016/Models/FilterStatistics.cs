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

    public class FilterStatistics : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of raw logs</p>
        /// </summary>
        [JsonProperty("OriginalCount")]
        public ulong? OriginalCount{ get; set; }

        /// <summary>
        /// <p>Number of filtered logs</p>
        /// </summary>
        [JsonProperty("FilteredCount")]
        public ulong? FilteredCount{ get; set; }

        /// <summary>
        /// <p>Filtered results</p>
        /// </summary>
        [JsonProperty("FilteredResult")]
        public string[] FilteredResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginalCount", this.OriginalCount);
            this.SetParamSimple(map, prefix + "FilteredCount", this.FilteredCount);
            this.SetParamArraySimple(map, prefix + "FilteredResult.", this.FilteredResult);
        }
    }
}

