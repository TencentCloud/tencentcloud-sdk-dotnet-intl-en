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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyWordSampleRequest : AbstractModel
    {
        
        /// <summary>
        /// Keyword. Length limit: 128 characters.
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// <b>Keyword use case. Valid values:</b>
        /// 1. Recognition.Ocr: OCR-based content recognition;
        /// 2. Recognition.Asr: ASR-based content recognition;
        /// 3. Review.Ocr: OCR-based detection of inappropriate content;
        /// 4. Review.Asr：ASR-based detection of inappropriate content;
        /// <b>These values can be merged as follows:</b>
        /// 5. Recognition: ASR- and OCR-based content recognition, equivalent to 1 and 2 combined;
        /// 6. Review: ASR- and OCR-based detection of inappropriate content, equivalent to 3 and 4 combined.
        /// 7. All: all of the above, equivalent to 1, 2, 3, and 4 combined.
        /// </summary>
        [JsonProperty("Usages")]
        public string[] Usages{ get; set; }

        /// <summary>
        /// Tag operation information.
        /// </summary>
        [JsonProperty("TagOperationInfo")]
        public AiSampleTagOperation TagOperationInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamArraySimple(map, prefix + "Usages.", this.Usages);
            this.SetParamObj(map, prefix + "TagOperationInfo.", this.TagOperationInfo);
        }
    }
}

