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

    public class DocReference : AbstractModel
    {
        
        /// <summary>
        /// <p>Document business ID</p>
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// <p>Document fragment reference ID</p>
        /// </summary>
        [JsonProperty("ReferBizId")]
        public string ReferBizId{ get; set; }

        /// <summary>
        /// <p>Document name</p>
        /// </summary>
        [JsonProperty("DocName")]
        public string DocName{ get; set; }

        /// <summary>
        /// <p>Business ID of the knowledge base where the document resides</p>
        /// </summary>
        [JsonProperty("KnowledgeBizId")]
        public string KnowledgeBizId{ get; set; }

        /// <summary>
        /// <p>Name of the knowledge base where the document resides</p>
        /// </summary>
        [JsonProperty("KnowledgeName")]
        public string KnowledgeName{ get; set; }

        /// <summary>
        /// <p>Document Access Address</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "ReferBizId", this.ReferBizId);
            this.SetParamSimple(map, prefix + "DocName", this.DocName);
            this.SetParamSimple(map, prefix + "KnowledgeBizId", this.KnowledgeBizId);
            this.SetParamSimple(map, prefix + "KnowledgeName", this.KnowledgeName);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

