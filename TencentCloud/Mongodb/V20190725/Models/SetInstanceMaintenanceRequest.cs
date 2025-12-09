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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetInstanceMaintenanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the instance ID. For example, cmgo-p8vn****. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Start time of the maintenance window. The value range is any hour or half-hour between 00:00 and 23:00, such as 00:00 or 00:30.
        /// </summary>
        [JsonProperty("MaintenanceStart")]
        public string MaintenanceStart{ get; set; }

        /// <summary>
        /// End time of the maintenance window.
        /// - The value range is any hour or half-hour between 00:00 and 23:00. The minimum value of maintenance time is 30 minutes, and the maximum value is 3 hours.
        /// - The end time should be later than the start time.
        /// </summary>
        [JsonProperty("MaintenanceEnd")]
        public string MaintenanceEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MaintenanceStart", this.MaintenanceStart);
            this.SetParamSimple(map, prefix + "MaintenanceEnd", this.MaintenanceEnd);
        }
    }
}

