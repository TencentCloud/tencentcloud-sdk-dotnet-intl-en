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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PlaybackInfoReq : AbstractModel
    {
        
        /// <summary>
        /// Program startup method, live broadcast only supports Absolute, on-demand also supports Relative.
        /// Optional values: Absolute, Relative.
        /// </summary>
        [JsonProperty("TransitionType")]
        public string TransitionType{ get; set; }

        /// <summary>
        /// Unix timestamp, the start execution time of the program in absolute scenarios.
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// Program duration, in milliseconds, valid for live broadcast.
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// It is related to the insertion order of the selected program, divided into After and Before.
        /// </summary>
        [JsonProperty("RelativePosition")]
        public string RelativePosition{ get; set; }

        /// <summary>
        /// The selected insertion reference program id.
        /// </summary>
        [JsonProperty("RelativeProgramId")]
        public string RelativeProgramId{ get; set; }

        /// <summary>
        /// Spacer configuration.
        /// </summary>
        [JsonProperty("ClipRangeConf")]
        public ClipRangeInfo ClipRangeConf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransitionType", this.TransitionType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "RelativePosition", this.RelativePosition);
            this.SetParamSimple(map, prefix + "RelativeProgramId", this.RelativeProgramId);
            this.SetParamObj(map, prefix + "ClipRangeConf.", this.ClipRangeConf);
        }
    }
}

