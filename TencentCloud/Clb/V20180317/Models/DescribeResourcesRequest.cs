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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// Number of returned AZ resources. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Starting offset of the returned AZ resource list. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Specifies the conditions for querying the availability zone resource list. detailed filter criteria are as follows:.
        /// - master-zone
        /// Filters by regional availability zone, for example: ap-guangzhou-2.
        /// Type: String.
        /// Required: No
        /// - ip-version
        /// Filter by [IP type], such as IPv4.
        /// Type: String.
        /// Required: No
        /// Valid values: IPv4, IPv6, IPv6_Nat.
        /// - isp
        /// Filters by [ISP type], for example: BGP.
        /// Type: String.
        /// Required: No
        /// Optional. valid values: BGP, CMCC (china mobile), CUCC (china unicom), CTCC (china telecom), BGP_PRO, INTERNAL (private network).
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

