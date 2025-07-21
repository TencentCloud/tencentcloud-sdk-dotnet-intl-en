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

    public class RefreshBatchRelatedInstance : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Refresh instance status. if the instance is removed or terminated during refresh, the status will be updated to NOT_FOUND. valid values: <li>WAITING: pending refresh;</li> <li>INIT: initializing;</li> <li>RUNNING: refreshing;</li> <li>FAILED: refresh FAILED;</li> <li>CANCELLED: CANCELLED;</li> <li>SUCCESSFUL: refresh SUCCESSFUL;</li> <li>NOT_FOUND: instance does NOT exist.</li>.
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// The most recent scaling activity ID during instance refresh can be queried via the DescribeAutoScalingActivities api.
        /// Please note that scaling activities differ from instance refresh activities; a single instance refresh activity may involve multiple scaling activities.
        /// </summary>
        [JsonProperty("LastActivityId")]
        public string LastActivityId{ get; set; }

        /// <summary>
        /// Describes the instance refresh status.
        /// </summary>
        [JsonProperty("InstanceStatusMessage")]
        public string InstanceStatusMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "LastActivityId", this.LastActivityId);
            this.SetParamSimple(map, prefix + "InstanceStatusMessage", this.InstanceStatusMessage);
        }
    }
}

