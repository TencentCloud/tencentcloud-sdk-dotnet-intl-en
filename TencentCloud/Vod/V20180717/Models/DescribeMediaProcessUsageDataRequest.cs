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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMediaProcessUsageDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Start date in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End date in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F). The end date must be on or after the start date.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Query the video processing task type. Currently supported task types include:
        /// <li> Transcoding: Normal transcoding</li>
        /// <li> Transcoding-TESHD: Extremely fast high-definition transcoding</li>
        /// <li> Editing : Video editing</li>
        /// <li> Editing-TESHD: Extremely fast high-definition video editing</li>
        /// <li> AdaptiveBitrateStreaming: Adaptive bitrate streaming</li>
        /// <li> ContentAudit: Content audit</li> li>
        /// <li> ContentRecognition: Content recognition</li>
        /// <li> RemoveWatermark: Remove watermark</li>
        /// <li> ExtractTraceWatermark: Extract watermark</li>
        /// <li> AddTraceWatermark: Add watermark </li>
        /// <li> RebuildMedia: Rebirth of audio and video quality</li>
        /// <li> QualityInspect: Media quality inspection</li>
        /// <li> VideoHighlight: Smart video collection</li>
        /// < li> VideoTag: Video smart tag</li>
        /// <li> VideoClassification: Video smart classification</li>
        /// <li> VideoCover: Video smart cover</li>
        /// <li> VideoSegment: Video smart split </li>
        /// <li>Transcode: transcoding, including normal transcoding, high-speed HD and video editing (not recommended)</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

