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

    public class DubbingEmbedSubtitleConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>id of the suppressed subtitles.</p>
        /// </summary>
        [JsonProperty("SubtitleEmbedId")]
        public long? SubtitleEmbedId{ get; set; }

        /// <summary>
        /// <p>Continue to use the original subtitle position.</p><p>Default value: 1</p>
        /// </summary>
        [JsonProperty("UseOriginalPos")]
        public long? UseOriginalPos{ get; set; }

        /// <summary>
        /// <p>Continue to use the original subtitle font size.</p><p>Default value: 1</p>
        /// </summary>
        [JsonProperty("UseOriginalSize")]
        public long? UseOriginalSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleEmbedId", this.SubtitleEmbedId);
            this.SetParamSimple(map, prefix + "UseOriginalPos", this.UseOriginalPos);
            this.SetParamSimple(map, prefix + "UseOriginalSize", this.UseOriginalSize);
        }
    }
}

