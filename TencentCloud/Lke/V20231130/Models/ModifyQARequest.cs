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

    public class ModifyQARequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID.
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// Q&A ID.
        /// </summary>
        [JsonProperty("QaBizId")]
        public string QaBizId{ get; set; }

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
        /// Custom parameter.
        /// </summary>
        [JsonProperty("CustomParam")]
        public string CustomParam{ get; set; }

        /// <summary>
        /// Applicable scope of labels: 1. all; 2. by conditions.
        /// </summary>
        [JsonProperty("AttrRange")]
        public ulong? AttrRange{ get; set; }

        /// <summary>
        /// Label reference.
        /// </summary>
        [JsonProperty("AttrLabels")]
        public AttrLabelRefer[] AttrLabels{ get; set; }

        /// <summary>
        /// Document ID.
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// Category ID.
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// Effective start time, unix timestamp.
        /// </summary>
        [JsonProperty("ExpireStart")]
        public string ExpireStart{ get; set; }

        /// <summary>
        /// Effective end time, unix timestamp, 0 indicates permanent validity.
        /// </summary>
        [JsonProperty("ExpireEnd")]
        public string ExpireEnd{ get; set; }

        /// <summary>
        /// Similar question modification information (not passed if there is no modification to the similar question).
        /// </summary>
        [JsonProperty("SimilarQuestionModify")]
        public SimilarQuestionModify SimilarQuestionModify{ get; set; }

        /// <summary>
        /// Problem description.
        /// </summary>
        [JsonProperty("QuestionDesc")]
        public string QuestionDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "QaBizId", this.QaBizId);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
            this.SetParamSimple(map, prefix + "CustomParam", this.CustomParam);
            this.SetParamSimple(map, prefix + "AttrRange", this.AttrRange);
            this.SetParamArrayObj(map, prefix + "AttrLabels.", this.AttrLabels);
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamSimple(map, prefix + "ExpireStart", this.ExpireStart);
            this.SetParamSimple(map, prefix + "ExpireEnd", this.ExpireEnd);
            this.SetParamObj(map, prefix + "SimilarQuestionModify.", this.SimilarQuestionModify);
            this.SetParamSimple(map, prefix + "QuestionDesc", this.QuestionDesc);
        }
    }
}

