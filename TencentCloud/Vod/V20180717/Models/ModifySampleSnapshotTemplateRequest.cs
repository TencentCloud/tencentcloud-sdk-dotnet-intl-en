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

    public class ModifySampleSnapshotTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Sampling screenshot template unique identifier.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="/document/product/266/14574">application</a> ID. For customers who activate VOD services after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications, whether in the default application or a newly created application.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Sample screenshot template name. Length limit: 64 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>The maximum value of the screenshot width (or long side). Valid values: 0 and [32, 4096]. Unit: px.<li>When Width and Height are both 0, the resolution is from the same source;</li><li>When Width is 0 and Height is non-0, Width is scaled proportionally;</li><li>When Width is non-0 and Height is 0, Height is scaled proportionally;</li><li>When both Width and Height are non-0, the resolution is specified by the user.</li>Default value: 0.</p>
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// <p>The maximum value of the screenshot height (or short side). Valid values: 0 and [32, 4096]. Unit: px.<li>When Width and Height are both 0, the resolution is from the same source;</li><li>When Width is 0 and Height is non-0, Width is scaled proportionally;</li><li>When Width is non-0 and Height is 0, Height is scaled proportionally;</li><li>When both Width and Height are non-0, the resolution is specified by the user.</li>Default value: 0.</p>
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// <p>Resolution adaptation. Available values:</p><li>open: enable. At this point, Width represents the long side of the video, and Height represents the short side;</li><li>close: disable. At this point, Width represents the video width, and Height represents the video height.</li>Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// <p>Sampling screenshot type. Valid values:</p><li>Percent: By percent.</li><li>Time: By time interval.</li>
        /// </summary>
        [JsonProperty("SampleType")]
        public string SampleType{ get; set; }

        /// <summary>
        /// <p>Sampling interval.</p><li>When SampleType is Percent, specify the percentage of the sampling interval.</li><li>When SampleType is Time, specify the sampling interval in seconds.</li>
        /// </summary>
        [JsonProperty("SampleInterval")]
        public ulong? SampleInterval{ get; set; }

        /// <summary>
        /// <p>Image format. Valid values: jpg, png, and webp. Default value: jpg.</p>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// <p>Transcoding template description. Length limit: 256 characters.</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Filling method. The processing method for transcoding when the video stream configuration width and height parameters are inconsistent with the aspect ratio of the original video is "fill". Optional filling modes:</p><li>stretch: Stretch each frame to fill the entire screen, possibly causing the transcoded video to be "squashed" or "stretched".</li><li>black: Keep the video aspect ratio unchanged and fill the remaining edge part with black.</li><li>white: Keep the video aspect ratio unchanged and fill the remaining edge part with white.</li><li>gauss: Keep the video aspect ratio unchanged and apply Gaussian blur to the remaining edge part.</li>Default value: black.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "SampleType", this.SampleType);
            this.SetParamSimple(map, prefix + "SampleInterval", this.SampleInterval);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
        }
    }
}

