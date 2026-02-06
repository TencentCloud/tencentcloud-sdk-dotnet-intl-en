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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MixLayoutParams : AbstractModel
    {
        
        /// <summary>
        /// Layout mode.
        /// 1: floating layout.
        /// 2: screen sharing layout.
        /// 3: nine-grid layout.
        /// 4: custom layout.
        /// 
        /// Floating layout: by default, the video footage of the first host who enters the room (or a specified host) fills the entire screen. other hosts' video images are arranged horizontally from the bottom-left corner in the room entry sequence, displayed as small pictures floating above the large screen. when the number of screens is less than or equal to 17, each line has 4 (4 x 4 arrangement). when the number of screens exceeds 17, the small pictures are rearranged with 5 per line (5 x 5 arrangement). a maximum of 25 screens are supported. if the user only sends audio, it still occupies a screen position.
        /// 
        /// Screen sharing layout: specifies a large screen position on the left side for one host (if not specified, the large screen position uses the background color). other hosts are arranged vertically on the right side from top to bottom. when the number of screens is less than 17, each column on the right supports up to 8 hosts, occupying a maximum of two columns. when the number of screens exceeds 17, hosts beyond the 17th are arranged horizontally starting from the bottom-left corner. a maximum of 25 screens is supported. if a host only sends audio, it still occupies a screen position.
        /// 
        /// Nine-Grid layout: automatically adjust the size of each frame based on the number of hosts. each host's frame size is the same, supporting up to 25 frames.
        /// 
        /// Custom layout: customize the layout of each host's video as needed in MixLayoutList.
        /// </summary>
        [JsonProperty("MixLayoutMode")]
        public ulong? MixLayoutMode{ get; set; }

        /// <summary>
        /// The custom layout details. This parameter is valid if `MixLayoutMode` is set to `4`. Up to 25 videos can be displayed.
        /// </summary>
        [JsonProperty("MixLayoutList")]
        public MixLayout[] MixLayoutList{ get; set; }

        /// <summary>
        /// The background color, which is a hexadecimal value (starting with "#", followed by the color value) converted from an 8-bit RGB value. For example, the RGB value of orange is `R:255 G:165 B:0`, and its hexadecimal value is `#FFA500`. The default color is black.
        /// </summary>
        [JsonProperty("BackGroundColor")]
        public string BackGroundColor{ get; set; }

        /// <summary>
        /// The user whose video is displayed in the big window. This parameter is valid if `MixLayoutMode` is set to `1` (floating) or `2` (screen sharing). If it is left empty, the first anchor entering the room is displayed in the big window in the floating mode and the canvas background is displayed in the screen sharing mode.
        /// </summary>
        [JsonProperty("MaxResolutionUserId")]
        public string MaxResolutionUserId{ get; set; }

        /// <summary>
        /// The stream type.
        /// 0: Primary stream (default)
        /// 1: Substream (screen sharing stream)
        /// This parameter specifies the type of the stream displayed in the big window. If it appears in `MixLayoutList`, it indicates the type of the stream of a specified user.
        /// </summary>
        [JsonProperty("MediaId")]
        public ulong? MediaId{ get; set; }

        /// <summary>
        /// The image url supports only jpg, png, and jpeg. the image resolution is limited to no more than 2K, and the image size limit is no more than 5MB. note that the url must carry the format extension, and only specific strings are supported in the url, including a-z, a-z, 0-9, '-', '.', '_', '~', ':', '/', '?', '#', '[', ']', '@', '!', '&', '(', ')', '*', '+', ',', '%', and '='.
        /// </summary>
        [JsonProperty("BackgroundImageUrl")]
        public string BackgroundImageUrl{ get; set; }

        /// <summary>
        /// Set to 1 to enable the placeholder image function, and 0 to disable it. default is 0. when enabled, the corresponding placeholder image can be displayed in the preset position if the user has no upload audio and video.
        /// </summary>
        [JsonProperty("PlaceHolderMode")]
        public ulong? PlaceHolderMode{ get; set; }

        /// <summary>
        /// Handling solution when the background image aspect ratio is not the same, consistent with the RenderMode defined in MixLayoutList.
        /// </summary>
        [JsonProperty("BackgroundImageRenderMode")]
        public ulong? BackgroundImageRenderMode{ get; set; }

        /// <summary>
        /// Sub-Picture placeholder image url supports only jpg, png, jpeg. resolution limitation is no more than 2K. image size limit is no more than 5MB. note that the url must carry format extension and supports only specific string literals within the range of a-z a-z 0-9 '-', '.', '_', '~', ':', '/', '?', '#', '[', ']' '@', '!', '&', '(', ')', '*', '+', ',', '%', '='.
        /// </summary>
        [JsonProperty("DefaultSubBackgroundImage")]
        public string DefaultSubBackgroundImage{ get; set; }

        /// <summary>
        /// The watermark layout. Up to 25 watermarks are supported.
        /// </summary>
        [JsonProperty("WaterMarkList")]
        public WaterMark[] WaterMarkList{ get; set; }

        /// <summary>
        /// When the aspect ratio of the background image does not match in the template layout, the handling solution is applied. the custom layout is disabled and aligns with the RenderMode defined in MixLayoutList.
        /// </summary>
        [JsonProperty("RenderMode")]
        public ulong? RenderMode{ get; set; }

        /// <summary>
        /// This parameter is valid only if the screen sharing layout is used. If you set it to `1`, the large video window will appear on the right and the small window on the left. The default value is `0`.
        /// </summary>
        [JsonProperty("MaxResolutionUserAlign")]
        public ulong? MaxResolutionUserAlign{ get; set; }

        /// <summary>
        /// Controls whether audio users inside the room occupy the stream mixing layout. this takes effect only in mixed stream recording and template layout. true: represents that audio users do not occupy placeholders. false: represents that audio users occupy placeholders (false by default).
        /// </summary>
        [JsonProperty("PureAudioDisableLayout")]
        public bool? PureAudioDisableLayout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MixLayoutMode", this.MixLayoutMode);
            this.SetParamArrayObj(map, prefix + "MixLayoutList.", this.MixLayoutList);
            this.SetParamSimple(map, prefix + "BackGroundColor", this.BackGroundColor);
            this.SetParamSimple(map, prefix + "MaxResolutionUserId", this.MaxResolutionUserId);
            this.SetParamSimple(map, prefix + "MediaId", this.MediaId);
            this.SetParamSimple(map, prefix + "BackgroundImageUrl", this.BackgroundImageUrl);
            this.SetParamSimple(map, prefix + "PlaceHolderMode", this.PlaceHolderMode);
            this.SetParamSimple(map, prefix + "BackgroundImageRenderMode", this.BackgroundImageRenderMode);
            this.SetParamSimple(map, prefix + "DefaultSubBackgroundImage", this.DefaultSubBackgroundImage);
            this.SetParamArrayObj(map, prefix + "WaterMarkList.", this.WaterMarkList);
            this.SetParamSimple(map, prefix + "RenderMode", this.RenderMode);
            this.SetParamSimple(map, prefix + "MaxResolutionUserAlign", this.MaxResolutionUserAlign);
            this.SetParamSimple(map, prefix + "PureAudioDisableLayout", this.PureAudioDisableLayout);
        }
    }
}

