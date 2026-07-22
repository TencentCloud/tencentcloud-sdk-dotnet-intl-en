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

namespace TencentCloud.Es.V20250101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Document : AbstractModel
    {
        
        /// <summary>
        /// Supported file types: PDF, DOC, DOCX, PPT, PPTX, MD, TXT, XLS.
        /// XLSX,CSV,PNG,JPG,JPEG,BMP,GIF,WEBP,HEIC,EPS,ICNS,
        /// IM,PCX,PPM,TIFF,XBM,HEIF,JP2
        /// 
        /// Supported file size for document parsing:
        /// -PDF, DOC, DOCX, PPT, PPTX support 100M.
        /// -MD, TXT, XLS, XLSX, CSV support 10M.
        /// -Other supports 20M
        /// 
        /// Supported file size for text slicing:
        /// -Maximum PDF size: 300 MB
        /// -D0CX, D0C, PPT, PPTX maximum 200M
        /// -Maximum 10M for TXT, MD
        /// -Another maximum of 20M
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// File storage on Tencent Cloud's URL ensures higher download speed and stability by using Tencent Cloud COS file address.
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// base64 value of the file, carrying the MineType prefix information. The encoded file is no more than 10M.
        /// Supported file size: The downloaded file is no more than 8M after Base64 encoding. File download time is not more than 3 seconds.
        /// Supported image pixel: Unilateral between 20-10000px.
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// File name, used when uploading with base64.
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// Starting page number of the document
        /// </summary>
        [JsonProperty("FileStartPageNumber")]
        public long? FileStartPageNumber{ get; set; }

        /// <summary>
        /// End page number of the document
        /// </summary>
        [JsonProperty("FileEndPageNumber")]
        public long? FileEndPageNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileStartPageNumber", this.FileStartPageNumber);
            this.SetParamSimple(map, prefix + "FileEndPageNumber", this.FileEndPageNumber);
        }
    }
}

