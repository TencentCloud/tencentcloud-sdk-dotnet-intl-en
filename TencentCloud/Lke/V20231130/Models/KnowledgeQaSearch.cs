/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class KnowledgeQaSearch : AbstractModel
    {
        
        /// <summary>
        /// Knowledge source: doc (document), qa (question & answering), taskflow (business process), search (search enhancement).
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Q&A - reply flexibility, 1: directly reply if the answer has been accepted. 2: reply after the accepted answer has been polished.
        /// </summary>
        [JsonProperty("ReplyFlexibility")]
        public ulong? ReplyFlexibility{ get; set; }

        /// <summary>
        /// Search enhancement - search engine status.
        /// </summary>
        [JsonProperty("UseSearchEngine")]
        public bool? UseSearchEngine{ get; set; }

        /// <summary>
        /// Whether to display the search engine retrieval status.
        /// </summary>
        [JsonProperty("ShowSearchEngine")]
        public bool? ShowSearchEngine{ get; set; }

        /// <summary>
        /// Knowledge source, whether to select.
        /// </summary>
        [JsonProperty("IsEnabled")]
        public bool? IsEnabled{ get; set; }

        /// <summary>
        /// Maximum number of Q&A recalls, defaults to 2, limited to 5.
        /// </summary>
        [JsonProperty("QaTopN")]
        public ulong? QaTopN{ get; set; }

        /// <summary>
        /// Maximum number of documents recalls, defaults to 3, limited to 5.
        /// </summary>
        [JsonProperty("DocTopN")]
        public ulong? DocTopN{ get; set; }

        /// <summary>
        /// Retrieval confidence degree, valid for documents and Q&A. Value range: 0.01 - 0.99.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Resource status, 1: the resource is available; 2: the resource is exhausted.
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public ulong? ResourceStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ReplyFlexibility", this.ReplyFlexibility);
            this.SetParamSimple(map, prefix + "UseSearchEngine", this.UseSearchEngine);
            this.SetParamSimple(map, prefix + "ShowSearchEngine", this.ShowSearchEngine);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "QaTopN", this.QaTopN);
            this.SetParamSimple(map, prefix + "DocTopN", this.DocTopN);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
        }
    }
}

