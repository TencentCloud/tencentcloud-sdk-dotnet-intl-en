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

namespace TencentCloud.Aiart.V20221229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageToImageRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64 code of the input mage.
        /// Either the Base64 code or URL must be provided. If both are provided, URL prevails.
        /// Image restrictions: The single-edge resolution must be less than 5,000 and greater than 50, and the size after Base64 encoding must be less than 8 MB. Supported formats include JPG, JPEG, PNG, BMP, TIFF and WEBP.
        /// </summary>
        [JsonProperty("InputImage")]
        public string InputImage{ get; set; }

        /// <summary>
        /// URL of the input mage.
        /// Either the Base64 code or URL must be provided. If both are provided, URL prevails.
        /// Image restrictions: The single-edge resolution must be less than 5,000 and greater than 50, and the size after Base64 encoding must be less than 8 MB. Supported formats include JPG, JPEG, PNG, BMP, TIFF and WEBP.
        /// </summary>
        [JsonProperty("InputUrl")]
        public string InputUrl{ get; set; }

        /// <summary>
        /// Text description.
        /// It is used to increase the possibility that the generation result contains the described content.
        /// A maximum of 256 UTF-8 characters are supported.
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// Negative text description.
        /// It is used to reduce the possibility that the generation result contains the described content, but such content cannot be completely avoided.
        /// English is recommended. A maximum of 256 UTF-8 characters are supported.
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// Image style.
        /// Select the desired style from the [Image Style List](https://intl.cloud.tencent.com/document/product/1668/86250?from_cn_redirect=1) and enter the style number.
        /// It is recommended to use only one style. If no style is specified, 201 (anime style) is used by default.
        /// </summary>
        [JsonProperty("Styles")]
        public string[] Styles{ get; set; }

        /// <summary>
        /// Configurations of the generated image, including the resolution.
        /// Images with the following resolutions can be generated: origin (The resolution is the same as the input image resolution, with the edge resolution of up to 2000. The image will be zoomed out proportionally if the resolution is exceeded.), 768:768 (1:1), 768:1024 (3:4), and 1024:768 (4:3).
        /// If the resolution is not specified, origin is used by default.
        /// </summary>
        [JsonProperty("ResultConfig")]
        public ResultConfig ResultConfig{ get; set; }

        /// <summary>
        /// Switch indicating whether to add a logo to the generated image. Default value: 1.
        /// 1: add logo
        /// 0: do not add logo
        /// Other values: add logo
        /// It is recommended to use an obvious logo to indicate that the image result is generated by AI.
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// Logo content settings.
        /// By default, the text "Generated by AI" is added to the bottom right corner of the generated image. You can also use other logo.
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }

        /// <summary>
        /// Generation strength.
        /// The smaller the strength value, the more the generated image resembles the original image. Value range: (0, 1]. If the strength is not specified, the default value of the model is used.
        /// The recommended value range is 0.6 to 0.8.
        /// </summary>
        [JsonProperty("Strength")]
        public float? Strength{ get; set; }

        /// <summary>
        /// Image return method (base64 or url).
        /// You can specify only one method. Default value: base64.
        /// The URL is valid for 1 hour.
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }

        /// <summary>
        /// Switch indicating whether to  enhance image clarity. Default value: 0.
        /// 1: on
        /// 0: off
        /// If the switch is turned on, the image clarity will be enhanced and the generation time will increase.
        /// </summary>
        [JsonProperty("EnhanceImage")]
        public long? EnhanceImage{ get; set; }

        /// <summary>
        /// Maximum number of faces for detail restoration. Value range: 0 - 6. Default value: 0.
        /// If the input value is greater than 0, the value will be used as the maximum number of faces with a small area can be restored in each image. The generation time will increase according to the actual number of faces restored.
        /// </summary>
        [JsonProperty("RestoreFace")]
        public long? RestoreFace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputImage", this.InputImage);
            this.SetParamSimple(map, prefix + "InputUrl", this.InputUrl);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamArraySimple(map, prefix + "Styles.", this.Styles);
            this.SetParamObj(map, prefix + "ResultConfig.", this.ResultConfig);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
            this.SetParamSimple(map, prefix + "Strength", this.Strength);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
            this.SetParamSimple(map, prefix + "EnhanceImage", this.EnhanceImage);
            this.SetParamSimple(map, prefix + "RestoreFace", this.RestoreFace);
        }
    }
}

