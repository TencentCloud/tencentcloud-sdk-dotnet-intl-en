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

    public class CompleteLifecycleActionRequest : AbstractModel
    {
        
        /// <summary>
        /// Lifecycle hook ID. you can get the lifecycle hook ID by calling the api [DescribeLifecycleHooks](https://intl.cloud.tencent.com/document/api/377/34452?from_cn_redirect=1) and retrieving the `LifecycleHookId` from the returned information.
        /// </summary>
        [JsonProperty("LifecycleHookId")]
        public string LifecycleHookId{ get; set; }

        /// <summary>
        /// Describes the result of the lifecycle action. valid values are as follows:.
        /// <Li>CONTINUE: default value, means continue execution of capacity expansion or reduction</li>.
        /// <li>ABANDON: for scale-out hooks, CVM instances with hook timeout or failed LifecycleCommand execution will be released directly or moved; for scale-in hooks, scale-in activities will continue.</li>.
        /// </summary>
        [JsonProperty("LifecycleActionResult")]
        public string LifecycleActionResult{ get; set; }

        /// <summary>
        /// One of the parameters `InstanceId` or `LifecycleActionToken` is required. you can get the instance ID by logging in to the [console](https://console.cloud.tencent.com/cvm/index) or making an api call to [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1) and retrieving the `InstanceId` from the returned information.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Lifecycle action token. specifies that one of `InstanceId` or `LifecycleActionToken` must be filled.
        /// The method for accessing the parameter is as follows: when the hook of the `NotificationTarget` parameter is triggered, deliver a message containing the token to the message queue specified in the `NotificationTarget` parameter. the message queue consumer can obtain the token from the message.
        /// </summary>
        [JsonProperty("LifecycleActionToken")]
        public string LifecycleActionToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LifecycleHookId", this.LifecycleHookId);
            this.SetParamSimple(map, prefix + "LifecycleActionResult", this.LifecycleActionResult);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LifecycleActionToken", this.LifecycleActionToken);
        }
    }
}

