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

    public class DescribeAutoScaleRecordsRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Record filter parameter, which can only be "StartTime", "EndTime", "StrategyName", "ActionStatus", or "ScaleAction".
        /// Time format. Either 2006-01-02 15:04:05 or 2006/01/02 15:04:05 for StartTime and EndTime.
        /// ActionStatus: 0 (INITED), 1 (SUCCESS), 2 (FAILED), 3 (LIMITED_SUCCESSED), 4 (IN_PROCESS), and 5 (IN_RETRY).
        /// ScaleAction: 1 (scale-out) and 2 (scale-in).
        /// </summary>
        [JsonProperty("Filters")]
        public KeyValue[] Filters{ get; set; }

        /// <summary>
        /// Pagination parameter.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of entries per page. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Whether it is an auto scaling (0) or managed scaling (1) operation.
        /// </summary>
        [JsonProperty("RecordSource")]
        public long? RecordSource{ get; set; }

        /// <summary>
        /// Whether to sort data in ascending order. Valid values: 1 (yes) and 0 (no).
        /// </summary>
        [JsonProperty("Asc")]
        public long? Asc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "RecordSource", this.RecordSource);
            this.SetParamSimple(map, prefix + "Asc", this.Asc);
        }
    }
}

