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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonMixLayoutParams : AbstractModel
    {
        
        /// <summary>
        /// Input layer. Value range: [1,16]
        /// (1) For the background stream, i.e., the room owner’s image or the canvas, set this parameter to `1`.
        /// (2) This parameter is required for audio-only stream mixing as well.
        /// Note that two inputs cannot have the same `ImageLayer` value.
        /// </summary>
        [JsonProperty("ImageLayer")]
        public long? ImageLayer{ get; set; }

        /// <summary>
        /// Input type. Value range: [0,5].
        /// If this parameter is left empty, 0 will be used by default.
        /// 0: the input stream is audio/video.
        /// 2: the input stream is image.
        /// 3: the input stream is canvas. 
        /// 4: the input stream is audio.
        /// 5: the input stream is pure video.
        /// </summary>
        [JsonProperty("InputType")]
        public long? InputType{ get; set; }

        /// <summary>
        /// Output height of input video image. Value range:
        /// Pixel: [0,2000]
        /// Percentage: [0.01,0.99]
        /// If this parameter is left empty, the input stream height will be used by default.
        /// If percentage is used, the expected output is (percentage * background height).
        /// </summary>
        [JsonProperty("ImageHeight")]
        public float? ImageHeight{ get; set; }

        /// <summary>
        /// Output width of input video image. Value range:
        /// Pixel: [0,2000]
        /// Percentage: [0.01,0.99]
        /// If this parameter is left empty, the input stream width will be used by default.
        /// If percentage is used, the expected output is (percentage * background width).
        /// </summary>
        [JsonProperty("ImageWidth")]
        public float? ImageWidth{ get; set; }

        /// <summary>
        /// X-axis offset of input in output video image. Value range:
        /// Pixel: [0,2000]
        /// Percentage: [0.01,0.99]
        /// If this parameter is left empty, 0 will be used by default.
        /// Horizontal offset from the top-left corner of main host background video image. 
        /// If percentage is used, the expected output is (percentage * background width).
        /// </summary>
        [JsonProperty("LocationX")]
        public float? LocationX{ get; set; }

        /// <summary>
        /// Y-axis offset of input in output video image. Value range:
        /// Pixel: [0,2000]
        /// Percentage: [0.01,0.99]
        /// If this parameter is left empty, 0 will be used by default.
        /// Vertical offset from the top-left corner of main host background video image. 
        /// If percentage is used, the expected output is (percentage * background width)
        /// </summary>
        [JsonProperty("LocationY")]
        public float? LocationY{ get; set; }

        /// <summary>
        /// When `InputType` is 3 (canvas), this value indicates the canvas color.
        /// Commonly used colors include:
        /// Red: 0xcc0033.
        /// Yellow: 0xcc9900.
        /// Green: 0xcccc33.
        /// Blue: 0x99CCFF.
        /// Black: 0x000000.
        /// White: 0xFFFFFF.
        /// Gray: 0x999999
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }

        /// <summary>
        /// When `InputType` is 2 (image), this value is the watermark ID.
        /// </summary>
        [JsonProperty("WatermarkId")]
        public long? WatermarkId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageLayer", this.ImageLayer);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
            this.SetParamSimple(map, prefix + "LocationX", this.LocationX);
            this.SetParamSimple(map, prefix + "LocationY", this.LocationY);
            this.SetParamSimple(map, prefix + "Color", this.Color);
            this.SetParamSimple(map, prefix + "WatermarkId", this.WatermarkId);
        }
    }
}

