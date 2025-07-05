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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProxyStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// Connection ID
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// Start time (2019-03-25 12:00:00)
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time (2019-03-25 12:00:00)
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Statistical metric name list. Valid values: `InBandwidth` (inbound bandwidth); `OutBandwidth` (outbound bandwidth); Concurrent (concurrence); `InPackets` (inbound packets); `OutPackets` (outbound packets); `PacketLoss` (packet loss rate); `Latency` (latency); `HttpQPS` (the number of HTTP requests); `HttpsQPS` (the number of HTTPS requests).
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// Monitoring granularity. It currently supports: 60, 300, 3,600, and 86,400. Unit: seconds.
        /// Time range: ≤ 3 day. Supported minimum granularity: 60 seconds;
        /// Time range: ≤ 7 day. Supported minimum granularity: 300 seconds;
        /// Time range: ≤ 30 days. Supported minimum granularity: 36,00 seconds;
        /// </summary>
        [JsonProperty("Granularity")]
        public ulong? Granularity{ get; set; }

        /// <summary>
        /// Specifies the ISP. Valid values: `CMCC`, `CUCC`, and `CTCC`. If it is not specified, all ISP data will be returned. Note that this field is valid only when a non-BGP connection is used.
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
        }
    }
}

