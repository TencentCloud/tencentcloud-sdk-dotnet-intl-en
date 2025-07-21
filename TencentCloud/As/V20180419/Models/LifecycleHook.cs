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

    public class LifecycleHook : AbstractModel
    {
        
        /// <summary>
        /// Lifecycle hook ID
        /// </summary>
        [JsonProperty("LifecycleHookId")]
        public string LifecycleHookId{ get; set; }

        /// <summary>
        /// Lifecycle hook name
        /// </summary>
        [JsonProperty("LifecycleHookName")]
        public string LifecycleHookName{ get; set; }

        /// <summary>
        /// Auto scaling group ID
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// Action to be taken by the scaling group in case of lifecycle hook timeout or LifecycleCommand execution failure. valid values:.
        /// -CONTINUE execution by default means capacity expansion or reduction.
        /// -For scale-out hooks, cvms with hook timeout or failed LifecycleCommand execution will be released directly or removed; for scale-in hooks, scale-in activities will continue.
        /// </summary>
        [JsonProperty("DefaultResult")]
        public string DefaultResult{ get; set; }

        /// <summary>
        /// Specifies the timeout waiting time of the lifecycle hook in seconds. value range: 30 to 7200.
        /// </summary>
        [JsonProperty("HeartbeatTimeout")]
        public long? HeartbeatTimeout{ get; set; }

        /// <summary>
        /// Scenario for entering the lifecycle hook. valid values:.
        /// -`INSTANCE_LAUNCHING`: the lifecycle hook is being scaled out.
        /// -INSTANCE_TERMINATING: scale-in lifecycle hook.
        /// </summary>
        [JsonProperty("LifecycleTransition")]
        public string LifecycleTransition{ get; set; }

        /// <summary>
        /// Additional information for the notification target
        /// </summary>
        [JsonProperty("NotificationMetadata")]
        public string NotificationMetadata{ get; set; }

        /// <summary>
        /// Creation time. uses UTC for timing.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Notification target
        /// </summary>
        [JsonProperty("NotificationTarget")]
        public NotificationTarget NotificationTarget{ get; set; }

        /// <summary>
        /// Specifies the scenario type for performing the lifecycle hook. valid values: NORMAL and EXTENSION. default value: NORMAL.
        /// Description: when set to `EXTENSION`, the lifecycle hook will be triggered during `AttachInstances`, `DetachInstances`, or `RemoveInstances` API calls. if set to `NORMAL`, the lifecycle hook will not be triggered by these apis.
        /// </summary>
        [JsonProperty("LifecycleTransitionType")]
        public string LifecycleTransitionType{ get; set; }

        /// <summary>
        /// Remote command execution object.
        /// </summary>
        [JsonProperty("LifecycleCommand")]
        public LifecycleCommand LifecycleCommand{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LifecycleHookId", this.LifecycleHookId);
            this.SetParamSimple(map, prefix + "LifecycleHookName", this.LifecycleHookName);
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "DefaultResult", this.DefaultResult);
            this.SetParamSimple(map, prefix + "HeartbeatTimeout", this.HeartbeatTimeout);
            this.SetParamSimple(map, prefix + "LifecycleTransition", this.LifecycleTransition);
            this.SetParamSimple(map, prefix + "NotificationMetadata", this.NotificationMetadata);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamObj(map, prefix + "NotificationTarget.", this.NotificationTarget);
            this.SetParamSimple(map, prefix + "LifecycleTransitionType", this.LifecycleTransitionType);
            this.SetParamObj(map, prefix + "LifecycleCommand.", this.LifecycleCommand);
        }
    }
}

