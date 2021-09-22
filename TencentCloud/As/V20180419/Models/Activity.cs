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
        /// Type of the scaling activity. Valid values:<br>
        /// <li>SCALE_OUT: scales out. <li>SCALE_IN: scales in. <li>ATTACH_INSTANCES: adds an instance. <li>REMOVE_INSTANCES: terminates an instance. <li>DETACH_INSTANCES: removes an instance. <li>TERMINATE_INSTANCES_UNEXPECTEDLY: terminates an instance in the CVM console. <li>REPLACE_UNHEALTHY_INSTANCE: replaces an unhealthy instance.
        /// <li>START_INSTANCES: starts an instance.
        /// <li>STOP_INSTANCES: stops an instance.
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// Scaling activity status. Value range:<br>
        /// <li>INIT: initializing
        /// <li>RUNNING: running
        /// <li>SUCCESSFUL: succeeded
        /// <li>PARTIALLY_SUCCESSFUL: partially succeeded
        /// <li>FAILED: failed
        /// <li>CANCELLED: canceled
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
        /// Information set of the instances related to the scaling activity.
        /// </summary>
        [JsonProperty("ActivityRelatedInstanceSet")]
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
        }
    }
}

