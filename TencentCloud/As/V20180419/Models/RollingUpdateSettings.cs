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

    public class RollingUpdateSettings : AbstractModel
    {
        
        /// <summary>
        /// Batch quantity. The batch quantity should be a positive integer greater than 0, but cannot exceed the total number of instances pending refresh.
        /// </summary>
        [JsonProperty("BatchNumber")]
        public ulong? BatchNumber{ get; set; }

        /// <summary>
        /// Pause policy between batches. Default value: Automatic. Valid values:
        /// <li>FIRST_BATCH_PAUSE: Pause after the first batch of updates is completed.</li>
        /// <li>BATCH_INTERVAL_PAUSE: Pause between batches.</li>
        /// <li>AUTOMATIC: Do not pause.</li>
        /// </summary>
        [JsonProperty("BatchPause")]
        public string BatchPause{ get; set; }

        /// <summary>
        /// The maximum additional quantity of instances. After this parameter is set, create a batch of additional pay-as-you-go instances according to the launch configuration before the rolling update starts. After the rolling update is completed, the additional instances will be terminated.This parameter is used to ensure a certain number of instances available during the rolling update. The maximum additional quantity of instances cannot exceed the number of refreshing instances in a single batch of the rolling update. The rollback process does not support this parameter currently.
        /// </summary>
        [JsonProperty("MaxSurge")]
        public long? MaxSurge{ get; set; }

        /// <summary>
        /// Failure handling strategy. default value: AUTO_PAUSE. valid values:.
        /// <Li>AUTO_PAUSE: suspended after refresh fails</li>.
        /// <li>AUTO_ROLLBACK: roll back after a refresh fails. each batch rolls back one instance during ROLLBACK, and the CheckInstanceTargetHealth parameter value matches the original refresh activity. no need to roll back if the shrinkage process introduced by the MaxSurge parameter fails. a cancel action will replace the ROLLBACK.</li>.
        /// <Li>AUTO_CANCEL: cancel after refresh fails</li>.
        /// </summary>
        [JsonProperty("FailProcess")]
        public string FailProcess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BatchNumber", this.BatchNumber);
            this.SetParamSimple(map, prefix + "BatchPause", this.BatchPause);
            this.SetParamSimple(map, prefix + "MaxSurge", this.MaxSurge);
            this.SetParamSimple(map, prefix + "FailProcess", this.FailProcess);
        }
    }
}

