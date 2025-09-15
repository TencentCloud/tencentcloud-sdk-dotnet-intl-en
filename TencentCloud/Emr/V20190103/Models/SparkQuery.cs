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

    public class SparkQuery : AbstractModel
    {
        
        /// <summary>
        /// Execution statement.
        /// </summary>
        [JsonProperty("Statement")]
        public string Statement{ get; set; }

        /// <summary>
        /// Execution duration (ms).
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// Execution status.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Query ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Number of scanned partitions.
        /// </summary>
        [JsonProperty("ScanPartitionNum")]
        public long? ScanPartitionNum{ get; set; }

        /// <summary>
        /// Total number of scanned rows.
        /// </summary>
        [JsonProperty("ScanRowNum")]
        public long? ScanRowNum{ get; set; }

        /// <summary>
        /// Total number of scanned files.
        /// </summary>
        [JsonProperty("ScanFileNum")]
        public long? ScanFileNum{ get; set; }

        /// <summary>
        /// Total data volume scanned by query (bytes).
        /// </summary>
        [JsonProperty("ScanTotalData")]
        public long? ScanTotalData{ get; set; }

        /// <summary>
        /// Application ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string[] ApplicationId{ get; set; }

        /// <summary>
        /// Total number of output rows.
        /// </summary>
        [JsonProperty("OutputRowNum")]
        public long? OutputRowNum{ get; set; }

        /// <summary>
        /// Total number of output files.
        /// </summary>
        [JsonProperty("OutputFileNum")]
        public long? OutputFileNum{ get; set; }

        /// <summary>
        /// Number of output partitions.
        /// </summary>
        [JsonProperty("OutputPartitionNum")]
        public long? OutputPartitionNum{ get; set; }

        /// <summary>
        /// Total output data volume (bytes).
        /// </summary>
        [JsonProperty("OutputTotalData")]
        public long? OutputTotalData{ get; set; }

        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Statement", this.Statement);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ScanPartitionNum", this.ScanPartitionNum);
            this.SetParamSimple(map, prefix + "ScanRowNum", this.ScanRowNum);
            this.SetParamSimple(map, prefix + "ScanFileNum", this.ScanFileNum);
            this.SetParamSimple(map, prefix + "ScanTotalData", this.ScanTotalData);
            this.SetParamArraySimple(map, prefix + "ApplicationId.", this.ApplicationId);
            this.SetParamSimple(map, prefix + "OutputRowNum", this.OutputRowNum);
            this.SetParamSimple(map, prefix + "OutputFileNum", this.OutputFileNum);
            this.SetParamSimple(map, prefix + "OutputPartitionNum", this.OutputPartitionNum);
            this.SetParamSimple(map, prefix + "OutputTotalData", this.OutputTotalData);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

