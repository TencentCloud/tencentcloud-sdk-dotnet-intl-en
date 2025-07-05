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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTransmitStatisResponse : AbstractModel
    {
        
        /// <summary>
        /// If `MetricName` is `traffic`, this field indicates the inbound traffic bandwidth in bps;
        /// If `MetricName` is `pkg`, this field indicates the inbound packet rate in pps;
        /// </summary>
        [JsonProperty("InDataList")]
        public float?[] InDataList{ get; set; }

        /// <summary>
        /// If `MetricName` is `traffic`, this field indicates the outbound traffic bandwidth in bps;
        /// If `MetricName` is `pkg`, this field indicates the outbound packet rate in pps;
        /// </summary>
        [JsonProperty("OutDataList")]
        public float?[] OutDataList{ get; set; }

        /// <summary>
        /// Metric name:
        /// traffic: traffic bandwidth;
        /// pkg: packet rate;
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InDataList.", this.InDataList);
            this.SetParamArraySimple(map, prefix + "OutDataList.", this.OutDataList);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

