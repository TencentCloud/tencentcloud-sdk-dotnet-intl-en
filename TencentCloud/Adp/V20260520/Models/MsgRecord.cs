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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MsgRecord : AbstractModel
    {
        
        /// <summary>
        /// Answer.
        /// </summary>
        [JsonProperty("Answer")]
        public string Answer{ get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// Category ID
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Intent.
        /// </summary>
        [JsonProperty("Intent")]
        public string Intent{ get; set; }

        /// <summary>
        /// Intent category
        /// </summary>
        [JsonProperty("IntentCategory")]
        public string IntentCategory{ get; set; }

        /// <summary>
        /// Whether it is intelligent categorization
        /// </summary>
        [JsonProperty("IsSmart")]
        public bool? IsSmart{ get; set; }

        /// <summary>
        /// Issue
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// Record ID
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// method. Enumerates ReplyMethod: 0=not specified, 1=direct reply by large model, 2=conservative reply, 3=refuse to answer, 4=sensitive reply, 5=Q&A pair prioritized reply, 6=welcome message, 7=concurrency limit exceeded, 8=global intervention knowledge, 9=task flow process reply, 10=task flow answer, 11=search engine, 12=knowledge polish, 13=image understanding, 14=real-time document, 15=clarification confirmation, 16=workflow reply, 17=workflow completion, 18=Intelligent Agent reply, 19=multiple intents, 20=interruption, 21=Intelligent Agent plan preview, 22=Intelligent Agent plan result, 23=Intelligent Agent structured output.
        /// </summary>
        [JsonProperty("ReplyMethod")]
        public long? ReplyMethod{ get; set; }

        /// <summary>
        /// Returned result
        /// </summary>
        [JsonProperty("Result")]
        public MsgRecordResult Result{ get; set; }

        /// <summary>
        /// Score
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// Session ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Source.
        /// </summary>
        [JsonProperty("Source")]
        public MsgRecordSource Source{ get; set; }

        /// <summary>
        /// trace_id
        /// </summary>
        [JsonProperty("TraceId")]
        public string TraceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Intent", this.Intent);
            this.SetParamSimple(map, prefix + "IntentCategory", this.IntentCategory);
            this.SetParamSimple(map, prefix + "IsSmart", this.IsSmart);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "ReplyMethod", this.ReplyMethod);
            this.SetParamObj(map, prefix + "Result.", this.Result);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamObj(map, prefix + "Source.", this.Source);
            this.SetParamSimple(map, prefix + "TraceId", this.TraceId);
        }
    }
}

