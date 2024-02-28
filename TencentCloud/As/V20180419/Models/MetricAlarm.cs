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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricAlarm : AbstractModel
    {
        
        /// <summary>
        /// Comparison operator. Value range: <br><li>GREATER_THAN: greater than </li><li>GREATER_THAN_OR_EQUAL_TO: greater than or equal to </li><li>LESS_THAN: less than </li><li> LESS_THAN_OR_EQUAL_TO: less than or equal to </li><li> EQUAL_TO: equal to </li> <li>NOT_EQUAL_TO: not equal to </li>
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public string ComparisonOperator{ get; set; }

        /// <summary>
        /// Metric names, with the following optional fields: <br><li>CPU_UTILIZATION: CPU utilization.</li> <li>MEM_UTILIZATION: Memory utilization.</li> <li>LAN_TRAFFIC_OUT: Private network outbound bandwidth.</li> <li>LAN_TRAFFIC_IN: Private network inbound bandwidth.</li> <li>WAN_TRAFFIC_OUT: Public network outbound bandwidth.</li> <li>WAN_TRAFFIC_IN: Public network inbound bandwidth.</li> <li>TCP_CURR_ESTAB: TCP connections.</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Alarm threshold values: <br><li>CPU_UTILIZATION: [1, 100], Unit: %.</li> <li>MEM_UTILIZATION: [1, 100], Unit: %.</li> <li>LAN_TRAFFIC_OUT: >0, Unit: Mbps.</li> <li>LAN_TRAFFIC_IN: >0, Unit: Mbps.</li> <li>WAN_TRAFFIC_OUT: >0, Unit: Mbps.</li> <li>WAN_TRAFFIC_IN: >0, Unit: Mbps.</li> <li>TCP_CURR_ESTAB: >0, Unit: Count.</li>
        /// </summary>
        [JsonProperty("Threshold")]
        public ulong? Threshold{ get; set; }

        /// <summary>
        /// Time period in seconds. Enumerated values: 60, 300.
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// Number of repetitions. Value range: [1, 10]
        /// </summary>
        [JsonProperty("ContinuousTime")]
        public ulong? ContinuousTime{ get; set; }

        /// <summary>
        /// Statistics type. Value range: <br><li>AVERAGE: average </li><li>MAXIMUM: maximum <li>MINIMUM: minimum </li><br> Default value: AVERAGE
        /// </summary>
        [JsonProperty("Statistic")]
        public string Statistic{ get; set; }

        /// <summary>
        /// Precise alarm threshold values. This parameter is not used as an input argument but is used solely as an output parameter for the query API: <br><li>CPU_UTILIZATION: (0, 100], Unit: %.</li> <li>MEM_UTILIZATION: (0, 100], Unit: %.</li> <li>LAN_TRAFFIC_OUT: >0, Unit: Mbps.</li> <li>LAN_TRAFFIC_IN: >0, Unit: Mbps.</li> <li>WAN_TRAFFIC_OUT: >0, Unit: Mbps.</li> <li>WAN_TRAFFIC_IN: >0, Unit: Mbps.</li> <li>TCP_CURR_ESTAB: >0, Unit: Count.</li>
        /// </summary>
        [JsonProperty("PreciseThreshold")]
        public float? PreciseThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComparisonOperator", this.ComparisonOperator);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ContinuousTime", this.ContinuousTime);
            this.SetParamSimple(map, prefix + "Statistic", this.Statistic);
            this.SetParamSimple(map, prefix + "PreciseThreshold", this.PreciseThreshold);
        }
    }
}

