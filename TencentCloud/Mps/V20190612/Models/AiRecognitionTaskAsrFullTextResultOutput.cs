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

    public class AiRecognitionTaskAsrFullTextResultOutput : AbstractModel
    {
        
        /// <summary>
        /// List of full speech recognition segments.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public AiRecognitionTaskAsrFullTextSegmentItem[] SegmentSet{ get; set; }

        /// <summary>
        /// Subtitles file address.
        /// </summary>
        [JsonProperty("SubtitlePath")]
        public string SubtitlePath{ get; set; }

        /// <summary>
        /// Subtitles file storage location.
        /// </summary>
        [JsonProperty("OutputStorage")]
        [System.Obsolete]
        public TaskOutputStorage OutputStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
            this.SetParamSimple(map, prefix + "SubtitlePath", this.SubtitlePath);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
        }
    }
}

