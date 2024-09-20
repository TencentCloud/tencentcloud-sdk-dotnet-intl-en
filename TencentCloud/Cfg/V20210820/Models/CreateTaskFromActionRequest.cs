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

    public class CreateTaskFromActionRequest : AbstractModel
    {
        
        /// <summary>
        /// Action ID, which can be obtained by using the action list API DescribeActionLibraryList.
        /// </summary>
        [JsonProperty("TaskActionId")]
        public ulong? TaskActionId{ get; set; }

        /// <summary>
        /// ID of the instance participating in the experiment
        /// </summary>
        [JsonProperty("TaskInstances")]
        public string[] TaskInstances{ get; set; }

        /// <summary>
        /// Experiment name. If this parameter is left blank, the action name is used by default.
        /// </summary>
        [JsonProperty("TaskTitle")]
        public string TaskTitle{ get; set; }

        /// <summary>
        /// Experiment description. If this parameter is left blank, the action description is used by default.
        /// </summary>
        [JsonProperty("TaskDescription")]
        public string TaskDescription{ get; set; }

        /// <summary>
        /// General action parameters, which need to be passed in after JSON serialization. The parameters can be obtained by using the action details API DescribeActionFieldConfigList. If this field is left blank, the default action parameters are used by default.
        /// </summary>
        [JsonProperty("TaskActionGeneralConfiguration")]
        public string TaskActionGeneralConfiguration{ get; set; }

        /// <summary>
        /// Action custom parameters need to be passed in as json serialization. They can be obtained from the action details interface DescribeActionFieldConfigList. If not filled in, the default action parameters will be used. Note: Required parameters have no default values. Be sure to pass in valid values.
        /// </summary>
        [JsonProperty("TaskActionCustomConfiguration")]
        public string TaskActionCustomConfiguration{ get; set; }

        /// <summary>
        /// Automatic experiment pause time, in minutes. If this parameter is left blank, the default value 60 is used.
        /// </summary>
        [JsonProperty("TaskPauseDuration")]
        public ulong? TaskPauseDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskActionId", this.TaskActionId);
            this.SetParamArraySimple(map, prefix + "TaskInstances.", this.TaskInstances);
            this.SetParamSimple(map, prefix + "TaskTitle", this.TaskTitle);
            this.SetParamSimple(map, prefix + "TaskDescription", this.TaskDescription);
            this.SetParamSimple(map, prefix + "TaskActionGeneralConfiguration", this.TaskActionGeneralConfiguration);
            this.SetParamSimple(map, prefix + "TaskActionCustomConfiguration", this.TaskActionCustomConfiguration);
            this.SetParamSimple(map, prefix + "TaskPauseDuration", this.TaskPauseDuration);
        }
    }
}

