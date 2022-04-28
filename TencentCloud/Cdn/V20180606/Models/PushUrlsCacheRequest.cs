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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PushUrlsCacheRequest : AbstractModel
    {
        
        /// <summary>
        /// List of URLs. The protocol header such as "http://" or "https://" needs to be included.
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }

        /// <summary>
        /// Specifies the User-Agent header of an HTTP prefetch request when it is forwarded to the origin server
        /// Default value: `TencentCdn`
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// Destination region for the prefetch
        /// `mainland`: prefetches resources to nodes within Mainland China
        /// `overseas`: prefetches resources to nodes outside Mainland China
        /// `global`: prefetches resources to global nodes
        /// Default value: `mainland`. You can prefetch a URL to nodes in a region provided that CDN service has been enabled for the domain name in the URL in the region.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// If this parameter is `middle` or left empty, prefetch will be performed onto the intermediate node.
        /// Note: resources prefetched outside the Chinese mainland will be cached to CDN nodes outside the Chinese mainland and the traffic generated will incur costs.
        /// </summary>
        [JsonProperty("Layer")]
        public string Layer{ get; set; }

        /// <summary>
        /// Whether to recursively resolve the M3U8 index file and prefetch the TS shards in it.
        /// Notes:
        /// 1. This feature requires that the M3U8 index file can be directly requested and obtained.
        /// 2. In the M3U8 index file, currently only the TS shards at the first to the third level can be recursively resolved.
        /// 3. Prefetching the TS shards obtained through recursive resolution consumes the daily prefetch quota. If the usage exceeds the quota, the feature will be disabled and TS shards will not be prefetched.
        /// </summary>
        [JsonProperty("ParseM3U8")]
        public bool? ParseM3U8{ get; set; }

        /// <summary>
        /// Specifies whether to disable Range GETs.
        /// Notes:
        /// This feature is in beta test.
        /// </summary>
        [JsonProperty("DisableRange")]
        public bool? DisableRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Layer", this.Layer);
            this.SetParamSimple(map, prefix + "ParseM3U8", this.ParseM3U8);
            this.SetParamSimple(map, prefix + "DisableRange", this.DisableRange);
        }
    }
}

