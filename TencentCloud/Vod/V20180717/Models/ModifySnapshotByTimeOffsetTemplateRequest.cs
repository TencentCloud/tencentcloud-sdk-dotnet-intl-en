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

    public class ModifySnapshotByTimeOffsetTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of a specified time point screencapturing template.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Name of a time point screencapturing template. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Maximum value of the width (or long side) of a screenshot in px. Value range: 0 and [128, 4,096].
        /// <li>If both `Width` and `Height` are 0, the resolution will be the same as that of the source video;</li>
        /// <li>If `Width` is 0, but `Height` is not 0, `Width` will be proportionally scaled;</li>
        /// <li>If `Width` is not 0, but `Height` is 0, `Height` will be proportionally scaled;</li>
        /// <li>If both `Width` and `Height` are not 0, the custom resolution will be used.</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Maximum value of the height (or short side) of a screenshot in px. Value range: 0 and [128, 4,096].
        /// <li>If both `Width` and `Height` are 0, the resolution will be the same as that of the source video;</li>
        /// <li>If `Width` is 0, but `Height` is not 0, `Width` will be proportionally scaled;</li>
        /// <li>If `Width` is not 0, but `Height` is 0, `Height` will be proportionally scaled;</li>
        /// <li>If both `Width` and `Height` are not 0, the custom resolution will be used.</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Resolution adaption. Valid values:
        /// <li>open: enabled. In this case, `Width` represents the long side of a video, while `Height` the short side;</li>
        /// <li>close: disabled. In this case, `Width` represents the width of a video, while `Height` the height.</li>
        /// Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Image format. Valid values: jpg, png.
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// Template description. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Fill type. "Fill" refers to the way of processing a screenshot when its aspect ratio is different from that of the source video. The following fill types are supported:
        /// <li> stretch: stretch. The screenshot will be stretched frame by frame to match the aspect ratio of the source video, which may make the screenshot "shorter" or "longer";</li>
        /// <li>black: fill with black. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with black color blocks.</li>
        /// <li>white: fill with white. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with white color blocks.</li>
        /// <li>gauss: fill with Gaussian blur. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with Gaussian blur.</li>
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
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
        }
    }
}

