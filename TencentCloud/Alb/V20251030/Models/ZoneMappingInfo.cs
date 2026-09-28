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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneMappingInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Subnet ID.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Availability zone ID. Maximum support for adding 10 availability zones. If the current region supports 2 or more availability zones, at least 2 availability zones need to be added.<br>You can obtain the availability zone information corresponding to the availability zone ID by calling the <a href="https://www.tencentcloud.com/document/api/1822/133727?from_cn_redirect=1">DescribeZones</a> API.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Load balancing VIP/EIP information</p>
        /// </summary>
        [JsonProperty("LoadBalancerAddress")]
        public LoadBalancerAddress LoadBalancerAddress{ get; set; }

        /// <summary>
        /// <p>Availability zone status. Value:</p><ul><li><strong>Active</strong>: Running.</li><li><strong>Stopped</strong>: Stopped.</li><li><strong>Shifted</strong>: Has been removed.</li><li><strong>Starting</strong>: Starting.</li><li><strong>Stopping</strong>: Stopping.</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamObj(map, prefix + "LoadBalancerAddress.", this.LoadBalancerAddress);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

