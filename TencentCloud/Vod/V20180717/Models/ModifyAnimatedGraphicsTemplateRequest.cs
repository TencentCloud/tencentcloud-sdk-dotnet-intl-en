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

    public class ModifyAnimatedGraphicsTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of the rotation diagram template.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate VOD services after December 25, 2023 must fill this field with the application ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Rotating image template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Maximum value of animated gif width (or long side), value ranges from 0 to [32, 4096], unit: px.<li>When Width and Height are 0, Same Resolution Source;</li><li>When Width is 0 and Height is not 0, proportionally scale Width;</li><li>When Width is not 0 and Height is 0, proportionally scale Height;</li><li>When Width and Height are not 0, resolution specified by user.</li>Default value: 0.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// The maximum value of animated gif height (or short side), value ranges from 0 to [32, 4096], unit: px. <li>When both Width and Height are 0, the resolution is Same Resolution Source;</li> <li>When Width is 0 and Height is not 0, Width is proportionally scaled;</li> <li>When Width is not 0 and Height is 0, Height is proportionally scaled;</li> <li>When both Width and Height are not 0, the resolution is specified by user.</li> Default value: 0.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Resolution adaptation, available values:
        /// <li>open: start. At this point, Width represents the long side of the video, and Height indicates the short side of the video;</li>
        /// <li>close: Close. At this point, Width represents the width of the video, and Height indicates the height of the video.</li>
        /// Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Animated image file format, value is gif and webp.
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// Frame rate. Value ranges from 1 to 30. Unit: Hz.
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// Image quality. Valid range: 1 - 100. Default value: 75.
        /// </summary>
        [JsonProperty("Quality")]
        public float? Quality{ get; set; }

        /// <summary>
        /// Template description, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


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
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "Quality", this.Quality);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

