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

    public class DescribeBasicAlarmListRequest : AbstractModel
    {
        
        /// <summary>
        /// API component name. The value for the current API is monitor.
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// Start time, which is the timestamp one day prior by default.
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// End time, which is the current timestamp by default.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Number of parameters that can be returned on each page. Value range: 1 - 100. Default value: 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Parameter offset on each page. The value starts from 0 and the default value is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Sorting by occurrence time. Valid values: asc and desc.
        /// </summary>
        [JsonProperty("OccurTimeOrder")]
        public string OccurTimeOrder{ get; set; }

        /// <summary>
        /// Filter by project ID.
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// Filter by policy type.
        /// </summary>
        [JsonProperty("ViewNames")]
        public string[] ViewNames{ get; set; }

        /// <summary>
        /// Filter by alarm status.
        /// </summary>
        [JsonProperty("AlarmStatus")]
        public long?[] AlarmStatus{ get; set; }

        /// <summary>
        /// Filter by alarm object.
        /// </summary>
        [JsonProperty("ObjLike")]
        public string ObjLike{ get; set; }

        /// <summary>
        /// Filter by instance group ID.
        /// </summary>
        [JsonProperty("InstanceGroupIds")]
        public long?[] InstanceGroupIds{ get; set; }

        /// <summary>
        /// Filtering by metric names
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OccurTimeOrder", this.OccurTimeOrder);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "ViewNames.", this.ViewNames);
            this.SetParamArraySimple(map, prefix + "AlarmStatus.", this.AlarmStatus);
            this.SetParamSimple(map, prefix + "ObjLike", this.ObjLike);
            this.SetParamArraySimple(map, prefix + "InstanceGroupIds.", this.InstanceGroupIds);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
        }
    }
}

