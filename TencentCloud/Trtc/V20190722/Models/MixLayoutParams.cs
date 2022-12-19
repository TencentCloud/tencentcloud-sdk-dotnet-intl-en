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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MixLayoutParams : AbstractModel
    {
        
        /// <summary>
        /// Layout mode:
        /// 1: Floating
        /// 2: Screen sharing
        /// 3: Grid (default)
        /// 4: Custom
        /// 
        /// Floating: By default, the video of the first anchor (you can also specify an anchor) who enters the room is scaled to fill the screen. When other anchors enter the room, their videos appear smaller and are superimposed over the large video from left to right starting from the bottom of the canvas according to their room entry sequence. If the total number of videos is 17 or less, there will be four windows in each row (4 x 4); if it is greater than 17, there will be five windows in each row (5 x 5). Up to 25 videos can be displayed. A user who publishes only audio will still be displayed in one window.
        /// 
        /// Screen sharing: The video of a specified anchor occupies a larger part of the canvas on the left side (if you do not specify an anchor, the left window will display the canvas background). The videos of other anchors are smaller and are positioned on the right side. If the total number of videos is 17 or less, the small videos are positioned from top to bottom in up to two columns on the right side, with eight videos per column at most. If there are more than 17 videos, the additional videos are positioned at the bottom of the canvas from left to right. Up to 25 videos can be displayed. A user who publishes only audio will still be displayed in one window.
        /// 
        /// Grid: The videos of anchors are scaled and positioned automatically according to the total number of anchors in a room. Each video has the same size. Up to 25 videos can be displayed.
        /// 
        /// Custom: Specify the layout of videos by using the `MixLayoutList` parameter.
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
        /// The download URL of the background image for the canvas, which must be in JPG or PNG format and cannot be larger than 5 MB.
        /// </summary>
        [JsonProperty("BackgroundImageUrl")]
        public string BackgroundImageUrl{ get; set; }

        /// <summary>
        /// `1` means to use placeholders, and `0` (default) means to not use placeholders. If this parameter is set to `1`, when a user is not publishing video, a placeholder image will be displayed in the window reserved for the user.
        /// </summary>
        [JsonProperty("PlaceHolderMode")]
        public ulong? PlaceHolderMode{ get; set; }

        /// <summary>
        /// The render mode to use when the aspect ratio of a video is different from that of the window. This parameter is defined the same as `RenderMode` in `MixLayoufList`.
        /// </summary>
        [JsonProperty("BackgroundImageRenderMode")]
        public ulong? BackgroundImageRenderMode{ get; set; }

        /// <summary>
        /// The URL of the background image for a window. The image must be in JPG or PNG format and cannot be larger than 5 MB. If the image’s aspect ratio is different from that of the window, the image will be rendered according to the value of `RenderMode`.
        /// </summary>
        [JsonProperty("DefaultSubBackgroundImage")]
        public string DefaultSubBackgroundImage{ get; set; }

        /// <summary>
        /// The watermark layout. Up to 25 watermarks are supported.
        /// </summary>
        [JsonProperty("WaterMarkList")]
        public WaterMark[] WaterMarkList{ get; set; }

        /// <summary>
        /// The render mode to use when the aspect ratio of a video is different from that of the window. This parameter is invalid if a custom layout is used. It is defined the same as `RenderMode` in `MixLayoufList`.
        /// </summary>
        [JsonProperty("RenderMode")]
        public ulong? RenderMode{ get; set; }

        /// <summary>
        /// This parameter is valid only if the screen sharing layout is used. If you set it to `1`, the large video window will appear on the right and the small window on the left. The default value is `0`.
        /// </summary>
        [JsonProperty("MaxResolutionUserAlign")]
        public ulong? MaxResolutionUserAlign{ get; set; }


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
        }
    }
}

