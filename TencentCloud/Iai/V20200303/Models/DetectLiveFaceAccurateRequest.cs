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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectLiveFaceAccurateRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the base64 code of the image.
        /// -base64-Encoded size cannot exceed 5M.
        /// -The long side pixel of a jpg image must not exceed 4000. the long side pixel of another format image cannot exceed 2000. 
        /// -Specifies the image aspect ratio should be close to 3:4. mobile phone shooting proportion is best.
        /// -Specifies the human face dimension is greater than 100X100 pixels.
        /// -Supported image formats include PNG, JPG, JPEG, and BMP. GIF is not supported.
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// Specifies the Url of the image.
        /// -Specifies the maximum size of the corresponding image after base64 encoding is 5M.
        /// -The long side pixel of a jpg image must not exceed 4000. the long side pixel of another format image must not exceed 2000.
        /// -Url or Image must be provided. if both are provided, only use Url. 
        /// -Specifies the image aspect ratio should be close to 3:4. mobile phone shooting proportion is best.
        /// -Specifies the human face dimension is greater than 100X100 pixels.
        /// -Image storage Url on tencent cloud guarantees higher download speed and stability. it is recommended to store images on tencent cloud. non-tencent cloud storage urls may be impacted in speed and stability.
        /// -Supported image formats include PNG, JPG, JPEG, and BMP. GIF is not supported.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Algorithm model version used for face recognition. Valid value: `3.0`.
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
        }
    }
}

