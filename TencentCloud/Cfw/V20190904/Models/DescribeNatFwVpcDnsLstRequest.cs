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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNatFwVpcDnsLstRequest : AbstractModel
    {
        
        /// <summary>
        /// NAT firewall instance ID
        /// </summary>
        [JsonProperty("NatFwInsId")]
        public string NatFwInsId{ get; set; }

        /// <summary>
        /// Content filtered by NAT firewall, separated with ","
        /// </summary>
        [JsonProperty("NatInsIdFilter")]
        public string NatInsIdFilter{ get; set; }

        /// <summary>
        /// Number of pages
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Maximum entries per page
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatFwInsId", this.NatFwInsId);
            this.SetParamSimple(map, prefix + "NatInsIdFilter", this.NatInsIdFilter);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

