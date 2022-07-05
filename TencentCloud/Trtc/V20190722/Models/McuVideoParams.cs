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

    public class McuVideoParams : AbstractModel
    {
        
        /// <summary>
        /// The video encoding parameters.
        /// </summary>
        [JsonProperty("VideoEncode")]
        public VideoEncode VideoEncode{ get; set; }

        /// <summary>
        /// The layout parameters.
        /// </summary>
        [JsonProperty("LayoutParams")]
        public McuLayoutParams LayoutParams{ get; set; }

        /// <summary>
        /// The canvas color. Below are the values for some common colors:
        /// Red: 0xcc0033
        /// Yellow: 0xcc9900
        /// Green: 0xcccc33
        /// Blue: 0x99CCFF
        /// Black: 0x000000
        /// White: 0xFFFFFF
        /// Grey: 0x999999
        /// </summary>
        [JsonProperty("BackGroundColor")]
        public string BackGroundColor{ get; set; }

        /// <summary>
        /// The URL of the background image for the canvas. This parameter has a higher priority than `BackGroundColor`.
        /// </summary>
        [JsonProperty("BackgroundImageUrl")]
        public string BackgroundImageUrl{ get; set; }

        /// <summary>
        /// The watermark information for the mixed stream.
        /// </summary>
        [JsonProperty("WaterMarkList")]
        public McuWaterMarkParams[] WaterMarkList{ get; set; }


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
        }
    }
}

