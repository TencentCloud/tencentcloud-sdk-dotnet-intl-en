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

    public class Usage : AbstractModel
    {
        
        /// <summary>
        /// Input Token quantity.
        /// </summary>
        [JsonProperty("PromptTokens")]
        public long? PromptTokens{ get; set; }

        /// <summary>
        /// Output Token quantity.
        /// </summary>
        [JsonProperty("CompletionTokens")]
        public long? CompletionTokens{ get; set; }

        /// <summary>
        /// Total Token quantity.
        /// </summary>
        [JsonProperty("TotalTokens")]
        public long? TotalTokens{ get; set; }

        /// <summary>
        /// Details of the input token.
        /// </summary>
        [JsonProperty("PromptTokensDetails")]
        public PromptTokensDetails PromptTokensDetails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PromptTokens", this.PromptTokens);
            this.SetParamSimple(map, prefix + "CompletionTokens", this.CompletionTokens);
            this.SetParamSimple(map, prefix + "TotalTokens", this.TotalTokens);
            this.SetParamObj(map, prefix + "PromptTokensDetails.", this.PromptTokensDetails);
        }
    }
}

