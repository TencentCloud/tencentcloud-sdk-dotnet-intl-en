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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImportMediaKnowledgeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>VOD <a href="/document/product/266/14574">application</a> ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Media file ID, the globally unique identifier of the file in VOD, is assigned by the VOD backend after successful upload. You can get this field in the <a href="/document/product/266/7830">video upload completion event notification</a> or the <a href="https://console.cloud.tencent.com/vod/media">VOD console</a>.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Unique identifier of the Large Model Understanding Template</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>List of knowledge base IDs. If left blank, the default knowledge base will be used.</p>
        /// </summary>
        [JsonProperty("KnowledgeBaseIds")]
        public string[] KnowledgeBaseIds{ get; set; }

        /// <summary>
        /// <p>Task type required to import knowledge base. Optional values:</p><ul><li>AiAnalysis.DescriptionTask</li><li>SmartSubtitle.AsrFullTextTask</li></ul>
        /// </summary>
        [JsonProperty("ImportTasks")]
        [System.Obsolete]
        public string[] ImportTasks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamArraySimple(map, prefix + "KnowledgeBaseIds.", this.KnowledgeBaseIds);
            this.SetParamArraySimple(map, prefix + "ImportTasks.", this.ImportTasks);
        }
    }
}

