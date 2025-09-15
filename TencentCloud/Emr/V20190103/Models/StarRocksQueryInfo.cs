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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StarRocksQueryInfo : AbstractModel
    {
        
        /// <summary>
        /// Submission IP address.
        /// </summary>
        [JsonProperty("ClientIP")]
        public string ClientIP{ get; set; }

        /// <summary>
        /// Total CPU time (ns).
        /// </summary>
        [JsonProperty("CPUCost")]
        public long? CPUCost{ get; set; }

        /// <summary>
        /// Default DB.
        /// </summary>
        [JsonProperty("DefaultDB")]
        public string DefaultDB{ get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Execution IP address.
        /// </summary>
        [JsonProperty("ExecutionIP")]
        public string ExecutionIP{ get; set; }

        /// <summary>
        /// Query ID.
        /// </summary>
        [JsonProperty("QueryID")]
        public string QueryID{ get; set; }

        /// <summary>
        /// Query type.
        /// </summary>
        [JsonProperty("QueryType")]
        public string QueryType{ get; set; }

        /// <summary>
        /// Total memory consumed (bytes).
        /// </summary>
        [JsonProperty("MemCost")]
        public long? MemCost{ get; set; }

        /// <summary>
        /// CPU usage (ns) at the plan stage.
        /// </summary>
        [JsonProperty("PlanCpuCosts")]
        public long? PlanCpuCosts{ get; set; }

        /// <summary>
        /// Memory usage (bytes) at the plan stage.
        /// </summary>
        [JsonProperty("PlanMemCosts")]
        public long? PlanMemCosts{ get; set; }

        /// <summary>
        /// Execution duration.
        /// </summary>
        [JsonProperty("QueryTime")]
        public long? QueryTime{ get; set; }

        /// <summary>
        /// Resource group.
        /// </summary>
        [JsonProperty("ResourceGroup")]
        public string ResourceGroup{ get; set; }

        /// <summary>
        /// Number of rows obtained.
        /// </summary>
        [JsonProperty("ReturnRows")]
        public long? ReturnRows{ get; set; }

        /// <summary>
        /// Scanned data volume (bytes).
        /// </summary>
        [JsonProperty("ScanBytes")]
        public long? ScanBytes{ get; set; }

        /// <summary>
        /// Number of scanned rows.
        /// </summary>
        [JsonProperty("ScanRows")]
        public long? ScanRows{ get; set; }

        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// Execution status.
        /// </summary>
        [JsonProperty("ExecutionState")]
        public string ExecutionState{ get; set; }

        /// <summary>
        /// Execution statement.
        /// </summary>
        [JsonProperty("ExecutionStatement")]
        public string ExecutionStatement{ get; set; }

        /// <summary>
        /// User.
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientIP", this.ClientIP);
            this.SetParamSimple(map, prefix + "CPUCost", this.CPUCost);
            this.SetParamSimple(map, prefix + "DefaultDB", this.DefaultDB);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExecutionIP", this.ExecutionIP);
            this.SetParamSimple(map, prefix + "QueryID", this.QueryID);
            this.SetParamSimple(map, prefix + "QueryType", this.QueryType);
            this.SetParamSimple(map, prefix + "MemCost", this.MemCost);
            this.SetParamSimple(map, prefix + "PlanCpuCosts", this.PlanCpuCosts);
            this.SetParamSimple(map, prefix + "PlanMemCosts", this.PlanMemCosts);
            this.SetParamSimple(map, prefix + "QueryTime", this.QueryTime);
            this.SetParamSimple(map, prefix + "ResourceGroup", this.ResourceGroup);
            this.SetParamSimple(map, prefix + "ReturnRows", this.ReturnRows);
            this.SetParamSimple(map, prefix + "ScanBytes", this.ScanBytes);
            this.SetParamSimple(map, prefix + "ScanRows", this.ScanRows);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "ExecutionState", this.ExecutionState);
            this.SetParamSimple(map, prefix + "ExecutionStatement", this.ExecutionStatement);
            this.SetParamSimple(map, prefix + "User", this.User);
        }
    }
}

