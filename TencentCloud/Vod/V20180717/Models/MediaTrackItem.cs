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

    public class MediaTrackItem : AbstractModel
    {
        
        /// <summary>
        /// Fragment type. Valid values:
        /// <li>Video: video clip.</li>
        /// <li>Audio: audio clip.</li>
        /// <li>Sticker: texture segment.</li>
        /// <li>Transition: transition.</li>
        /// <li>Empty: empty segment.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Video clip. Valid when Type is Video.
        /// </summary>
        [JsonProperty("VideoItem")]
        public VideoTrackItem VideoItem{ get; set; }

        /// <summary>
        /// Audio clip. Valid when Type = Audio.
        /// </summary>
        [JsonProperty("AudioItem")]
        public AudioTrackItem AudioItem{ get; set; }

        /// <summary>
        /// Texture segment. Valid when Type is Sticker.
        /// </summary>
        [JsonProperty("StickerItem")]
        public StickerTrackItem StickerItem{ get; set; }

        /// <summary>
        /// Transition. Valid when Type is Transition.
        /// </summary>
        [JsonProperty("TransitionItem")]
        public MediaTransitionItem TransitionItem{ get; set; }

        /// <summary>
        /// Empty segment. Valid when Type is Empty. Empty segments are used as placeholders on the timeline.<li>If a period of silence is required between two audio clips, you can use EmptyTrackItem as a placeholder.</li>
        /// <li>Use EmptyTrackItem as a placeholder to locate an item.</li>
        /// </summary>
        [JsonProperty("EmptyItem")]
        public EmptyTrackItem EmptyItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "VideoItem.", this.VideoItem);
            this.SetParamObj(map, prefix + "AudioItem.", this.AudioItem);
            this.SetParamObj(map, prefix + "StickerItem.", this.StickerItem);
            this.SetParamObj(map, prefix + "TransitionItem.", this.TransitionItem);
            this.SetParamObj(map, prefix + "EmptyItem.", this.EmptyItem);
        }
    }
}

