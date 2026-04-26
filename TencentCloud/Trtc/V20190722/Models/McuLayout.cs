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

    public class McuLayout : AbstractModel
    {
        
        /// <summary>
        /// User media stream parameters. if left blank, tencent cloud backend fills them automatically by the room entry sequence of the uplink host.
        /// </summary>
        [JsonProperty("UserMediaStream")]
        public UserMediaStream UserMediaStream{ get; set; }

        /// <summary>
        /// The width of the sub-screen in the output, unit: pixel value. defaults to 0 if left blank.
        /// </summary>
        [JsonProperty("ImageWidth")]
        public ulong? ImageWidth{ get; set; }

        /// <summary>
        /// The height of the sub-screen in the output, in pixel values. default is 0.
        /// </summary>
        [JsonProperty("ImageHeight")]
        public ulong? ImageHeight{ get; set; }

        /// <summary>
        /// The X-axis offset of the sub-screen in the output, unit: pixel value. the sum of LocationX and ImageWidth must not exceed the total width of the mixed stream output. default is 0.
        /// </summary>
        [JsonProperty("LocationX")]
        public ulong? LocationX{ get; set; }

        /// <summary>
        /// The Y-axis offset of the sub-screen in the output, unit: pixel value. the sum of LocationY and ImageHeight must not exceed the total height of the mixed stream output. default is 0 if left blank.
        /// </summary>
        [JsonProperty("LocationY")]
        public ulong? LocationY{ get; set; }

        /// <summary>
        /// The hierarchy of the sub-screen in the output. default is 0.
        /// </summary>
        [JsonProperty("ZOrder")]
        public ulong? ZOrder{ get; set; }

        /// <summary>
        /// The display mode of the sub-screen in the output: 0 for crop, 1 for scale and display background, 2 for scale and display black background. defaults to 0 if left blank.
        /// </summary>
        [JsonProperty("RenderMode")]
        public ulong? RenderMode{ get; set; }

        /// <summary>
        /// [This parameter configuration is invalid and not currently supported] the background color of the sub-picture. commonly used colors are:.
        /// Red: 0xcc0033.
        /// Yellow: 0xcc9900.
        /// Green: 0xcccc33.
        /// Blue: 0x99CCFF.
        /// Black: 0x000000.
        /// White: 0xFFFFFF.
        /// Gray: 0x999999.
        /// </summary>
        [JsonProperty("BackGroundColor")]
        public string BackGroundColor{ get; set; }

        /// <summary>
        /// The url of the placeholder image for the sub-window. fill in this parameter to specify the image displayed in the layout position when the user turns the camera off or has not joined the TRTC room. if the specified image has a different size ratio from the layout position, it will be stretched. this parameter has a higher priority than BackGroundColor. supported formats include png, jpg, jpeg, bmp, gif, and webm. the image size limit is no more than 5MB.
        /// Note:.
        /// 1. make sure the image link is accessible. the backend single download timeout period is 10 seconds with a maximum of 3 retries. if the image download fails eventually, the placeholder image will not take effect.
        /// 2. supported character sets for urls: ['0-9', 'a-z', 'a-z', '-', '.', '_', '~', ':', '/', '?', '#', '[', ']', '@', '!', '&', '(', ')', '*', '+', ',', '%', '=', ';', '|']. make sure url characters are within the supported character sets. if characters outside the supported character sets exist, the placeholder image will not take effect.
        /// </summary>
        [JsonProperty("BackgroundImageUrl")]
        public string BackgroundImageUrl{ get; set; }

        /// <summary>
        /// Customer custom crop, targeting the input stream.
        /// </summary>
        [JsonProperty("CustomCrop")]
        public McuCustomCrop CustomCrop{ get; set; }

        /// <summary>
        /// The display mode of the sub-background image in the output: 0 for crop, 1 for scale and display background, 2 for scale and display black background, 3 for variable-scale scaling, 4 for custom rendering. defaults to 3 if left blank.
        /// </summary>
        [JsonProperty("BackgroundRenderMode")]
        public ulong? BackgroundRenderMode{ get; set; }

        /// <summary>
        /// The sub-screen template url points to a template image with an alpha channel. fill in this parameter, and the backend will extract the alpha channel of the template image during compositing, scale it as the alpha channel of the target frame, and mix it with other frames. you can use the transparent template to achieve a semi-transparent effect and arbitrary shape cropping (such as rounded corners, stars, hearts) for the target frame. png format is supported. the image size limit is no more than 5MB.
        /// Note:.
        /// 1. the image aspect ratio of the template should be close to the target frame aspect ratio to avoid deformation of the template effect when scaling to fit the target frame. 2. the transparent template only takes effect when RenderMode is 0 (crop). 3. make sure the image link is accessible. the backend single download timeout period is 10 seconds with a maximum of 3 retries. if the image download fails eventually, the transparent template will not take effect.
        /// 2. url supported character sets: ['0-9','a-z','a-z','-', '.', '_', '~', ':', '/', '?', '#', '[', ']','@', '!', '&', '(', ')', '*', '+', ',', '%', '=', ';', '|']. make sure url characters are within the supported character sets. if characters outside the supported character sets exist, the transparent template will not take effect.
        /// </summary>
        [JsonProperty("TransparentUrl")]
        public string TransparentUrl{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BackgroundCustomRender")]
        public McuBackgroundCustomRender BackgroundCustomRender{ get; set; }

        /// <summary>
        /// Sub-Background color effective mode. default value 0 means disabled.
        /// bit0 specifies whether placeholder image scaling takes effect.
        /// bit1 specifies whether upstream flow scaling takes effect.
        /// You can set the corresponding bit position to 1 to start up and take effect, such as:.
        /// 0(00) means the sub background color is disabled.
        /// 1(01) indicates the sub-background color is valid only when placeholder image scaling is enabled.
        /// 2(10) means the sub background color is valid only when upstream flow scaling.
        /// 3(11) indicates the sub-background color takes effect in both placeholder image scaling and upstream flow scaling.
        /// </summary>
        [JsonProperty("BackGroundColorMode")]
        public ulong? BackGroundColorMode{ get; set; }


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
            this.SetParamSimple(map, prefix + "BackgroundRenderMode", this.BackgroundRenderMode);
            this.SetParamSimple(map, prefix + "TransparentUrl", this.TransparentUrl);
            this.SetParamObj(map, prefix + "BackgroundCustomRender.", this.BackgroundCustomRender);
            this.SetParamSimple(map, prefix + "BackGroundColorMode", this.BackGroundColorMode);
        }
    }
}

