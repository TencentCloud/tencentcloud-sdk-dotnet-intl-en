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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNatGatewayFlowMonitorDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// Point in time. It indicates the moment to query. When the aggregation granularity is 60 or 300, the system queries the aggregation cycle starting from the latest whole minute. When the aggregation granularity is 3600, the system queries the aggregation cycle starting from the latest hour. When the aggregation granularity is 86400, the system queries the aggregation cycle starting from the latest whole day. Example: `2019-03-24T10:51:23+08:00`.
        /// </summary>
        [JsonProperty("TimePoint")]
        public string TimePoint{ get; set; }

        /// <summary>
        /// NAT gateway ID, for example: `nat-ig8xpno8`.
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// Displays top-ranked data. Default value: 10, indicating that the top 10 ranked data is displayed by default. Maximum value: 100.
        /// </summary>
        [JsonProperty("TopN")]
        public long? TopN{ get; set; }

        /// <summary>
        /// Sorting field. Valid values: `InPkg`, `OutPkg`, `InTraffic`, and `OutTraffic`. Standard NAT gateways additionally support `ConcurrentConnectionCount` and `NewConnectionRate`. Default value: `OutTraffic`.
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// Aggregation time granularity. Valid values: 60, 300, 3600, and 86400, corresponding to aggregation queries by 1 minute, 5 minutes, 1 hour, and 1 day.
        /// </summary>
        [JsonProperty("AggregationTimeRange")]
        public long? AggregationTimeRange{ get; set; }

        /// <summary>
        /// Specifies whether to query all metrics. Default value: True, which indicates that all metrics are queried.
        /// </summary>
        [JsonProperty("AllMetricMode")]
        public bool? AllMetricMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimePoint", this.TimePoint);
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamSimple(map, prefix + "TopN", this.TopN);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "AggregationTimeRange", this.AggregationTimeRange);
            this.SetParamSimple(map, prefix + "AllMetricMode", this.AllMetricMode);
        }
    }
}

