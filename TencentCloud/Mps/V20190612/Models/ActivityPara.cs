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
        /// A transcoding task.
        /// </summary>
        [JsonProperty("TranscodeTask")]
        public TranscodeTaskInput TranscodeTask{ get; set; }

        /// <summary>
        /// An animated screenshot generation task.
        /// </summary>
        [JsonProperty("AnimatedGraphicTask")]
        public AnimatedGraphicTaskInput AnimatedGraphicTask{ get; set; }

        /// <summary>
        /// A time point screenshot task.
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTask")]
        public SnapshotByTimeOffsetTaskInput SnapshotByTimeOffsetTask{ get; set; }

        /// <summary>
        /// A sampled screenshot task.
        /// </summary>
        [JsonProperty("SampleSnapshotTask")]
        public SampleSnapshotTaskInput SampleSnapshotTask{ get; set; }

        /// <summary>
        /// An image sprite screenshot task.
        /// </summary>
        [JsonProperty("ImageSpriteTask")]
        public ImageSpriteTaskInput ImageSpriteTask{ get; set; }

        /// <summary>
        /// An adaptive bitrate streaming task.
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingTask")]
        public AdaptiveDynamicStreamingTaskInput AdaptiveDynamicStreamingTask{ get; set; }

        /// <summary>
        /// A content moderation task.
        /// </summary>
        [JsonProperty("AiContentReviewTask")]
        public AiContentReviewTaskInput AiContentReviewTask{ get; set; }

        /// <summary>
        /// A content analysis task.
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public AiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// A content recognition task.
        /// </summary>
        [JsonProperty("AiRecognitionTask")]
        public AiRecognitionTaskInput AiRecognitionTask{ get; set; }

        /// <summary>
        /// Media quality inspection task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QualityControlTask")]
        public AiQualityControlTaskInput QualityControlTask{ get; set; }

        /// <summary>
        /// Smart subtitle task.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SmartSubtitlesTask")]
        public SmartSubtitlesTaskInput SmartSubtitlesTask{ get; set; }


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
            this.SetParamObj(map, prefix + "SmartSubtitlesTask.", this.SmartSubtitlesTask);
        }
    }
}

