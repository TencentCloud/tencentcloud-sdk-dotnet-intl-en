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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrafficSandboxDLPUserRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// File name match dimension: summarized and deduplicated file name/regular list
        /// </summary>
        [JsonProperty("FileName")]
        public string[] FileName{ get; set; }

        /// <summary>
        /// File size limit dimension (interval)
        /// </summary>
        [JsonProperty("FileSize")]
        public TrafficSandboxDLPFileSizeRange FileSize{ get; set; }

        /// <summary>
        /// File format limited dimensions: format/category list after aggregation and deduplication
        /// </summary>
        [JsonProperty("FileType")]
        public string[] FileType{ get; set; }

        /// <summary>
        /// Outbound domain name detection dimension (single Value Object)
        /// </summary>
        [JsonProperty("URLRule")]
        public TrafficSandboxDLPURLRuleItem URLRule{ get; set; }

        /// <summary>
        /// Outbound content detection dimension (multi-line, name + regular)
        /// </summary>
        [JsonProperty("TrafficRule")]
        public TrafficSandboxDLPTrafficRuleItem[] TrafficRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FileName.", this.FileName);
            this.SetParamObj(map, prefix + "FileSize.", this.FileSize);
            this.SetParamArraySimple(map, prefix + "FileType.", this.FileType);
            this.SetParamObj(map, prefix + "URLRule.", this.URLRule);
            this.SetParamArrayObj(map, prefix + "TrafficRule.", this.TrafficRule);
        }
    }
}

