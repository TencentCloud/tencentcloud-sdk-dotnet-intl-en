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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChatTranslationsRequest : AbstractModel
    {
        
        /// <summary>
        /// Model name. optional values include hunyuan-translation.
        /// Please read the introduction in [the product overview](https://www.tencentcloud.com/document/product/1284/75277) for model descriptions.
        /// 
        /// Note:
        /// Different models have different pricing. according to [the purchase guide](https://www.tencentcloud.com/document/product/1284/77186), call as needed.
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// Streaming call switch.
        /// Note:.
        /// 1. it defaults to non-streaming (false) when no value is passed.
        /// 2. for streaming calls, the results are incrementally returned via the SSE protocol (the return value is taken from Choices[n].Delta, and incremental data must be concatenated to obtain the complete result).
        /// 3. for non-streaming calls:.
        /// The calling method is the same as an ordinary HTTP request.
        /// The API response is time-consuming. if needed, set it to true for reduced latency.
        /// Only return the final result once (return value takes the value from Choices[n].Message).
        /// 
        /// Note:.
        /// When making an SDK call, streaming and non-streaming calls require **different ways** to obtain the return value. refer to the comments or sample code in the SDK (in the examples/hunyuan/v20230901/ directory of each language SDK code repository).
        /// </summary>
        [JsonProperty("Stream")]
        public bool? Stream{ get; set; }

        /// <summary>
        /// Text to be translated.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// Source language.
        /// Supported language list:. 
        /// Simplified chinese: zh, traditional chinese: zh-TR, cantonese: yue, english: en, french: fr, portuguese: pt, spanish: es, japanese: ja, turkish: TR, russian: ru, arabic: ar, korean: ko, thai: th, italian: it, german: de, vietnamese: vi, malay: ms, indonesian: id.
        /// The following languages are supported only by the hunyuan-translation model:.
        /// Filipino: fil, hindi: hi, polish: pl, czech: cs, dutch: nl, khmer: km, burmese: my, persian: fa, gujarati: gu, urdu: ur, telugu: te, marathi: mr, hebrew: he, bengali: bn, tamil: ta, ukrainian: uk, tibetan: bo, kazakh: kk, mongolian: mn, uyghur: ug.
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// Target language.
        /// Supported language list:. 
        /// Simplified chinese: zh, traditional chinese: zh-TR, cantonese: yue, english: en, french: fr, portuguese: pt, spanish: es, japanese: ja, turkish: TR, russian: ru, arabic: ar, korean: ko, thai: th, italian: it, german: de, vietnamese: vi, malay: ms, indonesian: id.
        /// The following languages are supported only by the hunyuan-translation model:.
        /// Filipino: fil, hindi: hi, polish: pl, czech: cs, dutch: nl, khmer: km, burmese: my, persian: fa, gujarati: gu, urdu: ur, telugu: te, marathi: mr, hebrew: he, bengali: bn, tamil: ta, ukrainian: uk, tibetan: bo, kazakh: kk, mongolian: mn, uyghur: ug.
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// Domain of the text to be translated, such as game plot.
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// Reference example, up to 10.
        /// </summary>
        [JsonProperty("References")]
        public Reference[] References{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamArrayObj(map, prefix + "References.", this.References);
        }
    }
}

