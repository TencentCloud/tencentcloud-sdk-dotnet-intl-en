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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetEmbeddingRequest : AbstractModel
    {
        
        /// <summary>
        /// Select the model for generating vectors
        /// Note: Optional [adp-text-embedding-0.5b]
        /// 
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// Text that requires embedding. The maximum length of a single text is 500 characters. The maximum total number of entries is 7.
        /// </summary>
        [JsonProperty("Inputs")]
        public string[] Inputs{ get; set; }

        /// <summary>
        /// The type of text vectorization. To achieve better retrieval performance, it is recommended to distinguish between query text and document text types. For symmetric tasks such as clustering and classification, there is no need for special specification simply use the system default value "document".
        /// </summary>
        [JsonProperty("TextType")]
        public string TextType{ get; set; }

        /// <summary>
        /// This field is not currently supported.
        /// </summary>
        [JsonProperty("Instruction")]
        public string Instruction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArraySimple(map, prefix + "Inputs.", this.Inputs);
            this.SetParamSimple(map, prefix + "TextType", this.TextType);
            this.SetParamSimple(map, prefix + "Instruction", this.Instruction);
        }
    }
}

