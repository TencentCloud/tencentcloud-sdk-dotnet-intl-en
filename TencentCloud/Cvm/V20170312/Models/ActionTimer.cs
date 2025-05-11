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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActionTimer : AbstractModel
    {
        
        /// <summary>
        /// Timer action currently only supports terminating one value: TerminateInstances.
        /// </summary>
        [JsonProperty("TimerAction")]
        public string TimerAction{ get; set; }

        /// <summary>
        /// Execution time, in standard ISO8601 representation and using UTC time. format: YYYY-MM-DDThh:MM:ssZ. for example, 2018-05-29T11:26:40Z. the execution time must be later than the current time by 5 minutes.
        /// </summary>
        [JsonProperty("ActionTime")]
        public string ActionTime{ get; set; }

        /// <summary>
        /// Extension data. only used as output usage.
        /// </summary>
        [JsonProperty("Externals")]
        public Externals Externals{ get; set; }

        /// <summary>
        /// Timer ID. only used as output usage.
        /// </summary>
        [JsonProperty("ActionTimerId")]
        public string ActionTimerId{ get; set; }

        /// <summary>
        /// Timer status, for output usage only. value ranges from: <li>UNDO: unexecuted</li> <li>DOING: executing</li> <li>DONE: execution completed.</li>.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Instance ID corresponding to a timer. used only for output.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimerAction", this.TimerAction);
            this.SetParamSimple(map, prefix + "ActionTime", this.ActionTime);
            this.SetParamObj(map, prefix + "Externals.", this.Externals);
            this.SetParamSimple(map, prefix + "ActionTimerId", this.ActionTimerId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

