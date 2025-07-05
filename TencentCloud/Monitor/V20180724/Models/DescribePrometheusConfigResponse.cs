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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePrometheusConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// Global configuration
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// ServiceMonitor configuration
        /// </summary>
        [JsonProperty("ServiceMonitors")]
        public PrometheusConfigItem[] ServiceMonitors{ get; set; }

        /// <summary>
        /// PodMonitor configuration
        /// </summary>
        [JsonProperty("PodMonitors")]
        public PrometheusConfigItem[] PodMonitors{ get; set; }

        /// <summary>
        /// Raw jobs
        /// </summary>
        [JsonProperty("RawJobs")]
        public PrometheusConfigItem[] RawJobs{ get; set; }

        /// <summary>
        /// Probes
        /// </summary>
        [JsonProperty("Probes")]
        public PrometheusConfigItem[] Probes{ get; set; }

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
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamArrayObj(map, prefix + "ServiceMonitors.", this.ServiceMonitors);
            this.SetParamArrayObj(map, prefix + "PodMonitors.", this.PodMonitors);
            this.SetParamArrayObj(map, prefix + "RawJobs.", this.RawJobs);
            this.SetParamArrayObj(map, prefix + "Probes.", this.Probes);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

