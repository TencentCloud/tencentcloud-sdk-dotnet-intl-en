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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskGroupConfig : AbstractModel
    {
        
        /// <summary>
        /// Instance object associated with the action group
        /// </summary>
        [JsonProperty("TaskGroupInstances")]
        public string[] TaskGroupInstances{ get; set; }

        /// <summary>
        /// Action group name. If this parameter is left blank, the action group name in the template is used by default.
        /// </summary>
        [JsonProperty("TaskGroupTitle")]
        public string TaskGroupTitle{ get; set; }

        /// <summary>
        /// Action group description. If this parameter is left blank, the action group description in the template is used by default.
        /// </summary>
        [JsonProperty("TaskGroupDescription")]
        public string TaskGroupDescription{ get; set; }

        /// <summary>
        /// Action group execution mode. 1: sequential execution; 2: execution by stage. If this parameter is left blank, the action execution mode in the template is used by default.
        /// </summary>
        [JsonProperty("TaskGroupMode")]
        public ulong? TaskGroupMode{ get; set; }

        /// <summary>
        /// Action parameters in the action group. If this field is left blank, the action parameters in the template is used by default. You only need to specify the action whose parameters are to be modified during configuration.
        /// </summary>
        [JsonProperty("TaskGroupActionsConfig")]
        public TaskGroupActionConfig[] TaskGroupActionsConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TaskGroupInstances.", this.TaskGroupInstances);
            this.SetParamSimple(map, prefix + "TaskGroupTitle", this.TaskGroupTitle);
            this.SetParamSimple(map, prefix + "TaskGroupDescription", this.TaskGroupDescription);
            this.SetParamSimple(map, prefix + "TaskGroupMode", this.TaskGroupMode);
            this.SetParamArrayObj(map, prefix + "TaskGroupActionsConfig.", this.TaskGroupActionsConfig);
        }
    }
}

