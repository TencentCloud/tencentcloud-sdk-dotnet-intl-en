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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateTriggerTaskPartiallyRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task basic attributes.
        /// </summary>
        [JsonProperty("NewSetting")]
        public UpdateTriggerTaskPart NewSetting{ get; set; }

        /// <summary>
        /// Delete field content, identified in the form of property paths, with deleted values separated by ":" and multiple values separated by "," delete the attribute "TaskConfiguration/TaskSchedulingParameterList:aa,bb" where ParamKey is aa,bb in scheduling parameters delete the upstream dependency "TaskSchedulerConfiguration/UpstreamDependencyConfigList:2509162129381111,2509162129381112" where TaskId is 2509162129381111,2509162129381112 in upstream dependencies delete the downstream dependency "TaskSchedulerConfiguration/DownStreamDependencyConfigList:2509162129382222,2509162129382223" where TaskId is 2509162129382222,2509162129382223 in downstream circular dependencies delete the event "TaskSchedulerConfiguration/EventListenerList:event_250916_213234,event_250916_213235" where EventName is event_250916_213234,event_250916_213235 in events delete the parameter "TaskSchedulerConfiguration/ParamTaskOutList:pp_out,pp_1" where ParamKey is pp_out,pp_1 in parameter output transmission delete the parameter "TaskSchedulerConfiguration/ParamTaskInList:pp_in,pp_1" where ParamKey is pp_in,pp_1 in parameter application delete the output registration "TaskSchedulerConfiguration/TaskOutputRegistryList:6578laxif4d1" where TablePhysicalId is 6578laxif4d1 in product registration.
        /// </summary>
        [JsonProperty("FieldToRemoveList")]
        public string[] FieldToRemoveList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamObj(map, prefix + "NewSetting.", this.NewSetting);
            this.SetParamArraySimple(map, prefix + "FieldToRemoveList.", this.FieldToRemoveList);
        }
    }
}

