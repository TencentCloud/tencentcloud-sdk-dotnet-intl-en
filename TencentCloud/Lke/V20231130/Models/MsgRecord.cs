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

    public class MsgRecord : AbstractModel
    {
        
        /// <summary>
        /// Content.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// The Session ID corresponding to the current record.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Record ID.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// Associated record ID.
        /// </summary>
        [JsonProperty("RelatedRecordId")]
        public string RelatedRecordId{ get; set; }

        /// <summary>
        /// Whether it is from oneself.
        /// </summary>
        [JsonProperty("IsFromSelf")]
        public bool? IsFromSelf{ get; set; }

        /// <summary>
        /// Sender name.
        /// </summary>
        [JsonProperty("FromName")]
        public string FromName{ get; set; }

        /// <summary>
        /// Avatar of the sender.
        /// </summary>
        [JsonProperty("FromAvatar")]
        public string FromAvatar{ get; set; }

        /// <summary>
        /// Timestamp.
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// Whether it is read.
        /// </summary>
        [JsonProperty("HasRead")]
        public bool? HasRead{ get; set; }

        /// <summary>
        /// Evaluation.
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// Whether to rate.
        /// </summary>
        [JsonProperty("CanRating")]
        public bool? CanRating{ get; set; }

        /// <summary>
        /// Whether to display the feedback button.
        /// </summary>
        [JsonProperty("CanFeedback")]
        public bool? CanFeedback{ get; set; }

        /// <summary>
        /// Record type.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Reference source.
        /// </summary>
        [JsonProperty("References")]
        public MsgRecordReference[] References{ get; set; }

        /// <summary>
        /// Reason for evaluation.
        /// </summary>
        [JsonProperty("Reasons")]
        public string[] Reasons{ get; set; }

        /// <summary>
        /// Whether it is a large model.
        /// </summary>
        [JsonProperty("IsLlmGenerated")]
        public bool? IsLlmGenerated{ get; set; }

        /// <summary>
        /// Image URL, which can be public read.
        /// </summary>
        [JsonProperty("ImageUrls")]
        public string[] ImageUrls{ get; set; }

        /// <summary>
        /// Statistical information of the current token.
        /// </summary>
        [JsonProperty("TokenStat")]
        public TokenStat TokenStat{ get; set; }

        /// <summary>
        /// Response method.
        /// 1: Large model directly replies.
        /// 2: Conservative reply, reply to unknown questions.
        /// 3: Reply to rejected question.
        /// 4: Sensitive response.
        /// 5: Directly reply to Q&A pairs. Priority will be given to answering the adopted Q&A pairs.
        /// 6: Reply with welcome words.
        /// 7: Reply for concurrency limit exceeded.
        /// 8: Global intervention knowledge.
        /// 9: Reply during the task flow process. When task_flow.type = 0 in history, it is a response from the large model.
        /// 10: Reply with task flow answer.
        /// 11: Reply from the search engine.
        /// 12: Reply after knowledge polishing.
        /// 13: Reply with image understanding.
        /// 14: Reply based on real-time document.
        /// </summary>
        [JsonProperty("ReplyMethod")]
        public ulong? ReplyMethod{ get; set; }

        /// <summary>
        /// Option tab, used for multi-round dialogue.
        /// </summary>
        [JsonProperty("OptionCards")]
        public string[] OptionCards{ get; set; }

        /// <summary>
        /// Task information.
        /// </summary>
        [JsonProperty("TaskFlow")]
        public TaskFlowInfo TaskFlow{ get; set; }

        /// <summary>
        /// File information passed in by the user.
        /// </summary>
        [JsonProperty("FileInfos")]
        public FileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// Location information of reference source .
        /// </summary>
        [JsonProperty("QuoteInfos")]
        public QuoteInfo[] QuoteInfos{ get; set; }

        /// <summary>
        /// Information on the thinking process of the agent.
        /// </summary>
        [JsonProperty("AgentThought")]
        public AgentThought AgentThought{ get; set; }

        /// <summary>
        /// Expanded information.
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public ExtraInfo ExtraInfo{ get; set; }

        /// <summary>
        /// Workflow information.
        /// </summary>
        [JsonProperty("WorkFlow")]
        public WorkflowInfo WorkFlow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "RelatedRecordId", this.RelatedRecordId);
            this.SetParamSimple(map, prefix + "IsFromSelf", this.IsFromSelf);
            this.SetParamSimple(map, prefix + "FromName", this.FromName);
            this.SetParamSimple(map, prefix + "FromAvatar", this.FromAvatar);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "HasRead", this.HasRead);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "CanRating", this.CanRating);
            this.SetParamSimple(map, prefix + "CanFeedback", this.CanFeedback);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "References.", this.References);
            this.SetParamArraySimple(map, prefix + "Reasons.", this.Reasons);
            this.SetParamSimple(map, prefix + "IsLlmGenerated", this.IsLlmGenerated);
            this.SetParamArraySimple(map, prefix + "ImageUrls.", this.ImageUrls);
            this.SetParamObj(map, prefix + "TokenStat.", this.TokenStat);
            this.SetParamSimple(map, prefix + "ReplyMethod", this.ReplyMethod);
            this.SetParamArraySimple(map, prefix + "OptionCards.", this.OptionCards);
            this.SetParamObj(map, prefix + "TaskFlow.", this.TaskFlow);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArrayObj(map, prefix + "QuoteInfos.", this.QuoteInfos);
            this.SetParamObj(map, prefix + "AgentThought.", this.AgentThought);
            this.SetParamObj(map, prefix + "ExtraInfo.", this.ExtraInfo);
            this.SetParamObj(map, prefix + "WorkFlow.", this.WorkFlow);
        }
    }
}

