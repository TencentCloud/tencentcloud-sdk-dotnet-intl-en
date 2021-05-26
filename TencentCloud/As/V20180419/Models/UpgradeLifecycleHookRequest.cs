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

    public class UpgradeLifecycleHookRequest : AbstractModel
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
        /// Scenario for the lifecycle hook. Value range: "INSTANCE_LAUNCHING", "INSTANCE_TERMINATING"
        /// </summary>
        [JsonProperty("LifecycleTransition")]
        public string LifecycleTransition{ get; set; }

        /// <summary>
        /// Defines the action to be taken by the auto scaling group upon lifecycle hook timeout. Value range: "CONTINUE", "ABANDON". Default value: "CONTINUE"
        /// </summary>
        [JsonProperty("DefaultResult")]
        public string DefaultResult{ get; set; }

        /// <summary>
        /// The maximum length of time (in seconds) that can elapse before the lifecycle hook times out. Value range: 30-7200. Default value: 300
        /// </summary>
        [JsonProperty("HeartbeatTimeout")]
        public long? HeartbeatTimeout{ get; set; }

        /// <summary>
        /// Additional information of a notification that Auto Scaling sends to targets. This parameter is left empty by default.
        /// </summary>
        [JsonProperty("NotificationMetadata")]
        public string NotificationMetadata{ get; set; }

        /// <summary>
        /// Notification target
        /// </summary>
        [JsonProperty("NotificationTarget")]
        public NotificationTarget NotificationTarget{ get; set; }

        /// <summary>
        /// The scenario where the lifecycle hook is applied. `EXTENSION`: the lifecycle hook will be triggered when AttachInstances, DetachInstances or RemoveInstaces is called. `NORMAL`: the lifecycle hook is not triggered by the above APIs. 
        /// </summary>
        [JsonProperty("LifecycleTransitionType")]
        public string LifecycleTransitionType{ get; set; }


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
        }
    }
}

