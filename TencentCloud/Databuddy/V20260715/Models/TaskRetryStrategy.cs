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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskRetryStrategy : AbstractModel
    {
        
        /// <summary>
        /// Maximum retry count. Default value: 3.
        /// </summary>
        [JsonProperty("MaxRetryTimes")]
        public long? MaxRetryTimes{ get; set; }

        /// <summary>
        /// Waiting time between retries. Default value: 5
        /// </summary>
        [JsonProperty("RetryBetweenWaitTime")]
        public long? RetryBetweenWaitTime{ get; set; }

        /// <summary>
        /// Time unit to wait between retries
        /// ms: MILLISECOND second: SECOND minute (default): MINUTE hour: HOUR
        /// </summary>
        [JsonProperty("RetryBetweenWaitTimeUnit")]
        public string RetryBetweenWaitTimeUnit{ get; set; }

        /// <summary>
        /// Retry switch when task running fails. true by default.
        /// </summary>
        [JsonProperty("TaskRunFailureRetrySwitch")]
        public bool? TaskRunFailureRetrySwitch{ get; set; }

        /// <summary>
        /// Retry switch for task timeout, false by default
        /// </summary>
        [JsonProperty("TaskRunTimeoutRetrySwitch")]
        public bool? TaskRunTimeoutRetrySwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxRetryTimes", this.MaxRetryTimes);
            this.SetParamSimple(map, prefix + "RetryBetweenWaitTime", this.RetryBetweenWaitTime);
            this.SetParamSimple(map, prefix + "RetryBetweenWaitTimeUnit", this.RetryBetweenWaitTimeUnit);
            this.SetParamSimple(map, prefix + "TaskRunFailureRetrySwitch", this.TaskRunFailureRetrySwitch);
            this.SetParamSimple(map, prefix + "TaskRunTimeoutRetrySwitch", this.TaskRunTimeoutRetrySwitch);
        }
    }
}

