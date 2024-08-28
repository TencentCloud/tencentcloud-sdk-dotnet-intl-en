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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRansomDefenseMachineListRequest : AbstractModel
    {
        
        /// <summary>
        /// Pagination parameters (The maximum quantity is 100)
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Pagination parameter
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Filter criteria
        /// <li>Ips - String - required: no - query by IP</li>
        /// <li>MachineNames - String - required: no - query by instance name</li>
        /// <li>Names - String - required: no - query by policy name</li>
        /// <li>Status - String - required: no - policy status: 0: backup in progress; 1: backup successful; 2: backup failed; 9: no backup</li>
        /// <li>LastBackupStatus - String - required: no - last backup status: 0: backup in progress; 1: backup succeeded; 2: backup failed; 9: no backup</li>
        /// <li>LastBackupTimeBegin - String - required: no - start of the last backup time</li>
        /// <li>LastBackupTimeEnd - String - required: no - end of the last backup time</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// Sorting method: ASC / DESC
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting fields, support CreateTime, LastBackupTime, BackupCount.
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

