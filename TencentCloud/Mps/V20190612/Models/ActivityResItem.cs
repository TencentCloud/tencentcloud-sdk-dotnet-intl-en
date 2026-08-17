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
        /// 
        /// </summary>
        [JsonProperty("TranscodeTask")]
        public MediaProcessTaskTranscodeResult TranscodeTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AnimatedGraphicTask")]
        public MediaProcessTaskAnimatedGraphicResult AnimatedGraphicTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTask")]
        public MediaProcessTaskSnapshotByTimeOffsetResult SnapshotByTimeOffsetTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SampleSnapshotTask")]
        public MediaProcessTaskSampleSnapshotResult SampleSnapshotTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ImageSpriteTask")]
        public MediaProcessTaskImageSpriteResult ImageSpriteTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingTask")]
        public MediaProcessTaskAdaptiveDynamicStreamingResult AdaptiveDynamicStreamingTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RecognitionTask")]
        public ScheduleRecognitionTaskResult RecognitionTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReviewTask")]
        public ScheduleReviewTaskResult ReviewTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AnalysisTask")]
        public ScheduleAnalysisTaskResult AnalysisTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("QualityControlTask")]
        public ScheduleQualityControlTaskResult QualityControlTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExecRuleTask")]
        public ScheduleExecRuleTaskResult ExecRuleTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SmartSubtitlesTask")]
        public ScheduleSmartSubtitleTaskResult SmartSubtitlesTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SmartEraseTask")]
        public SmartEraseTaskResult SmartEraseTask{ get; set; }


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
            this.SetParamObj(map, prefix + "SmartEraseTask.", this.SmartEraseTask);
        }
    }
}

