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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QuestionInfo : AbstractModel
    {
        
        /// <summary>
        /// The question ID.
        /// </summary>
        [JsonProperty("QuestionId")]
        public string QuestionId{ get; set; }

        /// <summary>
        /// The question.
        /// </summary>
        [JsonProperty("QuestionContent")]
        public string QuestionContent{ get; set; }

        /// <summary>
        /// The time limit for the question. If you set this parameter to `0`, there will not be a time limit.
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// The correct answer. Bits are used to indicate the options that should be chosen. For example, `0x1` indicates option A; `0x11` indicates A and B, and so on.
        /// </summary>
        [JsonProperty("CorrectAnswer")]
        public long? CorrectAnswer{ get; set; }

        /// <summary>
        /// The statistics for each type of answer.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AnswerStats")]
        public AnswerStat[] AnswerStats{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QuestionId", this.QuestionId);
            this.SetParamSimple(map, prefix + "QuestionContent", this.QuestionContent);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "CorrectAnswer", this.CorrectAnswer);
            this.SetParamArrayObj(map, prefix + "AnswerStats.", this.AnswerStats);
        }
    }
}

