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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillingDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time of the query.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time of the query.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Zone ID set. This parameter is required.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Indicator list. Valid values:<li>acc_flux: Content acceleration traffic, in bytes;</li>
        /// <li>smt_flux: Intelligent acceleration traffic, in bytes;</li>
        /// <li>l4_flux: Layer 4 acceleration traffic, in bytes;</li>
        /// <li>sec_flux: Exclusive protection traffic, in bytes;</li>
        /// <li>zxctg_flux: Traffic for network optimization in the Chinese mainland, in bytes;</li>
        /// <li>acc_bandwidth: Bandwidth for content acceleration, in bps;</li>
        /// <li>smt_bandwidth: Bandwidth for intelligent acceleration, in bps;</li>
        /// <li>l4_bandwidth: Bandwidth for Layer 4 acceleration, in bps;</li>
        /// <li>sec_bandwidth: Bandwidth for exclusive protection, in bps;</li>
        /// <li>zxctg_bandwidth: Bandwidth for network optimization in the Chinese mainland, in bps;</li><li>sec_request_clean: HTTP/HTTPS requests, count;</li>
        /// <li>smt_request_clean: Intelligent acceleration requests, count;</li>
        /// <li>quic_request: QUIC requests, count;</li>
        /// <li>bot_request_clean: Bot requests, count;</li>
        /// <li>cls_count: Real-time log pushes, count;</li>
        /// <li>ddos_bandwidth: Elastic Anti-DDoS bandwidth, in bps.</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Query period granularity. Valid values:<li>5min: 5-minute granularity;</li>
        /// <li>hour: 1-hour granularity;</li>
        /// <li>day: 1-day granularity.</li>
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Filter criteria. The detailed filter criteria are as follows:
        /// <li>host<br>   Filters by <strong>Domain Name</strong>. Example: test.example.com<br>   Type: String<br>   Required: No</li>
        /// <li>proxy-id<br>   Filters by <strong>Layer 4 Proxy Instance ID</strong>. Example: sid-2rugn89bkla9<br>   Type: String<br>   Required: No</li>
        /// <li>region-id<br>   Filters by <strong>Billing Region</strong>.<br>   Type: String<br>   Required: No<br>   Options are:<br>   CH: Chinese mainland<br>   AF: Africa<br>   AS1: Asia-Pacific Region 1<br>   AS2: Asia-Pacific Region 2<br>   AS3: Asia-Pacific Region 3<br>   EU: Europe<br>   MidEast: Middle East<br>   NA: North America<br>   SA: South America</li>
        /// </summary>
        [JsonProperty("Filters")]
        public BillingDataFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

