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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceAuditLogFilters : AbstractModel
    {
        
        /// <summary>
        /// Filter condition. The search conditions are supported as follows:
        /// 
        /// Include/Exclude, and Include/Exclude (segment dimension) can be used to search for:
        /// `sql` - SQL details.
        /// 
        /// `Equal to`, `Not equal to`, `Include`, and `Exclude` can be used to search for:
        /// `host` - Client IP,
        /// `user` - Username,
        /// `DBName` - Database name.
        /// 
        /// `Equal to` and `Not equal to` can be used to search for:
        /// `sqlType` - SQL type,
        /// `errCode` - Error code,
        /// `threadId` - Thread ID.
        /// 
        /// Range search is supported for:
        /// `execTime`- Execution time (μs),
        /// `lockWaitTime` - Lock wait time (μs),
        /// `ioWaitTime` - IO wait time (μs),
        /// `trxLivingTime` - Transaction duration (μs),
        /// `cpuTime` - CPU time (μs),
        /// `checkRows` - Number of scanned rows,
        /// `affectRows` - Number of affected rows,
        /// `sentRows` - Number of returned rows.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Filter. Valid values:
        /// `WINC` - Include (segment dimension)
        /// `WEXC` - Exclude (segment dimension)
        /// `INC` - Include,
        /// `EXC` - Exclude,
        /// `EQS` - Equal to,
        /// `NEQ` - Not equal to.
        /// `RA` - Range
        /// </summary>
        [JsonProperty("Compare")]
        public string Compare{ get; set; }

        /// <summary>
        /// The filter value. In a reverse query, multiple values are in an "AND" relationship; while in a forward query, multiple values are in an "OR" relationship.
        /// </summary>
        [JsonProperty("Value")]
        public string[] Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Compare", this.Compare);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
        }
    }
}

