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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DocumentInfo : AbstractModel
    {
        
        /// <summary>
        /// The document ID. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DocumentId")]
        public string DocumentId{ get; set; }

        /// <summary>
        /// The document's original URL. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DocumentUrl")]
        public string DocumentUrl{ get; set; }

        /// <summary>
        /// The document title. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DocumentName")]
        public string DocumentName{ get; set; }

        /// <summary>
        /// The user ID of the document's owner. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// The application ID. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// The document access type. 0: Private; 1: Public. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Permission")]
        public ulong? Permission{ get; set; }

        /// <summary>
        /// The transcoding result. If the file is not transcoded, this parameter will be empty. If it is successfully transcoded, this parameter will be the URL of the transcoded file. If transcoding fails, this parameter will indicate the error code. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranscodeResult")]
        public string TranscodeResult{ get; set; }

        /// <summary>
        /// The transcoding type. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranscodeType")]
        public ulong? TranscodeType{ get; set; }

        /// <summary>
        /// The transcoding progress. Value range: 0-100. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranscodeProgress")]
        public ulong? TranscodeProgress{ get; set; }

        /// <summary>
        /// The transcoding status. 0: The file is not transcoded. 1: The file is being transcoded. 2: Transcoding failed. 3: Transcoding is successful. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranscodeState")]
        public ulong? TranscodeState{ get; set; }

        /// <summary>
        /// The error message for failed transcoding. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranscodeInfo")]
        public string TranscodeInfo{ get; set; }

        /// <summary>
        /// The document type. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DocumentType")]
        public string DocumentType{ get; set; }

        /// <summary>
        /// The document size (bytes). Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DocumentSize")]
        public ulong? DocumentSize{ get; set; }

        /// <summary>
        /// The time (Unix timestamp) when the document was last updated. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// The number of pages.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Pages")]
        public ulong? Pages{ get; set; }

        /// <summary>
        /// The width. This parameter is valid only if static document transcoding is used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// The height. This parameter is valid only if static document transcoding is used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// The thumbnail. Only transcoded courseware has thumbnails.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Cover")]
        public string Cover{ get; set; }

        /// <summary>
        /// Document preview address
        /// </summary>
        [JsonProperty("Preview")]
        public string Preview{ get; set; }

        /// <summary>
        /// Document resolution.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// Minimum resolution of a transcoded document, consistent with the parameters provided when the document is created.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinScaleResolution")]
        public string MinScaleResolution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DocumentId", this.DocumentId);
            this.SetParamSimple(map, prefix + "DocumentUrl", this.DocumentUrl);
            this.SetParamSimple(map, prefix + "DocumentName", this.DocumentName);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
            this.SetParamSimple(map, prefix + "TranscodeResult", this.TranscodeResult);
            this.SetParamSimple(map, prefix + "TranscodeType", this.TranscodeType);
            this.SetParamSimple(map, prefix + "TranscodeProgress", this.TranscodeProgress);
            this.SetParamSimple(map, prefix + "TranscodeState", this.TranscodeState);
            this.SetParamSimple(map, prefix + "TranscodeInfo", this.TranscodeInfo);
            this.SetParamSimple(map, prefix + "DocumentType", this.DocumentType);
            this.SetParamSimple(map, prefix + "DocumentSize", this.DocumentSize);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Pages", this.Pages);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Cover", this.Cover);
            this.SetParamSimple(map, prefix + "Preview", this.Preview);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "MinScaleResolution", this.MinScaleResolution);
        }
    }
}

