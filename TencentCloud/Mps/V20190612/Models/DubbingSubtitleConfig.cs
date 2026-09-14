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

    public class DubbingSubtitleConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Subtitle source.</p><p>Enumeration values:</p><ul><li>OCR: OCR text recognition, recognizes text in video frames.</li><li>ASR: ASR speech recognition, recognizes voice dialogue in videos.</li><li>External: External subtitle file, provide the URL of the original/translated subtitles.</li></ul>
        /// </summary>
        [JsonProperty("SubtitleSource")]
        public string SubtitleSource{ get; set; }

        /// <summary>
        /// <p>Use ASR to assist OCR.</p><p>Enumeration values:</p><ul><li>ON: Enable the use of ASR to assist OCR.</li><li>OFF: Disable the use of ASR to assist OCR.</li></ul><p>Default value: OFF</p><p>Can be set to ON only when SubtitleSource=OCR</p>
        /// </summary>
        [JsonProperty("AsrAssistOcr")]
        public string AsrAssistOcr{ get; set; }

        /// <summary>
        /// <p>Erase the original subtitle.</p><p>Enumeration values:</p><ul><li>ON: Erase the original subtitle.</li><li>OFF: Retain the original subtitle.</li></ul><p>Default value: OFF</p><p>Cannot be set to ON when SubtitleSource=External</p>
        /// </summary>
        [JsonProperty("EraseOriginalSubtitle")]
        public string EraseOriginalSubtitle{ get; set; }

        /// <summary>
        /// <p>Subtitle location information.</p>
        /// </summary>
        [JsonProperty("SelectingSubtitleAreasConfig")]
        public SelectingSubtitleAreasConfig SelectingSubtitleAreasConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleSource", this.SubtitleSource);
            this.SetParamSimple(map, prefix + "AsrAssistOcr", this.AsrAssistOcr);
            this.SetParamSimple(map, prefix + "EraseOriginalSubtitle", this.EraseOriginalSubtitle);
            this.SetParamObj(map, prefix + "SelectingSubtitleAreasConfig.", this.SelectingSubtitleAreasConfig);
        }
    }
}

