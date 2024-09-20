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

    public class TaskConfig : AbstractModel
    {
        
        /// <summary>
        /// Action group configurations. The number of configured action groups needs to be consistent with that in the template.
        /// </summary>
        [JsonProperty("TaskGroupsConfig")]
        public TaskGroupConfig[] TaskGroupsConfig{ get; set; }

        /// <summary>
        /// Experiment name after change. If this parameter is left blank, the template name is used by default.
        /// </summary>
        [JsonProperty("TaskTitle")]
        public string TaskTitle{ get; set; }

        /// <summary>
        /// Experiment description after change. If this parameter is left blank, the template description is used by default.
        /// </summary>
        [JsonProperty("TaskDescription")]
        public string TaskDescription{ get; set; }

        /// <summary>
        /// Experiment execution mode. 1: manual execution; 2: automatic execution. If this parameter is left blank, the template execution mode is used by default.
        /// </summary>
        [JsonProperty("TaskMode")]
        public ulong? TaskMode{ get; set; }

        /// <summary>
        /// Automatic pause time of the experiment, in minutes. If this parameter is left blank, the automatic pause time of the template is used by default.
        /// </summary>
        [JsonProperty("TaskPauseDuration")]
        public ulong? TaskPauseDuration{ get; set; }

        /// <summary>
        /// Experiment tag. If this parameter is left blank, the template tag is used by default.
        /// </summary>
        [JsonProperty("Tags")]
        public TagWithCreate[] Tags{ get; set; }

        /// <summary>
        /// Guardrail processing method. 1: roll back sequentially; 2: pause experiment.
        /// </summary>
        [JsonProperty("PolicyDealType")]
        public long? PolicyDealType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TaskGroupsConfig.", this.TaskGroupsConfig);
            this.SetParamSimple(map, prefix + "TaskTitle", this.TaskTitle);
            this.SetParamSimple(map, prefix + "TaskDescription", this.TaskDescription);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamSimple(map, prefix + "TaskPauseDuration", this.TaskPauseDuration);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "PolicyDealType", this.PolicyDealType);
        }
    }
}

