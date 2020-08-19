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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaSampleSnapshotItem : AbstractModel
    {
        
        /// <summary>
        /// Sampled screenshot specification ID. For more information, please see [Sampled Screencapturing Parameter Template](https://intl.cloud.tencent.com/document/product/266/33480?from_cn_redirect=1#.E9.87.87.E6.A0.B7.E6.88.AA.E5.9B.BE.E6.A8.A1.E6.9D.BF).
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Sample type. Valid values:
        /// <li>Percent: Samples at the specified percentage interval.</li>
        /// <li>Time: Samples at the specified time interval.</li>
        /// </summary>
        [JsonProperty("SampleType")]
        public string SampleType{ get; set; }

        /// <summary>
        /// Sampling interval
        /// <li>If `SampleType` is `Percent`, this value means taking a screenshot at an interval of the specified percentage.</li>
        /// <li>If `SampleType` is `Time`, this value means taking a screenshot at an interval of the specified time (in seconds). The first screenshot is always the first video frame.</li>
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// Storage location of a generated screenshot file.
        /// </summary>
        [JsonProperty("Storage")]
        public TaskOutputStorage Storage{ get; set; }

        /// <summary>
        /// List of paths to generated screenshots.
        /// </summary>
        [JsonProperty("ImagePathSet")]
        public string[] ImagePathSet{ get; set; }

        /// <summary>
        /// List of watermarking template IDs if the screenshots are watermarked.
        /// </summary>
        [JsonProperty("WaterMarkDefinition")]
        public long?[] WaterMarkDefinition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SampleType", this.SampleType);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamObj(map, prefix + "Storage.", this.Storage);
            this.SetParamArraySimple(map, prefix + "ImagePathSet.", this.ImagePathSet);
            this.SetParamArraySimple(map, prefix + "WaterMarkDefinition.", this.WaterMarkDefinition);
        }
    }
}

