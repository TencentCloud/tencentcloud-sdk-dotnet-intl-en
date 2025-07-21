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

    public class RefreshActivity : AbstractModel
    {
        
        /// <summary>
        /// Scaling group ID.
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// Refresh activity ID.
        /// </summary>
        [JsonProperty("RefreshActivityId")]
        public string RefreshActivityId{ get; set; }

        /// <summary>
        /// Original refresh activity ID. exists only in rollback refresh activity.
        /// </summary>
        [JsonProperty("OriginRefreshActivityId")]
        public string OriginRefreshActivityId{ get; set; }

        /// <summary>
        /// Refresh batch information list.
        /// </summary>
        [JsonProperty("RefreshBatchSet")]
        public RefreshBatch[] RefreshBatchSet{ get; set; }

        /// <summary>
        /// Refresh mode. valid values as follows:.
        /// <Li>ROLLING_UPDATE_RESET: reinstall the system for rolling updates.</li>.
        /// <li>ROLLING_UPDATE_REPLACE: Create an instance and replace the old instance with it for rolling updates. This mode does not support the rollback API currently.</li>
        /// </summary>
        [JsonProperty("RefreshMode")]
        public string RefreshMode{ get; set; }

        /// <summary>
        /// Instance update setting parameters.
        /// </summary>
        [JsonProperty("RefreshSettings")]
        public RefreshSettings RefreshSettings{ get; set; }

        /// <summary>
        /// Refresh activity type. Valid values:
        /// <li>NORMAL: normal refresh activity.</li>
        /// <li>ROLLBACK: rollback refresh activity.</li>
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// Refresh activity status. Valid values:
        /// <li>INIT: initializing.</li>
        /// <li>RUNNING: running.</li>
        /// <li>SUCCESSFUL: successful.</li>
        /// <li>FAILED_PAUSE: paused due to the failure of a refresh batch.</li>
        /// <li>AUTO_PAUSE: automatically paused due to the pause policy.</li>
        /// <li>MANUAL_PAUSE: manually paused.</li>
        /// <li>CANCELLED: canceled.</li>
        /// <li>FAILED: failed.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Current refresh batch number. for example, 2 indicates the second batch of instances is being refreshed by the current activity.
        /// </summary>
        [JsonProperty("CurrentRefreshBatchNum")]
        public ulong? CurrentRefreshBatchNum{ get; set; }

        /// <summary>
        /// The activity start time is refreshed in standard `UTC` time, in the format `YYYY-MM-DDTHH:MM:ssZ`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Refresh activity end time, in standard UTC time, in the format YYYY-MM-DDTHH:MM:ssZ.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Refresh activity creation time, in standard UTC time, in the format YYYY-MM-DDTHH:MM:ssZ.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "RefreshActivityId", this.RefreshActivityId);
            this.SetParamSimple(map, prefix + "OriginRefreshActivityId", this.OriginRefreshActivityId);
            this.SetParamArrayObj(map, prefix + "RefreshBatchSet.", this.RefreshBatchSet);
            this.SetParamSimple(map, prefix + "RefreshMode", this.RefreshMode);
            this.SetParamObj(map, prefix + "RefreshSettings.", this.RefreshSettings);
            this.SetParamSimple(map, prefix + "ActivityType", this.ActivityType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CurrentRefreshBatchNum", this.CurrentRefreshBatchNum);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

