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
        /// Additional data
        /// </summary>
        [JsonProperty("Externals")]
        public Externals Externals{ get; set; }

        /// <summary>
        /// Timer name. Currently `TerminateInstances` is the only supported value.
        /// </summary>
        [JsonProperty("TimerAction")]
        public string TimerAction{ get; set; }

        /// <summary>
        /// Execution time, which must be at least 5 minutes later than the current time. For example, 2018-5-29 11:26:40.
        /// </summary>
        [JsonProperty("ActionTime")]
        public string ActionTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Externals.", this.Externals);
            this.SetParamSimple(map, prefix + "TimerAction", this.TimerAction);
            this.SetParamSimple(map, prefix + "ActionTime", this.ActionTime);
        }
    }
}

