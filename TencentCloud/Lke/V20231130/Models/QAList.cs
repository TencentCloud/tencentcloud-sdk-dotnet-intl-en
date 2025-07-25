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

    public class QAList : AbstractModel
    {
        
        /// <summary>
        /// Q&A ID.
        /// </summary>
        [JsonProperty("QaBizId")]
        public string QaBizId{ get; set; }

        /// <summary>
        /// Whether to accept.
        /// </summary>
        [JsonProperty("IsAccepted")]
        public bool? IsAccepted{ get; set; }

        /// <summary>
        /// Category ID.
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QaBizId", this.QaBizId);
            this.SetParamSimple(map, prefix + "IsAccepted", this.IsAccepted);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
        }
    }
}

