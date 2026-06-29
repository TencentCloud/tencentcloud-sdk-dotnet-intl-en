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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyCardVerificationExternalRequest : AbstractModel
    {
        
        /// <summary>
        /// Country/Region of the document. For the full list of supported countries/regions, refer to the API description.
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// Document type. Supported values: ID_CARD, PASSPORT, DRIVING_LICENSE, RESIDENCE_PERMIT (only supported in certain countries/regions, including Australia, Canada, Germany, New Zealand, Nigeria, Singapore).
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType{ get; set; }

        /// <summary>
        /// Base64-encoded image of the document front.
        /// Supported image formats: PNG, JPG/JPEG (GIF not supported).
        /// Supported image size: The downloaded image after Base64 encoding must not exceed 2 MB. Image download time must not exceed 5 seconds.
        /// Supported image resolution: Between 256*256 and 4096*4096 pixels.
        /// Note: You must provide either ImageUrlFront or ImageBase64Front. If both are provided, only ImageUrlFront is used.
        /// </summary>
        [JsonProperty("ImageBase64Front")]
        public string ImageBase64Front{ get; set; }

        /// <summary>
        /// The Base64 value of the reverse side of the document. Supported image formats: PNG, JPG/JPEG. 
        /// Supported image size: the downloaded image after Base64 encoding must be no more than 2M. Image download time must be no more than 5 seconds. 
        /// Supported image resolution: between 256 \* 256 and 4096 \* 4096. For some documents, either ImageUrlBack or ImageBase64Back must be provided. If both are provided, only ImageUrlBack is used.
        /// </summary>
        [JsonProperty("ImageBase64Back")]
        public string ImageBase64Back{ get; set; }

        /// <summary>
        /// URL of the document front image.
        /// Supported image formats: PNG, JPG/JPEG (GIF not supported).
        /// Supported image size: The downloaded image after Base64 encoding must not exceed 2 MB. Image download time must not exceed 5 seconds.
        /// Supported image resolution: Between 256*256 and 4096*4096 pixels.
        /// Note: You must provide either ImageUrlFront or ImageBase64Front. If both are provided, only ImageUrlFront is used.
        /// </summary>
        [JsonProperty("ImageUrlFront")]
        public string ImageUrlFront{ get; set; }

        /// <summary>
        /// URL of the document back image.
        /// Supported image formats: PNG, JPG/JPEG (GIF not supported).
        /// Supported image size: The downloaded image after Base64 encoding must not exceed 2 MB. Image download time must not exceed 5 seconds.
        /// Supported image resolution: Between 256*256 and 4096*4096 pixels.
        /// Note: For some documents, you must provide either ImageUrlBack or ImageBase64Back. If both are provided, only ImageUrlBack is used.
        /// </summary>
        [JsonProperty("ImageUrlBack")]
        public string ImageUrlBack{ get; set; }

        /// <summary>
        /// Whether to crop and return the face image from the document. Default: false.
        /// If set to true, the image constraints are:
        /// - Size after Base64 encoding must not exceed 5 MB.
        /// - Maximum pixel width/height: 4000 for JPG, 2000 for other formats.
        /// - Minimum pixel width/height: 64.
        /// - Supported formats: PNG, JPG, JPEG, BMP (GIF not supported).
        /// </summary>
        [JsonProperty("ReturnHeadImage")]
        public bool? ReturnHeadImage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamSimple(map, prefix + "ImageBase64Front", this.ImageBase64Front);
            this.SetParamSimple(map, prefix + "ImageBase64Back", this.ImageBase64Back);
            this.SetParamSimple(map, prefix + "ImageUrlFront", this.ImageUrlFront);
            this.SetParamSimple(map, prefix + "ImageUrlBack", this.ImageUrlBack);
            this.SetParamSimple(map, prefix + "ReturnHeadImage", this.ReturnHeadImage);
        }
    }
}

