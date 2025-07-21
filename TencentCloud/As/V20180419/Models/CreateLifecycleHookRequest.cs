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

    public class CreateLifecycleHookRequest : AbstractModel
    {
        
        /// <summary>
        /// Scaling group ID. obtain available scaling group ids in the following ways:.
        /// <li>Query the scaling group ID by logging in to the [console](https://console.cloud.tencent.com/autoscaling/group).</li>.
        /// <li>Specifies the scaling group ID obtained by calling the api [DescribeAutoScalingGroups](https://intl.cloud.tencent.com/document/api/377/20438?from_cn_redirect=1) and retrieving the AutoScalingGroupId from the return information.</li>.
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// Lifecycle hook name, which can contain Chinese characters, letters, numbers, underscores (_), hyphens (-), and periods (.) with a maximum length of 128 bytes.
        /// </summary>
        [JsonProperty("LifecycleHookName")]
        public string LifecycleHookName{ get; set; }

        /// <summary>
        /// Scenario for performing the lifecycle hook. valid values:.
        /// <Li>`INSTANCE_LAUNCHING`: the lifecycle hook is being scaled out.</li>.
        /// <Li>`INSTANCE_TERMINATING`: scaling in lifecycle hook</li>.
        /// </summary>
        [JsonProperty("LifecycleTransition")]
        public string LifecycleTransition{ get; set; }

        /// <summary>
        /// Action to be taken by the scaling group in case of lifecycle hook timeout or LifecycleCommand execution failure. valid values:.
        /// <Li>CONTINUE: default value, means continue execution of capacity expansion or reduction</li>.
        /// <li>ABANDON: for scale-out hooks, CVM instances with hook timeout or failed LifecycleCommand execution will be released directly or removed. for scale-in hooks, scale-in activities will continue.</li>.
        /// </summary>
        [JsonProperty("DefaultResult")]
        public string DefaultResult{ get; set; }

        /// <summary>
        /// The maximum length of time (in seconds) that can elapse before the lifecycle hook times out. Value range: 30-7200. Default value: 300
        /// </summary>
        [JsonProperty("HeartbeatTimeout")]
        public long? HeartbeatTimeout{ get; set; }

        /// <summary>
        /// Additional information of a notification that auto scaling sends to targets. this parameter is set when you configure a notification (default value: ""), with a maximum length of 1024 characters. NotificationMetadata and LifecycleCommand are mutually exclusive, and either can be specified.
        /// </summary>
        [JsonProperty("NotificationMetadata")]
        public string NotificationMetadata{ get; set; }

        /// <summary>
        /// Notification target. `NotificationTarget` and `LifecycleCommand` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("NotificationTarget")]
        public NotificationTarget NotificationTarget{ get; set; }

        /// <summary>
        /// Specifies the scenario type for performing the lifecycle hook. valid values: NORMAL and EXTENSION. default value: NORMAL.
        /// `EXTENSION`: the lifecycle hook will be triggered when calling [AttachInstances](https://intl.cloud.tencent.com/document/api/377/20441?from_cn_redirect=1), [DetachInstances](https://intl.cloud.tencent.com/document/api/377/20436?from_cn_redirect=1), [removeinstances](https://intl.cloud.tencent.com/document/api/377/20431?from_cn_redirect=1), [StopAutoScalingInstances](https://intl.cloud.tencent.com/document/api/377/40286?from_cn_redirect=1), [StartAutoScalingInstances](https://intl.cloud.tencent.com/document/api/377/40287?from_cn_redirect=1), or [StartInstanceRefresh](https://intl.cloud.tencent.com/document/api/377/99172?from_cn_redirect=1). `NORMAL`: the lifecycle hook is not triggered by these apis.
        /// </summary>
        [JsonProperty("LifecycleTransitionType")]
        public string LifecycleTransitionType{ get; set; }

        /// <summary>
        /// Specifies the remote command execution object. NotificationTarget and NotificationMetadata are mutually exclusive with this parameter. either cannot be specified simultaneously.
        /// </summary>
        [JsonProperty("LifecycleCommand")]
        public LifecycleCommand LifecycleCommand{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
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

