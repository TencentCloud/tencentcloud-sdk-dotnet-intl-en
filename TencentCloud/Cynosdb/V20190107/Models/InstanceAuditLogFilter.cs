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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceAuditLogFilter : AbstractModel
    {
        
        /// <summary>
        /// Filter item. Currently supports the following search criteria:
        /// 
        /// Includes, excludes, includes (segment dimension), excludes (segment dimension): sql - SQL detail; alarmLevel - alarm level; ruleTemplateId - rule template id
        /// 
        /// Equal to, not equal to, contains, does not contain: host - client IP address; user - userName; dbName - database name;
        /// 
        /// Equal, not equal to: sqlType - SQL type; errCode - error code; threadId - thread ID.
        /// 
        /// Range search (time type is unified to µs): execTime - execution time; lockWaitTime - execution time; ioWaitTime - IO wait time; trxLivingTime - transaction duration; cpuTime - CPU time; checkRows - scanned rows; affectRows - number of affected rows; sentRows - rows returned.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Filter criteria. The following conditions are supported:
        /// WINC-Contains (segment dimension)
        /// WEXC - Excluding (segment dimension)
        /// INC - included
        /// EXC - Excluding
        /// EQS - equal to
        /// NEQ - not equal to
        /// RA - Range.
        /// </summary>
        [JsonProperty("Compare")]
        public string Compare{ get; set; }

        /// <summary>
        /// Filtered value. In reverse query, multiple values have an AND relationship. In forward query, multiple values have an OR relationship.
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

