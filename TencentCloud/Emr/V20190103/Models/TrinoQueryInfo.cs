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

    public class TrinoQueryInfo : AbstractModel
    {
        
        /// <summary>
        /// catalog
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// IP address used for submission.
        /// </summary>
        [JsonProperty("ClientIpAddr")]
        public string ClientIpAddr{ get; set; }

        /// <summary>
        /// Number of segments.
        /// </summary>
        [JsonProperty("CompletedSplits")]
        public string CompletedSplits{ get; set; }

        /// <summary>
        /// CPU time.
        /// </summary>
        [JsonProperty("CpuTime")]
        public long? CpuTime{ get; set; }

        /// <summary>
        /// Cumulative memory.
        /// </summary>
        [JsonProperty("CumulativeMemory")]
        public long? CumulativeMemory{ get; set; }

        /// <summary>
        /// Execution duration.
        /// </summary>
        [JsonProperty("DurationMillis")]
        public long? DurationMillis{ get; set; }

        /// <summary>
        /// End time (seconds).
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Query ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Internal transmission volume.
        /// </summary>
        [JsonProperty("InternalNetworkBytes")]
        public long? InternalNetworkBytes{ get; set; }

        /// <summary>
        /// Number of output bytes.
        /// </summary>
        [JsonProperty("OutputBytes")]
        public long? OutputBytes{ get; set; }

        /// <summary>
        /// Peak memory.
        /// </summary>
        [JsonProperty("PeakUserMemoryBytes")]
        public long? PeakUserMemoryBytes{ get; set; }

        /// <summary>
        /// Physical input volume.
        /// </summary>
        [JsonProperty("PhysicalInputBytes")]
        public long? PhysicalInputBytes{ get; set; }

        /// <summary>
        /// Processed input volume.
        /// </summary>
        [JsonProperty("ProcessedInputBytes")]
        public long? ProcessedInputBytes{ get; set; }

        /// <summary>
        /// Compilation duration.
        /// </summary>
        [JsonProperty("SqlCompileTime")]
        public long? SqlCompileTime{ get; set; }

        /// <summary>
        /// Start time (seconds).
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// Execution status.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Execution statement.
        /// </summary>
        [JsonProperty("Statement")]
        public string Statement{ get; set; }

        /// <summary>
        /// User who submits requests.
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Number of bytes written.
        /// </summary>
        [JsonProperty("WrittenBytes")]
        public long? WrittenBytes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "ClientIpAddr", this.ClientIpAddr);
            this.SetParamSimple(map, prefix + "CompletedSplits", this.CompletedSplits);
            this.SetParamSimple(map, prefix + "CpuTime", this.CpuTime);
            this.SetParamSimple(map, prefix + "CumulativeMemory", this.CumulativeMemory);
            this.SetParamSimple(map, prefix + "DurationMillis", this.DurationMillis);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InternalNetworkBytes", this.InternalNetworkBytes);
            this.SetParamSimple(map, prefix + "OutputBytes", this.OutputBytes);
            this.SetParamSimple(map, prefix + "PeakUserMemoryBytes", this.PeakUserMemoryBytes);
            this.SetParamSimple(map, prefix + "PhysicalInputBytes", this.PhysicalInputBytes);
            this.SetParamSimple(map, prefix + "ProcessedInputBytes", this.ProcessedInputBytes);
            this.SetParamSimple(map, prefix + "SqlCompileTime", this.SqlCompileTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Statement", this.Statement);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "WrittenBytes", this.WrittenBytes);
        }
    }
}

