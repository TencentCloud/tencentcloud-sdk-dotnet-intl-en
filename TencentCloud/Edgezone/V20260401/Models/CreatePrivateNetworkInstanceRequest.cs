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

namespace TencentCloud.Edgezone.V20260401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePrivateNetworkInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// New instance name
        /// </summary>
        [JsonProperty("NetworkInstanceName")]
        public string NetworkInstanceName{ get; set; }

        /// <summary>
        /// Availability zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The network address (host bits must be all 0s) must fall into one of the following RFC 1918 private ranges: `10.0.0.0/8`, `172.16.0.0/12`, `192.168.0.0/16`.
        /// </summary>
        [JsonProperty("Network")]
        public string Network{ get; set; }

        /// <summary>
        /// Mask digits. The upper limit is fixed at `28`, while the lower limit depends on the private segment it belongs to: `10.0.0.0/8` allows `8~28`, `172.16.0.0/12` allows `12~28`, `192.168.0.0/16` allows `16~28`. It must together form a valid network address with Network (host bits all set to 0).
        /// </summary>
        [JsonProperty("Mask")]
        public long? Mask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkInstanceName", this.NetworkInstanceName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Network", this.Network);
            this.SetParamSimple(map, prefix + "Mask", this.Mask);
        }
    }
}

