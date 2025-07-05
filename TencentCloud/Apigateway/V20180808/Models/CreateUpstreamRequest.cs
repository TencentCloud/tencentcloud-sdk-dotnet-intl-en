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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUpstreamRequest : AbstractModel
    {
        
        /// <summary>
        /// Backend protocol. Valid values: `HTTP`, `HTTPS`
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// Load balancing algorithm. Valid value: `ROUND-ROBIN`
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }

        /// <summary>
        /// Unique VPC ID
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Upstream name
        /// </summary>
        [JsonProperty("UpstreamName")]
        public string UpstreamName{ get; set; }

        /// <summary>
        /// Upstream description
        /// </summary>
        [JsonProperty("UpstreamDescription")]
        public string UpstreamDescription{ get; set; }

        /// <summary>
        /// Upstream access type. Valid values: `IP_PORT`, `K8S`
        /// </summary>
        [JsonProperty("UpstreamType")]
        public string UpstreamType{ get; set; }

        /// <summary>
        /// Retry attempts. It defaults to `3`.
        /// </summary>
        [JsonProperty("Retries")]
        public ulong? Retries{ get; set; }

        /// <summary>
        /// The Host request header that forwarded from the gateway to backend
        /// </summary>
        [JsonProperty("UpstreamHost")]
        public string UpstreamHost{ get; set; }

        /// <summary>
        /// Backend nodes
        /// </summary>
        [JsonProperty("Nodes")]
        public UpstreamNode[] Nodes{ get; set; }

        /// <summary>
        /// Label
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Health check configuration
        /// </summary>
        [JsonProperty("HealthChecker")]
        public UpstreamHealthChecker HealthChecker{ get; set; }

        /// <summary>
        /// Configuration of TKE service
        /// </summary>
        [JsonProperty("K8sService")]
        public K8sService[] K8sService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
            this.SetParamSimple(map, prefix + "Algorithm", this.Algorithm);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UpstreamName", this.UpstreamName);
            this.SetParamSimple(map, prefix + "UpstreamDescription", this.UpstreamDescription);
            this.SetParamSimple(map, prefix + "UpstreamType", this.UpstreamType);
            this.SetParamSimple(map, prefix + "Retries", this.Retries);
            this.SetParamSimple(map, prefix + "UpstreamHost", this.UpstreamHost);
            this.SetParamArrayObj(map, prefix + "Nodes.", this.Nodes);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "HealthChecker.", this.HealthChecker);
            this.SetParamArrayObj(map, prefix + "K8sService.", this.K8sService);
        }
    }
}

