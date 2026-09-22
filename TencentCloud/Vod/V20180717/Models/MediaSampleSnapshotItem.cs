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

    public class MediaSampleSnapshotItem : AbstractModel
    {
        
        /// <summary>
        /// Sampling screenshot specification ID. See [Sampling Screenshot Parameter Template](https://www.tencentcloud.com/document/product/266/33480?from_cn_redirect=1#.E9.87.87.E6.A0.B7.E6.88.AA.E5.9B.BE.E6.A8.A1.E6.9D.BF).
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Sampling method. Valid value:
        /// <li>Percent: interval sampling based on percentage.</li>
        /// <li>Time: sampling based on time interval.</li>
        /// </summary>
        [JsonProperty("SampleType")]
        public string SampleType{ get; set; }

        /// <summary>
        /// Sampling interval
        /// <li>When SampleType is Percent, this value indicates the percentage of images.</li>
        /// <li>When SampleType is Time, this value indicates how many time intervals between images, in seconds. The first image is always the first video frame.</li>
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// List of generated screenshot URLs.
        /// </summary>
        [JsonProperty("ImageUrlSet")]
        public string[] ImageUrlSet{ get; set; }

        /// <summary>
        /// List of template IDs if the screenshot is watermarked.
        /// </summary>
        [JsonProperty("WaterMarkDefinition")]
        public long?[] WaterMarkDefinition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SampleType", this.SampleType);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArraySimple(map, prefix + "ImageUrlSet.", this.ImageUrlSet);
            this.SetParamArraySimple(map, prefix + "WaterMarkDefinition.", this.WaterMarkDefinition);
        }
    }
}

