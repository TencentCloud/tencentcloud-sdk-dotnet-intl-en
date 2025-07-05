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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillingDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Site ID set. This parameter is required.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Metric list. Valid values:
        /// <li>acc_flux: content acceleration traffic, in bytes;</li>
        /// <li>smt_flux: smart acceleration traffic, in bytes;</li>
        /// <li>l4_flux: L4 acceleration traffic, in bytes;</li>
        /// <li>sec_flux: exclusive protection traffic, in bytes;</li>
        /// <li>zxctg_flux: network optimization traffic in the Chinese mainland, in bytes;</li>
        /// <li>acc_bandwidth: content acceleration bandwidth, in bps;</li>
        /// <li>smt_bandwidth: smart acceleration bandwidth, in bps;</li>
        /// <li>l4_bandwidth: L4 acceleration bandwidth, in bps;</li>
        /// <li>sec_bandwidth: exclusive protection bandwidth, in bps;</li>
        /// <li>zxctg_bandwidth: network optimization bandwidth in the Chinese mainland, in bps;</li>
        /// <li>sec_request_clean: number of HTTP/HTTPS requests;</li>
        /// <li>smt_request_clean: number of smart acceleration requests;</li>
        /// <li>quic_request: number of QUIC requests;</li>
        /// <li>bot_request_clean: number of Bot requests;</li>
        /// <li>cls_count: number of real-time log entries pushed;</li>
        /// <li>ddos_bandwidth: elastic DDoS protection bandwidth, in bps.</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Time granularity of the query. Valid values:
        /// <li>5min: 5 minutes;</li>
        /// <li>hour: 1 hour;</li>
        /// <li>day: 1 day.</li>
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Filter criteria. The detailed values of filter criteria are as follows:
        /// <li>host: Filter by domain name, such as test.example.com.<br></li>
        /// <li>proxy-id: Filter by L4 proxy instance ID, such as sid-2rugn89bkla9.<br></li>
        /// <li>region-id: Filter by billing region. Options:<br>  CH: Chinese mainland<br>  AF: Africa<br>  AS1: Asia-Pacific Region 1<br>  AS2: Asia-Pacific Region 2<br>  AS3: Asia-Pacific Region 3<br>  EU: Europe<br>  MidEast: Middle East<br>  NA: North America<br>  SA: South America</li>
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

