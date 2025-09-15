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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InspectionTaskSettings : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier for inspection tasks.
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Inspection task group name.
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// Inspection task name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Inspection task parameter settings.
        /// </summary>
        [JsonProperty("TaskSettings")]
        public TaskSettings[] TaskSettings{ get; set; }

        /// <summary>
        /// Whether it is selected, with the valid values of "true" and "false".
        /// </summary>
        [JsonProperty("Selected")]
        public string Selected{ get; set; }

        /// <summary>
        /// Whether monitoring is enabled.
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// Event JSON template.
        /// </summary>
        [JsonProperty("SettingsJson")]
        public string SettingsJson{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "TaskSettings.", this.TaskSettings);
            this.SetParamSimple(map, prefix + "Selected", this.Selected);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "SettingsJson", this.SettingsJson);
        }
    }
}

