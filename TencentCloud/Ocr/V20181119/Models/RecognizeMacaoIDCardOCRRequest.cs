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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeMacaoIDCardOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// The URL address of the image. 
        /// Supported image formats: PNG, JPG, JPEG. Not support GIF yet.
        /// Supported image size: The downloaded image should not exceed 7M. The image download takes no more than 3 seconds.Storing images in Tencent Cloud URLs can ensure higher download speed and stability. It is recommended that images be stored in Tencent Cloud. The URL speed and stability of non-Tencent cloud storage may be affected to a certain extent.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Base64 value of the image.Supported image formats: PNG, JPG, JPEG. Not support GIF yet.
        /// Supported image size: The downloaded image should not exceed 7M after Base64 encoding. The image download takes no more than 3 seconds.
        /// One of ImageUrl and ImageBase64 of the image must be provided. If both are provided, only ImageUrl will be used.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// The following optional fields are of string type and are empty by default: 
        /// RetImage: whether to return the processed image (base64 encrypted string); the value and meaning of RetImage are as follows: 1.preprocess returns the preprocessed image data 2.portrait Return portrait image data 3."" Do not return image data SDK setting method reference: Config = Json.stringify({"RetImage":"preprocess"}) API 3.0 Explorer setting method reference: Config = {"RetImage":"portrait" }
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "Config", this.Config);
        }
    }
}

