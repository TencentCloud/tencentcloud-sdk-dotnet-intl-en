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

    public class TaskStatData : AbstractModel
    {
        
        /// <summary>
        /// Task Type.
        /// <li> Transcoding: Normal transcoding</li>
        /// <li> Transcoding-TESHD: Extremely fast high-definition transcoding</li>
        /// <li> Editing: Video editing</li>
        /// < li> Editing-TESHD: Extremely fast high-definition video editing</li>
        /// <li> AdaptiveBitrateStreaming: Adaptive bitrate streaming</li>
        /// <li> ContentAudit: Content audit</li>
        /// <li> ContentRecognition: Content Recognize</li>
        /// <li> RemoveWatermark: Remove watermark</li>
        /// <li> ExtractTraceWatermark: Extract watermark</li>
        /// <li> AddTraceWatermark: Add watermark</li>
        /// <li> RebuildMedia : Audio and video quality reborn</li>
        /// <li> QualityInspect: Media quality inspection</li>
        /// <li>Transcode: transcoding, including normal transcoding, ultra-fast high-definition and video editing (not recommended)</li>
        /// <li>Transcode: li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Task statistics overview (usage unit: second).
        /// </summary>
        [JsonProperty("Summary")]
        public TaskStatDataItem[] Summary{ get; set; }

        /// <summary>
        /// The usage statistics for different task types.
        /// Transcoding:
        /// <li>`Remuxing`</li>
        /// <li>`Audio` (audio transcoding)</li>
        /// <li>`Standard.H264.SD`</li>
        /// <li>`Standard.H264.HD`</li>
        /// <li>`Standard.H264.FHD`</li>
        /// <li>`Standard.H264.2K`</li>
        /// <li>`Standard.H264.4K`</li>
        /// <li>`Standard.H265.SD`</li>
        /// <li>`Standard.H265.HD`</li>
        /// <li>`Standard.H265.FHD`</li>
        /// <li>`Standard.H265.2K`</li>
        /// <li>`Standard.H265.4K`</li>
        /// <li>`TESHD-10.H264.SD` (H.264 SD Top Speed Codec transcoding)</li>
        /// <li>`TESHD-10.H264.HD` (H.264 HD Top Speed Codec transcoding)</li>
        /// <li>`TESHD-10.H264.FHD` (H.264 FHD Top Speed Codec transcoding)</li>
        /// <li>`TESHD-10.H264.2K` (H.264 2K Top Speed Codec transcoding)</li>
        /// <li>`TESHD-10.H264.4K` (H.264 4K Top Speed Codec transcoding)</li>
        /// <li>`TESHD-10.H265.SD` (H.265 SD Top Speed Codec transcoding)</li>
        /// <li>`TESHD-10.H265.HD` (H.265 HD Top Speed Codec transcoding)</li>
        /// <li>`TESHD-10.H265.FHD` (H.265 FHD Top Speed Codec transcoding)</li>
        /// <li>`TESHD-10.H265.2K` (H.265 2K Top Speed Codec transcoding)</li>
        /// <li>`TESHD-10.H265.4K` (H.265 4K Top Speed Codec transcoding)</li>
        /// <li>`Edit.Audio`</li>
        /// <li>`Edit.H264.SD` (H.264 SD video editing)</li>
        /// <li>`Edit.H264.HD` (H.264 HD video editing)</li>
        /// <li>`Edit.H264.FHD` (H.264 FHD video editing)</li>
        /// <li>`Edit.H264.2K` (H.264 2K video editing)</li>
        /// <li>`Edit.H264.4K` (H.264 4K video editing)</li>
        /// <li>`Edit.H265.SD` (H.265 SD video editing)</li>
        /// <li>`Edit.H265.HD` (H.265 HD video editing)</li>
        /// <li>`Edit.H265.FHD` (H.265 FHD video editing)</li>
        /// <li>`Edit.H265.2K` (H.265 2K video editing)</li>
        /// <li>`Edit.H265.4K` (H.265 4K video editing)</li>
        /// <li>`Edit.TESHD-10.H264.SD` (H.264 SD Top Speed Codec video editing)</li>
        /// <li>`Edit.TESHD-10.H264.HD` (H.264 HD Top Speed Codec video editing)</li>
        /// <li>`Edit.TESHD-10.H264.FHD` (H.264 FHD Top Speed Codec video editing)</li>
        /// <li>`Edit.TESHD-10.H264.2K` (H.264 2K Top Speed Codec video editing)</li>
        /// <li>`Edit.TESHD-10.H264.4K` (H.264 4K Top Speed Codec video editing)</li>
        /// <li>`Edit.TESHD-10.H265.SD` (H.265 SD Top Speed Codec video editing)</li>
        /// <li>`Edit.TESHD-10.H265.HD` (H.265 HD Top Speed Codec video editing)</li>
        /// <li>`Edit.TESHD-10.H265.FHD` (H.265 FHD Top Speed Codec video editing)</li>
        /// <li>`Edit.TESHD-10.H265.2K` (H.265 2K Top Speed Codec video editing)</li>
        /// <li>`Edit.TESHD-10.H265.4K` (H.265 4K Top Speed Codec video editing)</li>
        /// The watermark removal/remaster specifications. Valid values:
        /// <li>`480P` (short side ≤ 480 px)</li>
        /// <li>`720P` (short side ≤ 720 px)</li>
        /// <li>`1080P` (short side ≤ 1080 px)</li>
        /// <li>`2K` (short side ≤ 1440 px)</li>
        /// <li>`4K` (short side ≤ 2160 px)</li>
        /// <li>`8K` (short side ≤ 4320 px)</li>
        /// <li>`audio`</li>
        /// </summary>
        [JsonProperty("Details")]
        public SpecificationDataItem[] Details{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArrayObj(map, prefix + "Summary.", this.Summary);
            this.SetParamArrayObj(map, prefix + "Details.", this.Details);
        }
    }
}

