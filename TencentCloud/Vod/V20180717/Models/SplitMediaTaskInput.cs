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

    public class SplitMediaTaskInput : AbstractModel
    {
        
        /// <summary>
        /// Video ID.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Start time offset of video splitting, in seconds.
        /// <li>Leave it empty or set it to 0, indicating that the transcoded video starts from the start position of the original video;</li>
        /// <li>When the value is greater than 0 (assuming n), the transcoded video starts from the nth second of the original video;</li>
        /// <li>When the value is less than 0 (assuming -n), the transcoded video starts n seconds before the end of the original video.</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of video splitting, in seconds.
        /// <li>If not set or set to 0, the transcoded video will last until the end of the original video.</li>
        /// <li>When the value is greater than 0 (assuming n), the transcoded video lasts until the nth second of the original video.</li>
        /// <li>When the value is less than 0 (assuming -n), it means the transcoded video lasts until n seconds before the original video ends.</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// [Task flow](https://www.tencentcloud.com/document/product/266/33475?from_cn_redirect=1#.E4.BB.BB.E5.8A.A1.E6.B5.81) name. Fill in if you want to execute a task flow on the generated new video.
        /// </summary>
        [JsonProperty("ProcedureName")]
        public string ProcedureName{ get; set; }

        /// <summary>
        /// Output information of video splitting.
        /// </summary>
        [JsonProperty("OutputConfig")]
        public SplitMediaOutputConfig OutputConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamSimple(map, prefix + "ProcedureName", this.ProcedureName);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
        }
    }
}

