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

    public class McuLayout : AbstractModel
    {
        
        /// <summary>
        /// The information of the stream that is displayed. If you do not pass this parameter, TRTC will display the videos of anchors in the room according to their room entry sequence.
        /// </summary>
        [JsonProperty("UserMediaStream")]
        public UserMediaStream UserMediaStream{ get; set; }

        /// <summary>
        /// The video width (pixels). If you do not pass this parameter, 0 will be used.
        /// </summary>
        [JsonProperty("ImageWidth")]
        public ulong? ImageWidth{ get; set; }

        /// <summary>
        /// The video height (pixels). If you do not pass this parameter, 0 will be used.
        /// </summary>
        [JsonProperty("ImageHeight")]
        public ulong? ImageHeight{ get; set; }

        /// <summary>
        /// The horizontal offset (pixels) of the video. The sum of `LocationX` and `ImageWidth` cannot exceed the width of the canvas. If you do not pass this parameter, 0 will be used.
        /// </summary>
        [JsonProperty("LocationX")]
        public ulong? LocationX{ get; set; }

        /// <summary>
        /// The vertical offset of the video. The sum of `LocationY` and `ImageHeight` cannot exceed the height of the canvas. If you do not pass this parameter, 0 will be used.
        /// </summary>
        [JsonProperty("LocationY")]
        public ulong? LocationY{ get; set; }

        /// <summary>
        /// The image layer of the video. If you do not pass this parameter, 0 will be used.
        /// </summary>
        [JsonProperty("ZOrder")]
        public ulong? ZOrder{ get; set; }

        /// <summary>
        /// The rendering mode of the video. 0 (the video is scaled and the excess parts are cropped), 1 (the video is scaled), 2 (the video is scaled and the blank spaces are filled with black bars). If you do not pass this parameter, 0 will be used.
        /// </summary>
        [JsonProperty("RenderMode")]
        public ulong? RenderMode{ get; set; }

        /// <summary>
        /// (Not supported yet) The background color of a video. Below are the values for some commonly used colors:
        /// Red: `0xcc0033`
        /// Yellow: `0xcc9900`
        /// Green: `0xcccc33`
        /// Blue: `0x99CCFF`
        /// Black: `0x000000`
        /// White: `0xFFFFFF`
        /// Grey: `0x999999`
        /// </summary>
        [JsonProperty("BackGroundColor")]
        public string BackGroundColor{ get; set; }

        /// <summary>
        /// The URL of the background image for the video. This parameter allows you to specify an image to display when the user’s camera is turned off or before the user enters the room. If the dimensions of the image specified are different from those of the video window, the image will be stretched to fit the space. This parameter has a higher priority than `BackGroundColor`.
        /// </summary>
        [JsonProperty("BackgroundImageUrl")]
        public string BackgroundImageUrl{ get; set; }

        /// <summary>
        /// Custom cropping.
        /// </summary>
        [JsonProperty("CustomCrop")]
        public McuCustomCrop CustomCrop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "UserMediaStream.", this.UserMediaStream);
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
            this.SetParamSimple(map, prefix + "LocationX", this.LocationX);
            this.SetParamSimple(map, prefix + "LocationY", this.LocationY);
            this.SetParamSimple(map, prefix + "ZOrder", this.ZOrder);
            this.SetParamSimple(map, prefix + "RenderMode", this.RenderMode);
            this.SetParamSimple(map, prefix + "BackGroundColor", this.BackGroundColor);
            this.SetParamSimple(map, prefix + "BackgroundImageUrl", this.BackgroundImageUrl);
            this.SetParamObj(map, prefix + "CustomCrop.", this.CustomCrop);
        }
    }
}

