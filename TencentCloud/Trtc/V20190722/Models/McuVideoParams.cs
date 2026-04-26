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

    public class McuVideoParams : AbstractModel
    {
        
        /// <summary>
        /// Video encoding parameter for the output stream.
        /// </summary>
        [JsonProperty("VideoEncode")]
        public VideoEncode VideoEncode{ get; set; }

        /// <summary>
        /// Stream mixing layout parameter.
        /// </summary>
        [JsonProperty("LayoutParams")]
        public McuLayoutParams LayoutParams{ get; set; }

        /// <summary>
        /// The entire canvas background color. commonly used colors:.
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
        /// The url of the background image for the entire canvas. priority is higher than BackGroundColor. supports png, jpg, and jpeg formats. image size limit is not more than 5MB.
        /// Note:.
        /// 1. make sure the image link is accessible. the backend download timeout is 10 seconds with a maximum of 3 retries. if the image download fails eventually, the background image will not take effect.
        /// 2. url supported character sets: ['0-9','a-z','a-z','-', '.', '_', '~', ':', '/', '?', '#', '[', ']','@', '!', '&', '(', ')', '*', '+', ',', '%', '=', ';', '|']. make sure url characters are within the supported character sets. if any character outside the supported character sets exists, the background image will not take effect.
        /// </summary>
        [JsonProperty("BackgroundImageUrl")]
        public string BackgroundImageUrl{ get; set; }

        /// <summary>
        /// Watermark parameters for the stream mixing layout.
        /// </summary>
        [JsonProperty("WaterMarkList")]
        public McuWaterMarkParams[] WaterMarkList{ get; set; }

        /// <summary>
        /// The display mode of the background image in the output: 0 for crop, 1 for scale and display black background, 2 for variable-scale scaling. the backend defaults to variable-scale scaling.
        /// </summary>
        [JsonProperty("BackgroundRenderMode")]
        public ulong? BackgroundRenderMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "VideoEncode.", this.VideoEncode);
            this.SetParamObj(map, prefix + "LayoutParams.", this.LayoutParams);
            this.SetParamSimple(map, prefix + "BackGroundColor", this.BackGroundColor);
            this.SetParamSimple(map, prefix + "BackgroundImageUrl", this.BackgroundImageUrl);
            this.SetParamArrayObj(map, prefix + "WaterMarkList.", this.WaterMarkList);
            this.SetParamSimple(map, prefix + "BackgroundRenderMode", this.BackgroundRenderMode);
        }
    }
}

