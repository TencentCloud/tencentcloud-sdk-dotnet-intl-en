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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnalysisItems : AbstractModel
    {
        
        /// <summary>
        /// The name of the database queried by the slow query statement
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// The name of the user who executes the slow query statement
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// The slow query statement whose parameter values are abstracted
        /// </summary>
        [JsonProperty("NormalQuery")]
        public string NormalQuery{ get; set; }

        /// <summary>
        /// The address of the client that executes the slow query statement
        /// </summary>
        [JsonProperty("ClientAddr")]
        public string ClientAddr{ get; set; }

        /// <summary>
        /// The number of executions of the slow query statement during the specified period of time
        /// </summary>
        [JsonProperty("CallNum")]
        public ulong? CallNum{ get; set; }

        /// <summary>
        /// The ratio (in decimal form) of the number of executions of the slow query statement to that of all slow query statements during the specified period of time
        /// </summary>
        [JsonProperty("CallPercent")]
        public float? CallPercent{ get; set; }

        /// <summary>
        /// The total execution time of the slow query statement during the specified period of time
        /// </summary>
        [JsonProperty("CostTime")]
        public float? CostTime{ get; set; }

        /// <summary>
        /// The ratio (in decimal form) of the total execution time of the slow query statement to that of all slow query statements during the specified period of time
        /// </summary>
        [JsonProperty("CostPercent")]
        public float? CostPercent{ get; set; }

        /// <summary>
        /// The shortest execution time (in ms) of the slow query statement during the specified period of time
        /// </summary>
        [JsonProperty("MinCostTime")]
        public float? MinCostTime{ get; set; }

        /// <summary>
        /// The longest execution time (in ms) of the slow query statement during the specified period of time
        /// </summary>
        [JsonProperty("MaxCostTime")]
        public float? MaxCostTime{ get; set; }

        /// <summary>
        /// The average execution time (in ms) of the slow query statement during the specified period of time
        /// </summary>
        [JsonProperty("AvgCostTime")]
        public float? AvgCostTime{ get; set; }

        /// <summary>
        /// The timestamp when the slow query statement starts to execute for the first time during the specified period of time
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// The timestamp when the slow query statement starts to execute for the last time during the specified period of time
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "NormalQuery", this.NormalQuery);
            this.SetParamSimple(map, prefix + "ClientAddr", this.ClientAddr);
            this.SetParamSimple(map, prefix + "CallNum", this.CallNum);
            this.SetParamSimple(map, prefix + "CallPercent", this.CallPercent);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "CostPercent", this.CostPercent);
            this.SetParamSimple(map, prefix + "MinCostTime", this.MinCostTime);
            this.SetParamSimple(map, prefix + "MaxCostTime", this.MaxCostTime);
            this.SetParamSimple(map, prefix + "AvgCostTime", this.AvgCostTime);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
        }
    }
}

