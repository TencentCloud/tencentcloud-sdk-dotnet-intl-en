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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AsrFullTextConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// Switch of full speech recognition task. Valid values:
        /// <li>ON: enables intelligent full speech recognition task;</li>
        /// <li>OFF: disables intelligent full speech recognition task.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// The formats of the subtitle files generated. If this parameter is not passed or an empty string is passed in, no subtitles files will be generated. Valid values:
        /// <li>vtt</li>
        /// <li>srt</li>
        /// </summary>
        [JsonProperty("SubtitleFormats")]
        public string[] SubtitleFormats{ get; set; }

        /// <summary>
        /// The format of the subtitle file generated. If this parameter is not passed or an empty string is passed in, no subtitles files will be generated. Valid values:
        /// <li>vtt</li>
        /// <li>srt</li>
        /// <font color='red'>Note: This parameter has been deprecated. Please use `SubtitleFormats` instead.</font>
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// Media source language value range: <li>zh: Mandarin </li> <li>en: English</li> <li>ja: Japanese </li> <li>zh-ca: Cantonese</li><font color=red>Note：</font> If it fills in an empty string or leave this parameter blank, it will be automatically recognized (it is recommended to fill in the language corresponding to the media to improve the recognition accuracy).
        /// </summary>
        [JsonProperty("SrcLanguage")]
        public string SrcLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "SubtitleFormats.", this.SubtitleFormats);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamSimple(map, prefix + "SrcLanguage", this.SrcLanguage);
        }
    }
}

