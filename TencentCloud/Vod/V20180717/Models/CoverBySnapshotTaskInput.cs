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

    public class CoverBySnapshotTaskInput : AbstractModel
    {
        
        /// <summary>
        /// Time point screencapturing template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Screencapturing mode. Valid values:
        /// <li>Time: screencaptures by time point</li>
        /// <li>Percent: screencaptures by percentage</li>
        /// </summary>
        [JsonProperty("PositionType")]
        public string PositionType{ get; set; }

        /// <summary>
        /// Screenshot position:
        /// <li>For time point screencapturing, this means to take a screenshot at a specified time point (in seconds) and use it as the cover</li>
        /// <li>For percentage screencapturing, this value means to take a screenshot at a specified percentage of the video duration and use it as the cover</li>
        /// </summary>
        [JsonProperty("PositionValue")]
        public float? PositionValue{ get; set; }

        /// <summary>
        /// List of up to 10 image or text watermarks.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WatermarkSet")]
        public WatermarkInput[] WatermarkSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "PositionType", this.PositionType);
            this.SetParamSimple(map, prefix + "PositionValue", this.PositionValue);
            this.SetParamArrayObj(map, prefix + "WatermarkSet.", this.WatermarkSet);
        }
    }
}

