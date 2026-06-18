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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogFilter : AbstractModel
    {
        
        /// <summary>
        /// Filter criterion name.
        /// 
        /// For example: sql - SQL command details
        /// 
        /// host - client IP
        /// user - database account;
        /// dbName – Database name;
        /// sqlType - SQL type;
        /// Error code
        /// 
        /// execTime - Execution time
        /// lockWaitTime - Lock waiting time
        /// ioWaitTime - IO wait time
        /// trxLivingTime - Transaction execution time
        /// Cpu time
        /// 
        /// threadId - Thread ID
        /// trxId - Transaction ID
        /// checkRows - Number of scanned rows
        /// affectRows - Number of rows affected
        /// sentRows - Number of rows returned
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Filter condition match type. Supported:
        /// INC – Includes (multiple values are in a || relationship before).
        /// EXC - excluding (multiple values are in an && relationship)
        /// EQS – equal to (multiple values before are in a || relationship).
        /// NEQ – not equal to (multiple values are in && relationship)
        /// 
        /// RG - Range;
        /// </summary>
        [JsonProperty("Compare")]
        public string Compare{ get; set; }

        /// <summary>
        /// Filter condition matching value. When Compare=RG, for example ["1-100","200-300"].
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

