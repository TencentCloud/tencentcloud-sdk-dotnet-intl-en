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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelLimit : AbstractModel
    {
        
        /// <summary>
        /// <p>Model context length display copy (for example, 128K, 1000K)</p>
        /// </summary>
        [JsonProperty("ContextLengthDescription")]
        public string ContextLengthDescription{ get; set; }

        /// <summary>
        /// <p>Character limit for model dialog box input length</p>
        /// </summary>
        [JsonProperty("InputLengthLimit")]
        public long? InputLengthLimit{ get; set; }

        /// <summary>
        /// <p>Maximum input Tokens display copy (for example, 960k, formatted on the server, empty string if not configured)</p>
        /// </summary>
        [JsonProperty("MaxInputTokensDescription")]
        public string MaxInputTokensDescription{ get; set; }

        /// <summary>
        /// <p>Display copy for the maximum output Tokens (for example, 64k, formatted on the server, empty string if not configured)</p>
        /// </summary>
        [JsonProperty("MaxOutputTokensDescription")]
        public string MaxOutputTokensDescription{ get; set; }

        /// <summary>
        /// <p>Model prompt content length character limit</p>
        /// </summary>
        [JsonProperty("PromptLengthLimit")]
        public long? PromptLengthLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ContextLengthDescription", this.ContextLengthDescription);
            this.SetParamSimple(map, prefix + "InputLengthLimit", this.InputLengthLimit);
            this.SetParamSimple(map, prefix + "MaxInputTokensDescription", this.MaxInputTokensDescription);
            this.SetParamSimple(map, prefix + "MaxOutputTokensDescription", this.MaxOutputTokensDescription);
            this.SetParamSimple(map, prefix + "PromptLengthLimit", this.PromptLengthLimit);
        }
    }
}

