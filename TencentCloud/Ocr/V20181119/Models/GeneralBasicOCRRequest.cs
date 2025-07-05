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

    public class GeneralBasicOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64-encoded value of image/PDF.
        /// The image/PDF cannot exceed 7 MB after being Base64-encoded. A resolution above 600x800 is recommended. PNG, JPG, JPEG, BMP, and PDF formats are supported.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// URL address of image/PDF. (This field is not supported outside Chinese mainland)
        /// The image/PDF cannot exceed 7 MB after being Base64-encoded. A resolution above 600x800 is recommended. PNG, JPG, JPEG, BMP, and PDF formats are supported.
        /// We recommend you store the image in Tencent Cloud, as a Tencent Cloud URL can guarantee higher download speed and stability. The download speed and stability of non-Tencent Cloud URLs may be low.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Reserved field.
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// Language to recognize
        /// The language can be automatically recognized or manually specified. Chinese-English mix (`zh`) is selected by default. Mixed characters in English and each supported language can be recognized together.
        /// Valid values:
        /// `zh`: Chinese-English mix
        /// `zh_rare`: supports letters, digits, rare Chinese characters, Traditional Chinese characters, special characters, etc.
        /// `auto`
        /// `mix`: language mix
        /// `jap`: Japanese
        /// `kor`: Korean
        /// `spa`: Spanish
        /// `fre`: French
        /// `ger`: German
        /// `por`: Portuguese
        /// `vie`: Vietnamese
        /// `may`: Malay
        /// `rus`: Russian
        /// `ita`: Italian
        /// `hol`: Dutch
        /// `swe`: Swedish
        /// `fin`: Finnish
        /// `dan`: Danish
        /// `nor`: Norwegian
        /// `hun`: Hungarian
        /// `tha`: Thai
        /// `hi`: Hindi
        /// `ara`: Arabic
        /// </summary>
        [JsonProperty("LanguageType")]
        public string LanguageType{ get; set; }

        /// <summary>
        /// Whether to enable PDF recognition. Default value: false. After this feature is enabled, both images and PDF files can be recognized at the same time.
        /// </summary>
        [JsonProperty("IsPdf")]
        public bool? IsPdf{ get; set; }

        /// <summary>
        /// Page number of the PDF page that needs to be recognized. Only one single PDF page can be recognized. This parameter is valid if the uploaded file is a PDF and the value of the `IsPdf` parameter is `true`. Default value: 1.
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public ulong? PdfPageNumber{ get; set; }

        /// <summary>
        /// Whether to return the character information. Default value: `false`
        /// </summary>
        [JsonProperty("IsWords")]
        public bool? IsWords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "LanguageType", this.LanguageType);
            this.SetParamSimple(map, prefix + "IsPdf", this.IsPdf);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamSimple(map, prefix + "IsWords", this.IsWords);
        }
    }
}

