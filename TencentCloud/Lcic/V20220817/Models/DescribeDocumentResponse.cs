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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDocumentResponse : AbstractModel
    {
        
        /// <summary>
        /// The document ID.
        /// </summary>
        [JsonProperty("DocumentId")]
        public string DocumentId{ get; set; }

        /// <summary>
        /// The document’s original URL.
        /// </summary>
        [JsonProperty("DocumentUrl")]
        public string DocumentUrl{ get; set; }

        /// <summary>
        /// The document title.
        /// </summary>
        [JsonProperty("DocumentName")]
        public string DocumentName{ get; set; }

        /// <summary>
        /// The user ID of the document’s owner.
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// The application ID.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// The document access type.
        /// </summary>
        [JsonProperty("Permission")]
        public ulong? Permission{ get; set; }

        /// <summary>
        /// The transcoding result. If the file is not transcoded, this parameter will be empty. If it is successfully transcoded, this parameter will be the URL of the transcoded file. If transcoding fails, this parameter will indicate the error code.
        /// </summary>
        [JsonProperty("TranscodeResult")]
        public string TranscodeResult{ get; set; }

        /// <summary>
        /// The transcoding type.
        /// </summary>
        [JsonProperty("TranscodeType")]
        public ulong? TranscodeType{ get; set; }

        /// <summary>
        /// The transcoding progress. Value range: 0-100.
        /// </summary>
        [JsonProperty("TranscodeProgress")]
        public ulong? TranscodeProgress{ get; set; }

        /// <summary>
        /// The transcoding status. 0: The file is not transcoded. 1: The file is being transcoded. 2: Transcoding failed. 3: Transcoding is successful.
        /// </summary>
        [JsonProperty("TranscodeState")]
        public ulong? TranscodeState{ get; set; }

        /// <summary>
        /// The error message for failed transcoding.
        /// </summary>
        [JsonProperty("TranscodeInfo")]
        public string TranscodeInfo{ get; set; }

        /// <summary>
        /// The document type.
        /// </summary>
        [JsonProperty("DocumentType")]
        public string DocumentType{ get; set; }

        /// <summary>
        /// The document size (bytes).
        /// </summary>
        [JsonProperty("DocumentSize")]
        public ulong? DocumentSize{ get; set; }

        /// <summary>
        /// The time (Unix timestamp) when the document was last updated.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

