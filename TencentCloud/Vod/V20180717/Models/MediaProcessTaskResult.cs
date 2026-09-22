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

    public class MediaProcessTaskResult : AbstractModel
    {
        
        /// <summary>
        /// Task type. Valid values:
        /// <li>Transcode: transcode</li>
        /// <li>AnimatedGraphics: animated image</li>
        /// <li>SnapshotByTimeOffset: time point screenshot.</li>
        /// <li>SampleSnapshot: sampled screenshot.</li>
        /// <li>ImageSprites: sprite sheet</li>
        /// <li>CoverBySnapshot: screencapturing for cover image</li>
        /// <li>AdaptiveDynamicStreaming: adaptive bitrate streaming</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Query result of a video transcoding task. Valid when the task type is Transcode.
        /// </summary>
        [JsonProperty("TranscodeTask")]
        public MediaProcessTaskTranscodeResult TranscodeTask{ get; set; }

        /// <summary>
        /// Query result of a video-to-GIF task. Valid when the task type is AnimatedGraphics.
        /// </summary>
        [JsonProperty("AnimatedGraphicTask")]
        public MediaProcessTaskAnimatedGraphicResult AnimatedGraphicTask{ get; set; }

        /// <summary>
        /// Query result of a video time point screenshot task. Valid when the task type is `SnapshotByTimeOffset`.
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTask")]
        public MediaProcessTaskSnapshotByTimeOffsetResult SnapshotByTimeOffsetTask{ get; set; }

        /// <summary>
        /// Query result of the video sampling screenshot task. Valid when the task type is `SampleSnapshot`.
        /// </summary>
        [JsonProperty("SampleSnapshotTask")]
        public MediaProcessTaskSampleSnapshotResult SampleSnapshotTask{ get; set; }

        /// <summary>
        /// Query result of the image sprite task for a video. Valid when the task type is `ImageSprite`.
        /// </summary>
        [JsonProperty("ImageSpriteTask")]
        public MediaProcessTaskImageSpriteResult ImageSpriteTask{ get; set; }

        /// <summary>
        /// Query result of the video screencapturing for cover image task. Valid when the task type is `CoverBySnapshot`.
        /// </summary>
        [JsonProperty("CoverBySnapshotTask")]
        public MediaProcessTaskCoverBySnapshotResult CoverBySnapshotTask{ get; set; }

        /// <summary>
        /// Query result of the video to adaptive streaming task. Valid when the task type is AdaptiveDynamicStreaming.
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingTask")]
        public MediaProcessTaskAdaptiveDynamicStreamingResult AdaptiveDynamicStreamingTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "TranscodeTask.", this.TranscodeTask);
            this.SetParamObj(map, prefix + "AnimatedGraphicTask.", this.AnimatedGraphicTask);
            this.SetParamObj(map, prefix + "SnapshotByTimeOffsetTask.", this.SnapshotByTimeOffsetTask);
            this.SetParamObj(map, prefix + "SampleSnapshotTask.", this.SampleSnapshotTask);
            this.SetParamObj(map, prefix + "ImageSpriteTask.", this.ImageSpriteTask);
            this.SetParamObj(map, prefix + "CoverBySnapshotTask.", this.CoverBySnapshotTask);
            this.SetParamObj(map, prefix + "AdaptiveDynamicStreamingTask.", this.AdaptiveDynamicStreamingTask);
        }
    }
}

