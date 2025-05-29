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

    public class QAQuery : AbstractModel
    {
        
        /// <summary>
        /// Page number.
        /// 
        /// 
        /// 
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// Number of items per page.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Application ID.
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// Query content.
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// Category ID.
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// Verification status.
        /// </summary>
        [JsonProperty("AcceptStatus")]
        public ulong?[] AcceptStatus{ get; set; }

        /// <summary>
        /// Release status.
        /// </summary>
        [JsonProperty("ReleaseStatus")]
        public ulong?[] ReleaseStatus{ get; set; }

        /// <summary>
        /// Document ID.
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// Q&A ID.
        /// </summary>
        [JsonProperty("QaBizId")]
        public string QaBizId{ get; set; }

        /// <summary>
        /// Source.
        /// 
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }

        /// <summary>
        /// Query an answer.
        /// </summary>
        [JsonProperty("QueryAnswer")]
        public string QueryAnswer{ get; set; }

        /// <summary>
        /// Query type: filename, attribute label.
        /// </summary>
        [JsonProperty("QueryType")]
        public string QueryType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamArraySimple(map, prefix + "AcceptStatus.", this.AcceptStatus);
            this.SetParamArraySimple(map, prefix + "ReleaseStatus.", this.ReleaseStatus);
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "QaBizId", this.QaBizId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "QueryAnswer", this.QueryAnswer);
            this.SetParamSimple(map, prefix + "QueryType", this.QueryType);
        }
    }
}

