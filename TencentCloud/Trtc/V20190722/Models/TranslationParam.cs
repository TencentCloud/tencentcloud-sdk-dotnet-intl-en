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

    public class TranslationParam : AbstractModel
    {
        
        /// <summary>
        /// Target language for translation. Example: ["en", "ja"].
        /// 
        /// Supported target languages:
        /// 
        /// - <code>"zh"</code>: Chinese
        /// - <code>"en"</code>: English
        /// - <code>"vi"</code>: Vietnamese
        /// - <code>"ja"</code>: Japanese
        /// - <code>"ko"</code>: Korean
        /// - <code>"id"</code>: Indonesian
        /// - <code>"th"</code>: Thai
        /// - <code>"pt"</code>: Portuguese
        /// - <code>"ar"</code>: Arabic
        /// - <code>"es"</code>: Spanish
        /// - <code>"fr"</code>: French
        /// - <code>"ms"</code>: Malay
        /// - <code>"de"</code>: German
        /// - <code>"it"</code>: Italian
        /// - <code>"ru"</code>: Russian
        /// </summary>
        [JsonProperty("TargetLang")]
        public string[] TargetLang{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TargetLang.", this.TargetLang);
        }
    }
}

