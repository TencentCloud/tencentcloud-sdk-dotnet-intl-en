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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileInfoContent : AbstractModel
    {
        
        /// <summary>
        /// <p>DocBizId returned by the real-time document parsing API</p>
        /// </summary>
        [JsonProperty("DocBizId")]
        [System.Obsolete]
        public string DocBizId{ get; set; }

        /// <summary>
        /// <p>File name.</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>File type</p>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// <p>File size in bytes</p>
        /// </summary>
        [JsonProperty("FileSize")]
        public string FileSize{ get; set; }

        /// <summary>
        /// <p>File URL</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// <p>doc_id returned by the real-time document parsing API.</p>
        /// </summary>
        [JsonProperty("DocId")]
        public string DocId{ get; set; }

        /// <summary>
        /// <p>File creation time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Local path of the file in the sandbox</p>
        /// </summary>
        [JsonProperty("LocalPath")]
        public string LocalPath{ get; set; }

        /// <summary>
        /// <p>File moderation status</p><p>Enumeration values:</p><ul><li>1: under review</li><li>2: pass review</li><li>3: fail review</li></ul>
        /// </summary>
        [JsonProperty("AuditStatus")]
        public ulong? AuditStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "DocId", this.DocId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LocalPath", this.LocalPath);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
        }
    }
}

