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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDirectConnectTunnelAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Dedicated tunnel ID.
        /// </summary>
        [JsonProperty("DirectConnectTunnelId")]
        public string DirectConnectTunnelId{ get; set; }

        /// <summary>
        /// Dedicated tunnel name.
        /// </summary>
        [JsonProperty("DirectConnectTunnelName")]
        public string DirectConnectTunnelName{ get; set; }

        /// <summary>
        /// User-side BGP, including Asn and AuthKey.
        /// </summary>
        [JsonProperty("BgpPeer")]
        public BgpPeer BgpPeer{ get; set; }

        /// <summary>
        /// User-side IP range.
        /// </summary>
        [JsonProperty("RouteFilterPrefixes")]
        public RouteFilterPrefix[] RouteFilterPrefixes{ get; set; }

        /// <summary>
        /// Tencent-side IP address.
        /// </summary>
        [JsonProperty("TencentAddress")]
        public string TencentAddress{ get; set; }

        /// <summary>
        /// User-side IP address.
        /// </summary>
        [JsonProperty("CustomerAddress")]
        public string CustomerAddress{ get; set; }

        /// <summary>
        /// Bandwidth value of a dedicated tunnel in Mbps.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// Tencent-side standby IP address
        /// </summary>
        [JsonProperty("TencentBackupAddress")]
        public string TencentBackupAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectTunnelId", this.DirectConnectTunnelId);
            this.SetParamSimple(map, prefix + "DirectConnectTunnelName", this.DirectConnectTunnelName);
            this.SetParamObj(map, prefix + "BgpPeer.", this.BgpPeer);
            this.SetParamArrayObj(map, prefix + "RouteFilterPrefixes.", this.RouteFilterPrefixes);
            this.SetParamSimple(map, prefix + "TencentAddress", this.TencentAddress);
            this.SetParamSimple(map, prefix + "CustomerAddress", this.CustomerAddress);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "TencentBackupAddress", this.TencentBackupAddress);
        }
    }
}

