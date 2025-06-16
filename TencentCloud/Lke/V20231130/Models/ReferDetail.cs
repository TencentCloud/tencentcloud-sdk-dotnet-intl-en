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

    public class ReferDetail : AbstractModel
    {
        
        /// <summary>
        /// Reference ID.
        /// </summary>
        [JsonProperty("ReferBizId")]
        public string ReferBizId{ get; set; }

        /// <summary>
        /// Document type (1: Q&A; 2: document paragraph).
        /// </summary>
        [JsonProperty("DocType")]
        public ulong? DocType{ get; set; }

        /// <summary>
        /// Document name.
        /// </summary>
        [JsonProperty("DocName")]
        public string DocName{ get; set; }

        /// <summary>
        /// Fragment content.
        /// </summary>
        [JsonProperty("PageContent")]
        public string PageContent{ get; set; }

        /// <summary>
        /// Question.
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// Answer.
        /// </summary>
        [JsonProperty("Answer")]
        public string Answer{ get; set; }

        /// <summary>
        /// Confidence.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Mark.
        /// </summary>
        [JsonProperty("Mark")]
        public ulong? Mark{ get; set; }

        /// <summary>
        /// Fragment highlight content.
        /// </summary>
        [JsonProperty("Highlights")]
        public Highlight[] Highlights{ get; set; }

        /// <summary>
        /// Original content.
        /// </summary>
        [JsonProperty("OrgData")]
        public string OrgData{ get; set; }

        /// <summary>
        /// Page number information.
        /// </summary>
        [JsonProperty("PageInfos")]
        public ulong?[] PageInfos{ get; set; }

        /// <summary>
        /// Sheet information.
        /// </summary>
        [JsonProperty("SheetInfos")]
        public string[] SheetInfos{ get; set; }

        /// <summary>
        /// Document ID.
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReferBizId", this.ReferBizId);
            this.SetParamSimple(map, prefix + "DocType", this.DocType);
            this.SetParamSimple(map, prefix + "DocName", this.DocName);
            this.SetParamSimple(map, prefix + "PageContent", this.PageContent);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Mark", this.Mark);
            this.SetParamArrayObj(map, prefix + "Highlights.", this.Highlights);
            this.SetParamSimple(map, prefix + "OrgData", this.OrgData);
            this.SetParamArraySimple(map, prefix + "PageInfos.", this.PageInfos);
            this.SetParamArraySimple(map, prefix + "SheetInfos.", this.SheetInfos);
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
        }
    }
}

