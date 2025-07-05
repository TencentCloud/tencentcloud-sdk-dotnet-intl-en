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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTaskVersionDsRequest : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("Task")]
        public BatchCreateTaskVersionDTO Task{ get; set; }

        /// <summary>
        /// Whether to verify that the parent task has been submitted for scheduling
        /// </summary>
        [JsonProperty("NeedCheckParentSubmitted")]
        public bool? NeedCheckParentSubmitted{ get; set; }

        /// <summary>
        /// Automatic Execution
        /// </summary>
        [JsonProperty("AutoRun")]
        public bool? AutoRun{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Request Source, WEB frontend; CLIENT client
        /// </summary>
        [JsonProperty("RequestFromSource")]
        public string RequestFromSource{ get; set; }

        /// <summary>
        /// Alert Method: email-Email; sms-SMS; wecom-WeCom
        /// </summary>
        [JsonProperty("AlarmWays")]
        public string AlarmWays{ get; set; }

        /// <summary>
        /// Alert Object: 1-Project Administrator, 2-Task Owner
        /// </summary>
        [JsonProperty("AlarmRecipientTypes")]
        public string AlarmRecipientTypes{ get; set; }

        /// <summary>
        /// Whether to verify circular dependencies, default is true. If false is passed after successful validation using CheckTaskCycleLink and CheckTaskCycleConfiguration interfaces, the back-end server will not perform validation
        /// </summary>
        [JsonProperty("EnableCheckTaskCycleLink")]
        public bool? EnableCheckTaskCycleLink{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Task.", this.Task);
            this.SetParamSimple(map, prefix + "NeedCheckParentSubmitted", this.NeedCheckParentSubmitted);
            this.SetParamSimple(map, prefix + "AutoRun", this.AutoRun);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RequestFromSource", this.RequestFromSource);
            this.SetParamSimple(map, prefix + "AlarmWays", this.AlarmWays);
            this.SetParamSimple(map, prefix + "AlarmRecipientTypes", this.AlarmRecipientTypes);
            this.SetParamSimple(map, prefix + "EnableCheckTaskCycleLink", this.EnableCheckTaskCycleLink);
        }
    }
}

