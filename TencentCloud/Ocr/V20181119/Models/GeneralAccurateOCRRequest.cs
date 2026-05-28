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

    public class GeneralAccurateOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>The Base64 value of the image/PDF. The image size after Base64 encoding must be no more than 10M, with a resolution of 600*800 or higher recommended. PNG, JPG, JPEG, BMP, and PDF formats are supported. Either ImageUrl or ImageBase64 of the image must be provided. If both are provided, only ImageUrl will be used.</p>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// URL address of image. 
        /// The image cannot exceed 10 MB after being Base64-encoded. A resolution above 600x800 is recommended. PNG, JPG, JPEG, and BMP formats are supported.
        /// We recommend you store the image in Tencent Cloud, as a Tencent Cloud URL can guarantee higher download speed and stability. The download speed and stability of non-Tencent Cloud URLs may be low.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>Whether to enable original image slicing detection. Once enabled, it improves recognition accuracy in scenarios where "the overall image area is large but the single character occupies a small proportion" (for example: exam paper). Default: disabled. Note: Only supported when ConfigID is configured as OCR.</p>
        /// </summary>
        [JsonProperty("EnableDetectSplit")]
        public bool? EnableDetectSplit{ get; set; }

        /// <summary>
        /// <p>Whether PDF recognition is enabled. The default value is false. Once enabled, it can simultaneously support image and PDF recognition.</p>
        /// </summary>
        [JsonProperty("IsPdf")]
        public bool? IsPdf{ get; set; }

        /// <summary>
        /// <p>The corresponding page number of the PDF page to be recognized. Only single page recognition is supported. Valid at that time when the upload file is a PDF and the IsPdf parameter value is true. The default value is 1.</p>
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public ulong? PdfPageNumber{ get; set; }

        /// <summary>
        /// <p>Text Detection Switch, true by default. Set to false to directly perform single-line recognition, suitable for image scenarios containing only forward single-line text.</p>
        /// </summary>
        [JsonProperty("EnableDetectText")]
        public bool? EnableDetectText{ get; set; }

        /// <summary>
        /// <p>Configuration ID support: OCR -- common scenarios MulOCR -- multilingual scenario. Default value: OCR.</p>
        /// </summary>
        [JsonProperty("ConfigID")]
        public string ConfigID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "EnableDetectSplit", this.EnableDetectSplit);
            this.SetParamSimple(map, prefix + "IsPdf", this.IsPdf);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamSimple(map, prefix + "EnableDetectText", this.EnableDetectText);
            this.SetParamSimple(map, prefix + "ConfigID", this.ConfigID);
        }
    }
}

