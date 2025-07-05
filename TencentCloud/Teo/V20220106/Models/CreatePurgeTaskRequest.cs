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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePurgeTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the site
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Type of the purging task. Values:
        /// - `purge_url`: Purge by the URL
        /// - `purge_prefix`: Purge by the prefix
        /// - `purge_host`: Purge by the Hostname
        /// - `purge_all`: Purge all cached contents
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Target resource to be purged, which depends on the `Type` field.
        /// 1. When `Type = purge_host`:
        /// Hostnames are purged, such as www.example.com and foo.bar.example.com.
        /// 2. When `Type = purge_prefix`:
        /// Prefixes are purged, such as http://www.example.com/example.
        /// 3. When `Type = purge_url`:
        /// URLs are purged, such as https://www.example.com/example.jpg.
        /// 4. When `Type = purge_all`: All types of resources are purged.
        /// `Targets` is not a required field.
        /// </summary>
        [JsonProperty("Targets")]
        public string[] Targets{ get; set; }

        /// <summary>
        /// Specifies whether to transcode non-ASCII URLs according to RFC3986.
        /// Note that if it’s enabled, the purging is based on the converted URLs.
        /// </summary>
        [JsonProperty("EncodeUrl")]
        public bool? EncodeUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "EncodeUrl", this.EncodeUrl);
        }
    }
}

