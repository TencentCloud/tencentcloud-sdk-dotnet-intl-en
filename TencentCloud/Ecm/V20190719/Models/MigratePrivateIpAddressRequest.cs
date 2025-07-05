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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigratePrivateIpAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// ECM region, such as `ap-xian-ecm`.
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }

        /// <summary>
        /// ID of the ENI instance bound to the private IP, such as `eni-11112222`.
        /// </summary>
        [JsonProperty("SourceNetworkInterfaceId")]
        public string SourceNetworkInterfaceId{ get; set; }

        /// <summary>
        /// ID of the destination ENI instance to be migrated.
        /// </summary>
        [JsonProperty("DestinationNetworkInterfaceId")]
        public string DestinationNetworkInterfaceId{ get; set; }

        /// <summary>
        /// Private IP address to be migrated, such as `10.0.0.6`.
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public string PrivateIpAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamSimple(map, prefix + "SourceNetworkInterfaceId", this.SourceNetworkInterfaceId);
            this.SetParamSimple(map, prefix + "DestinationNetworkInterfaceId", this.DestinationNetworkInterfaceId);
            this.SetParamSimple(map, prefix + "PrivateIpAddress", this.PrivateIpAddress);
        }
    }
}

