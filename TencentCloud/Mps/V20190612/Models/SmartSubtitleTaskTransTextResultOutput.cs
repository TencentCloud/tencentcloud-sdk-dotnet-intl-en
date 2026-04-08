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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmartSubtitleTaskTransTextResultOutput : AbstractModel
    {
        
        /// <summary>
        /// <p>List of segments for translation.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public SmartSubtitleTaskTransTextSegmentItem[] SegmentSet{ get; set; }

        /// <summary>
        /// <p>Subtitle file URL.</p>
        /// </summary>
        [JsonProperty("SubtitlePath")]
        public string SubtitlePath{ get; set; }

        /// <summary>
        /// <p>Smart subtitling result storage information.</p>
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// <p>Subtitle file path</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>Returned translation result during multilingual translation.</p>
        /// </summary>
        [JsonProperty("SubtitleResults")]
        public SubtitleTransResultItem[] SubtitleResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
            this.SetParamSimple(map, prefix + "SubtitlePath", this.SubtitlePath);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamArrayObj(map, prefix + "SubtitleResults.", this.SubtitleResults);
        }
    }
}

