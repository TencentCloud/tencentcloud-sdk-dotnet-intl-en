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
        /// List of resources to be preheated. required. each element format is as follows:.
        /// http://www.example.com/example.txt.
        /// Note: the number of submitted tasks is limited by the quota of a billing package. check the [EO billing package](https://www.tencentcloud.comom/document/product/1552/77380?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Targets")]
        public string[] Targets{ get; set; }

        /// <summary>
        /// Preheat mode. valid values:.
        /// <Li>Default: default mode, which preheats to the middle layer.</li>.
        /// <Li>Edge: specifies edge preheating mode, which preheats to both edge and middle layer.</li> if left empty, the default value is default.
        /// Notes:.
        /// Preheating to the edge generates edge layer traffic, which is included in billing traffic.
        /// 2. specifies the default allocation of edge preheating as a separate preheating amount of 1000 per day, which does not consume the standard preheating amount.
        /// Description:.
        /// This parameter is the allowlist feature. if needed, contact tencent cloud engineers.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Whether to encode a URL according to RFC3986. Enable this field when the URL contains non-ASCII characters.
        /// </summary>
        [JsonProperty("EncodeUrl")]
        [System.Obsolete]
        public bool? EncodeUrl{ get; set; }

        /// <summary>
        /// Specifies whether to carry HTTP header information for preheating. leave it empty otherwise.
        /// </summary>
        [JsonProperty("Headers")]
        public Header[] Headers{ get; set; }

        /// <summary>
        /// Media fragment preheating control. valid values:.
        /// <Li>On: enables shard preheating, preheats the description file, and performs recursive resolution of the description file shards for preheating.</li>.
        /// <Li>Off: only preheats the submitted description file.</li>default value: off if left empty.
        /// Notes:.
        /// Supported description file is M3U8; corresponding shard is TS.
        /// Specifies the description file must support normal requests and describe sharding paths as per industry standards.
        /// Specifies the recursive resolution depth is no more than 3.
        /// Parsed shards normally accumulate daily pre-warming amount. when usage exceeds the limit, silent processing is triggered and preheating is no longer executed.
        /// Description:.
        /// This parameter is the allowlist feature. if needed, contact tencent cloud engineers.
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
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "EncodeUrl", this.EncodeUrl);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "PrefetchMediaSegments", this.PrefetchMediaSegments);
        }
    }
}

