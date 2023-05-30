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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TranscodeTaskResult : AbstractModel
    {
        
        /// <summary>
        /// Transcoding result URL.
        /// </summary>
        [JsonProperty("ResultUrl")]
        public string ResultUrl{ get; set; }

        /// <summary>
        /// Target resolution.
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// Title (usually the document name).
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// Number of transcoded pages.
        /// </summary>
        [JsonProperty("Pages")]
        public long? Pages{ get; set; }

        /// <summary>
        /// URL prefix of the thumbnail. If the URL prefix is `http://example.com/g0jb42ps49vtebjshilb/`, the thumbnail URL for the first page of the dynamically transcoded PowerPoint file is
        /// `http://example.com/g0jb42ps49vtebjshilb/1.jpg`, and so on.
        /// 
        /// If the document transcoding request carries the ThumbnailResolution parameter and the transcoding type is dynamic transcoding, this parameter is not null. In other cases, this parameter is null.
        /// </summary>
        [JsonProperty("ThumbnailUrl")]
        public string ThumbnailUrl{ get; set; }

        /// <summary>
        /// Resolution of the thumbnail generated for dynamic transcoding
        /// </summary>
        [JsonProperty("ThumbnailResolution")]
        public string ThumbnailResolution{ get; set; }

        /// <summary>
        /// URL for downloading the transcoded and compressed file. If `CompressFileType` carried in the document transcoding request is null or is not a supported compression format, this parameter is null.
        /// </summary>
        [JsonProperty("CompressFileUrl")]
        public string CompressFileUrl{ get; set; }

        /// <summary>
        /// Task execution error code.
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// Task execution error message.
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResultUrl", this.ResultUrl);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Pages", this.Pages);
            this.SetParamSimple(map, prefix + "ThumbnailUrl", this.ThumbnailUrl);
            this.SetParamSimple(map, prefix + "ThumbnailResolution", this.ThumbnailResolution);
            this.SetParamSimple(map, prefix + "CompressFileUrl", this.CompressFileUrl);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
        }
    }
}

