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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Object key prefix matching, limited to object keys whose names contain the specified prefix in response.
        /// </summary>
        [JsonProperty("Prefix")]
        public string Prefix{ get; set; }

        /// <summary>
        /// A character separator used for grouping object keys. All object keys with the same part between the prefix or the start (if no prefix is specified) and the first delimiter are grouped as a prefix node under CommonPrefixes. Grouped object keys no longer appear in the subsequent object list.
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }

        /// <summary>
        /// ys  Maximum number of entries returned at a time. Default value: 100. Minimum: 1. Maximum: 100.
        /// </summary>
        [JsonProperty("MaxKeys")]
        public long? MaxKeys{ get; set; }

        /// <summary>
        /// Starting object key marker
        /// </summary>
        [JsonProperty("Marker")]
        public string Marker{ get; set; }

        /// <summary>
        /// File type. Match any element in the collection: <li>Video: video file</li> <li>Audio: audio file</li> <li>Image: image file</li>
        /// </summary>
        [JsonProperty("Categories")]
        public string[] Categories{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Prefix", this.Prefix);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
            this.SetParamSimple(map, prefix + "MaxKeys", this.MaxKeys);
            this.SetParamSimple(map, prefix + "Marker", this.Marker);
            this.SetParamArraySimple(map, prefix + "Categories.", this.Categories);
        }
    }
}

