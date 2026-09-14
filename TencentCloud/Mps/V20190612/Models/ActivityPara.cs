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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActivityPara : AbstractModel
    {
        
        /// <summary>
        /// <p>Video transcoding task</p>
        /// </summary>
        [JsonProperty("TranscodeTask")]
        public TranscodeTaskInput TranscodeTask{ get; set; }

        /// <summary>
        /// <p>Video-to-GIF task</p>
        /// </summary>
        [JsonProperty("AnimatedGraphicTask")]
        public AnimatedGraphicTaskInput AnimatedGraphicTask{ get; set; }

        /// <summary>
        /// <p>Video time point screenshot task</p>
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTask")]
        public SnapshotByTimeOffsetTaskInput SnapshotByTimeOffsetTask{ get; set; }

        /// <summary>
        /// <p>Video sampling screenshot task</p>
        /// </summary>
        [JsonProperty("SampleSnapshotTask")]
        public SampleSnapshotTaskInput SampleSnapshotTask{ get; set; }

        /// <summary>
        /// <p>Video image sprite task</p>
        /// </summary>
        [JsonProperty("ImageSpriteTask")]
        public ImageSpriteTaskInput ImageSpriteTask{ get; set; }

        /// <summary>
        /// <p>Adaptive bitrate streaming task</p>
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingTask")]
        public AdaptiveDynamicStreamingTaskInput AdaptiveDynamicStreamingTask{ get; set; }

        /// <summary>
        /// <p>Video content review task</p>
        /// </summary>
        [JsonProperty("AiContentReviewTask")]
        public AiContentReviewTaskInput AiContentReviewTask{ get; set; }

        /// <summary>
        /// <p>Video content analysis task</p>
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public AiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// <p>Video content recognition task</p>
        /// </summary>
        [JsonProperty("AiRecognitionTask")]
        public AiRecognitionTaskInput AiRecognitionTask{ get; set; }

        /// <summary>
        /// <p>Media quality inspection task</p>
        /// </summary>
        [JsonProperty("QualityControlTask")]
        public AiQualityControlTaskInput QualityControlTask{ get; set; }

        /// <summary>
        /// <p>Conditional judgment of the task.</p>
        /// </summary>
        [JsonProperty("ExecRulesTask")]
        public ExecRulesTask ExecRulesTask{ get; set; }

        /// <summary>
        /// <p>Smart subtitle task.</p>
        /// </summary>
        [JsonProperty("SmartSubtitlesTask")]
        public SmartSubtitlesTaskInput SmartSubtitlesTask{ get; set; }

        /// <summary>
        /// <p>Intelligent erasure task</p>
        /// </summary>
        [JsonProperty("SmartEraseTask")]
        public SmartEraseTaskInput SmartEraseTask{ get; set; }

        /// <summary>
        /// <p>AI Dubbing task.</p>
        /// </summary>
        [JsonProperty("AIDubbingTask")]
        public AIDubbingTaskInput AIDubbingTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TranscodeTask.", this.TranscodeTask);
            this.SetParamObj(map, prefix + "AnimatedGraphicTask.", this.AnimatedGraphicTask);
            this.SetParamObj(map, prefix + "SnapshotByTimeOffsetTask.", this.SnapshotByTimeOffsetTask);
            this.SetParamObj(map, prefix + "SampleSnapshotTask.", this.SampleSnapshotTask);
            this.SetParamObj(map, prefix + "ImageSpriteTask.", this.ImageSpriteTask);
            this.SetParamObj(map, prefix + "AdaptiveDynamicStreamingTask.", this.AdaptiveDynamicStreamingTask);
            this.SetParamObj(map, prefix + "AiContentReviewTask.", this.AiContentReviewTask);
            this.SetParamObj(map, prefix + "AiAnalysisTask.", this.AiAnalysisTask);
            this.SetParamObj(map, prefix + "AiRecognitionTask.", this.AiRecognitionTask);
            this.SetParamObj(map, prefix + "QualityControlTask.", this.QualityControlTask);
            this.SetParamObj(map, prefix + "ExecRulesTask.", this.ExecRulesTask);
            this.SetParamObj(map, prefix + "SmartSubtitlesTask.", this.SmartSubtitlesTask);
            this.SetParamObj(map, prefix + "SmartEraseTask.", this.SmartEraseTask);
            this.SetParamObj(map, prefix + "AIDubbingTask.", this.AIDubbingTask);
        }
    }
}

