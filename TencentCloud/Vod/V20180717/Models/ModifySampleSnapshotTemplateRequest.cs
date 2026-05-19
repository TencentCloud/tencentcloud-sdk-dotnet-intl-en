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
        /// Unique identifier of the sampling screenshot template.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// <b>On-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Sample screenshot template name. The length cannot exceed 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The maximum value of screenshot width (or long side), value ranges from 0 to [32, 4096], measurement unit: px.<li>When both Width and Height are 0, the resolution is the same as the source.</li><li>When Width is 0 and Height is not 0, Width is scaled proportionally.</li><li>When Width is not 0 and Height is 0, Height is scaled proportionally.</li><li>When both Width and Height are not 0, the resolution is specified by user.</li>Default value: 0.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// The maximum value of screenshot height (or short edge), value ranges from 0 to [32, 4096], unit: px.<li>When both Width and Height are 0, the resolution is the same as the source;</li><li>When Width is 0 and Height is not 0, Width is proportionally scaled;</li><li>When Width is not 0 and Height is 0, Height is proportionally scaled;</li><li>When both Width and Height are not 0, the resolution is specified by user.</li>Default value: 0.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Resolution adaptation, available values:
        /// <li>open: enable. At this point, Width represents the long side of the video, and Height indicates the short side.</li>
        /// <li>close: Closed. At this point, Width represents the Width of the video, and Height indicates the Height of the video.</li>
        /// Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Sampling screenshot type, Valid value:
        /// <li>Percent: by percent.</li>
        /// <li>Time: By time interval.</li>
        /// </summary>
        [JsonProperty("SampleType")]
        public string SampleType{ get; set; }

        /// <summary>
        /// Sampling interval.
        /// <li>When SampleType is Percent, specify the percentage of the sampling interval.</li>
        /// <li>When SampleType is Time, specify the sampling interval in seconds.</li>
        /// </summary>
        [JsonProperty("SampleInterval")]
        public ulong? SampleInterval{ get; set; }

        /// <summary>
        /// Image format. Valid values: jpg and png.
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// Template description, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Filling method. When the video stream configuration width and height parameters are inconsistent with the aspect ratio of the original video, the processing method for transcoding is "padding". Optional filling mode:
        /// <li> stretch: Stretch each frame to fill the entire screen, possibly causing the transcoded video to be squashed or stretched.</li>
        /// <li>black: Keep black, maintain video aspect ratio, edges filled with black.</li>
        /// <li>white: Leave blank, maintain video aspect ratio, edge remainder filled with white.</li>
        /// <li>gauss: Gaussian blur, maintain video aspect ratio, use Gaussian blur for the remaining edge part.</li>
        /// Default value: black.
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

