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

    public class CreateSplitDocumentFlowConfig : AbstractModel
    {
        
        /// <summary>
        /// The form in which tables in a Markdown file are returned.
        /// - 0: returned as MD.
        /// - 1: returned as HTML.
        /// </summary>
        [JsonProperty("TableResultType")]
        [System.Obsolete]
        public string TableResultType{ get; set; }

        /// <summary>
        /// The format of the returned results of intelligent document parsing.
        /// - 0: only returns full-text MD.
        /// - 1: only returns the OCR original Json for each page.
        /// - 2: only returns the MD of each page.
        /// - 3: returns the full-text MD and the original OCR Json of each page.
        /// - 4: returns full-text MD and MD of each page.
        /// The default value is 3 (returns the full-text MD and the original OCR Json of each page).
        /// </summary>
        [JsonProperty("ResultType")]
        [System.Obsolete]
        public string ResultType{ get; set; }

        /// <summary>
        /// Whether to enable mllm.
        /// </summary>
        [JsonProperty("EnableMllm")]
        public bool? EnableMllm{ get; set; }

        /// <summary>
        /// Max segment length.
        /// </summary>
        [JsonProperty("MaxChunkSize")]
        public long? MaxChunkSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableResultType", this.TableResultType);
            this.SetParamSimple(map, prefix + "ResultType", this.ResultType);
            this.SetParamSimple(map, prefix + "EnableMllm", this.EnableMllm);
            this.SetParamSimple(map, prefix + "MaxChunkSize", this.MaxChunkSize);
        }
    }
}

