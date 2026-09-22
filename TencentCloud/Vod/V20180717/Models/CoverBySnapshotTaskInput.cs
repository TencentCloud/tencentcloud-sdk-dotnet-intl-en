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

    public class CoverBySnapshotTaskInput : AbstractModel
    {
        
        /// <summary>
        /// Time point screenshot template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Screenshot type. Valid values:
        /// <li>Time: time point screencapturing</li>
        /// <li>Percent: screenshot by percentage</li>
        /// </summary>
        [JsonProperty("PositionType")]
        public string PositionType{ get; set; }

        /// <summary>
        /// Screenshot position:
        /// <li>For time point screenshot taking, this value indicates the second of the specified video to use as the cover</li>
        /// <li>For percentage-based screenshots, this value indicates the percentage of the video used as the cover.</li>
        /// </summary>
        [JsonProperty("PositionValue")]
        public float? PositionValue{ get; set; }

        /// <summary>
        /// Watermark list. Multiple image or text watermarks up to a maximum of 10 are supported.
        /// </summary>
        [JsonProperty("WatermarkSet")]
        public WatermarkInput[] WatermarkSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "PositionType", this.PositionType);
            this.SetParamSimple(map, prefix + "PositionValue", this.PositionValue);
            this.SetParamArrayObj(map, prefix + "WatermarkSet.", this.WatermarkSet);
        }
    }
}

