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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskDetail : AbstractModel
    {
        
        /// <summary>
        /// Current task step name.
        /// </summary>
        [JsonProperty("CurrentStep")]
        public string CurrentStep{ get; set; }

        /// <summary>
        /// Describes the step description of the current task you own.
        /// </summary>
        [JsonProperty("AllSteps")]
        public string AllSteps{ get; set; }

        /// <summary>
        /// Input of the task.
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// Output parameter of the task.
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// Specifies the switch time after instance configurations are modified. default value: 0.
        /// This task does not require switching.
        /// Switch immediately.
        /// 2: switch at specified time.
        /// 3: switch during maintenance time window.
        /// </summary>
        [JsonProperty("SwitchTag")]
        public ulong? SwitchTag{ get; set; }

        /// <summary>
        /// Specifies the switch time.
        /// </summary>
        [JsonProperty("SwitchTime")]
        public string SwitchTime{ get; set; }

        /// <summary>
        /// Note of the task.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentStep", this.CurrentStep);
            this.SetParamSimple(map, prefix + "AllSteps", this.AllSteps);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "SwitchTag", this.SwitchTag);
            this.SetParamSimple(map, prefix + "SwitchTime", this.SwitchTime);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

