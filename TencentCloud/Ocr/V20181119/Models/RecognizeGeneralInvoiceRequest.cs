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

    public class RecognizeGeneralInvoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// The Base64-encoded value of the image.
        /// Supported image formats: PNG, JPG, JPEG, and PDF. GIF is currently not supported.
        /// Supported image size: The downloaded image after Base64 encoding can be up to 7 MB. The download time of the image cannot exceed 3s.
        /// Supported image pixels: 20 to 10,000
        /// Either `ImageUrl` or `ImageBase64` of the image must be provided. If both are provided, only `ImageUrl` is used.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// The URL of the image.
        /// Supported image formats: PNG, JPG, JPEG, and PDF. GIF is currently not supported.
        /// Supported image size: The downloaded image after Base64 encoding can be up to 7 MB. The download time of the image cannot exceed 3s.
        /// Supported image pixels: 20 to 10,000
        /// We recommend that you store the image in Tencent Cloud for higher download speed and stability.
        /// The download speed and stability of non-Tencent Cloud URLs may be low.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// The list of the types of invoices to be recognized. If this parameter is left empty, all types of invoices are recognized.
        /// 0: Taxi receipt
        /// 1: Quota invoice
        /// 2: Train ticket
        /// 3: VAT invoice
        /// 5: Itinerary/Receipt of e-ticket for air transport
        /// 8: General machine-printed invoice
        /// 9: Bus ticket
        /// 10: Ship ticket
        /// 11: VAT invoice (roll)
        /// 12: Car sales inovice
        /// 13: Toll receipt
        /// 15: Non-tax revenue invoice
        /// 16: Fully digitalized electronic invoice
        /// -1: Other
        /// 
        /// By default, this parameter is left empty, which means to recognize all types of invoices.
        /// When a single type is passed in, the image is recognized based on this type.
        /// You can only specify a singe type or all types, but not some types.
        /// </summary>
        [JsonProperty("Types")]
        public long?[] Types{ get; set; }

        /// <summary>
        /// Whether to enable recognition of other invoices. If you enable this feature, other invoices can be recognized. Default value: `true`.	
        /// </summary>
        [JsonProperty("EnableOther")]
        public bool? EnableOther{ get; set; }

        /// <summary>
        /// Whether to enable PDF recognition. If you enable this feature, both images and PDF files can be recognized. Default value: `true`.
        /// </summary>
        [JsonProperty("EnablePdf")]
        public bool? EnablePdf{ get; set; }

        /// <summary>
        /// The number of the PDF page that needs to be recognized. Only one single PDF page can be recognized. This parameter is valid if the uploaded file is a PDF and the value of `EnablePdf` is `true`. Default value: 1.
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public long? PdfPageNumber{ get; set; }

        /// <summary>
        /// Whether to enable multi-page PDF recognition. If you enable this feature, multiple pages of a PDF file can be recognized, and the recognition results of a maximum of the first 30 pages can be returned. After you enable this feature, input parameters `EnablePdf` and `PdfPageNumber` are invalid. Default value: `false`.
        /// </summary>
        [JsonProperty("EnableMultiplePage")]
        public bool? EnableMultiplePage{ get; set; }

        /// <summary>
        /// Whether to return the Base64-encoded value of the cropped image. Default value: `false`.
        /// </summary>
        [JsonProperty("EnableCutImage")]
        public bool? EnableCutImage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamArraySimple(map, prefix + "Types.", this.Types);
            this.SetParamSimple(map, prefix + "EnableOther", this.EnableOther);
            this.SetParamSimple(map, prefix + "EnablePdf", this.EnablePdf);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamSimple(map, prefix + "EnableMultiplePage", this.EnableMultiplePage);
            this.SetParamSimple(map, prefix + "EnableCutImage", this.EnableCutImage);
        }
    }
}

