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

    public class StickerTrackItem : AbstractModel
    {
        
        /// <summary>
        /// Source of media file for sticker material, which can be an ID of a VOD file or URL of another file.
        /// </summary>
        [JsonProperty("SourceMedia")]
        public string SourceMedia{ get; set; }

        /// <summary>
        /// Sticker duration in seconds.
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// Start time of sticker on track in seconds.
        /// </summary>
        [JsonProperty("StartTime")]
        public float? StartTime{ get; set; }

        /// <summary>
        /// Origin position. Valid values:
        /// <li> Center: the origin of coordinates is the center position, such as the center of canvas.</li>
        /// Default value: Center.
        /// </summary>
        [JsonProperty("CoordinateOrigin")]
        public string CoordinateOrigin{ get; set; }

        /// <summary>
        /// The horizontal position of the origin of the sticker relative to the origin of the canvas. % and px formats are supported:
        /// <li>If the string ends in %, the `XPos` of the sticker will be at the position of the specified percentage of the canvas width; for example, `10%` means that `XPos` is 10% of the canvas width.</li><li>If the string ends in px, the `XPos` of the sticker will be in px; for example, `100px` means that `XPos` is 100 px.</li>
        /// Default value: 0 px.
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// The vertical position of the origin of the sticker relative to the origin of the canvas. % and px formats are supported:
        /// <li>If the string ends in %, the `YPos` of the sticker will be at the position of the specified percentage of the canvas height; for example, `10%` means that `YPos` is 10% of the canvas height.</li>
        /// <li>If the string ends in px, the `YPos` of the sticker will be in px; for example, `100px` means that `YPos` is 100 px.</li>
        /// Default value: 0 px.
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// Sticker width. % and px formats are supported:
        /// <li>If the string ends in %, the `Width` of the sticker will be the specified percentage of the canvas width; for example, `10%` means that `Width` is 10% of the canvas width.</li>
        /// <li>If the string ends in px, the `Width` of the sticker will be in px; for example, `100px` means that `Width` is 100 px.</li>
        /// <li>If both `Width` and `Height` are empty, then they will be the `Width` and `Height` of the sticker material, respectively.</li>
        /// <li>If `Width` is empty (0), but `Height` is not empty, `Width` will be proportionally scaled.</li>
        /// <li>If `Width` is not empty, but `Height` is empty, `Height` will be proportionally scaled.</li>
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// Sticker height. % and px formats are supported:
        /// <li>If the string ends in %, the `Height` of the sticker will be the specified percentage of the canvas height; for example, `10%` means that `Height` is 10% of the canvas height.</li>
        /// <li>If the string ends in px, the `Height` of the sticker will be in px; for example, `100px` means that `Height` is 100 px.</li>
        /// <li>If both `Width` and `Height` are empty, then they will be the `Width` and `Height` of the sticker material, respectively.</li>
        /// <li>If `Width` is empty, but `Height` is not empty, `Width` will be proportionally scaled.</li>
        /// <li>If `Width` is not empty, but `Height` is empty, `Height` will be proportionally scaled.</li>
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// Operation on sticker such as image rotation.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageOperations")]
        public ImageTransform[] ImageOperations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceMedia", this.SourceMedia);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "CoordinateOrigin", this.CoordinateOrigin);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamArrayObj(map, prefix + "ImageOperations.", this.ImageOperations);
        }
    }
}

