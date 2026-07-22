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

namespace TencentCloud.Es.V20250101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChunkConfig : AbstractModel
    {
        
        /// <summary>
        /// After splitting by the separator, the fragment length is validated. If it exceeds the maximum fragment length, it is split using the next-level separator. If there is no next-level separator, the original length is retained. Default value: 1000.
        /// </summary>
        [JsonProperty("MaxChunkSize")]
        public ulong? MaxChunkSize{ get; set; }

        /// <summary>
        /// Separator list, separators positioned towards the front take precedence; when the file type is TXT, default value: ["\n\n", "\n", ".", ".", "?", ",", ""].
        /// </summary>
        [JsonProperty("Delimiters")]
        public string[] Delimiters{ get; set; }

        /// <summary>
        /// The number of overlapping characters between adjacent fragments must be less than the fragment length. Fragments that form completely redundant slices are automatically filtered. Default value: 0.2*MaxChunkSize
        /// </summary>
        [JsonProperty("ChunkOverlap")]
        public ulong? ChunkOverlap{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxChunkSize", this.MaxChunkSize);
            this.SetParamArraySimple(map, prefix + "Delimiters.", this.Delimiters);
            this.SetParamSimple(map, prefix + "ChunkOverlap", this.ChunkOverlap);
        }
    }
}

