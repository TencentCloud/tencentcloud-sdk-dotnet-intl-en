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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaTrackItem : AbstractModel
    {
        
        /// <summary>
        /// Segment type. Valid values:
        /// <li>Video: video segment.</li>
        /// <li>Audio: audio segment.</li>
        /// <li>Sticker: sticker segment.</li>
        /// <li>Transition: transition.</li>
        /// <li>Empty: empty segment.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Video segment, which is valid if `Type` is `Video`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VideoItem")]
        public VideoTrackItem VideoItem{ get; set; }

        /// <summary>
        /// Audio segment, which is valid if `Type` is `Audio`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AudioItem")]
        public AudioTrackItem AudioItem{ get; set; }

        /// <summary>
        /// Sticker segment, which is valid if `Type` is `Sticker`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StickerItem")]
        public StickerTrackItem StickerItem{ get; set; }

        /// <summary>
        /// Transition, which is valid if `Type` is `Transition`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransitionItem")]
        public MediaTransitionItem TransitionItem{ get; set; }

        /// <summary>
        /// Empty segment, which is valid if `Type` is `Empty`. It is used as placeholder on time axis. <li>If you want a period of silence between two audio segments, you can use `EmptyTrackItem` to hold the place.</li>
        /// <li>Use `EmptyTrackItem` as a placeholder to locate an item.</li>
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EmptyItem")]
        public EmptyTrackItem EmptyItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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

