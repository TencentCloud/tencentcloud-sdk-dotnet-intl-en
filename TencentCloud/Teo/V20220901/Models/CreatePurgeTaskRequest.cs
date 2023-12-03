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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePurgeTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the site.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Type of cache purging. Values:
        /// <li>`purge_url`: Purge by the URL</li>
        /// <li>`purge_prefix`: Purge by the directory</li>
        /// <li>`purge_host`: Purge by the hostname</li>
        /// <li>`purge_all`: Purge all caches</li>
        /// <li>`purge_cache_tag`: Purge by the cache-tag </li>For more details, see [Cache Purge](https://intl.cloud.tencent.com/document/product/1552/70759?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Configures how resources under the directory are purged when `Type = purge_prefix`. Values: <li>`invalidate`: Only resources updated under the directory are purged.</li><li>`delete`: All resources under the directory are purged regardless of whether they are updated. </li>Default value: `invalidate`.
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// List of cached resources to purge. The format for input depends on the type of cache purging. See examples below for details. <li>By default, non-ASCII characters are escaped based on RFC3986.</li><li>The maximum number of tasks per purging request is determined by the EdgeOne plan. See [Billing Overview (New)](https://intl.cloud.tencent.com/document/product/1552/77380?from_cn_redirect=1). </li>
        /// </summary>
        [JsonProperty("Targets")]
        public string[] Targets{ get; set; }

        /// <summary>
        /// Specifies whether to transcode non-ASCII URLs according to RFC3986.
        /// Note that if it’s enabled, the purging is based on the converted URLs.
        /// </summary>
        [JsonProperty("EncodeUrl")]
        [System.Obsolete]
        public bool? EncodeUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamArraySimple(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "EncodeUrl", this.EncodeUrl);
        }
    }
}

