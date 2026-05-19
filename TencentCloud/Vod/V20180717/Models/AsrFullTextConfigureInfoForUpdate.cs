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

    public class AsrFullTextConfigureInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Voice full-text recognition task switch. Available values:
        /// <li>ON: enable intelligent voice full-text recognition task.</li>
        /// <li>OFF: disable intelligent voice full-text recognition task</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Subtitle format list operation information.
        /// </summary>
        [JsonProperty("SubtitleFormatsOperation")]
        public SubtitleFormatsOperation SubtitleFormatsOperation{ get; set; }

        /// <summary>
        /// Generated subtitle file format. <font color='red'>Fill in an empty string</font> to indicate no subtitle file generation. Available values:
        /// <li>vtt: Generate a WebVTT subtitle file.</li>
        /// <li>srt: Generate SRT subtitle file.</li>
        /// <font color='red'>Note: This field is deprecated. Recommend using SubtitleFormatsOperation.</font>
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
        /// </summary>
        [JsonProperty("SrcLanguage")]
        public string SrcLanguage{ get; set; }

        /// <summary>
        /// Specify subtitle name. Length limit: 64 characters. This value will be used for player display.
        /// </summary>
        [JsonProperty("SubtitleName")]
        public string SubtitleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "SubtitleFormatsOperation.", this.SubtitleFormatsOperation);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamSimple(map, prefix + "SrcLanguage", this.SrcLanguage);
            this.SetParamSimple(map, prefix + "SubtitleName", this.SubtitleName);
        }
    }
}

