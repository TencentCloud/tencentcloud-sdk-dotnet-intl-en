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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiAnalysisTaskDelLogoOutput : AbstractModel
    {
        
        /// <summary>
        /// <p>Path of a file after removal.</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>Storage location of a file after removal.</p>
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// <p>Path of subtitle file extracted from video.</p>
        /// </summary>
        [JsonProperty("OriginSubtitlePath")]
        public string OriginSubtitlePath{ get; set; }

        /// <summary>
        /// <p>Path of a subtitle translation file extracted from a video.</p>
        /// </summary>
        [JsonProperty("TranslateSubtitlePath")]
        public string TranslateSubtitlePath{ get; set; }

        /// <summary>
        /// <p>Subtitle position after removal. <strong>Note</strong>: only applicable to subtitle extraction when return of subtitle position is enabled.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubtitlePos")]
        public SubtitlePosition SubtitlePos{ get; set; }

        /// <summary>
        /// <p>File URL of the video after voice type cloning</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VoiceClonedVideo")]
        public string VoiceClonedVideo{ get; set; }

        /// <summary>
        /// <p>File address of the voice type clone annotation</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VoiceClonedMarkFile")]
        public string VoiceClonedMarkFile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OriginSubtitlePath", this.OriginSubtitlePath);
            this.SetParamSimple(map, prefix + "TranslateSubtitlePath", this.TranslateSubtitlePath);
            this.SetParamObj(map, prefix + "SubtitlePos.", this.SubtitlePos);
            this.SetParamSimple(map, prefix + "VoiceClonedVideo", this.VoiceClonedVideo);
            this.SetParamSimple(map, prefix + "VoiceClonedMarkFile", this.VoiceClonedMarkFile);
        }
    }
}

