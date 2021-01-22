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

    public class DescribeWordSamplesRequest : AbstractModel
    {
        
        /// <summary>
        /// Keyword filter. Array length limit: 100 words.
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// <b>Keyword use case filter. Valid values:</b>
        /// 1. Recognition.Ocr: OCR-based content recognition;
        /// 2. Recognition.Asr: ASR-based content recognition;
        /// 3. Review.Ocr: OCR-based detection of inappropriate content;
        /// 4. Review.Asr：ASR-based detection of inappropriate content;
        /// <b>These values can be merged as follows:</b>
        /// 5. Recognition: ASR- and OCR-based content recognition, equivalent to 1 and 2 combined;
        /// 6. Review: ASR- and OCR-based detection of inappropriate content, equivalent to 3+4 above;
        /// Multiple elements can be selected, and the relationship between them is "or", i.e., any keyword use case that contains any element in this field set will be deemed eligible.
        /// </summary>
        [JsonProperty("Usages")]
        public string[] Usages{ get; set; }

        /// <summary>
        /// Tag filter. Array length limit: 20 words.
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Paging offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of returned entries. Default value: 100. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamArraySimple(map, prefix + "Usages.", this.Usages);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

