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

    public class CreatePrefetchTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// 
        /// If you wish to quickly submit Targets urls under different sites, you can fill in * as the value. but the premise is that the account calling this API must have the permission to all site resources under the root account.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// List of resources to be preheated. Each element format is similar to the following:
        /// http://www.example.com/example.txt. The parameter value is currently required.
        /// Note: The number of tasks that can be submitted is limited by the quota of a billing package. For details, see [Billing Overview] (https://intl.cloud.tencent.com/document/product/1552/77380?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Targets")]
        public string[] Targets{ get; set; }

        /// <summary>
        /// Whether to encode a URL according to RFC3986. Enable this field when the URL contains non-ASCII characters.
        /// </summary>
        [JsonProperty("EncodeUrl")]
        [System.Obsolete]
        public bool? EncodeUrl{ get; set; }

        /// <summary>
        /// HTTP header information
        /// </summary>
        [JsonProperty("Headers")]
        public Header[] Headers{ get; set; }

        /// <summary>
        /// Media fragment preheating control. valid values:.
        /// <Li>On: enables shard preheating, preheats the description file, and performs recursive resolution of the description file shards for preheating.</li>.
        /// <Li>Off: only preheat the submitted description file.</li>default value: off if left empty.
        /// 
        /// Notes:.
        /// 1. the supported description file is M3U8, and the corresponding shard is TS.
        /// Describes the requirement that the description file can process normal requests and specify the sharding path as per industry standards.
        /// Recursive resolution depth is no more than 3.
        /// Parsed shards normally accumulate daily pre-warming amount. when usage exceeds the quota limit, silent processing is triggered and preheating is no longer executed.
        /// 
        /// This parameter specifies the allowlist feature. if necessary, contact tencent cloud engineers.
        /// </summary>
        [JsonProperty("PrefetchMediaSegments")]
        public string PrefetchMediaSegments{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "EncodeUrl", this.EncodeUrl);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "PrefetchMediaSegments", this.PrefetchMediaSegments);
        }
    }
}

