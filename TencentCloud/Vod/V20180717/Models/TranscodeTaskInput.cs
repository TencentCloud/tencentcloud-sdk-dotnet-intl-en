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

    public class TranscodeTaskInput : AbstractModel
    {
        
        /// <summary>
        /// <p>Video transcoding template ID.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// <p>Watermark list. Up to 10 image or text watermarks are supported.</p>
        /// </summary>
        [JsonProperty("WatermarkSet")]
        public WatermarkInput[] WatermarkSet{ get; set; }

        /// <summary>
        /// <p>Traceable watermark.</p>
        /// </summary>
        [JsonProperty("TraceWatermark")]
        public TraceWatermarkInput TraceWatermark{ get; set; }

        /// <summary>
        /// <p>Copyright watermark.</p>
        /// </summary>
        [JsonProperty("CopyRightWatermark")]
        public CopyRightWatermarkInput CopyRightWatermark{ get; set; }

        /// <summary>
        /// <p>Digital watermark.</p>
        /// </summary>
        [JsonProperty("BlindWatermark")]
        public BlindWatermarkInput BlindWatermark{ get; set; }

        /// <summary>
        /// <p>Mosaic list. Up to 10 are supported.</p>
        /// </summary>
        [JsonProperty("MosaicSet")]
        public MosaicInput[] MosaicSet{ get; set; }

        /// <summary>
        /// <p>Opening and ending list. Up to 10 opening and ending sequences are supported.</p>
        /// </summary>
        [JsonProperty("HeadTailSet")]
        public HeadTailTaskInput[] HeadTailSet{ get; set; }

        /// <summary>
        /// <p>Start time offset of the transcoded video, unit: second.</p><li>Leave it blank or enter 0 means the transcoded video starts from the start position of the original video.</li><li>When the value is greater than 0 (assume it is n), it means the transcoded video starts from the nth second position of the original video.</li><li>When the value is less than 0 (assume it is -n), it means the transcoded video starts from the position n seconds before the end of the original video.</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// <p>Offset of the termination time of the transcoded video, unit: second.</p><li>Leave it blank or enter 0 means the transcoded video lasts until the end of the original video.</li><li>When the value is greater than 0 (assume it is n), it means the transcoded video lasts until the nth second of the original video.</li><li>When the value is less than 0 (assume it is -n), it means the transcoded video lasts until n seconds before the end of the original video.</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// <p>List of subtitle suppression information. Up to 2 are supported.</p>
        /// </summary>
        [JsonProperty("SubtitleInfoSet")]
        public SubtitleInfoInput[] SubtitleInfoSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamArrayObj(map, prefix + "WatermarkSet.", this.WatermarkSet);
            this.SetParamObj(map, prefix + "TraceWatermark.", this.TraceWatermark);
            this.SetParamObj(map, prefix + "CopyRightWatermark.", this.CopyRightWatermark);
            this.SetParamObj(map, prefix + "BlindWatermark.", this.BlindWatermark);
            this.SetParamArrayObj(map, prefix + "MosaicSet.", this.MosaicSet);
            this.SetParamArrayObj(map, prefix + "HeadTailSet.", this.HeadTailSet);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamArrayObj(map, prefix + "SubtitleInfoSet.", this.SubtitleInfoSet);
        }
    }
}

