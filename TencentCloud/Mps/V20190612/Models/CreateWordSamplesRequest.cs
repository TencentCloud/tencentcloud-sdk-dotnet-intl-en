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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateWordSamplesRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>Keyword usage. Valid values:</b>
        /// 1. Recognition.Ocr: OCR-based content recognition
        /// 2. Recognition.Asr: ASR-based content recognition
        /// 3. Review.Ocr: OCR-based inappropriate information recognition
        /// 4. Review.Asr: ASR-based inappropriate information recognition
        /// <b>Valid values can also be:</b>
        /// 5. Recognition: ASR- and OCR-based content recognition; equivalent to 1+2
        /// 6. Review: ASR- and OCR-based inappropriate information recognition; equivalent to 3+4
        /// 7. All: ASR- and OCR-based content recognition and inappropriate information detection; equivalent to 1+2+3+4
        /// </summary>
        [JsonProperty("Usages")]
        public string[] Usages{ get; set; }

        /// <summary>
        /// Keyword. Array length limit: 100.
        /// </summary>
        [JsonProperty("Words")]
        public AiSampleWordInfo[] Words{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Usages.", this.Usages);
            this.SetParamArrayObj(map, prefix + "Words.", this.Words);
        }
    }
}

