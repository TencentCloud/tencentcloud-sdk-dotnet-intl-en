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

    public class MediaSubtitleInput : AbstractModel
    {
        
        /// <summary>
        /// Subtitle name. Length limit: 64 characters
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Subtitle language. Common values:
        /// <li>`zh`: Chinese</li>
        /// <li>`en`: English</li>
        /// <li>`ja`: Japanese</li>
        /// <li>`ko`: Korean</li>
        /// <li>`vi`: Vietnamese</li>
        /// <li>`ms`: Malay</li>
        /// <li>`th`: Thai</li>
        /// <li>`pt`: Portuguese</li>
        /// <li>`tr`: Turkish</li>
        /// <li>`ar`: Arabic</li>
        /// <li>`es`: Spanish</li>
        /// <li>`hi`: Hindi</li>
        /// <li>`fr`: French</li>For other valid values, see [RFC 5646](https://tools.ietf.org/html/rfc5646).
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// Subtitle format. Valid value:
        /// <li>vtt</li>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// Subtitle content, which is [Base64-encoded](https://tools.ietf.org/html/rfc4648) strings
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// The subtitle ID. It can be up to 16 characters long, can contain letters, numbers, underscores (_), and hyphens (-), and cannot be identical to an existing subtitle ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

