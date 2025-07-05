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

    public class CreateStreamPackageLinearAssemblyChannelRequest : AbstractModel
    {
        
        /// <summary>
        /// Channel name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Define the characteristics of the channel. Standard supports live broadcast and on-demand sources. Basic only supports on-demand source arrangement. Optional values: Standard and Basic.
        /// </summary>
        [JsonProperty("Tier")]
        public string Tier{ get; set; }

        /// <summary>
        /// The source switching modes in the channel are divided into Linear and Loop. Basic only supports Linear, and Standatd supports both.
        /// Optional values: Linear, Standatd.
        /// </summary>
        [JsonProperty("PlaybackMode")]
        public string PlaybackMode{ get; set; }

        /// <summary>
        /// Time shift enable switch, only valid when Tier is Standard.
        /// </summary>
        [JsonProperty("TimeShiftEnable")]
        public bool? TimeShiftEnable{ get; set; }

        /// <summary>
        /// Time shift configuration, effective when the time shift switch is turned on.
        /// </summary>
        [JsonProperty("TimeShiftConf")]
        public TimeShiftInfo TimeShiftConf{ get; set; }

        /// <summary>
        /// Spacer configuration is only valid when PlaybackMode is Linear.
        /// </summary>
        [JsonProperty("SlateConf")]
        public SlateInfo SlateConf{ get; set; }

        /// <summary>
        /// Output configuration.
        /// </summary>
        [JsonProperty("Outputs")]
        public OutputReq[] Outputs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Tier", this.Tier);
            this.SetParamSimple(map, prefix + "PlaybackMode", this.PlaybackMode);
            this.SetParamSimple(map, prefix + "TimeShiftEnable", this.TimeShiftEnable);
            this.SetParamObj(map, prefix + "TimeShiftConf.", this.TimeShiftConf);
            this.SetParamObj(map, prefix + "SlateConf.", this.SlateConf);
            this.SetParamArrayObj(map, prefix + "Outputs.", this.Outputs);
        }
    }
}

