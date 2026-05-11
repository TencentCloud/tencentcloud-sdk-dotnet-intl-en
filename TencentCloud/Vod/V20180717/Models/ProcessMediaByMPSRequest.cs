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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProcessMediaByMPSRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Media file ID, the globally unique ID of the file in VOD, is assigned by the VOD backend after successful upload. You can get this field in <a href="/document/product/266/7830?from_cn_redirect=1">video upload completion event notification</a> or <a href="https://console.cloud.tencent.com/vod/media">VOD console</a>.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p><b>VOD <a href="/document/product/266/14574?from_cn_redirect=1">application</a> ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Optional parameter. This parameter is used for passing through to the media processing service (MPS) to trigger MPS video processing tasks from VOD. For details on different types of video processing parameters, refer to <a href="https://www.tencentcloud.com/document/product/266/131209?from_cn_redirect=1">Using MPS Media AI Capability</a>. You can create custom templates via the <a href="https://www.tencentcloud.com/document/product/266/122580?from_cn_redirect=1">CreateMPSTemplate</a> API.</p>
        /// </summary>
        [JsonProperty("MPSProcessMediaParams")]
        public string MPSProcessMediaParams{ get; set; }

        /// <summary>
        /// <p>Parameters for the video content analysis task. Valid when MPSProcessMediaParams is empty.</p>
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public MPSAiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// <p>Parameters for the smart subtitle task of type kind. Valid when MPSProcessMediaParams is empty.</p>
        /// </summary>
        [JsonProperty("SmartSubtitlesTask")]
        public MPSSmartSubtitlesTaskInput SmartSubtitlesTask{ get; set; }

        /// <summary>
        /// <p>Parameters for the intelligent erasure task of type kind. Valid when MPSProcessMediaParams is empty.</p>
        /// </summary>
        [JsonProperty("SmartEraseTask")]
        public MPSSmartEraseTaskInput SmartEraseTask{ get; set; }

        /// <summary>
        /// <p>Reserved field. Used for special purpose.</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "MPSProcessMediaParams", this.MPSProcessMediaParams);
            this.SetParamObj(map, prefix + "AiAnalysisTask.", this.AiAnalysisTask);
            this.SetParamObj(map, prefix + "SmartSubtitlesTask.", this.SmartSubtitlesTask);
            this.SetParamObj(map, prefix + "SmartEraseTask.", this.SmartEraseTask);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

