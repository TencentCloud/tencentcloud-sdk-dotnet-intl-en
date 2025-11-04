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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ISPIPv6CidrBlock : AbstractModel
    {
        
        /// <summary>
        /// IPv6 CIdr Block
        /// </summary>
        [JsonProperty("IPv6CidrBlock")]
        public string IPv6CidrBlock{ get; set; }

        /// <summary>
        /// Network operator type. valid values: 'BGP' (default), 'CMCC' (china mobile), 'CTCC' (china telecom), 'CUCC' (china unicom).
        /// </summary>
        [JsonProperty("ISPType")]
        public string ISPType{ get; set; }

        /// <summary>
        /// Specifies the type of IPv6 Cidr: `GUA` (global unicast address), `ULA` (unique local address).
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IPv6CidrBlock", this.IPv6CidrBlock);
            this.SetParamSimple(map, prefix + "ISPType", this.ISPType);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
        }
    }
}

