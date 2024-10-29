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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HlsRemuxSettingsInfo : AbstractModel
    {
        
        /// <summary>
        /// Segment duration in ms. Value range: [1000,30000]. Default value: 4000. The value can only be a multiple of 1,000.
        /// </summary>
        [JsonProperty("SegmentDuration")]
        public ulong? SegmentDuration{ get; set; }

        /// <summary>
        /// Number of segments. Value range: [3,30]. Default value: 5.
        /// </summary>
        [JsonProperty("SegmentNumber")]
        public ulong? SegmentNumber{ get; set; }

        /// <summary>
        /// Whether to enable PDT insertion. Valid values: CLOSE/OPEN. Default value: CLOSE.
        /// </summary>
        [JsonProperty("PdtInsertion")]
        public string PdtInsertion{ get; set; }

        /// <summary>
        /// PDT duration in seconds. Value range: (0,3000]. Default value: 600.
        /// </summary>
        [JsonProperty("PdtDuration")]
        public ulong? PdtDuration{ get; set; }

        /// <summary>
        /// Audio/Video packaging scheme. Valid values: `SEPARATE`, `MERGE`. Default value is: SEPARATE.
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// The segment type. Valid values: `ts` (default), `fmp4`.
        /// Currently, fMP4 segments do not support DRM or time shifting.
        /// </summary>
        [JsonProperty("SegmentType")]
        public string SegmentType{ get; set; }

        /// <summary>
        /// The HLS package type when the H.265 codec is used. Valid values: `hvc1`, `hev1` (default).
        /// </summary>
        [JsonProperty("H265PackageType")]
        public string H265PackageType{ get; set; }

        /// <summary>
        /// Whether to enable low latency 0:CLOSE, 1:OPEN, default value: 0.
        /// </summary>
        [JsonProperty("LowLatency")]
        public ulong? LowLatency{ get; set; }

        /// <summary>
        /// Low latency slice size, unit ms. Value range: integer [200-HlsRemuxSettings.SegmentDuration] Default value: 500ms.
        /// </summary>
        [JsonProperty("PartialSegmentDuration")]
        public ulong? PartialSegmentDuration{ get; set; }

        /// <summary>
        /// Low latency slice playback position, unit ms. Value range: integer [3*HlsRemuxSettings.PartiSegmentDuration - 3*HlsRemuxSettings.SegmentDuration], Default value: 3*HlsRemuxSettings.PartiSegmentDuration.
        /// </summary>
        [JsonProperty("PartialSegmentPlaySite")]
        public ulong? PartialSegmentPlaySite{ get; set; }

        /// <summary>
        /// Hls main m3u8 file sorting rules by bitrate, optional values: 1: video bitrate ascending order; 2: video bitrate descending order. Default value: 1.
        /// </summary>
        [JsonProperty("StreamOrder")]
        public ulong? StreamOrder{ get; set; }

        /// <summary>
        /// Whether the Hls main m3u8 file contains resolution information, optional values: 1: INCLUDE includes video resolution; 2: EXCLUDE does not include video resolution. Default value: 1.
        /// </summary>
        [JsonProperty("VideoResolution")]
        public ulong? VideoResolution{ get; set; }

        /// <summary>
        /// Whether to include the `EXT-X-ENDLIST` tag, 1 includes  `EXT-X-ENDLIST` tag, 2 does not include  `EXT-X-ENDLIST` tag; the default value is 1.
        /// </summary>
        [JsonProperty("EndListTag")]
        public long? EndListTag{ get; set; }


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
        }
    }
}

