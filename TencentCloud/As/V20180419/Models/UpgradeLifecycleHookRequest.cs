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

    public class UpgradeLifecycleHookRequest : AbstractModel
    {
        
        /// <summary>
        /// Lifecycle hook ID. you can call the api [DescribeLifecycleHooks](https://intl.cloud.tencent.com/document/api/377/34452?from_cn_redirect=1) and retrieve the LifecycleHookId from the returned information to obtain the lifecycle hook ID.
        /// </summary>
        [JsonProperty("LifecycleHookId")]
        public string LifecycleHookId{ get; set; }

        /// <summary>
        /// Lifecycle hook name, which can contain chinese characters, letters, numbers, underscores (_), hyphens (-), and periods (.) with a maximum length of 128 characters.
        /// </summary>
        [JsonProperty("LifecycleHookName")]
        public string LifecycleHookName{ get; set; }

        /// <summary>
        /// Scenario for performing the lifecycle hook. valid values:.
        /// `INSTANCE_LAUNCHING`: the lifecycle hook is being scaled out.
        /// `INSTANCE_TERMINATING`: the lifecycle hook is being scaled in.
        /// </summary>
        [JsonProperty("LifecycleTransition")]
        public string LifecycleTransition{ get; set; }

        /// <summary>
        /// Action to be taken by the scaling group in case of lifecycle hook timeout or LifecycleCommand execution failure. valid values are as follows:.
        /// Default value, means CONTINUE to execute capacity expansion or reduction.
        /// * ABANDON: for scale-out hooks, cvms that time out or fail to execute LifecycleCommand will be released directly or removed. for scale-in hooks, scale-in activities will continue.
        /// </summary>
        [JsonProperty("DefaultResult")]
        public string DefaultResult{ get; set; }

        /// <summary>
        /// The maximum length of time (in seconds) that can elapse before the lifecycle hook times out. Value range: 30-7200. Default value: 300
        /// </summary>
        [JsonProperty("HeartbeatTimeout")]
        public long? HeartbeatTimeout{ get; set; }

        /// <summary>
        /// Additional information sent by auto scaling to notification targets, used when configuring a notification (default value: ""). NotificationMetadata and LifecycleCommand are mutually exclusive parameters and cannot be specified simultaneously.
        /// </summary>
        [JsonProperty("NotificationMetadata")]
        public string NotificationMetadata{ get; set; }

        /// <summary>
        /// Notification result. `NotificationTarget` and `LifecycleCommand` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("NotificationTarget")]
        public NotificationTarget NotificationTarget{ get; set; }

        /// <summary>
        /// The scenario where the lifecycle hook is applied. `EXTENSION`: the lifecycle hook will be triggered when AttachInstances, DetachInstances or RemoveInstaces is called. `NORMAL`: the lifecycle hook is not triggered by the above APIs. 
        /// </summary>
        [JsonProperty("LifecycleTransitionType")]
        public string LifecycleTransitionType{ get; set; }

        /// <summary>
        /// Remote command execution object. `NotificationMetadata`, `NotificationTarget`, and `LifecycleCommand` are mutually exclusive and cannot be specified simultaneously.
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
            this.SetParamSimple(map, prefix + "LifecycleTransition", this.LifecycleTransition);
            this.SetParamSimple(map, prefix + "DefaultResult", this.DefaultResult);
            this.SetParamSimple(map, prefix + "HeartbeatTimeout", this.HeartbeatTimeout);
            this.SetParamSimple(map, prefix + "NotificationMetadata", this.NotificationMetadata);
            this.SetParamObj(map, prefix + "NotificationTarget.", this.NotificationTarget);
            this.SetParamSimple(map, prefix + "LifecycleTransitionType", this.LifecycleTransitionType);
            this.SetParamObj(map, prefix + "LifecycleCommand.", this.LifecycleCommand);
        }
    }
}

