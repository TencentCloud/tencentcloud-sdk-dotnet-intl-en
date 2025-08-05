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

    public class ActivityResItem : AbstractModel
    {
        
        /// <summary>
        /// The result of a transcoding task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranscodeTask")]
        public MediaProcessTaskTranscodeResult TranscodeTask{ get; set; }

        /// <summary>
        /// The result of an animated image generating task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AnimatedGraphicTask")]
        public MediaProcessTaskAnimatedGraphicResult AnimatedGraphicTask{ get; set; }

        /// <summary>
        /// The result of a time point screenshot task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTask")]
        public MediaProcessTaskSnapshotByTimeOffsetResult SnapshotByTimeOffsetTask{ get; set; }

        /// <summary>
        /// The result of a sampled screenshot task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SampleSnapshotTask")]
        public MediaProcessTaskSampleSnapshotResult SampleSnapshotTask{ get; set; }

        /// <summary>
        /// The result of an image sprite task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageSpriteTask")]
        public MediaProcessTaskImageSpriteResult ImageSpriteTask{ get; set; }

        /// <summary>
        /// The result of an adaptive bitrate streaming task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingTask")]
        public MediaProcessTaskAdaptiveDynamicStreamingResult AdaptiveDynamicStreamingTask{ get; set; }

        /// <summary>
        /// The result of a content recognition task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecognitionTask")]
        public ScheduleRecognitionTaskResult RecognitionTask{ get; set; }

        /// <summary>
        /// The result of a content moderation task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReviewTask")]
        public ScheduleReviewTaskResult ReviewTask{ get; set; }

        /// <summary>
        /// The result of a content analysis task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AnalysisTask")]
        public ScheduleAnalysisTaskResult AnalysisTask{ get; set; }

        /// <summary>
        /// Media quality inspection task output.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QualityControlTask")]
        public ScheduleQualityControlTaskResult QualityControlTask{ get; set; }

        /// <summary>
        /// Conditional judgment task output.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExecRuleTask")]
        public ScheduleExecRuleTaskResult ExecRuleTask{ get; set; }

        /// <summary>
        /// Smart subtitle task output.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SmartSubtitlesTask")]
        public ScheduleSmartSubtitleTaskResult SmartSubtitlesTask{ get; set; }


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
            this.SetParamObj(map, prefix + "RecognitionTask.", this.RecognitionTask);
            this.SetParamObj(map, prefix + "ReviewTask.", this.ReviewTask);
            this.SetParamObj(map, prefix + "AnalysisTask.", this.AnalysisTask);
            this.SetParamObj(map, prefix + "QualityControlTask.", this.QualityControlTask);
            this.SetParamObj(map, prefix + "ExecRuleTask.", this.ExecRuleTask);
            this.SetParamObj(map, prefix + "SmartSubtitlesTask.", this.SmartSubtitlesTask);
        }
    }
}

