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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeConfig : AbstractModel
    {
        
        /// <summary>
        /// The supported languages for speech recognition are as follows, with the default being "zh" for Chinese. The values for the `Language` field follow the [ISO639](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) standard. Here is the full list of supported languages:
        /// 
        /// 1. Chinese = "zh"
        /// 2. Chinese_TW = "zh-TW"
        /// 3. Chinese_DIALECT = "zh-dialect"
        /// 4. English = "en"
        /// 5. Vietnamese = "vi"
        /// 6. Japanese = "ja"
        /// 7. Korean = "ko"
        /// 8. Indonesian = "id"
        /// 9. Thai = "th"
        /// 10. Portuguese = "pt"
        /// 11. Turkish = "tr"
        /// 12. Arabic = "ar"
        /// 13. Spanish = "es"
        /// 14. Hindi = "hi"
        /// 15. French = "fr"
        /// 16. Malay = "ms"
        /// 17. Filipino = "fil"
        /// 18. German = "de"
        /// 19. Italian = "it"
        /// 20. Russian = "ru"
        /// 
        /// **Note:** If the language you need is not listed, please contact our technical support team.
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// Initiate fuzzy recognition to replace additional language types. Fill in up to 3 language types. Note: When Language is specified as "zh-dialect", fuzzy recognition is not supported and this field is invalid.
        /// </summary>
        [JsonProperty("AlternativeLanguage")]
        public string[] AlternativeLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamArraySimple(map, prefix + "AlternativeLanguage.", this.AlternativeLanguage);
        }
    }
}

