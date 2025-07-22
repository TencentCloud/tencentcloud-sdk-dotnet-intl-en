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

    public class ExtractDocMultiRequest : AbstractModel
    {
        
        /// <summary>
        /// The Url address of the image. supported image formats: PNG, JPG, JPEG, WORD, EXCEL. GIF format is not currently supported. supported image size: no more than 10M after Base64 encoding. image download time should not exceed 3 seconds. supported image pixels: between 20-10000px. images stored in tencent cloud's Url ensure higher download speed and stability. it is recommended to store images in tencent cloud. the speed and stability of non-tencent cloud storage urls may be impacted.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// The Base64 value of the image. supported image formats: PNG, JPG, JPEG, WORD, EXCEL. GIF format is not currently supported. supported image size: no more than 10M after encoding the downloaded image with Base64. image download time: no more than 3 seconds. supported image pixels: between 20-10000px. either ImageUrl or ImageBase64 must be provided. if both are provided, only use ImageUrl.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// Specifies the page number of the PDF to be recognized. only single page recognition is supported. valid when uploading a PDF file with the IsPdf parameter set to true. default value is the first 3 pages.
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public ulong? PdfPageNumber{ get; set; }

        /// <summary>
        /// Specifies the field names to be returned by the customized structuring feature. for example, if the customer wants to add the recognition result of two fields, name and gender, manually input ItemNames=["name","gender"].
        /// </summary>
        [JsonProperty("ItemNames")]
        public string[] ItemNames{ get; set; }

        /// <summary>
        /// true: only custom field.
        /// False: default value field + custom field.
        /// Default true.
        /// </summary>
        [JsonProperty("ItemNamesShowMode")]
        public bool? ItemNamesShowMode{ get; set; }

        /// <summary>
        /// Whether the full-text field recognition is enabled.
        /// </summary>
        [JsonProperty("ReturnFullText")]
        public bool? ReturnFullText{ get; set; }

        /// <summary>
        /// Configuration ID support: 
        /// -- General
        /// -- InvoiceEng
        /// -- WayBillEng
        /// -- CustomsDeclaration
        /// -- WeightNote
        /// -- MedicalMeter
        /// -- BillOfLading
        /// -- EntrustmentBook
        /// -- Statement
        /// -- BookingConfirmation
        /// -- AirWayBill
        /// -- Table
        /// -- SteelLabel
        /// -- CarInsurance
        /// -- MultiRealEstateCertificate
        /// -- MultiRealEstateMaterial
        /// -- HongKongUtilityBill
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// Whether the full-text field coordinate value recognition is enabled.
        /// </summary>
        [JsonProperty("EnableCoord")]
        public bool? EnableCoord{ get; set; }

        /// <summary>
        /// Whether parent-child key recognition is enabled. the option is selected by default.
        /// </summary>
        [JsonProperty("OutputParentKey")]
        public bool? OutputParentKey{ get; set; }

        /// <summary>
        /// Single attribute configuration of a template.
        /// </summary>
        [JsonProperty("ConfigAdvanced")]
        public ConfigAdvanced ConfigAdvanced{ get; set; }

        /// <summary>
        /// When cn, the added key is chinese.  
        /// When set to en, the added key is english.
        /// </summary>
        [JsonProperty("OutputLanguage")]
        public string OutputLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamArraySimple(map, prefix + "ItemNames.", this.ItemNames);
            this.SetParamSimple(map, prefix + "ItemNamesShowMode", this.ItemNamesShowMode);
            this.SetParamSimple(map, prefix + "ReturnFullText", this.ReturnFullText);
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "EnableCoord", this.EnableCoord);
            this.SetParamSimple(map, prefix + "OutputParentKey", this.OutputParentKey);
            this.SetParamObj(map, prefix + "ConfigAdvanced.", this.ConfigAdvanced);
            this.SetParamSimple(map, prefix + "OutputLanguage", this.OutputLanguage);
        }
    }
}

