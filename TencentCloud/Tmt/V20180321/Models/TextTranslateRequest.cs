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

namespace TencentCloud.Tmt.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextTranslateRequest : AbstractModel
    {
        
        /// <summary>
        /// The texts to be translated, which must be encoded in UTF-8 and can contain up to 2,000 characters in a request. For non-pure texts such as those with HTML tags, the translation may fail.
        /// </summary>
        [JsonProperty("SourceText")]
        public string SourceText{ get; set; }

        /// <summary>
        /// Supported source languages:
        /// auto: Automatic language detection
        /// zh: Simplified Chinese
        /// zh_TW: Traditional Chinese
        /// en: English
        /// ja: Japanese
        /// fr: French
        /// es: Spanish
        /// it: Italian
        /// de: German
        /// tr: Turkish
        /// ru: Russian
        /// pt: Portuguese
        /// vi: Vietnamese
        /// id: Bahasa Indonesian
        /// th: Thai
        /// ms: Malay
        /// ar: Arabic
        /// hi: Hindi
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// Supported target languages for the above source languages:
        /// 
        /// <li>zh (Simplified Chinese): en (English), ja (Japanese), fr (French), es (Spanish), it (Italian), de (German), tr (Turkish), ru (Russian), pt (Portuguese), vi (Vietnamese), id (Bahasa Indonesian), th (Thai), and ms (Malay)</li>
        /// <li>zh-TW (Traditional Chinese): en (English), ja (Japanese), fr (French), es (Spanish), it (Italian), tr (Turkish), ru (Russian), pt (Portuguese), vi (Vietnamese), id (Bahasa Indonesian), th (Thai), and ms (Malay)</li>
        /// <li>en (English): zh (Simplified Chinese), zh-TW (Traditional Chinese), ja (Japanese), fr (French), es (Spanish), it (Italian), de (German), tr (Turkish), vi (Vietnamese), id (Bahasa Indonesian), th (Thai), ms (Malay), and hi (Hindi)</li>
        /// <li>fr (French): zh (Simplified Chinese), zh-TW (Traditional Chinese) and en (English)</li>
        /// <li>it (Italian): zh (Simplified Chinese), zh-TW (Traditional Chinese) and en (English)</li>
        /// <li>de (German): zh (Simplified Chinese), zh-TW (Traditional Chinese) and en (English)</li>
        /// <li>ru (Russian): zh (Simplified Chinese) and zh-TW (Traditional Chinese)</li>
        /// <li>tr (Turkish): zh (Simplified Chinese) and zh-TW (Traditional Chinese)</li>
        /// <li>pt (Portuguese): zh (Simplified Chinese) and tr (Turkish)</li>
        /// <li>es (Spanish): zh (Simplified Chinese), zh-TW (Traditional Chinese) and en (English)</li>
        /// <li>ja (Japanese): zh (Simplified Chinese), zh-TW (Traditional Chinese) and en (English)</li>
        /// <li>vi (Vietnamese): zh (Simplified Chinese), zh-TW (Traditional Chinese) and en (English)</li>
        /// <li>th (Thai): zh (Simplified Chinese) and en (English)</li>
        /// <li>id (Bahasa Indonesian): zh (Simplified Chinese), zh-TW (Traditional Chinese) and en (English)</li>
        /// <li>ms (Malay): zh (Simplified Chinese) and zh-TW (Traditional Chinese)</li>
        /// <li>ar (Arabic): en (English)</li>
        /// <li>hi (Hindi): en (English)</li>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// The project ID, which can be obtained from **Console -> Account Center -> Project Management**. If no one is set, enter the default project ID `0`.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// The parameter used to mark the text content that needs to remain untranslated, such as special symbols and names of people and places. You can set only one word for this parameter in each request. Only nouns (like names of people and places) are supported, and verbs or phrases may cause poor translation outcomes.
        /// </summary>
        [JsonProperty("UntranslatedText")]
        public string UntranslatedText{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TermRepoIDList")]
        public string[] TermRepoIDList{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SentRepoIDList")]
        public string[] SentRepoIDList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceText", this.SourceText);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "UntranslatedText", this.UntranslatedText);
            this.SetParamArraySimple(map, prefix + "TermRepoIDList.", this.TermRepoIDList);
            this.SetParamArraySimple(map, prefix + "SentRepoIDList.", this.SentRepoIDList);
        }
    }
}

