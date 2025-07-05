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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowLogData : AbstractModel
    {
        
        /// <summary>
        /// Statement checksum for querying details
        /// </summary>
        [JsonProperty("CheckSum")]
        public string CheckSum{ get; set; }

        /// <summary>
        /// Database name
        /// </summary>
        [JsonProperty("Db")]
        public string Db{ get; set; }

        /// <summary>
        /// Abstracted SQL statement
        /// </summary>
        [JsonProperty("FingerPrint")]
        public string FingerPrint{ get; set; }

        /// <summary>
        /// Average lock time
        /// </summary>
        [JsonProperty("LockTimeAvg")]
        public string LockTimeAvg{ get; set; }

        /// <summary>
        /// Maximum lock time
        /// </summary>
        [JsonProperty("LockTimeMax")]
        public string LockTimeMax{ get; set; }

        /// <summary>
        /// Minimum lock time
        /// </summary>
        [JsonProperty("LockTimeMin")]
        public string LockTimeMin{ get; set; }

        /// <summary>
        /// Total lock time
        /// </summary>
        [JsonProperty("LockTimeSum")]
        public string LockTimeSum{ get; set; }

        /// <summary>
        /// Number of queries
        /// </summary>
        [JsonProperty("QueryCount")]
        public string QueryCount{ get; set; }

        /// <summary>
        /// Average query time
        /// </summary>
        [JsonProperty("QueryTimeAvg")]
        public string QueryTimeAvg{ get; set; }

        /// <summary>
        /// Maximum query time
        /// </summary>
        [JsonProperty("QueryTimeMax")]
        public string QueryTimeMax{ get; set; }

        /// <summary>
        /// Minimum query time
        /// </summary>
        [JsonProperty("QueryTimeMin")]
        public string QueryTimeMin{ get; set; }

        /// <summary>
        /// Total query time
        /// </summary>
        [JsonProperty("QueryTimeSum")]
        public string QueryTimeSum{ get; set; }

        /// <summary>
        /// Number of scanned rows
        /// </summary>
        [JsonProperty("RowsExaminedSum")]
        public string RowsExaminedSum{ get; set; }

        /// <summary>
        /// Number of sent rows
        /// </summary>
        [JsonProperty("RowsSentSum")]
        public string RowsSentSum{ get; set; }

        /// <summary>
        /// Last execution time
        /// </summary>
        [JsonProperty("TsMax")]
        public string TsMax{ get; set; }

        /// <summary>
        /// First execution time
        /// </summary>
        [JsonProperty("TsMin")]
        public string TsMin{ get; set; }

        /// <summary>
        /// Account
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Sample SQL
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExampleSql")]
        public string ExampleSql{ get; set; }

        /// <summary>
        /// Host address of account
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckSum", this.CheckSum);
            this.SetParamSimple(map, prefix + "Db", this.Db);
            this.SetParamSimple(map, prefix + "FingerPrint", this.FingerPrint);
            this.SetParamSimple(map, prefix + "LockTimeAvg", this.LockTimeAvg);
            this.SetParamSimple(map, prefix + "LockTimeMax", this.LockTimeMax);
            this.SetParamSimple(map, prefix + "LockTimeMin", this.LockTimeMin);
            this.SetParamSimple(map, prefix + "LockTimeSum", this.LockTimeSum);
            this.SetParamSimple(map, prefix + "QueryCount", this.QueryCount);
            this.SetParamSimple(map, prefix + "QueryTimeAvg", this.QueryTimeAvg);
            this.SetParamSimple(map, prefix + "QueryTimeMax", this.QueryTimeMax);
            this.SetParamSimple(map, prefix + "QueryTimeMin", this.QueryTimeMin);
            this.SetParamSimple(map, prefix + "QueryTimeSum", this.QueryTimeSum);
            this.SetParamSimple(map, prefix + "RowsExaminedSum", this.RowsExaminedSum);
            this.SetParamSimple(map, prefix + "RowsSentSum", this.RowsSentSum);
            this.SetParamSimple(map, prefix + "TsMax", this.TsMax);
            this.SetParamSimple(map, prefix + "TsMin", this.TsMin);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "ExampleSql", this.ExampleSql);
            this.SetParamSimple(map, prefix + "Host", this.Host);
        }
    }
}

