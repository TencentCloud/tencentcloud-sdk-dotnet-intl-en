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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSplitDocumentFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// File type.
        /// **Supported file types**: PDF, DOC, DOCX, XLS, XLSX, PPT, PPTX, MD, TXT, PNG, JPG, JPEG, CSV, HTML, EPUB.
        /// **Supported file sizes**: 
        /// - Max 500 MB for PDF.
        /// - Max 200 MB for DOC, DOCX, PPT, and PPTX .
        /// - Max 10 MB for MD, and TXT.
        /// - Max 20 MB for others.
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// File URL. It is recommended to store the file in Tencent Cloud as the URL where the file is stored in Tencent Cloud can ensure higher download speed and stability. External URL may affect the speed and stability. 
        /// Refer to: [Tencent Cloud COS Documentation](https://cloud.tencent.com/document/product/436/7749).
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// Filename. optional.
        /// **The file type suffix shall be included**. This field is required to be specified when the file name cannot be obtained from the passed-in "FileUrl".
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// The base64 value of the file. File size limit: the downloaded file shall not exceed 8MB after base64 encoding. File download time does not exceed 3 seconds. Supported image pixels: the length of a single side is between 20-10000px. Either FileUrl or FileBase64 of the file must be provided. If both are provided, only the FileUrl is used.
        /// </summary>
        [JsonProperty("FileBase64")]
        [System.Obsolete]
        public string FileBase64{ get; set; }

        /// <summary>
        /// The starting page number of the file. When type of the uploaded file is pdf, doc, ppt, or pptx, it specifies the starting page number for recognition, including the current value.
        /// </summary>
        [JsonProperty("FileStartPageNumber")]
        public long? FileStartPageNumber{ get; set; }

        /// <summary>
        /// The end page number of the file. When type of the uploaded file is pdf, doc, ppt, or pptx, it specifies the end page number for recognition, including the current value.
        /// </summary>
        [JsonProperty("FileEndPageNumber")]
        public long? FileEndPageNumber{ get; set; }

        /// <summary>
        /// Configuration message for document splitting task.
        /// </summary>
        [JsonProperty("Config")]
        public CreateSplitDocumentFlowConfig Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileBase64", this.FileBase64);
            this.SetParamSimple(map, prefix + "FileStartPageNumber", this.FileStartPageNumber);
            this.SetParamSimple(map, prefix + "FileEndPageNumber", this.FileEndPageNumber);
            this.SetParamObj(map, prefix + "Config.", this.Config);
        }
    }
}

