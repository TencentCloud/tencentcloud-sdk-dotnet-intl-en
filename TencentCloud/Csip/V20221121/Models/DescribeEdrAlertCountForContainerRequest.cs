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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEdrAlertCountForContainerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Cluster ID list (≤500); group statistics by cluster when non-empty and ContainerIds is empty</p>
        /// </summary>
        [JsonProperty("ClusterIds")]
        public string[] ClusterIds{ get; set; }

        /// <summary>
        /// <p>Container ID list (≤500); if not empty, group statistics by container (higher priority than ClusterIds)</p>
        /// </summary>
        [JsonProperty("ContainerIds")]
        public string[] ContainerIds{ get; set; }

        /// <summary>
        /// <li>PolicyType - int - Required: No - policy type</li><li>PolicyName - string - Required: No - Policy Name</li><li>Domain - string - Required: No - domain name (urlencode the domain name first, then base64)</li><li>PolicyAction- int - Required: No - policy action</li><li>IsEnabled - int - Required: No - whether it takes effect</li><li>ContainerId - string - Required: No - container ID (exact/IN, dimension filtering)</li><li>ClusterId - string - Required: No - Cluster ID (exact/IN, dimension filtering)</li><li>ClusterName - string - Required: No - cluster name (prefix blurry)</li><li>ContainerName - string - Required: No - Container name (prefix blurry)</li><li>AlertSource - string - Required: No - alarm source: HOST-host alarm / CONTAINER-container alarm. If not specified, return all</li>
        /// </summary>
        [JsonProperty("Filters")]
        public EDRFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "ClusterIds.", this.ClusterIds);
            this.SetParamArraySimple(map, prefix + "ContainerIds.", this.ContainerIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

