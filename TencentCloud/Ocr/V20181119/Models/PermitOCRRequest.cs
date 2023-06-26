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

    public class PermitOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// The Base64-encoded value of the image.
        /// Supported image formats: PNG, JPG, and JPEG. GIF is currently not supported.
        /// Supported image size: The downloaded image after Base64 encoding can be up to 7 MB. The download time of the image cannot exceed 3s.
        /// Either `ImageUrl` or `ImageBase64` of the image must be provided. If both are provided, only `ImageUrl` is used.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// The URL of the image.
        /// Supported image formats: PNG, JPG, and JPEG. GIF is currently not supported.
        /// Supported image size: The downloaded image after Base64 encoding can be up to 7 MB. The download time of the image cannot exceed 3s.
        /// We recommend that you store the image in Tencent Cloud for higher download speed and stability.
        /// The download speed and stability of non-Tencent Cloud URLs may be low.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
        }
    }
}

