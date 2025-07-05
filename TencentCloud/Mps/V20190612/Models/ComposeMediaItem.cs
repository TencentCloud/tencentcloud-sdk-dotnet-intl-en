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

    public class ComposeMediaItem : AbstractModel
    {
        
        /// <summary>
        /// The element type. Valid values:
        /// <li>`Video` </li>
        /// <li>`Audio` </li>
        /// <li>`Image` </li>
        /// <li>`Transition` </li>
        /// <li>`Subtitle` </li>
        /// <li>`Empty` </li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The information of the video element, which is valid if `Type` is `Video`.
        /// </summary>
        [JsonProperty("Video")]
        public ComposeVideoItem Video{ get; set; }

        /// <summary>
        /// The information of the audio element, which is valid if `Type` is `Audio`.
        /// </summary>
        [JsonProperty("Audio")]
        public ComposeAudioItem Audio{ get; set; }

        /// <summary>
        /// The information of the image element, which is valid if `Type` is `Image`.
        /// </summary>
        [JsonProperty("Image")]
        public ComposeImageItem Image{ get; set; }

        /// <summary>
        /// The information of the transition element, which is valid if `Type` is `Transition`.
        /// </summary>
        [JsonProperty("Transition")]
        public ComposeTransitionItem Transition{ get; set; }

        /// <summary>
        /// The information of the subtitle element, which is valid if `Type` is `Subtitle`.
        /// </summary>
        [JsonProperty("Subtitle")]
        public ComposeSubtitleItem Subtitle{ get; set; }

        /// <summary>
        /// The information of the empty element, which is valid if `Type` is `Empty`. An empty element is used as a placeholder in the timeline.
        /// </summary>
        [JsonProperty("Empty")]
        public ComposeEmptyItem Empty{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Video.", this.Video);
            this.SetParamObj(map, prefix + "Audio.", this.Audio);
            this.SetParamObj(map, prefix + "Image.", this.Image);
            this.SetParamObj(map, prefix + "Transition.", this.Transition);
            this.SetParamObj(map, prefix + "Subtitle.", this.Subtitle);
            this.SetParamObj(map, prefix + "Empty.", this.Empty);
        }
    }
}

