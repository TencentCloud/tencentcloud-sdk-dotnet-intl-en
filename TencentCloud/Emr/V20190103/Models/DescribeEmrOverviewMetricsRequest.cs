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

    public class DescribeEmrOverviewMetricsRequest : AbstractModel
    {
        
        /// <summary>
        /// End time
        /// </summary>
        [JsonProperty("End")]
        public long? End{ get; set; }

        /// <summary>
        /// Metric name. NODE.CPU: average CPU utilization and core count of the node; NODE.CPU.SLHBASE: average CPU utilization and core count of the Serverless instance; HDFS.NN.CAPACITY: storage utilization and total amount.
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// Cluster ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Granularity, for example, 30s-max, 1m-max, and 1h-max.
        /// </summary>
        [JsonProperty("Downsample")]
        public string Downsample{ get; set; }

        /// <summary>
        /// Start time, not required for pie charts
        /// </summary>
        [JsonProperty("Start")]
        public long? Start{ get; set; }

        /// <summary>
        /// Aggregation method, for future use
        /// </summary>
        [JsonProperty("Aggregator")]
        public string Aggregator{ get; set; }

        /// <summary>
        /// Specific type of metrics to be queried, for example, "{"type":"CapacityTotal|CapacityRemaining"}".
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "End", this.End);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Downsample", this.Downsample);
            this.SetParamSimple(map, prefix + "Start", this.Start);
            this.SetParamSimple(map, prefix + "Aggregator", this.Aggregator);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
        }
    }
}

