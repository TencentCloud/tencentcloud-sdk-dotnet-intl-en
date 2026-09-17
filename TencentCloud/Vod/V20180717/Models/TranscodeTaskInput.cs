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
        /// 
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("WatermarkSet")]
        public WatermarkInput[] WatermarkSet{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TraceWatermark")]
        public TraceWatermarkInput TraceWatermark{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CopyRightWatermark")]
        public CopyRightWatermarkInput CopyRightWatermark{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BlindWatermark")]
        public BlindWatermarkInput BlindWatermark{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MosaicSet")]
        public MosaicInput[] MosaicSet{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HeadTailSet")]
        public HeadTailTaskInput[] HeadTailSet{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OverrideParameter")]
        public OverrideTranscodeParameter OverrideParameter{ get; set; }

        /// <summary>
        /// 
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
            this.SetParamObj(map, prefix + "OverrideParameter.", this.OverrideParameter);
            this.SetParamArrayObj(map, prefix + "SubtitleInfoSet.", this.SubtitleInfoSet);
        }
    }
}

