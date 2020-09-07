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

    public class AnalyzeDenseLandmarksRequest : AbstractModel
    {
        
        /// <summary>
        /// Detect mode. 0: detects all faces that appear; 1: detects the largest face. 
        /// Default value: 0. 
        /// Specific information of facial feature localization (facial keypoints) of up to 5 faces can be returned.
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// Base64-encoded image data, which cannot exceed 5 MB.  
        /// The long side cannot exceed 4,000 px for images in .jpg format or 2,000 px for images in other formats.
        /// .png, .jpg, .jpeg, and .bmp images are supported, while .gif images are not.
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// Image URL. The image cannot exceed 5 MB in size after being Base64-encoded.  
        /// The long side cannot exceed 4,000 px for images in .jpg format or 2,000 px for images in other formats.
        /// Either `Url` or `Image` must be provided; if both are provided, only `Url` will be used.  
        /// You are recommended to store the image in Tencent Cloud, as a Tencent Cloud URL can guarantee higher download speed and stability.  
        /// The download speed and stability of non-Tencent Cloud URLs may be low.  
        /// .png, .jpg, .jpeg, and .bmp images are supported, while .gif images are not.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Algorithm model version used by the Face Recognition service. You can enter only `3.0` for this API.
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }

        /// <summary>
        /// Whether to enable the support for rotated image recognition. 0: no; 1: yes. Default value: 0. When the face in the image is rotated and the image has no EXIF information, if this parameter is not enabled, the face in the image cannot be correctly detected and recognized. If you are sure that the input image contains EXIF information or the face in the image will not be rotated, do not enable this parameter, as the overall time consumption may increase by hundreds of milliseconds after it is enabled.
        /// </summary>
        [JsonProperty("NeedRotateDetection")]
        public long? NeedRotateDetection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "NeedRotateDetection", this.NeedRotateDetection);
        }
    }
}

