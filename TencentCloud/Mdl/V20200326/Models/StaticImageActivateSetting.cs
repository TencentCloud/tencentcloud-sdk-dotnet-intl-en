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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StaticImageActivateSetting : AbstractModel
    {
        
        /// <summary>
        /// The address of the image to be inserted, starting with http or https and ending with .png .PNG .bmp .BMP .tga .TGA.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// The layer of the superimposed image, 0-7; the default value is 0, and a higher layer means it is on the top.
        /// </summary>
        [JsonProperty("Layer")]
        public long? Layer{ get; set; }

        /// <summary>
        /// Opacity, range 0-100; the default value is 100, which means completely opaque.
        /// </summary>
        [JsonProperty("Opacity")]
        public long? Opacity{ get; set; }

        /// <summary>
        /// The distance from the left edge in pixels; the default value is 0 and the maximum value is 4096.
        /// </summary>
        [JsonProperty("ImageX")]
        public long? ImageX{ get; set; }

        /// <summary>
        /// The distance from the top edge in pixels; the default value is 0 and the maximum value is 2160.
        /// </summary>
        [JsonProperty("ImageY")]
        public long? ImageY{ get; set; }

        /// <summary>
        /// The width of the image superimposed on the video frame, in pixels. The default value is empty (not set), which means using the original image size. The minimum value is 1 and the maximum value is 4096.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// The height of the image superimposed on the video frame, in pixels. The default value is empty (not set), which means the original image size is used. The minimum value is 1 and the maximum value is 2160.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Overlay duration, in milliseconds, range 0-86400000; default value 0, 0 means continuous.
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// Fade-in duration, in milliseconds, range 0-5000; default value 0, 0 means no fade-in effect.
        /// </summary>
        [JsonProperty("FadeIn")]
        public long? FadeIn{ get; set; }

        /// <summary>
        /// Fade-out duration, in milliseconds, range 0-5000; default value 0, 0 means no fade-out effect.
        /// </summary>
        [JsonProperty("FadeOut")]
        public long? FadeOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "Layer", this.Layer);
            this.SetParamSimple(map, prefix + "Opacity", this.Opacity);
            this.SetParamSimple(map, prefix + "ImageX", this.ImageX);
            this.SetParamSimple(map, prefix + "ImageY", this.ImageY);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "FadeIn", this.FadeIn);
            this.SetParamSimple(map, prefix + "FadeOut", this.FadeOut);
        }
    }
}

