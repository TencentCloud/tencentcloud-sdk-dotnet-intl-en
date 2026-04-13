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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMaintainTimeWindowRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. obtain through the api [DescribeDBInstances](https://www.tencentcloud.com/document/product/409/16773?lang=en).
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// Maintenance start time. time zone is UTC+8.
        /// </summary>
        [JsonProperty("MaintainStartTime")]
        public string MaintainStartTime{ get; set; }

        /// <summary>
        /// Maintenance duration. unit: hr. value range: [1,4].
        /// </summary>
        [JsonProperty("MaintainDuration")]
        public ulong? MaintainDuration{ get; set; }

        /// <summary>
        /// Specifies the maintenance period.
        /// </summary>
        [JsonProperty("MaintainWeekDays")]
        public string[] MaintainWeekDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "MaintainStartTime", this.MaintainStartTime);
            this.SetParamSimple(map, prefix + "MaintainDuration", this.MaintainDuration);
            this.SetParamArraySimple(map, prefix + "MaintainWeekDays.", this.MaintainWeekDays);
        }
    }
}

