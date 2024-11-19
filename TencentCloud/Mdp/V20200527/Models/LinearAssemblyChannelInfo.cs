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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LinearAssemblyChannelInfo : AbstractModel
    {
        
        /// <summary>
        /// Linear assembly channel name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Define the characteristics of the channel. Standard supports live broadcast and on-demand sources, while Basic only supports on-demand source arrangement.
        /// </summary>
        [JsonProperty("Tier")]
        public string Tier{ get; set; }

        /// <summary>
        /// The source switching mode in the channel is divided into Linear and Loop. Live broadcast only supports Linear.
        /// </summary>
        [JsonProperty("PlaybackMode")]
        public string PlaybackMode{ get; set; }

        /// <summary>
        /// Time shift configuration, vod is valid.
        /// </summary>
        [JsonProperty("TimeShiftConf")]
        public TimeShiftInfo TimeShiftConf{ get; set; }

        /// <summary>
        /// Spacer configuration.
        /// </summary>
        [JsonProperty("SlateConf")]
        public SlateInfo SlateConf{ get; set; }

        /// <summary>
        /// output information.
        /// </summary>
        [JsonProperty("Outputs")]
        public OutputInfo[] Outputs{ get; set; }

        /// <summary>
        /// List of programs bound to this channel.
        /// </summary>
        [JsonProperty("AttachedPrograms")]
        public string[] AttachedPrograms{ get; set; }

        /// <summary>
        /// program information.
        /// </summary>
        [JsonProperty("ProgramSchedules")]
        public ProgramScheduleInfo[] ProgramSchedules{ get; set; }

        /// <summary>
        /// ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Region.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// State.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Time shift on switch.
        /// </summary>
        [JsonProperty("TimeShiftEnable")]
        public bool? TimeShiftEnable{ get; set; }

        /// <summary>
        /// Channel creation time, unix seconds timestamp.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Tier", this.Tier);
            this.SetParamSimple(map, prefix + "PlaybackMode", this.PlaybackMode);
            this.SetParamObj(map, prefix + "TimeShiftConf.", this.TimeShiftConf);
            this.SetParamObj(map, prefix + "SlateConf.", this.SlateConf);
            this.SetParamArrayObj(map, prefix + "Outputs.", this.Outputs);
            this.SetParamArraySimple(map, prefix + "AttachedPrograms.", this.AttachedPrograms);
            this.SetParamArrayObj(map, prefix + "ProgramSchedules.", this.ProgramSchedules);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "TimeShiftEnable", this.TimeShiftEnable);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

