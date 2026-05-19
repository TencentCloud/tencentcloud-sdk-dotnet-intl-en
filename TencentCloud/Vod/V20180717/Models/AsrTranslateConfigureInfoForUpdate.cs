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

    public class AsrTranslateConfigureInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Voice translation recognition task switch. Available values:
        /// <li>ON: enabled;</li>
        /// <li>OFF: Disabled.</li><font color=red>Note:</font> The speech translation recognition task itself will return ASR full text recognition results. To avoid duplicate charges, it is forbidden to enable both speech translation recognition and ASR full text recognition feature items simultaneously.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Media source language. Valid values:
        /// <li>zh: Chinese.</li>
        /// <li>en: English;</li>
        /// <li>ja: Japanese;</li>
        /// <li>ko: Korean;</li>
        /// <li>vi: Vietnamese;</li>
        /// <li>ms: Malay;</li>
        /// <li>th: Thai;</li>
        /// <li>pt: Portuguese;</li>
        /// <li>tr: Turkish;</li>
        /// <li>ar: Arabic;</li>
        /// <li>es: Spanish;</li>
        /// <li>hi: Hindi;</li>
        /// <li>fr: French.</li>
        /// </summary>
        [JsonProperty("SrcLanguage")]
        public string SrcLanguage{ get; set; }

        /// <summary>
        /// Target language.
        /// If this parameter is filled in with an empty string, it means that only full speech recognition is performed without translation (the billing item is the same as AsrFullTextConfigure full speech recognition).
        /// Otherwise, the parameter value range is divided into the following cases:
        /// When SrcLanguage is zh (Chinese), the value ranges from...to...
        /// <li>en: English;</li>
        /// <li>ja: Japanese;</li>
        /// <li>ko: Korean;</li>
        /// <li>fr: French;</li>
        /// <li>es: Spanish;</li>
        /// <li>it: Italian.</li>
        /// <li>de: German;</li>
        /// <li>tr: Turkish;</li>
        /// <li>ru: Russian;</li>
        /// <li>pt: Portuguese;</li>
        /// <li>vi: Vietnamese;</li>
        /// <li>id: Indonesian;</li>
        /// <li>th: Thai;</li>
        /// <li>ms: Malay.</li>
        /// When SrcLanguage is en (English), the value ranges from...to...
        /// <li>zh: Chinese.</li>
        /// <li>ja: Japanese;</li>
        /// <li>ko: Korean;</li>
        /// <li>fr: French;</li>
        /// <li>es: Spanish;</li>
        /// <li>it: Italian.</li>
        /// <li>de: German;</li>
        /// <li>tr: Turkish;</li>
        /// <li>ru: Russian;</li>
        /// <li>pt: Portuguese;</li>
        /// <li>vi: Vietnamese;</li>
        /// <li>id: Indonesian;</li>
        /// <li>th: Thai;</li>
        /// <li>ms: Malay;</li>
        /// <li>ar: Arabic;</li>
        /// <li>hi: Hindi.</li>
        /// When SrcLanguage is ja (Japanese), the parameter value range is
        /// <li>zh: Chinese.</li>
        /// <li>en: English;</li>
        /// <li>ko: Korean.</li>
        /// When SrcLanguage is ko (Korean), the value ranges from...to...
        /// <li>zh: Chinese.</li>
        /// <li>en: English;</li>
        /// <li>ja: Japanese.</li>
        /// When SrcLanguage is vi (Vietnamese), ms (Malay), or th (Thai), the value ranges from...to...
        /// <li>zh: Chinese.</li>
        /// <li>en: English.</li>
        /// When SrcLanguage is pt (Portuguese), the value ranges from...to...
        /// <li>zh: Chinese.</li>
        /// <li>en: English;</li>
        /// <li>fr: French;</li>
        /// <li>es: Spanish;</li>
        /// <li>it: Italian.</li>
        /// <li>de: German;</li>
        /// <li>tr: Turkish;</li>
        /// <li>ru: Russian.</li>
        /// When SrcLanguage is tr (Turkish), the value ranges from...to...
        /// <li>zh: Chinese.</li>
        /// <li>en: English;</li>
        /// <li>fr: French;</li>
        /// <li>es: Spanish;</li>
        /// <li>it: Italian.</li>
        /// <li>de: German;</li>
        /// <li>ru: Russian;</li>
        /// <li>pt: Portuguese.</li>
        /// When SrcLanguage is es (Spanish), the parameter value range is
        /// <li>zh: Chinese.</li>
        /// <li>en: English;</li>
        /// <li>fr: French;</li>
        /// <li>it: Italian.</li>
        /// <li>de: German;</li>
        /// <li>tr: Turkish;</li>
        /// <li>ru: Russian;</li>
        /// <li>pt: Portuguese.</li>
        /// When SrcLanguage is ar (Arabic) or hi (Hindi), the value ranges from...to...
        /// <li>en: English.</li>
        /// When SrcLanguage is fr (French), the value ranges from...to...
        /// <li>zh: Chinese.</li>
        /// <li>en: English;</li>
        /// <li>es: Spanish;</li>
        /// <li>it: Italian.</li>
        /// <li>de: German;</li>
        /// <li>tr: Turkish;</li>
        /// <li>ru: Russian;</li>
        /// <li>pt: Portuguese.</li>
        /// </summary>
        [JsonProperty("DstLanguage")]
        public string DstLanguage{ get; set; }

        /// <summary>
        /// Subtitle format list operation information.
        /// </summary>
        [JsonProperty("SubtitleFormatsOperation")]
        public SubtitleFormatsOperation SubtitleFormatsOperation{ get; set; }

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
            this.SetParamSimple(map, prefix + "SrcLanguage", this.SrcLanguage);
            this.SetParamSimple(map, prefix + "DstLanguage", this.DstLanguage);
            this.SetParamObj(map, prefix + "SubtitleFormatsOperation.", this.SubtitleFormatsOperation);
            this.SetParamSimple(map, prefix + "SubtitleName", this.SubtitleName);
        }
    }
}

