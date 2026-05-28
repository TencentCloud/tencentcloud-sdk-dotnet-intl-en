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

    public class SmartStructuralProRequest : AbstractModel
    {
        
        /// <summary>
        /// The URL of the image.
        /// Supported image formats: PNG, JPG, and JPEG. GIF is currently not supported.
        /// Supported image size: The downloaded image after Base64 encoding can be up to 7 MB. The download time of the image cannot exceed 3s.
        /// We recommend that you store the image in Tencent Cloud for higher download speed and stability.
        /// The download speed and stability of non-Tencent Cloud URLs may be low.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// The Base64-encoded value of the image.
        /// Supported image formats: PNG, JPG, and JPEG. GIF is currently not supported.
        /// Supported image size: The downloaded image after Base64 encoding can be up to 7 MB. The download time of the image cannot exceed 3s.
        /// Either `ImageUrl` or `ImageBase64` of the image must be provided. If both are provided, only `ImageUrl` is used.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// The number of the PDF page that needs to be recognized. Only one single PDF page can be recognized. This parameter is valid if the uploaded file is a PDF `. Default value: `1`.
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public ulong? PdfPageNumber{ get; set; }

        /// <summary>
        /// The names of the fields you want to return for the structured information recognition.
        /// For example, if you want to return only the recognition result of the "Name" and "Gender" fields, set this parameter as follows:
        /// ItemNames=["Name","Gender"]
        /// </summary>
        [JsonProperty("ItemNames")]
        public string[] ItemNames{ get; set; }

        /// <summary>
        /// Whether to enable recognition of all fields.
        /// </summary>
        [JsonProperty("ReturnFullText")]
        public bool? ReturnFullText{ get; set; }

        /// <summary>
        /// Configuration ID support: General 
        /// -- General scenarios; InvoiceEng 
        /// -- Ocean bill of lading, international invoice template; 
        /// -- Ocean shipment order template; WayBillEng 
        /// -- CustomsDeclaration
        /// -- WeightNote
        /// -- MedicalMeter
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// Enable recognition of coordinate values in full-text fields
        /// </summary>
        [JsonProperty("EnableCoord")]
        public bool? EnableCoord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamArraySimple(map, prefix + "ItemNames.", this.ItemNames);
            this.SetParamSimple(map, prefix + "ReturnFullText", this.ReturnFullText);
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "EnableCoord", this.EnableCoord);
        }
    }
}

