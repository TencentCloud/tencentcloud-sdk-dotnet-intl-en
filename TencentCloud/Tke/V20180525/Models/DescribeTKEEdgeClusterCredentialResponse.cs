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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTKEEdgeClusterCredentialResponse : AbstractModel
    {
        
        /// <summary>
        /// Access address of the cluster
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Addresses")]
        public IPAddress[] Addresses{ get; set; }

        /// <summary>
        /// Cluster authentication information
        /// </summary>
        [JsonProperty("Credential")]
        public ClusterCredential Credential{ get; set; }

        /// <summary>
        /// Public network access information of the cluster
        /// </summary>
        [JsonProperty("PublicLB")]
        public EdgeClusterPublicLB PublicLB{ get; set; }

        /// <summary>
        /// Private network access information of the cluster
        /// </summary>
        [JsonProperty("InternalLB")]
        public EdgeClusterInternalLB InternalLB{ get; set; }

        /// <summary>
        /// CoreDns deployment information of the cluster
        /// </summary>
        [JsonProperty("CoreDns")]
        public string CoreDns{ get; set; }

        /// <summary>
        /// Multi-region health check deployment information of the cluster
        /// </summary>
        [JsonProperty("HealthRegion")]
        public string HealthRegion{ get; set; }

        /// <summary>
        /// Health check deployment information of the cluster
        /// </summary>
        [JsonProperty("Health")]
        public string Health{ get; set; }

        /// <summary>
        /// Whether to deploy GridDaemon to support headless service
        /// </summary>
        [JsonProperty("GridDaemon")]
        public string GridDaemon{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Addresses.", this.Addresses);
            this.SetParamObj(map, prefix + "Credential.", this.Credential);
            this.SetParamObj(map, prefix + "PublicLB.", this.PublicLB);
            this.SetParamObj(map, prefix + "InternalLB.", this.InternalLB);
            this.SetParamSimple(map, prefix + "CoreDns", this.CoreDns);
            this.SetParamSimple(map, prefix + "HealthRegion", this.HealthRegion);
            this.SetParamSimple(map, prefix + "Health", this.Health);
            this.SetParamSimple(map, prefix + "GridDaemon", this.GridDaemon);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

