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

    public class DescribeBaseMetricsRequest : AbstractModel
    {
        
        /// <summary>
        /// Service namespace. Different Tencent Cloud services have different namespaces. For more information on service namespaces, see the monitoring API documentation of each product. For example, you can see [CVM Monitoring APIs](https://cloud.tencent.com/document/api/248/30385) for the namespace of CVM.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Metric name. Different Tencent Cloud services have different metric names. For more information on service metric names, see the monitoring API documentation of each product. For example, you can see the [CVM Monitoring APIs](https://cloud.tencent.com/document/api/248/30385) for the metric names of CVM.
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
        }
    }
}

