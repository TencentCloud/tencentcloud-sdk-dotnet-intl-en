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

    public class SearchMediaBySemanticsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services from December 25, 2023, if they access resources in on-demand applications (whether the default application or a newly created application), this field must be filled with the app ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Content to search</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Knowledge base ID. If left empty, the default knowledge base will be used</p>
        /// </summary>
        [JsonProperty("KnowledgeBaseId")]
        public string KnowledgeBaseId{ get; set; }

        /// <summary>
        /// <p>Number of returned records. Default value: 20.</p><p>Value range: [1, 100]</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>File type. Match any element in the collection: <li>Video: video file</li> <li>Audio: audio file</li> <li>Image: image file</li></p>
        /// </summary>
        [JsonProperty("Categories")]
        public string[] Categories{ get; set; }

        /// <summary>
        /// <p>Tag set, match any element in the collection.</p><p>Input parameter limits: Single tag length limit: 32 characters. Array length limit: 16.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>Collection of people, matching recording clips where all input people appear</p><p>Input limit: array length limit: 16</p>
        /// </summary>
        [JsonProperty("Persons")]
        public string[] Persons{ get; set; }

        /// <summary>
        /// <p>Task type to search. Optional values: </p><ul><li>AiAnalysis.DescriptionTask </li><li>SmartSubtitle.AsrFullTextTask</li></ul>
        /// </summary>
        [JsonProperty("TaskTypes")]
        public string[] TaskTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "KnowledgeBaseId", this.KnowledgeBaseId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "Categories.", this.Categories);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "Persons.", this.Persons);
            this.SetParamArraySimple(map, prefix + "TaskTypes.", this.TaskTypes);
        }
    }
}

