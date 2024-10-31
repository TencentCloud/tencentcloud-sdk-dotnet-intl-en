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

    public class AsrTranslateConfigureInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Voice translation task switch, optional values:
        /// <li>ON: switch on;</li>
        /// <li>OFF: switch off.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Media source language, value range:
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
        /// Translation target language.
        /// When SrcLanguage is zh(Chinese), value range:
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
        /// When SrcLanguage is en(English), value range:
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
        /// When SrcLanguage is ja (Japanese), value range:
        /// <li>zh: Chinese;</li>
        /// <li>en: English;</li>
        /// <li>ko: Korean.</li>
        /// 
        /// When SrcLanguage is ko (Korean), value range:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English;</li>
        /// <li>`ja`: Japanese.</li>
        /// 
        /// When SrcLanguage is vi (Vietnamese) or ms (Malay) or th (Thai), value range:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English.</li>
        /// 
        /// When SrcLanguage is pt (Portuguese), value range:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English;</li>
        /// <li>`fr`: French;</li>
        /// <li>`es`: Spanish;</li>
        /// <li>`it`: Italian;</li>
        /// <li>`de`: German;</li>
        /// <li>`tr`: Turkish;</li>
        /// <li>`ru`: Russian.</li>
        /// 
        /// When SrcLanguage is tr (Turkish), value range:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English;</li>
        /// <li>`fr`: French;</li>
        /// <li>`es`: Spanish;</li>
        /// <li>`it`: Italian;</li>
        /// <li>`de`: German;</li>
        /// <li>`ru`: Russian;</li>
        /// <li>`pt`: Portuguese.</li>
        /// 
        /// When SrcLanguage is es (Spanish), value range:
        /// <li>`zh`: Chinese;</li>
        /// <li>`en`: English;</li>
        /// <li>`fr`: French;</li>
        /// <li>`it`: Italian;</li>
        /// <li>`de`: German;</li>
        /// <li>`tr`: Turkish;</li>
        /// <li>`ru`: Russian;</li>
        /// <li>`pt`: Portuguese.</li>
        /// 
        /// When SrcLanguage is ar (Arabic) or hi (Hindi), value range:
        /// <li>`en`: English.</li>
        /// 
        /// When SrcLanguage is fr (French), value range:
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
        /// Operation information about subtitle format list.
        /// </summary>
        [JsonProperty("SubtitleFormatsOperation")]
        public SubtitleFormatsOperation SubtitleFormatsOperation{ get; set; }

        /// <summary>
        /// Specify subtitle name, length limit: 64 characters. This value will be used for player display.
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

