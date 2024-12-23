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

    public class DetectFaceSimilarityRequest : AbstractModel
    {
        
        /// <summary>
        /// A image base64 data.
        ///  - The size after base64 encoding cannot exceed 5M. 
        /// - The long side pixels of jpg format cannot exceed 4000, and the long side pixels of pictures in other formats cannot exceed 2000. The short side of images in all formats must be no less than 64 pixels. 
        /// - If the picture contains multiple faces, only the face with the highest confidence is selected. - Supports PNG, JPG, JPEG, BMP, but does not support GIF images.
        /// </summary>
        [JsonProperty("ImageA")]
        public string ImageA{ get; set; }

        /// <summary>
        /// B image base64 data.
        ///  - The size after base64 encoding cannot exceed 5M. 
        /// - The long side pixels of jpg format cannot exceed 4000, and the long side pixels of pictures in other formats cannot exceed 2000. The short side of images in all formats must be no less than 64 pixels. 
        /// - If the picture contains multiple faces, only the face with the highest confidence is selected. - Supports PNG, JPG, JPEG, BMP, but does not support GIF images.
        /// </summary>
        [JsonProperty("ImageB")]
        public string ImageB{ get; set; }

        /// <summary>
        /// A URL for the image. 
        /// - The size of the corresponding image after base64 encoding cannot exceed 5M. 
        /// - The long side pixels of jpg format cannot exceed 4000, and the long side pixels of pictures in other formats cannot exceed 2000. The short side of images in all formats must be no less than 64 pixels. 
        /// - A The URL and Image of the picture must be provided. If both are provided, only the Url will be used. 
        /// - Images stored in Tencent Cloud's Url can ensure higher download speed and stability. It is recommended that images be stored in Tencent Cloud. 
        /// - The URL speed and stability of non-Tencent cloud storage may be affected to a certain extent. 
        /// - If the picture contains multiple faces, only the face with the largest face area is selected. 
        /// - Supports PNG, JPG, JPEG, BMP, but does not support GIF images.
        /// </summary>
        [JsonProperty("UrlA")]
        public string UrlA{ get; set; }

        /// <summary>
        /// B The URL of the image. 
        /// - The size of the corresponding image after base64 encoding cannot exceed 5M. 
        /// - The long side pixels of jpg format cannot exceed 4000, and the long side pixels of pictures in other formats cannot exceed 2000. The short side of images in all formats must be no less than 64 pixels. 
        /// - B The URL and Image of the picture must be provided. If both are provided, only the Url will be used. 
        /// - Images stored in Tencent Cloud's Url can ensure higher download speed and stability. It is recommended that images be stored in Tencent Cloud. 
        /// - The URL speed and stability of non-Tencent cloud storage may be affected to a certain extent. 
        /// - If the picture contains multiple faces, only the face with the largest face area is selected. 
        /// - Supports PNG, JPG, JPEG, BMP, but does not support GIF images.
        /// </summary>
        [JsonProperty("UrlB")]
        public string UrlB{ get; set; }

        /// <summary>
        /// Image quality control. 
        /// - Value range: 0: No control; 1: Lower quality requirements, the image is very blurry, and the eyes, nose, and mouth cover at least one or more of them; 2: General quality requirements, the image is bright, Dark, blurry or generally blurred, eyebrows covered, cheeks covered, chin covered, at least three of them; 3: High quality requirements, the image may be brighter, darker, generally blurry, eyebrows blocked, cheeks blocked, chin blocked, one or two of them; 4: Very high quality requirements, all dimensions are the best or the most , there is a slight problem in one dimension; default is 0. 
        /// - If the image quality does not meet the requirements, the returned result will prompt that the image quality test does not meet the requirements.
        /// </summary>
        [JsonProperty("QualityControl")]
        public ulong? QualityControl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageA", this.ImageA);
            this.SetParamSimple(map, prefix + "ImageB", this.ImageB);
            this.SetParamSimple(map, prefix + "UrlA", this.UrlA);
            this.SetParamSimple(map, prefix + "UrlB", this.UrlB);
            this.SetParamSimple(map, prefix + "QualityControl", this.QualityControl);
        }
    }
}

