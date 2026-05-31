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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HlsRemuxSettingsInfo : AbstractModel
    {
        
        /// <summary>
        /// Segment duration in milliseconds. Input range is [1000, 30000], default 4000, can only be a multiple of 1000.
        /// </summary>
        [JsonProperty("SegmentDuration")]
        public ulong? SegmentDuration{ get; set; }

        /// <summary>
        /// Number of shards. Input range [3, 30]. Default is 5.
        /// </summary>
        [JsonProperty("SegmentNumber")]
        public ulong? SegmentNumber{ get; set; }

        /// <summary>
        /// Whether to enable Pdt insertion. CLOSE/OPEN. Default is CLOSE.
        /// </summary>
        [JsonProperty("PdtInsertion")]
        public string PdtInsertion{ get; set; }

        /// <summary>
        /// Pdt duration in seconds. Input range (0, 3000]. Default 600.
        /// </summary>
        [JsonProperty("PdtDuration")]
        public ulong? PdtDuration{ get; set; }

        /// <summary>
        /// Video packaging type, selectable SEPARATE|MERGE.
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// Segment type, supports [ts|fmp4], default ts.
        /// fmp4 does not currently support DRM and time shifting.
        /// </summary>
        [JsonProperty("SegmentType")]
        public string SegmentType{ get; set; }

        /// <summary>
        /// When the transcoding type is H265, the HLS H265 encapsulation type is selectable [hvc1|hev1], default is hev1.
        /// </summary>
        [JsonProperty("H265PackageType")]
        public string H265PackageType{ get; set; }

        /// <summary>
        /// Whether to enable low delay. 0:CLOSE. Default is 0. 1:OPEN.
        /// </summary>
        [JsonProperty("LowLatency")]
        public ulong? LowLatency{ get; set; }

        /// <summary>
        /// Small slice size in milliseconds. Value ranges from 200 to SegmentDuration (integer). Default value: 500 ms.
        /// </summary>
        [JsonProperty("PartialSegmentDuration")]
        public ulong? PartialSegmentDuration{ get; set; }

        /// <summary>
        /// Small slice playback position in milliseconds. Value ranges from 3*PartiSegmentDuration to 3*SegmentDuration (integer). Default value: 3*PartiSegmentDuration.
        /// </summary>
        [JsonProperty("PartialSegmentPlaySite")]
        public ulong? PartialSegmentPlaySite{ get; set; }

        /// <summary>
        /// Hls master m3u8 file sorting rule by bitrate. Available values:
        /// 1: Video bitrate ascending 2: Video bitrate descending
        /// Default value: 1
        /// </summary>
        [JsonProperty("StreamOrder")]
        public ulong? StreamOrder{ get; set; }

        /// <summary>
        /// Whether the Hls master m3u8 file contains resolution information. Available values:
        /// 1: INCLUDE includes video resolution 2: EXCLUDE excludes video resolution.
        /// Default value: 1.
        /// </summary>
        [JsonProperty("VideoResolution")]
        public ulong? VideoResolution{ get; set; }

        /// <summary>
        /// Whether the content contains the `EXT-X-ENDLIST` tag. 1: contains; 2: does not contain. Default: 1.
        /// </summary>
        [JsonProperty("EndListTag")]
        public long? EndListTag{ get; set; }

        /// <summary>
        /// Option: `ENHANCED_SCTE35`, `DATERANGE`; default `ENHANCED_SCTE35`.
        /// </summary>
        [JsonProperty("AdMarkupType")]
        public string AdMarkupType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SegmentDuration", this.SegmentDuration);
            this.SetParamSimple(map, prefix + "SegmentNumber", this.SegmentNumber);
            this.SetParamSimple(map, prefix + "PdtInsertion", this.PdtInsertion);
            this.SetParamSimple(map, prefix + "PdtDuration", this.PdtDuration);
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
            this.SetParamSimple(map, prefix + "H265PackageType", this.H265PackageType);
            this.SetParamSimple(map, prefix + "LowLatency", this.LowLatency);
            this.SetParamSimple(map, prefix + "PartialSegmentDuration", this.PartialSegmentDuration);
            this.SetParamSimple(map, prefix + "PartialSegmentPlaySite", this.PartialSegmentPlaySite);
            this.SetParamSimple(map, prefix + "StreamOrder", this.StreamOrder);
            this.SetParamSimple(map, prefix + "VideoResolution", this.VideoResolution);
            this.SetParamSimple(map, prefix + "EndListTag", this.EndListTag);
            this.SetParamSimple(map, prefix + "AdMarkupType", this.AdMarkupType);
        }
    }
}

