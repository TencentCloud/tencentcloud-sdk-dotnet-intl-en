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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTransmitStatisRequest : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type. `bgpip`: Anti-DDoS Advanced, `net`: Anti-DDoS Ultimate, `bgp`: Anti-DDoS Pro (single IP), `bgp-multip`: Anti-DDoS Pro (multi-IP)
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// Anti-DDoS instance ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Metric name. Valid values:
        /// traffic: traffic bandwidth;
        /// pkg: packet rate;
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Statistical time granularity (300: 5-minute, 3600: hourly, 86400: daily)
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// Statistics start time. The second part is kept at 0, and the minute part is a multiple of 5
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Statistics end time. The second part is kept at 0, and the minute part is a multiple of 5
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Resource IP, which is required and only supports one IP if `Business` is `bgp-multip`. If this field is left empty, all IPs of a resource instance will be counted by default. If the resource instance has multiple IPs (such as Anti-DDoS Ultimate), the statistical method is summation;
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
        }
    }
}

