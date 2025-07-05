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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSparkSessionBatchSQLRequest : AbstractModel
    {
        
        /// <summary>
        /// The name of the engine for executing the Spark job.
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// Run SQL. The base64 encoding is needed.
        /// </summary>
        [JsonProperty("ExecuteSQL")]
        public string ExecuteSQL{ get; set; }

        /// <summary>
        /// The driver size. Valid values: `small` (default, 1 CU), `medium` (2 CUs), `large` (4 CUs), and `xlarge` (8 CUs).
        /// </summary>
        [JsonProperty("DriverSize")]
        public string DriverSize{ get; set; }

        /// <summary>
        /// The executor size. Valid values: `small` (default, 1 CU), `medium` (2 CUs), `large` (4 CUs), and `xlarge` (8 CUs).
        /// </summary>
        [JsonProperty("ExecutorSize")]
        public string ExecutorSize{ get; set; }

        /// <summary>
        /// The executor count, which defaults to 1.
        /// </summary>
        [JsonProperty("ExecutorNumbers")]
        public ulong? ExecutorNumbers{ get; set; }

        /// <summary>
        /// The maximum executor count, which defaults to 1. This parameter applies if the "Dynamic" mode is selected. If the "Dynamic" mode is not selected, the value of this parameter is the same as that of `ExecutorNumbers`.
        /// </summary>
        [JsonProperty("ExecutorMaxNumbers")]
        public ulong? ExecutorMaxNumbers{ get; set; }

        /// <summary>
        /// The session timeout period in seconds. Default value: 3600
        /// </summary>
        [JsonProperty("TimeoutInSecond")]
        public long? TimeoutInSecond{ get; set; }

        /// <summary>
        /// The unique ID of a session. If this parameter is specified, the task will be run using the specified session.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// The name of the session to create.
        /// </summary>
        [JsonProperty("SessionName")]
        public string SessionName{ get; set; }

        /// <summary>
        /// The session configurations. Valid values: `1.dlc.eni` for user-defined ENI gateway information;
        /// `2.dlc.role.arn` for user-defined roleArn configurations;
        /// and `3.dlc.sql.set.config` for user-defined cluster configurations.
        /// </summary>
        [JsonProperty("Arguments")]
        public KVPair[] Arguments{ get; set; }

        /// <summary>
        /// Whether to inherit the resource configuration of clusters; 0: not inherit (by default); 1: inherit clusters.
        /// </summary>
        [JsonProperty("IsInherit")]
        public long? IsInherit{ get; set; }

        /// <summary>
        /// User-defined primary key, and it should be unique.
        /// </summary>
        [JsonProperty("CustomKey")]
        public string CustomKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "ExecuteSQL", this.ExecuteSQL);
            this.SetParamSimple(map, prefix + "DriverSize", this.DriverSize);
            this.SetParamSimple(map, prefix + "ExecutorSize", this.ExecutorSize);
            this.SetParamSimple(map, prefix + "ExecutorNumbers", this.ExecutorNumbers);
            this.SetParamSimple(map, prefix + "ExecutorMaxNumbers", this.ExecutorMaxNumbers);
            this.SetParamSimple(map, prefix + "TimeoutInSecond", this.TimeoutInSecond);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionName", this.SessionName);
            this.SetParamArrayObj(map, prefix + "Arguments.", this.Arguments);
            this.SetParamSimple(map, prefix + "IsInherit", this.IsInherit);
            this.SetParamSimple(map, prefix + "CustomKey", this.CustomKey);
        }
    }
}

