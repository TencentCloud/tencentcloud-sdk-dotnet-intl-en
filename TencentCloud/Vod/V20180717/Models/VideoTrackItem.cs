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

    public class VideoTrackItem : AbstractModel
    {
        
        /// <summary>
        /// Media material source of the video clip, which can be:
        /// <li>Media file ID of on-demand video;</li>
        /// <li>Download URL of other media files.</li>
        /// Note: When using the download URL of another media file as the material source, and access control (such as anti-hotlinking) is enabled, the URL needs to carry access control parameters (such as a hotlink protection signature).
        /// </summary>
        [JsonProperty("SourceMedia")]
        public string SourceMedia{ get; set; }

        /// <summary>
        /// Start time of the video clip in the material file, in seconds. Default value: 0.
        /// </summary>
        [JsonProperty("SourceMediaStartTime")]
        public float? SourceMediaStartTime{ get; set; }

        /// <summary>
        /// Video segment duration in seconds. The default value is the length of the video material itself, which means the entire material is captured. If the source file is an image, Duration must be greater than 0.
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// Target duration of the video clip, in seconds.
        /// <li>If TargetDuration is not specified or set to 0, it means the target duration is the same as Duration;</li>
        /// <li>When TargetDuration is set to a value more than 0, the video clip will be fast-forwarded or slowed down so that the duration of the output segment equals TargetDuration.</li>
        /// </summary>
        [JsonProperty("TargetDuration")]
        public float? TargetDuration{ get; set; }

        /// <summary>
        /// Video origin position. Valid values:
        /// <li>Center: The coordinate origin is the central position, such as the center of the canvas.</li>
        /// Default value: Center.
        /// </summary>
        [JsonProperty("CoordinateOrigin")]
        public string CoordinateOrigin{ get; set; }

        /// <summary>
        /// Horizontal position of the origin point of a video clip relative to the origin of the canvas. Supports two formats: % and px.
        /// <li>When the string ends with %, it means the video clip XPos is at a position of the specified percentage of the canvas width. For example, 10% means XPos is at 10% of the canvas width.</li>
        /// <li>If a string ends with px, it means the unit of the video clip XPos is pixel. For example, 100px means XPos is 100 pixels.</li>
        /// Default value: 0px.
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// Vertical position of the origin point of a video clip relative to the origin of the canvas. Supports % and px.
        /// <li>If a string ends with %, it indicates that the `YPos` of a video clip is at a specified percentage of the canvas height. For example, `10%` means that `YPos` is at 10% of the canvas height.</li>
        /// <li>If a string ends with px, it means the unit of the video clip YPos is pixel. For example, 100px means YPos is 100 pixels.</li>
        /// Default value: 0px.
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// Width of a video clip, supporting two formats: % and px.
        /// <li>If a string ends with %, it indicates that the `Width` of a video clip is a percentage of the canvas width. For example, `10%` means that `Width` is 10% of the canvas width.</li>
        /// <li>If a string ends with px, it means the video clip Width unit is pixel. For example, 100px means the Width is 100 pixels.</li>
        /// <li>If both Width and Height are empty, the width and height of the video footage itself will be used.</li>
        /// <li>If Width is empty but Height is not empty, the width will be proportionally scaled.</li>
        /// <li>If Width is not empty but Height is empty, the height will be proportionally scaled.</li>
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// Height of a video clip, supporting two formats: % and px.
        /// <li>If a string ends with %, it indicates that the `Height` of a video clip is a percentage of the canvas height. For example, `10%` means that `Height` is 10% of the canvas height.</li>
        /// </li><li>If a string ends with px, it means the video clip Height unit is pixel. For example, 100px means the Height is 100 pixels.</li>
        /// <li>If both Width and Height are empty, the width and height of the video footage itself will be used.</li>
        /// <li>If Width is empty but Height is not empty, the width will be proportionally scaled.</li>
        /// <li>If Width is not empty but Height is empty, the height will be proportionally scaled.</li>
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// Perform operations on audio, such as muting.
        /// </summary>
        [JsonProperty("AudioOperations")]
        public AudioTransform[] AudioOperations{ get; set; }

        /// <summary>
        /// Operation performed on the image, such as image rotation.
        /// </summary>
        [JsonProperty("ImageOperations")]
        public ImageTransform[] ImageOperations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceMedia", this.SourceMedia);
            this.SetParamSimple(map, prefix + "SourceMediaStartTime", this.SourceMediaStartTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "TargetDuration", this.TargetDuration);
            this.SetParamSimple(map, prefix + "CoordinateOrigin", this.CoordinateOrigin);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamArrayObj(map, prefix + "AudioOperations.", this.AudioOperations);
            this.SetParamArrayObj(map, prefix + "ImageOperations.", this.ImageOperations);
        }
    }
}

