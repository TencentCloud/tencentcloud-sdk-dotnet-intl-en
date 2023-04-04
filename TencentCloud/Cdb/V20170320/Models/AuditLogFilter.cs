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

    public class AuditLogFilter : AbstractModel
    {
        
        /// <summary>
        /// Client address
        /// </summary>
        [JsonProperty("Host")]
        public string[] Host{ get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonProperty("User")]
        public string[] User{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DBName")]
        public string[] DBName{ get; set; }

        /// <summary>
        /// Table name
        /// </summary>
        [JsonProperty("TableName")]
        public string[] TableName{ get; set; }

        /// <summary>
        /// Audit policy name
        /// </summary>
        [JsonProperty("PolicyName")]
        public string[] PolicyName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// Execution time in ms, which is used to filter the audit log with execution time greater than this value.
        /// </summary>
        [JsonProperty("ExecTime")]
        public long? ExecTime{ get; set; }

        /// <summary>
        /// Number of affected rows, which is used to filter the audit log with affected rows greater than this value.
        /// </summary>
        [JsonProperty("AffectRows")]
        public long? AffectRows{ get; set; }

        /// <summary>
        /// SQL type (Multiple types can be queried at same time). Valid values: `SELECT`, `INSERT`, `UPDATE`, `DELETE`, `CREATE`, `DROP`, `ALTER`, `SET`, `REPLACE`, `EXECUTE`.
        /// </summary>
        [JsonProperty("SqlTypes")]
        public string[] SqlTypes{ get; set; }

        /// <summary>
        /// SQL statement. Multiple SQL statements can be passed in.
        /// </summary>
        [JsonProperty("Sqls")]
        public string[] Sqls{ get; set; }

        /// <summary>
        /// Number of rows affected in the format of M-N, such as 10-200.
        /// </summary>
        [JsonProperty("AffectRowsSection")]
        public string AffectRowsSection{ get; set; }

        /// <summary>
        /// Number of rows returned in the format of M-N, such as 10-200.
        /// </summary>
        [JsonProperty("SentRowsSection")]
        public string SentRowsSection{ get; set; }

        /// <summary>
        /// Execution time in the format of M-N, such as 10-200.
        /// </summary>
        [JsonProperty("ExecTimeSection")]
        public string ExecTimeSection{ get; set; }

        /// <summary>
        /// Lock wait time in the format of M-N, such as 10-200.
        /// </summary>
        [JsonProperty("LockWaitTimeSection")]
        public string LockWaitTimeSection{ get; set; }

        /// <summary>
        /// IO wait time in the format of M-N, such as 10-200.
        /// </summary>
        [JsonProperty("IoWaitTimeSection")]
        public string IoWaitTimeSection{ get; set; }

        /// <summary>
        /// Transaction duration in the format of M-N, such as 10-200.
        /// </summary>
        [JsonProperty("TransactionLivingTimeSection")]
        public string TransactionLivingTimeSection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Host.", this.Host);
            this.SetParamArraySimple(map, prefix + "User.", this.User);
            this.SetParamArraySimple(map, prefix + "DBName.", this.DBName);
            this.SetParamArraySimple(map, prefix + "TableName.", this.TableName);
            this.SetParamArraySimple(map, prefix + "PolicyName.", this.PolicyName);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamSimple(map, prefix + "AffectRows", this.AffectRows);
            this.SetParamArraySimple(map, prefix + "SqlTypes.", this.SqlTypes);
            this.SetParamArraySimple(map, prefix + "Sqls.", this.Sqls);
            this.SetParamSimple(map, prefix + "AffectRowsSection", this.AffectRowsSection);
            this.SetParamSimple(map, prefix + "SentRowsSection", this.SentRowsSection);
            this.SetParamSimple(map, prefix + "ExecTimeSection", this.ExecTimeSection);
            this.SetParamSimple(map, prefix + "LockWaitTimeSection", this.LockWaitTimeSection);
            this.SetParamSimple(map, prefix + "IoWaitTimeSection", this.IoWaitTimeSection);
            this.SetParamSimple(map, prefix + "TransactionLivingTimeSection", this.TransactionLivingTimeSection);
        }
    }
}

