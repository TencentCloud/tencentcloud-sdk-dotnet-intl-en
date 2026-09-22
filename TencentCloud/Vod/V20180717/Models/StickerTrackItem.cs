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

    public class StickerTrackItem : AbstractModel
    {
        
        /// <summary>
        /// Media material source of the texture segment, which can be:
        /// <li>Media file ID for VOD;</li>
        /// <li>Download URL of other media files.</li>
        /// Note: When using the download URL of another media file as the material source, and access control (such as anti-hotlinking) is enabled, the URL needs to carry access control parameters (such as a hotlink protection signature).
        /// </summary>
        [JsonProperty("SourceMedia")]
        public string SourceMedia{ get; set; }

        /// <summary>
        /// Duration of the sticker, in seconds.
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// Start time of the sticker on the track, in seconds.
        /// </summary>
        [JsonProperty("StartTime")]
        public float? StartTime{ get; set; }

        /// <summary>
        /// Origin position. Valid values:
        /// <li>Center: The coordinate origin is the central position, such as the center of canvas.</li>
        /// Default: Center.
        /// </summary>
        [JsonProperty("CoordinateOrigin")]
        public string CoordinateOrigin{ get; set; }

        /// <summary>
        /// Horizontal position of the texture origin relative to the canvas origin, supporting two formats: % and px.
        /// <li>If a string ends with %, it indicates that the texture XPos is at a specified percentage of the canvas width. For example, 10% means the XPos is at 10% of the canvas width.</li><li>If a string ends with px, it indicates that the texture XPos is in pixels. For example, 100px means the XPos is 100 pixels.</li>
        /// Default value: 0px.
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// Vertical position of the texture origin from the canvas origin. Supports two formats: % and px.
        /// <li>When a string ends with %, it means the texture YPos is at the specified percentage of the canvas height. For example, 10% means the YPos is 10% of the canvas height.</li>
        /// <li>If a string ends with px, it means the texture YPos unit is pixel. For example, 100px means YPos is 100 pixels.</li>
        /// Default value: 0px.
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// Width of a sticker, supporting two formats: % and px.
        /// <li>If a string ends with %, it indicates that the `Width` of a sticker is a percentage of the canvas width. For example, `10%` means that `Width` is 10% of the canvas width.</li>
        /// <li>If a string ends with px, it means the texture Width unit is pixel. For example, 100px means the Width is 100 pixels.</li>
        /// <li>If both Width and Height are empty, the width and height of the texture material itself will be used.</li>
        /// <li>If Width is 0 but Height is not, the width will be proportionally scaled.</li>
        /// <li>If Width is not empty but Height is empty, the height will be proportionally scaled.</li>
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// Height of a sticker, supporting two formats: % and px.
        /// <li>If a string ends with %, it indicates that the `Height` of a sticker is a percentage of the canvas height. For example, `10%` means that `Height` is 10% of the canvas height.</li>
        /// <li>If a string ends with px, it means the texture Height unit is pixel. For example, 100px means the Height is 100 pixels.</li>
        /// <li>If both Width and Height are empty, the width and height of the texture material itself will be used.</li>
        /// <li>If Width is empty but Height is not empty, the width will be proportionally scaled.</li>
        /// <li>If Width is not empty but Height is empty, the height will be proportionally scaled.</li>
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// Operation performed on the texture, such as image rotation.
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

