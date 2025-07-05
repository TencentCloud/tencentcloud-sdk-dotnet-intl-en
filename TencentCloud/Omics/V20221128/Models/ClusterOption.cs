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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterOption : AbstractModel
    {
        
        /// <summary>
        /// Computing cluster availability zone
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Computing cluster type. Valid values:
        /// - KUBERNETES
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Computing cluster Service CIDR. It must not overlap with the VPC IP range.
        /// </summary>
        [JsonProperty("ServiceCidr")]
        public string ServiceCidr{ get; set; }

        /// <summary>
        /// Resource quota
        /// </summary>
        [JsonProperty("ResourceQuota")]
        public ResourceQuota ResourceQuota{ get; set; }

        /// <summary>
        /// Limit scope
        /// </summary>
        [JsonProperty("LimitRange")]
        public LimitRange LimitRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ServiceCidr", this.ServiceCidr);
            this.SetParamObj(map, prefix + "ResourceQuota.", this.ResourceQuota);
            this.SetParamObj(map, prefix + "LimitRange.", this.LimitRange);
        }
    }
}

