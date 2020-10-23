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

    public class VerifyFaceRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the person to be verified. For more information on `PersonId`, please see the group management APIs.
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// Base64-encoded image data, which cannot exceed 5 MB.
        /// The long side cannot exceed 4,000 px for images in .jpg format or 2,000 px for images in other formats.
        /// If there are multiple faces in the image, only the face with the largest size will be selected.
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
        /// If there are multiple faces in the image, only the face with the largest size will be selected.
        /// .png, .jpg, .jpeg, and .bmp images are supported, while .gif images are not.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Image quality control. 
        /// 0: no control. 
        /// 1: low quality requirement. The image has one or more of the following problems: extreme blurriness, covered eyes, covered nose, and covered mouth. 
        /// 2: average quality requirement. The image has at least three of following problems: extreme brightness, extreme dimness, blurriness or average blurriness, covered eyebrows, covered cheeks, and covered chin. 
        /// 3: high quality requirement. The image has one to two of following problems: extreme brightness, extreme dimness, average blurriness, covered eyebrows, covered cheeks, and covered chin. 
        /// 4: very high quality requirement. The image is optimal in all dimensions or only has a slight problem in one dimension. 
        /// Default value: 0. 
        /// If the image quality does not meet the requirement, the returned result will prompt that the detected image quality is unsatisfactory.
        /// </summary>
        [JsonProperty("QualityControl")]
        public ulong? QualityControl{ get; set; }

        /// <summary>
        /// Whether to enable the support for rotated image recognition. 0: no; 1: yes. Default value: 0. When the face in the image is rotated and the image has no EXIF information, if this parameter is not enabled, the face in the image cannot be correctly detected and recognized. If you are sure that the input image contains EXIF information or the face in the image will not be rotated, do not enable this parameter, as the overall time consumption may increase by hundreds of milliseconds after it is enabled.
        /// </summary>
        [JsonProperty("NeedRotateDetection")]
        public ulong? NeedRotateDetection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "QualityControl", this.QualityControl);
            this.SetParamSimple(map, prefix + "NeedRotateDetection", this.NeedRotateDetection);
        }
    }
}

