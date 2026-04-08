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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubtitleTransResultItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Translation flag:</p><ul><li>Success</li><li>Error</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Source language (such as "en")</p>
        /// </summary>
        [JsonProperty("TransSrc")]
        public string TransSrc{ get; set; }

        /// <summary>
        /// <p>Target language (such as "zh")</p>
        /// </summary>
        [JsonProperty("TransDst")]
        public string TransDst{ get; set; }

        /// <summary>
        /// <p>Subtitle file URL</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>Subtitle translation suppression video path.</p>
        /// </summary>
        [JsonProperty("SubtitleEmbedPath")]
        public string SubtitleEmbedPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TransSrc", this.TransSrc);
            this.SetParamSimple(map, prefix + "TransDst", this.TransDst);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "SubtitleEmbedPath", this.SubtitleEmbedPath);
        }
    }
}

