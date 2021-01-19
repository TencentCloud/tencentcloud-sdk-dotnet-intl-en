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

    public class BankCardOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64-encoded value of image.
        /// Supported image formats: PNG, JPG, JPEG. GIF is currently not supported.
        /// Supported image size: the downloaded image cannot exceed 7 MB in size after being Base64-encoded. The download time of the image cannot exceed 3 seconds.
        /// Either the `ImageUrl` or `ImageBase64` of the image must be provided; if both are provided, only `ImageUrl` will be used.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// URL address of image. (This field is not supported outside Chinese mainland)
        /// Supported image formats: PNG, JPG, JPEG. GIF is currently not supported.
        /// Supported image size: the downloaded image cannot exceed 7 MB after being Base64-encoded. The download time of the image cannot exceed 3 seconds.
        /// We recommend you store the image in Tencent Cloud, as a Tencent Cloud URL can guarantee higher download speed and stability.
        /// The download speed and stability of non-Tencent Cloud URLs may be low.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RetBorderCutImage")]
        public bool? RetBorderCutImage{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RetCardNoImage")]
        public bool? RetCardNoImage{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EnableCopyCheck")]
        public bool? EnableCopyCheck{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EnableReshootCheck")]
        public bool? EnableReshootCheck{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EnableBorderCheck")]
        public bool? EnableBorderCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "RetBorderCutImage", this.RetBorderCutImage);
            this.SetParamSimple(map, prefix + "RetCardNoImage", this.RetCardNoImage);
            this.SetParamSimple(map, prefix + "EnableCopyCheck", this.EnableCopyCheck);
            this.SetParamSimple(map, prefix + "EnableReshootCheck", this.EnableReshootCheck);
            this.SetParamSimple(map, prefix + "EnableBorderCheck", this.EnableBorderCheck);
        }
    }
}

