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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCCTrendRequest : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type. `bgpip`: Anti-DDoS Advanced; `bgp`: Anti-DDoS Pro (Single IP); `bgp-multip`: Anti-DDoS Pro (Multi-IP); `net`: Anti-DDoS Ultimate; `basic`: Anti-DDoS Basic
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// Instance IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Sampling period. Valid values: `300` (5 minutes), `3600` (one hour), `86400` (one day)
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Beginning of the time range for the query
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End of the time range for the query
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Metric. Valid values: `inqps` (total QPS peaks), `dropqps` (attack QPS peaks), `incount` (total number of requests), and `dropcount` (number of attack requests).
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// (Optional) Domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Instance ID. Leave this field empty when `Business` is `basic`, as basic protection does not require an instance.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

