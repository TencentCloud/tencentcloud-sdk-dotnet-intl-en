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
        /// The Base64 value of an image/PDF. the image must be no more than 10M after encoding, with a resolution of 600*800 or higher recommended. supported formats include PNG, JPG, JPEG, BMP, and PDF. either ImageUrl or ImageBase64 must be provided. if both are provided, only ImageUrl will be used.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// URL address of image. (This field is not supported outside Chinese mainland)
        /// The image cannot exceed 7 MB after being Base64-encoded. A resolution above 600x800 is recommended. PNG, JPG, JPEG, and BMP formats are supported.
        /// We recommend you store the image in Tencent Cloud, as a Tencent Cloud URL can guarantee higher download speed and stability. The download speed and stability of non-Tencent Cloud URLs may be low.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Whether to enable original image slicing detection. once enabled, it improves recognition accuracy in scenarios where "the overall image area is large but the single character area is small" (for example: exam paper). default: disabled. note: only supported when ConfigID is configured as OCR.
        /// </summary>
        [JsonProperty("EnableDetectSplit")]
        public bool? EnableDetectSplit{ get; set; }

        /// <summary>
        /// Whether to enable PDF recognition. Default value: `false`. If you enable this feature, both images and PDF files can be recognized.
        /// </summary>
        [JsonProperty("IsPdf")]
        public bool? IsPdf{ get; set; }

        /// <summary>
        /// Number of a PDF page that needs to be recognized. Currently, only one single page can be recognized. This parameter takes effect only if a PDF file is uploaded and `IsPdf` is set to `true`. Default value: `1`
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public ulong? PdfPageNumber{ get; set; }

        /// <summary>
        /// Text detection switch, default is true. set to false to directly perform single-line text recognition, suitable for image scenarios containing only forward single-line text.
        /// </summary>
        [JsonProperty("EnableDetectText")]
        public bool? EnableDetectText{ get; set; }

        /// <summary>
        /// Configuration ID supports: OCR - general scenario MulOCR - multilingual scenario. default value is OCR.
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

