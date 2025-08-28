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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMaintenanceSpanRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, in the format of mssql-k8voqdlz.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Specifies the days in each week allowed for maintenance. For example, [1,2,3,4,5,6,7] indicates that all days from Monday to Sunday are allowed for maintenance. If this parameter is left unspecified, this value is not modified.
        /// </summary>
        [JsonProperty("Weekly")]
        public long?[] Weekly{ get; set; }

        /// <summary>
        /// Maintenance start time each day. For example, 10:24 indicates that the maintenance window starts at 10:24. If this parameter is left unspecified, this value is not modified.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Maintenance duration each day, in hours. For example, 1 indicates that the duration is 1 hour after maintenance starts. If this parameter is left unspecified, this value is not modified.
        /// </summary>
        [JsonProperty("Span")]
        public ulong? Span{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "Weekly.", this.Weekly);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Span", this.Span);
        }
    }
}

