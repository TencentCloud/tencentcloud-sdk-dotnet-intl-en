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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaProcessTaskInput : AbstractModel
    {
        
        /// <summary>
        /// List of transcoding tasks.
        /// </summary>
        [JsonProperty("TranscodeTaskSet")]
        public TranscodeTaskInput[] TranscodeTaskSet{ get; set; }

        /// <summary>
        /// List of animated image screenshot tasks.
        /// </summary>
        [JsonProperty("AnimatedGraphicTaskSet")]
        public AnimatedGraphicTaskInput[] AnimatedGraphicTaskSet{ get; set; }

        /// <summary>
        /// List of time point screenshot tasks.
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTaskSet")]
        public SnapshotByTimeOffsetTaskInput[] SnapshotByTimeOffsetTaskSet{ get; set; }

        /// <summary>
        /// List of sampled screenshot tasks.
        /// </summary>
        [JsonProperty("SampleSnapshotTaskSet")]
        public SampleSnapshotTaskInput[] SampleSnapshotTaskSet{ get; set; }

        /// <summary>
        /// List of image sprite screenshot tasks.
        /// </summary>
        [JsonProperty("ImageSpriteTaskSet")]
        public ImageSpriteTaskInput[] ImageSpriteTaskSet{ get; set; }

        /// <summary>
        /// List of adaptive bitrate streaming tasks.
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingTaskSet")]
        public AdaptiveDynamicStreamingTaskInput[] AdaptiveDynamicStreamingTaskSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TranscodeTaskSet.", this.TranscodeTaskSet);
            this.SetParamArrayObj(map, prefix + "AnimatedGraphicTaskSet.", this.AnimatedGraphicTaskSet);
            this.SetParamArrayObj(map, prefix + "SnapshotByTimeOffsetTaskSet.", this.SnapshotByTimeOffsetTaskSet);
            this.SetParamArrayObj(map, prefix + "SampleSnapshotTaskSet.", this.SampleSnapshotTaskSet);
            this.SetParamArrayObj(map, prefix + "ImageSpriteTaskSet.", this.ImageSpriteTaskSet);
            this.SetParamArrayObj(map, prefix + "AdaptiveDynamicStreamingTaskSet.", this.AdaptiveDynamicStreamingTaskSet);
        }
    }
}

