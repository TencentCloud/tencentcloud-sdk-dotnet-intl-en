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

    public class GeneralBasicOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// Information of recognized text, including the text line content, confidence, text line coordinates, and text line coordinates after rotation correction. For more information, please click the link on the left.
        /// </summary>
        [JsonProperty("TextDetections")]
        public TextDetection[] TextDetections{ get; set; }

        /// <summary>
        /// Detected language. For more information on the supported languages, please see the description of the `LanguageType` input parameter.
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// Image rotation angle in degrees. 0° indicates horizontal text, a positive value indicates clockwise rotation, and a negative value indicates anticlockwise rotation. For more information, please see <a href="https://intl.cloud.tencent.com/document/product/866/45139?from_cn_redirect=1">How to Correct Tilted Text</a>.
        /// </summary>
        [JsonProperty("Angel")]
        public float? Angel{ get; set; }

        /// <summary>
        /// Total number of PDF pages to be returned if the image is a PDF. Default value: 0.
        /// </summary>
        [JsonProperty("PdfPageSize")]
        public long? PdfPageSize{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TextDetections.", this.TextDetections);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "Angel", this.Angel);
            this.SetParamSimple(map, prefix + "PdfPageSize", this.PdfPageSize);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

