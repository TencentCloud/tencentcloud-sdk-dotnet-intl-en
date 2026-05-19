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

    public class AsrFullTextConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// Voice full-text recognition task switch. Available values:
        /// <li>ON: Enable intelligent voice full-text recognition task.</li>
        /// <li>OFF: Disable the intelligent voice full-text recognition task.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Generated subtitle file format list. Leaving it as an empty array means no subtitle file will be generated. Available values:
        /// <li>vtt: Generate a WebVTT subtitle file.</li>
        /// <li>srt: Generate SRT subtitle file.</li><font color=red>Note:</font> VOD media asset information only supports adding vtt subtitles. When and only when SubtitleFormats includes vtt, VOD will be generated subtitles add to media assets.
        /// </summary>
        [JsonProperty("SubtitleFormats")]
        public string[] SubtitleFormats{ get; set; }

        /// <summary>
        /// Generated subtitle file format. Leaving it as an empty string or not filling it means no subtitle file will be generated. Valid value:
        /// <li>vtt: Generate a WebVTT subtitle file.</li>
        /// <li>srt: Generate SRT subtitle file.</li>
        /// <font color='red'>Note: This field is deprecated. Recommend using SubtitleFormats.</font>
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        [System.Obsolete]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// Media source language. Valid values:
        /// <li>zh: Mandarin;</li>
        /// <li>en: English;</li>
        /// <li>ja: Japanese;</li>
        /// <li>zh-ca: Cantonese.</li>
        /// <font color=red>Note:</font> Fill in an empty string or leave the parameter blank for automatic recognition (effectiveness difficult to guarantee. Recommended to fill in the language corresponding to the original media to improve recognition accuracy).
        /// </summary>
        [JsonProperty("SrcLanguage")]
        public string SrcLanguage{ get; set; }

        /// <summary>
        /// Specify subtitle name. Length limit: 64 characters. This value will be used for player display. If left blank, VOD will auto generate.
        /// <font color=red>Note:</font> This field is valid only when SubtitleFormats contains vtt.
        /// </summary>
        [JsonProperty("SubtitleName")]
        public string SubtitleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "SubtitleFormats.", this.SubtitleFormats);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamSimple(map, prefix + "SrcLanguage", this.SrcLanguage);
            this.SetParamSimple(map, prefix + "SubtitleName", this.SubtitleName);
        }
    }
}

