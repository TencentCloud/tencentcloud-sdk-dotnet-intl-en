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

    public class LifecycleActionResultInfo : AbstractModel
    {
        
        /// <summary>
        /// ID of the lifecycle hook
        /// </summary>
        [JsonProperty("LifecycleHookId")]
        public string LifecycleHookId{ get; set; }

        /// <summary>
        /// ID of the instance
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Execution task ID. You can query the result by using the [DescribeInvocations](https://intl.cloud.tencent.com/document/api/1340/52679?from_cn_redirect=1) API of TAT. 
        /// </summary>
        [JsonProperty("InvocationId")]
        public string InvocationId{ get; set; }

        /// <summary>
        /// Result of command invocation,
        /// <li>`SUCCESSFUL`: Successful command invocation. It does mean that the task is successfully. You can query the task result with the `InvocationId.</li>
        /// <li>`FAILED`: Failed to invoke the command</li>
        /// <li>`NONE`</li>
        /// </summary>
        [JsonProperty("InvokeCommandResult")]
        public string InvokeCommandResult{ get; set; }

        /// <summary>
        /// Notification result, which indicates whether it is successful to notify CMQ/TDMQ.<br>
        /// <li>SUCCESSFUL: It is successful to notify CMQ/TDMQ.</li>
        /// <li>FAILED: It is failed to notify CMQ/TDMQ.</li>
        /// <li>NONE</li>
        /// </summary>
        [JsonProperty("NotificationResult")]
        public string NotificationResult{ get; set; }

        /// <summary>
        /// Result of the lifecyle hook action. Values: CONTINUE, ABANDON
        /// </summary>
        [JsonProperty("LifecycleActionResult")]
        public string LifecycleActionResult{ get; set; }

        /// <summary>
        /// Reason of the result <br>
        /// <li>`HEARTBEAT_TIMEOUT`: Heartbeat timed out. The setting of `DefaultResult` is used.</li>
        /// <li>`NOTIFICATION_FAILURE`: Failed to send the notification. The setting of `DefaultResult` is used.</li>
        /// <li>`CALL_INTERFACE`: Calls the `CompleteLifecycleAction` to set the result</li>
        /// <li>ANOTHER_ACTION_ABANDON: It has been set to `ABANDON` by another operation.</li>
        /// <li>COMMAND_CALL_FAILURE: Failed to call the command. The DefaultResult is applied.</li>
        /// <li>COMMAND_EXEC_FINISH: Command completed</li>
        /// <li>COMMAND_CALL_FAILURE: Failed to execute the command. The DefaultResult is applied.</li>
        /// <li>COMMAND_EXEC_RESULT_CHECK_FAILURE: Failed to check the command result. The DefaultResult is applied.</li>
        /// </summary>
        [JsonProperty("ResultReason")]
        public string ResultReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LifecycleHookId", this.LifecycleHookId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InvocationId", this.InvocationId);
            this.SetParamSimple(map, prefix + "InvokeCommandResult", this.InvokeCommandResult);
            this.SetParamSimple(map, prefix + "NotificationResult", this.NotificationResult);
            this.SetParamSimple(map, prefix + "LifecycleActionResult", this.LifecycleActionResult);
            this.SetParamSimple(map, prefix + "ResultReason", this.ResultReason);
        }
    }
}

