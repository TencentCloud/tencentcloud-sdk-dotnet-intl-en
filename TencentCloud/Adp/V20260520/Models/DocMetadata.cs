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

    public class DocMetadata : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of characters in the document</p>
        /// </summary>
        [JsonProperty("DocCharCount")]
        public string DocCharCount{ get; set; }

        /// <summary>
        /// <p>File name.</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>File size (byte)</p>
        /// </summary>
        [JsonProperty("FileSize")]
        public string FileSize{ get; set; }

        /// <summary>
        /// <p>File type/extension</p>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// <p>List of metadata reference field names (used to display which categories and properties of a document are set as metadata)</p>
        /// </summary>
        [JsonProperty("RefFieldNameList")]
        public string[] RefFieldNameList{ get; set; }

        /// <summary>
        /// <p>Source description.</p>
        /// </summary>
        [JsonProperty("SourceDesc")]
        public string SourceDesc{ get; set; }

        /// <summary>
        /// <p>Document source type: 1=local upload, 2=webpage link, 3=COS integration, 4=import from external sources<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>DOC_SOURCE_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>DOC_SOURCE_TYPE_LOCAL</td><td>1</td><td>Local upload</td></tr><tr><td>DOC_SOURCE_TYPE_URL</td><td>2</td><td>Webpage link</td></tr><tr><td>DOC_SOURCE_TYPE_COS</td><td>3</td><td>COS integration</td></tr><tr><td>DOC_SOURCE_TYPE_IMPORT</td><td>4</td><td>Import from external sources</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DocCharCount", this.DocCharCount);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamArraySimple(map, prefix + "RefFieldNameList.", this.RefFieldNameList);
            this.SetParamSimple(map, prefix + "SourceDesc", this.SourceDesc);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
        }
    }
}

