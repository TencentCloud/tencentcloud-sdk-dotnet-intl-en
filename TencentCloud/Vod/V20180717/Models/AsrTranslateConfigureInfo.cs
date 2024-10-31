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

    public class AsrTranslateConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// Voice translation task switch, optional values:
        /// <li>ON: switch on;</li>
        /// <li>OFF: switch off.</li><font color=red>Note:</font> The task results of voice translation include asr full text recognition result. To avoid duplicate charges, simultaneous activation of voice translation and asr full text recognition features is prohibited.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Media source language. When the Switch is ON, this parameter is mandatory. Value range:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English;</li>
        /// <li>`ja`: Japanese;</li>
        /// <li>`ko`: Korean;</li>
        /// <li>`vi`: Vietnamese;</li>
        /// <li>`ms`: Malay;</li>
        /// <li>`th`: Thai;</li>
        /// <li>`pt`: Portuguese;</li>
        /// <li>`tr`: Turkish;</li>
        /// <li>`ar`: Arabic;</li>
        /// <li>`es`: Spanish;</li>
        /// <li>`hi`: Hindi;</li>
        /// <li>`fr`: French.</li>
        /// </summary>
        [JsonProperty("SrcLanguage")]
        public string SrcLanguage{ get; set; }

        /// <summary>
        /// Translation target language. When the Switch is ON, this parameter is mandatory.
        /// When SrcLanguage is zh (Chinese), the value range:
        /// <li>`en`: English;</li>
        /// <li>`ja`: Japanese;</li>
        /// <li>`ko`: Korean;</li>
        /// <li>`fr`: French;</li>
        /// <li>`es`: Spanish;</li>
        /// <li>`it`: Italian;</li>
        /// <li>`de`: German;</li>
        /// <li>`tr`: Turkish;</li>
        /// <li>`ru`: Russian;</li>
        /// <li>`pt`: Portuguese;</li>
        /// <li>`vi`: Vietnamese;</li>
        /// <li>`id`: Indonesian;</li>
        /// <li>`th`: Thai;</li>
        /// <li>`ms`: Malay.</li>
        /// 
        /// When SrcLanguage is en (English), the value range:
        /// <li>`zh`: Chinese;</li>
        /// <li>`ja`: Japanese;</li>
        /// <li>`ko`: Korean;</li>
        /// <li>`fr`: French;</li>
        /// <li>`es`: Spanish;</li>
        /// <li>`it`: Italian;</li>
        /// <li>`de`: German;</li>
        /// <li>`tr`: Turkish;</li>
        /// <li>`ru`: Russian;</li>
        /// <li>`pt`: Portuguese;</li>
        /// <li>`vi`: Vietnamese;</li>
        /// <li>`id`: Indonesian;</li>
        /// <li>`th`: Thai;</li>
        /// <li>`ms`: Malay;</li>
        /// <li>`ar`: Arabic;</li>
        /// <li>`hi`: Hindi.</li>
        /// 
        /// When SrcLanguage is ja (Japanese), the valid options are:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English;</li>
        /// <li>`ko`: Korean.</li>
        /// 
        /// When SrcLanguage is ko (Korean), the valid options are:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English;</li>
        /// <li>`ja`: Japanese.</li>
        /// 
        /// When SrcLanguage is vi (Vietnamese), ms (Malay), or th (Thai), the valid options are:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English.</li>
        /// 
        /// When SrcLanguage is pt (Portuguese), the valid options are:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English;</li>
        /// <li>`fr`: French;</li>
        /// <li>`es`: Spanish;</li>
        /// <li>`it`: Italian;</li>
        /// <li>`de`: German;</li>
        /// <li>`tr`: Turkish;</li>
        /// <li>`ru`: Russian.</li>
        /// 
        /// When SrcLanguage is tr (Turkish), the value range is:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English;</li>
        /// <li>`fr`: French;</li>
        /// <li>`es`: Spanish;</li>
        /// <li>`it`: Italian;</li>
        /// <li>`de`: German;</li>
        /// <li>`ru`: Russian;</li>
        /// <li>`pt`: Portuguese.</li>
        /// 
        /// When SrcLanguage is es (Spanish), the value range is:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English;</li>
        /// <li>`fr`: French;</li>
        /// <li>`it`: Italian;</li>
        /// <li>`de`: German;</li>
        /// <li>`tr`: Turkish;</li>
        /// <li>`ru`: Russian;</li>
        /// <li>`pt`: Portuguese.</li>
        /// 
        /// When SrcLanguage is ar (Arabic) or hi (Hindi), the value range is:
        /// <li>`en`: English.</li>
        /// 
        /// When SrcLanguage is fr (French), the value range is:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English;</li>
        /// <li>`es`: Spanish;</li>
        /// <li>`it`: Italian;</li>
        /// <li>`de`: German;</li>
        /// <li>`tr`: Turkish;</li>
        /// <li>`ru`: Russian;</li>
        /// <li>`pt`: Portuguese.</li>
        /// </summary>
        [JsonProperty("DstLanguage")]
        public string DstLanguage{ get; set; }

        /// <summary>
        /// Generated subtitle file format list. If not filled or an empty array is provided, no subtitle file will be generated. Optional values:
        /// <li>vtt: generate WebVTT subtitle file;</li>
        /// <li>srt: generate SRT subtitle files.</li><font color=red>Note:</font> VOD media assets only support adding vtt subtitles. Therefore, VOD will add generated subtitles to media assets only when SubtitleFormats includes vtt.
        /// </summary>
        [JsonProperty("SubtitleFormats")]
        public string[] SubtitleFormats{ get; set; }

        /// <summary>
        /// Specify subtitle name, length limit: 64 characters. This value will be displayed by the player. If not provided, VOD will automatically generate it.
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
            this.SetParamArraySimple(map, prefix + "SubtitleFormats.", this.SubtitleFormats);
            this.SetParamSimple(map, prefix + "SubtitleName", this.SubtitleName);
        }
    }
}

