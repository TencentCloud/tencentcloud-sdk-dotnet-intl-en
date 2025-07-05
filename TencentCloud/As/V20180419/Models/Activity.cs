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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Activity : AbstractModel
    {
        
        /// <summary>
        /// Auto scaling group ID.
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// Scaling activity ID.
        /// </summary>
        [JsonProperty("ActivityId")]
        public string ActivityId{ get; set; }

        /// <summary>
        /// Scaling activity type. Valid values:
        /// <li>SCALE_OUT: Scale out an instance.</li>
        /// <li>SCALE_IN: Scale in an instance.</li>
        /// <li>ATTACH_INSTANCES: Add an instance.</li>
        /// <li>REMOVE_INSTANCES: Terminate an instance.</li>
        /// <li>DETACH_INSTANCES: Remove an instance.</li>
        /// <li>TERMINATE_INSTANCES_UNEXPECTEDLY: Terminate an instance in the CVM console.</li>
        /// <li>REPLACE_UNHEALTHY_INSTANCE: Replace an unhealthy instance.</li>
        /// <li>START_INSTANCES: Start an instance.</li>
        /// <li>STOP_INSTANCES: Stop an instance.</li>
        /// <li>INVOKE_COMMAND: Execute a command.</li>
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// Scaling activity status. Valid values:
        /// <li>INIT: initializing.</li>
        /// <li>RUNNING: running.</li>
        /// <li>SUCCESSFUL: successful.</li>
        /// <li>PARTIALLY_SUCCESSFUL: partially successful.</li>
        /// <li>FAILED: failed.</li>
        /// <li>CANCELLED: canceled.</li>
        /// </summary>
        [JsonProperty("StatusCode")]
        public string StatusCode{ get; set; }

        /// <summary>
        /// Description of the scaling activity status.
        /// </summary>
        [JsonProperty("StatusMessage")]
        public string StatusMessage{ get; set; }

        /// <summary>
        /// Cause of the scaling activity.
        /// </summary>
        [JsonProperty("Cause")]
        public string Cause{ get; set; }

        /// <summary>
        /// Description of the scaling activity.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Start time of the scaling activity.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time of the scaling activity.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Creation time of the scaling activity.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// This parameter has been deprecated.
        /// </summary>
        [JsonProperty("ActivityRelatedInstanceSet")]
        [System.Obsolete]
        public ActivtyRelatedInstance[] ActivityRelatedInstanceSet{ get; set; }

        /// <summary>
        /// Brief description of the scaling activity status.
        /// </summary>
        [JsonProperty("StatusMessageSimplified")]
        public string StatusMessageSimplified{ get; set; }

        /// <summary>
        /// Result of the lifecycle hook action in the scaling activity
        /// </summary>
        [JsonProperty("LifecycleActionResultSet")]
        public LifecycleActionResultInfo[] LifecycleActionResultSet{ get; set; }

        /// <summary>
        /// Detailed description of scaling activity status
        /// </summary>
        [JsonProperty("DetailedStatusMessageSet")]
        public DetailedStatusMessage[] DetailedStatusMessageSet{ get; set; }

        /// <summary>
        /// Result of the command execution
        /// </summary>
        [JsonProperty("InvocationResultSet")]
        public InvocationResult[] InvocationResultSet{ get; set; }

        /// <summary>
        /// Information set of the instances related to the scaling activity.
        /// </summary>
        [JsonProperty("RelatedInstanceSet")]
        public RelatedInstance[] RelatedInstanceSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "ActivityType", this.ActivityType);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "StatusMessage", this.StatusMessage);
            this.SetParamSimple(map, prefix + "Cause", this.Cause);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "ActivityRelatedInstanceSet.", this.ActivityRelatedInstanceSet);
            this.SetParamSimple(map, prefix + "StatusMessageSimplified", this.StatusMessageSimplified);
            this.SetParamArrayObj(map, prefix + "LifecycleActionResultSet.", this.LifecycleActionResultSet);
            this.SetParamArrayObj(map, prefix + "DetailedStatusMessageSet.", this.DetailedStatusMessageSet);
            this.SetParamArrayObj(map, prefix + "InvocationResultSet.", this.InvocationResultSet);
            this.SetParamArrayObj(map, prefix + "RelatedInstanceSet.", this.RelatedInstanceSet);
        }
    }
}

