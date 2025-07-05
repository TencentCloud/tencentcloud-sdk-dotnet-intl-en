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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateScheduleRequest : AbstractModel
    {
        
        /// <summary>
        /// The scheme name (max 128 characters). This name should be unique across your account.
        /// </summary>
        [JsonProperty("ScheduleName")]
        public string ScheduleName{ get; set; }

        /// <summary>
        /// The trigger of the scheme. If a file is uploaded to the specified bucket, the scheme will be triggered.
        /// </summary>
        [JsonProperty("Trigger")]
        public WorkflowTrigger Trigger{ get; set; }

        /// <summary>
        /// The subtasks of the scheme.
        /// </summary>
        [JsonProperty("Activities")]
        public Activity[] Activities{ get; set; }

        /// <summary>
        /// The bucket to save the output file. If you do not specify this parameter, the bucket in `Trigger` will be used.
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.
        /// If you do not specify this, the file will be saved to the trigger directory.
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// The notification configuration. If you do not specify this parameter, notifications will not be sent.
        /// </summary>
        [JsonProperty("TaskNotifyConfig")]
        public TaskNotifyConfig TaskNotifyConfig{ get; set; }

        /// <summary>
        /// Resource ID. Ensure the corresponding resource is in the enabled state. The default value is an account's primary resource ID.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduleName", this.ScheduleName);
            this.SetParamObj(map, prefix + "Trigger.", this.Trigger);
            this.SetParamArrayObj(map, prefix + "Activities.", this.Activities);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamObj(map, prefix + "TaskNotifyConfig.", this.TaskNotifyConfig);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

