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

    public class DubbingOutputConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Output method</p><p>Enumeration values:</p><ul><li>FinalVideoOnly: default, final video only</li><li>AudioAndSubtitle: translation audio + translation subtitle</li><li>Custom: customization</li></ul><p>Default value: FinalVideoOnly</p><p>No translation audio and subtitle are returned when using external subtitles</p>
        /// </summary>
        [JsonProperty("OutputMode")]
        public string OutputMode{ get; set; }

        /// <summary>
        /// <p>Output video switch</p><p>Enumeration values: </p><ul><li>ON: Enable</li><li>OFF: Disable</li></ul><p>Default value: ON</p><p>Only takes effect in Custom mode</p>
        /// </summary>
        [JsonProperty("OutputFinalVideo")]
        public string OutputFinalVideo{ get; set; }

        /// <summary>
        /// <p>Switch to output subtitle files (contains both original voice subtitles and target language subtitles)</p><p>Enumeration values:</p><ul><li>ON: enable</li><li>OFF: disable</li></ul><p>Default value: OFF</p>
        /// </summary>
        [JsonProperty("OutputSubtitle")]
        public string OutputSubtitle{ get; set; }

        /// <summary>
        /// <p>Audio switch for output translation dubbing</p><p>Enumeration values: </p><ul><li>ON: Enable</li><li>OFF: Disable</li></ul><p>Default value: OFF</p><p>Only takes effect in Custom mode</p>
        /// </summary>
        [JsonProperty("OutputDstAudio")]
        public string OutputDstAudio{ get; set; }

        /// <summary>
        /// <p>Subtitle suppression configuration message.</p>
        /// </summary>
        [JsonProperty("EmbedSubtitleConfig")]
        public DubbingEmbedSubtitleConfig EmbedSubtitleConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputMode", this.OutputMode);
            this.SetParamSimple(map, prefix + "OutputFinalVideo", this.OutputFinalVideo);
            this.SetParamSimple(map, prefix + "OutputSubtitle", this.OutputSubtitle);
            this.SetParamSimple(map, prefix + "OutputDstAudio", this.OutputDstAudio);
            this.SetParamObj(map, prefix + "EmbedSubtitleConfig.", this.EmbedSubtitleConfig);
        }
    }
}

