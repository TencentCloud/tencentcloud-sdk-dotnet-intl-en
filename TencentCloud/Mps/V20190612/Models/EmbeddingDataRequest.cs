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

    public class EmbeddingDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Embedding model; currently only supports text_embedding_v1</p><p>Enumeration values: </p><ul><li>text_embedding_v1: The text embedding model. Prompt can be filled.</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>Embedding input</p>
        /// </summary>
        [JsonProperty("Files")]
        public EmbeddingData[] Files{ get; set; }

        /// <summary>
        /// <p>Prompt for embedding input</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArrayObj(map, prefix + "Files.", this.Files);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
        }
    }
}

