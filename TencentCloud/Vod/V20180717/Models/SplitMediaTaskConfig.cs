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

    public class SplitMediaTaskConfig : AbstractModel
    {
        
        /// <summary>
        /// The offset time of the start of video stripping, unit: seconds. 
        /// <li>Leave it blank or fill in 0, which means that the transcoded video starts from the starting position of the original video;</li>
        /// <li>When the value is greater than 0 (assumed to be n), it means that after transcoding The video starts from the n-th second position of the original video;</li>
        /// <li>When the value is less than 0 (assumed to be -n), it means that the transcoded video starts from the position n seconds before the end of the original video. </li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// Offset time at the end of video stripping, unit: seconds. 
        /// <li>Leave it blank or fill it in with 0, which means that the transcoded video will continue until the end of the original video;</li>
        /// <li>When the value is greater than 0 (assumed to be n), it means that the transcoded video will continue until the end of the original video. The video continues until the nth second of the original video and terminates;</li>
        /// <li>When the value is less than 0 (assumed to be -n), it means that the transcoded video continues until n seconds before the end of the original video. </li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// Task flow template name, if you want Fill in when executing the task flow on the generated new video.
        /// </summary>
        [JsonProperty("ProcedureName")]
        public string ProcedureName{ get; set; }

        /// <summary>
        /// The video is split into strips to output information.
        /// </summary>
        [JsonProperty("OutputConfig")]
        public SplitMediaOutputConfig OutputConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamSimple(map, prefix + "ProcedureName", this.ProcedureName);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
        }
    }
}

