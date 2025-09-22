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
        /// Path of a file after removal.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Storage location of a file after removal.
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// Path of a subtitle file extracted from a video.
        /// </summary>
        [JsonProperty("OriginSubtitlePath")]
        public string OriginSubtitlePath{ get; set; }

        /// <summary>
        /// Path of a subtitle translation file extracted from a video.
        /// </summary>
        [JsonProperty("TranslateSubtitlePath")]
        public string TranslateSubtitlePath{ get; set; }

        /// <summary>
        /// Position of the erased subtitle. Note: This field is only valid for subtitle extraction when the option to return subtitle positions is enabled.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SubtitlePos")]
        public SubtitlePosition SubtitlePos{ get; set; }

        /// <summary>
        /// Specifies the file url of the video after voice cloning.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("VoiceClonedVideo")]
        public string VoiceClonedVideo{ get; set; }

        /// <summary>
        /// Specifies the file address of the voice type clone annotation.
        /// Note: This field may return null, indicating that no valid value can be obtained.
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

