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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobMonitorDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Job ID; see JobId in the job list (https://www.tencentcloud.com/document/product/599/15909?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// Name of the job Task. See [job details](https://www.tencentcloud.com/document/product/599/15904?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Serial number of the task instance. For details, see [Task Detail](https://www.tencentcloud.com/document/product/599/15905?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("TaskInstanceIndex")]
        public long? TaskInstanceIndex{ get; set; }

        /// <summary>
        /// Supported metrics; Metrics to be queried for the task currently supported.
        /// 
        /// -CpuUsage: cpu usage, unit: %
        /// -MemUsage: Memory usage, measurement unit: %
        /// -LanOuttraffic: Private network outbound bandwidth, measurement unit: Bytes/s
        /// -LanIntraffic: Private network inbound bandwidth, unit: Bytes/s
        /// -MaxDiskUsage: Highest disk utilization among all disks. Measurement unit: %
        /// -TargetDiskUsage: Specify disk utilization, unit: %; use in conjunction with the Dimensions parameter.
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Query start time of the task instance. If the query start time is not passed in or the incoming time is less than the instance creation time (see task detail (https://www.tencentcloud.com/document/product/599/15905?from_cn_redirect=1) for instance creation time), the query time will automatically be adjusted to the instance creation time. The passed-in time format supports only the zero time zone format.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Query the termination time of the task instance. If the query end time is not passed in or the passed-in time is larger than the termination time of the task instance (see [task detail](https://www.tencentcloud.com/document/product/599/15905?from_cn_redirect=1) for the termination time of the task instance), and the task instance has already ended, the query end time will be automatically adjusted to the termination time of the task instance. If the task instance has not ended, the query end time will be automatically adjusted to the current time. The input time format supports only the zero time zone format.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Query metrics extension parameter; currently only support TargetDiskUsage.
        /// 
        /// - TargetDiskUsage
        /// -Supported query dimensions include diskname. The dimension value is the disk mount name, such as vdb. If this parameter is not provided, the default query is disk utilization of vdb.
        /// Sample: [{"Name":"diskname", "Value":"vdb"}]
        /// </summary>
        [JsonProperty("Dimensions")]
        public Dimension[] Dimensions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskInstanceIndex", this.TaskInstanceIndex);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "Dimensions.", this.Dimensions);
        }
    }
}

