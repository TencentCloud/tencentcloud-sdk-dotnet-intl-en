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

    public class CreatePurgeTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// If you wish to quickly submit Targets Url under different sites, you can fill in *, but the account calling the API must have permission for all site resources under the root account.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Node cache clearing type, with values:
        /// <li>purge_url: URL refresh;</li>
        /// <li>purge_prefix: directory refresh;</li>
        /// <li>purge_host: Hostname refresh;</li>
        /// <li>purge_all: cache purge for all under the site (when this value is used, ZoneId input parameter * is not supported);</li>
        /// <li>purge_cache_tag: cache-tag refresh.</li>For cache purge types, see [Purge Cache](https://www.tencentcloud.com/document/product/1552/70759?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Node cache purge method, valid for directory refresh, Hostname refresh, and refresh all cache types. Valid values: <li> invalidate: refresh only resources that have been updated under the directory;</li><li> delete: refresh node resources regardless of whether resources under the directory are updated.</li>Default value: invalidate.
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// List of resources for cache purging, for example, https://www.example.com/example.jpg. Protocol information must be included. The format of additional elements depends on the type of cache purging. Refer to the API call example below.<li>The number of tasks that can be submitted at a time is limited by the billing package quota. Check [EO billing packages](https://www.tencentcloud.com/document/product/1552/77380?from_cn_redirect=1).</li>
        /// </summary>
        [JsonProperty("Targets")]
        public string[] Targets{ get; set; }

        /// <summary>
        /// If transcoding exists, only delete the resources that match after transcoding.
        /// If the content contains characters in a non-ASCII character set, enable this switch for encoding conversion (the encoding rule adheres to RFC3986).
        /// </summary>
        [JsonProperty("EncodeUrl")]
        [System.Obsolete]
        public bool? EncodeUrl{ get; set; }

        /// <summary>
        /// This parameter is required when the node cache purge type is set to purge_cache_tag. The input value is a domain name.
        /// </summary>
        [JsonProperty("CacheTag")]
        public CacheTag CacheTag{ get; set; }


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
            this.SetParamObj(map, prefix + "CacheTag.", this.CacheTag);
        }
    }
}

