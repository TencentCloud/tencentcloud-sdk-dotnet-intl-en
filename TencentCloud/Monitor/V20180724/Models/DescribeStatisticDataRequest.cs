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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStatisticDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Module, whose value is fixed at `monitor`
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// Namespace. Valid values: `QCE`, `TKE2`.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Metric name list
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// Dimension condition. The `=` and `in` operators are supported
        /// </summary>
        [JsonProperty("Conditions")]
        public MidQueryCondition[] Conditions{ get; set; }

        /// <summary>
        /// Statistical period in seconds. Default value: 300. Optional values: 60, 300, 3,600, and 86,400.
        /// Due to the storage period limit, the statistical period is subject to the time range of statistics:
        /// 60s: The time range is less than 12 hours, and the timespan between `StartTime` and the current time cannot exceed 15 days.
        /// 300s: The time range is less than three days, and the timespan between `StartTime` and the current time cannot exceed 31 days.
        /// 3,600s: The time range is less than 30 days, and the timespan between `StartTime` and the current time cannot exceed 93 days.
        /// 86,400s: The time range is less than 186 days, and the timespan between `StartTime` and the current time cannot exceed 186 days.
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// Start time, which is the current time by default, such as 2020-12-08T19:51:23+08:00
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time, which is the current time by default, such as 2020-12-08T19:51:23+08:00
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// `groupBy` by the specified dimension
        /// </summary>
        [JsonProperty("GroupBys")]
        public string[] GroupBys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "GroupBys.", this.GroupBys);
        }
    }
}

