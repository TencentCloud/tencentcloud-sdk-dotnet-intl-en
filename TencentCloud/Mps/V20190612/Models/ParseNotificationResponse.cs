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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParseNotificationResponse : AbstractModel
    {
        
        /// <summary>
        /// The event type. Valid values:
        /// <li>WorkflowTask</li>
        /// <li>EditMediaTask</li>
        /// <li>ScheduleTask (scheme)</li>
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// Information of a video processing task. This field has a value only when `TaskType` is `WorkflowTask`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkflowTaskEvent")]
        public WorkflowTask WorkflowTaskEvent{ get; set; }

        /// <summary>
        /// Video editing task information. This field has a value only when `TaskType` is `EditMediaTask`.
        /// </summary>
        [JsonProperty("EditMediaTaskEvent")]
        public EditMediaTask EditMediaTaskEvent{ get; set; }

        /// <summary>
        /// The ID used for deduplication. If there was a request with the same ID in the last seven days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// The information of a scheme. This parameter is valid only if `TaskType` is `ScheduleTask`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScheduleTaskEvent")]
        public ScheduleTask ScheduleTaskEvent{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamObj(map, prefix + "WorkflowTaskEvent.", this.WorkflowTaskEvent);
            this.SetParamObj(map, prefix + "EditMediaTaskEvent.", this.EditMediaTaskEvent);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamObj(map, prefix + "ScheduleTaskEvent.", this.ScheduleTaskEvent);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

