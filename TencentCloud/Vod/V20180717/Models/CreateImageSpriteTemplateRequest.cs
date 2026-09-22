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
        /// <li>When SampleType is Percent, specify the percentage of the sampling interval.</li>
        /// <li>The time when the sampling interval is specified if SampleType is Time, in seconds.</li>
        /// </summary>
        [JsonProperty("SampleInterval")]
        public ulong? SampleInterval{ get; set; }

        /// <summary>
        /// Number of rows of small images in the sprite image.
        /// Note: The number of subimage rows impacts the final height of the large image. The maximum height of the large image is 15,000 pixels, where the height of the large image is the product of the number of subimage rows and the subimage height.
        /// </summary>
        [JsonProperty("RowCount")]
        public ulong? RowCount{ get; set; }

        /// <summary>
        /// Number of columns of small images in the sprite image.
        /// Note: The number of columns of small images impacts the final width of the large image. The maximum width of the large image is 15,000 pixels, where the width of the large image is the product of the number of columns and the width of the small images.
        /// </summary>
        [JsonProperty("ColumnCount")]
        public ulong? ColumnCount{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Sprite image template name, with a length limit of 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Filling method. When the video stream configuration width and height parameters are inconsistent with the aspect ratio of the original video, the processing method for transcoding is "filling". Optional filling methods: <li> stretch: Stretch each frame to fill the entire screen, which may cause the transcoded video to be "squashed" or "stretched";</li><li>black: Keep black bars, maintain the video aspect ratio, and fill the remaining edges with black.</li>Default value: black.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// Maximum value of the width (or long side) of small images in the sprite image. Value range: 0 and [128, 4096]. Unit: px.<li>When both Width and Height are 0, Same Resolution Source is used;</li><li>When Width is 0 and Height is not 0, Width is proportionally scaled;</li><li>When Width is not 0 and Height is 0, Height is proportionally scaled;</li><li>When both Width and Height are not 0, the resolution specified by user is used.</li>Default value: 0. Note: The width of small images impacts the width of the final large image. The maximum width of the large image is 15000 pixels, where the width of the large image is the product of the columns and the width of small images.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Maximum value of the height (or short side) of small images in the sprite image. Value range: 0 and [128, 4096]. Unit: px.<li>When both Width and Height are 0, the resolution is the same as the source.</li><li>When Width is 0 and Height is not 0, Width is proportionally scaled.</li><li>When Width is not 0 and Height is 0, Height is proportionally scaled.</li><li>When both Width and Height are not 0, the resolution is specified by the user.</li>Default value: 0. Note: The height of small images impacts the height of the final large image. The maximum height of the large image is 15000 pixels, where the height of the large image is the product of the subimage rows and the height of small images.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Resolution adaptation. Available values:
        /// <li>open: enable. At this point, Width represents the long side of the video, and Height indicates the short side of the video;</li>
        /// <li>close: closed. At this point, Width represents the width of the video, and Height represents the height of the video.</li>
        /// Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Image format. Value:
        /// <li> jpg: jpg format;</li>
        /// <li> png: PNG format;</li>
        /// <li> webp: webp format.</li>
        /// Default value: jpg.
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

