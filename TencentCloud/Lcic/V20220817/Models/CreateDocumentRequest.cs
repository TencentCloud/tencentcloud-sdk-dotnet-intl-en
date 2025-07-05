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

    public class CreateDocumentRequest : AbstractModel
    {
        
        /// <summary>
        /// LCIC SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// Document URL	
        /// </summary>
        [JsonProperty("DocumentUrl")]
        public string DocumentUrl{ get; set; }

        /// <summary>
        /// Document name	
        /// </summary>
        [JsonProperty("DocumentName")]
        public string DocumentName{ get; set; }

        /// <summary>
        /// Document owner ID	
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// Transcoding type. Valid values: `0`: No transcoding required (default); `1`: Documents that need to be transcoded: ppt, pptx, pdf, doc, docx; `2`: Videos that need to be transcoded: mp4, 3pg, mpeg, avi, flv, wmv, rm, h264, etc.; `2`: Audio that needs to be transcoded: mp3, wav, wma, aac, flac, opus
        /// </summary>
        [JsonProperty("TranscodeType")]
        public ulong? TranscodeType{ get; set; }

        /// <summary>
        /// Permission. Valid values: `0`: Private document (default); `1`: Public document
        /// </summary>
        [JsonProperty("Permission")]
        public ulong? Permission{ get; set; }

        /// <summary>
        /// Document extension
        /// </summary>
        [JsonProperty("DocumentType")]
        public string DocumentType{ get; set; }

        /// <summary>
        /// Document size, in bytes
        /// </summary>
        [JsonProperty("DocumentSize")]
        public ulong? DocumentSize{ get; set; }

        /// <summary>
        /// Whether or not to enable automatic processing for unsupported elements. Default: off. The automatically processed elements are as follows: 1. Ink: Remove unsupported ink (e.g. WPS Ink) 2. Auto Page Turn: Remove all auto page turn settings on the PPT and set it to mouse click to turn the page 3. Corrupted Audio/Video: Remove references to corrupted audio/video on the PPT
        /// </summary>
        [JsonProperty("AutoHandleUnsupportedElement")]
        public bool? AutoHandleUnsupportedElement{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "DocumentUrl", this.DocumentUrl);
            this.SetParamSimple(map, prefix + "DocumentName", this.DocumentName);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "TranscodeType", this.TranscodeType);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
            this.SetParamSimple(map, prefix + "DocumentType", this.DocumentType);
            this.SetParamSimple(map, prefix + "DocumentSize", this.DocumentSize);
            this.SetParamSimple(map, prefix + "AutoHandleUnsupportedElement", this.AutoHandleUnsupportedElement);
        }
    }
}

