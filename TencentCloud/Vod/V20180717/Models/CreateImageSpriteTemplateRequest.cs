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

    public class CreateImageSpriteTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Sampling type. Valid values:
        /// <li>Percent: by percent.</li>
        /// <li>Time: by time interval.</li>
        /// </summary>
        [JsonProperty("SampleType")]
        public string SampleType{ get; set; }

        /// <summary>
        /// Sampling interval.
        /// <li>If `SampleType` is `Percent`, sampling will be performed at an interval of the specified percentage.</li>
        /// <li>If `SampleType` is `Time`, sampling will be performed at the specified time interval in seconds.</li>
        /// </summary>
        [JsonProperty("SampleInterval")]
        public ulong? SampleInterval{ get; set; }

        /// <summary>
        /// The number of rows of small images in the sprite image. 
        /// Note: The number of rows of the small image will affect the height of the final large image. The maximum height of the large image is 15,000 pixels. The height of the large image is the product of the number of rows of the small image and the height of the small image.
        /// </summary>
        [JsonProperty("RowCount")]
        public ulong? RowCount{ get; set; }

        /// <summary>
        /// The number of columns of small images in the sprite image. 
        /// Note: The number of columns of the small image will affect the width of the final large image. The maximum width of the large image is 15,000 pixels. The width of the large image is the product of the number of columns of the small image and the width of the small image.
        /// </summary>
        [JsonProperty("ColumnCount")]
        public ulong? ColumnCount{ get; set; }

        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Name of an image sprite generating template. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Fill type. "Fill" refers to the way of processing a screenshot when its aspect ratio is different from that of the source video. The following fill types are supported:
        /// <li> stretch: stretch. The screenshot will be stretched frame by frame to match the aspect ratio of the source video, which may make the screenshot "shorter" or "longer";</li>
        /// <li>black: fill with black. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with black color blocks.</li>
        /// Default value: black.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// The maximum value of the width (or long side) of the small image in the sprite image, value range: 0 and [128, 4096], unit: px. 
        /// <li>When Width and Height are both 0, the resolution is from the same source;</li>
        /// <li>When Width is 0 and Height is non-0, Width is scaled proportionally;</li>
        /// < li>When Width is non-0 and Height is 0, the Height is scaled proportionally; </li>
        /// <li>When both Width and Height are non-0, the resolution is specified by the user. </li>
        /// Default value: 0. 
        /// Note: The width of the small image will affect the width of the final large image. The maximum width of the large image is 15,000 pixels. The width of the large image is the product of the number of columns of the small image and the width of the small image.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// The maximum value of the height (or short side) of the small image in the sprite image, value range: 0 and [128, 4096], unit: px. 
        /// <li>When Width and Height are both 0, the resolution is from the same source;</li>
        /// <li>When Width is 0 and Height is non-0, Width is scaled proportionally;</li>
        /// < li>When Width is non-0 and Height is 0, the Height is scaled proportionally; </li>
        /// <li>When both Width and Height are non-0, the resolution is specified by the user. </li>
        /// Default value: 0. 
        /// Note: The height of the small image will affect the height of the final large image. The maximum height of the large image is 15,000 pixels. The height of the large image is the product of the number of rows of the small image and the height of the small image.
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
        /// The image format. Valid values:
        /// <li> jpg</li>
        /// <li> png</li>
        /// <li> webp</li>
        /// Default: jpg
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SampleType", this.SampleType);
            this.SetParamSimple(map, prefix + "SampleInterval", this.SampleInterval);
            this.SetParamSimple(map, prefix + "RowCount", this.RowCount);
            this.SetParamSimple(map, prefix + "ColumnCount", this.ColumnCount);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "Format", this.Format);
        }
    }
}

