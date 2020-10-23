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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectLiveFaceAccurateRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64-encoded image data, which cannot exceed 5 MB.
        /// The long side cannot exceed 4,000 px for images in JPG format or 2,000 px for images in other formats. 
        /// The recommended image aspect ratio is 3:4 (generally, the aspect ratio of images taken by mobile phones).
        /// The face must be greater than 100*100 px in size.
        /// Supported image formats are PNG, JPG, JPEG, and BMP. GIF is currently not supported.
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// Image URL. The image cannot exceed 5 MB in size after being base64-encoded.
        /// The long side cannot exceed 4,000 px for images in JPG format or 2,000 px for images in other formats.
        /// Either `Url` or `Image` of the image must be provided; if both are provided, only `Url` will be used. 
        /// The recommended image aspect ratio is 3:4 (generally, the aspect ratio of images taken by mobile phones).
        /// The face must be greater than 100*100 px in size.
        /// We recommend storing the image in Tencent Cloud, as a Tencent Cloud URL can guarantee higher download speed and stability. The download speed and stability of non-Tencent Cloud URLs may be low.
        /// Supported image formats are PNG, JPG, JPEG, and BMP. GIF is currently not supported.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Algorithm model version used for face recognition. Valid value: 3.0
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

