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

    public class ProcedureTemplate : AbstractModel
    {
        
        /// <summary>
        /// <p>Task flow name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Task flow template type. Valid values:</p><li>Preset: system preset task flow template.</li><li>Custom: user-defined task flow template.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Transcoding template description. Length limit: 256 characters.</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Video processing type task parameters.</p>
        /// </summary>
        [JsonProperty("MediaProcessTask")]
        public MediaProcessTaskInput MediaProcessTask{ get; set; }

        /// <summary>
        /// <p>AI moderation type task parameter *.<br><font color="red">*: This parameter is used to initiate legacy review and is not recommended. It is recommended to use the ReviewAudioVideoTask parameter to initiate review.</font></p>
        /// </summary>
        [JsonProperty("AiContentReviewTask")]
        public AiContentReviewTaskInput AiContentReviewTask{ get; set; }

        /// <summary>
        /// <p>Parameters for the AI intelligent content analysis task.</p>
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public AiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// <p>Parameters for the AI content detect-type task.</p>
        /// </summary>
        [JsonProperty("AiRecognitionTaskSet")]
        public AiRecognitionTaskInput[] AiRecognitionTaskSet{ get; set; }

        /// <summary>
        /// <p>This parameter is not recommended. Use AiRecognitionTaskSet instead.</p>
        /// </summary>
        [JsonProperty("AiRecognitionTask")]
        [System.Obsolete]
        public AiRecognitionTaskInput AiRecognitionTask{ get; set; }

        /// <summary>
        /// <p>WeChat Mini Program publishing task parameter.</p>
        /// </summary>
        [JsonProperty("MiniProgramPublishTask")]
        public WechatMiniProgramPublishTaskInput MiniProgramPublishTask{ get; set; }

        /// <summary>
        /// <p>Parameters for the audio and video moderation task.</p>
        /// </summary>
        [JsonProperty("ReviewAudioVideoTask")]
        public ProcedureReviewAudioVideoTaskInput ReviewAudioVideoTask{ get; set; }

        /// <summary>
        /// <p>Parameters for importing the Intelligent Media Assets knowledge base.</p>
        /// </summary>
        [JsonProperty("ImportMediaKnowledgeTaskSet")]
        public ImportMediaKnowledgeTaskInput[] ImportMediaKnowledgeTaskSet{ get; set; }

        /// <summary>
        /// <p>Template creation time, use <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Last template modification time, in <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "MediaProcessTask.", this.MediaProcessTask);
            this.SetParamObj(map, prefix + "AiContentReviewTask.", this.AiContentReviewTask);
            this.SetParamObj(map, prefix + "AiAnalysisTask.", this.AiAnalysisTask);
            this.SetParamArrayObj(map, prefix + "AiRecognitionTaskSet.", this.AiRecognitionTaskSet);
            this.SetParamObj(map, prefix + "AiRecognitionTask.", this.AiRecognitionTask);
            this.SetParamObj(map, prefix + "MiniProgramPublishTask.", this.MiniProgramPublishTask);
            this.SetParamObj(map, prefix + "ReviewAudioVideoTask.", this.ReviewAudioVideoTask);
            this.SetParamArrayObj(map, prefix + "ImportMediaKnowledgeTaskSet.", this.ImportMediaKnowledgeTaskSet);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

