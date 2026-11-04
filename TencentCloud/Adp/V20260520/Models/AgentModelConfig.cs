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

    public class AgentModelConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Unique model id</p>
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>Model alias</p>
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// <p>Model context length character limit</p>
        /// </summary>
        [JsonProperty("ContextWordsLimit")]
        public ulong? ContextWordsLimit{ get; set; }

        /// <summary>
        /// <p>Instruction length character limit</p>
        /// </summary>
        [JsonProperty("InstructionsWordsLimit")]
        public ulong? InstructionsWordsLimit{ get; set; }

        /// <summary>
        /// <p>Model parameters</p>
        /// </summary>
        [JsonProperty("ModelParameters")]
        public ModelParams ModelParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "ContextWordsLimit", this.ContextWordsLimit);
            this.SetParamSimple(map, prefix + "InstructionsWordsLimit", this.InstructionsWordsLimit);
            this.SetParamObj(map, prefix + "ModelParameters.", this.ModelParameters);
        }
    }
}

