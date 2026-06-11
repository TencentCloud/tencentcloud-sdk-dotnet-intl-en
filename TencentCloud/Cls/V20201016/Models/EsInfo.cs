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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EsInfo : AbstractModel
    {
        
        /// <summary>
        /// ES Types. 1: Cloud ES, 2: Self-build ES.
        /// </summary>
        [JsonProperty("EsType")]
        public ulong? EsType{ get; set; }

        /// <summary>
        /// Access method 1: private network, 2: public network. Self-built ES required.
        /// </summary>
        [JsonProperty("AccessMode")]
        public ulong? AccessMode{ get; set; }

        /// <summary>
        /// Instance id. Required for es instance.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Access address. Self-built ES required.
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// Access port. Self-built ES required.
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Network. Required when accessing self-built ES via private network.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Network service type. Required when accessing a self-built ES via private network.
        /// CLB:1025 Cloud Virtual Machine (CVM):0
        /// </summary>
        [JsonProperty("VirtualGatewayType")]
        public ulong? VirtualGatewayType{ get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EsType", this.EsType);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VirtualGatewayType", this.VirtualGatewayType);
            this.SetParamSimple(map, prefix + "Password", this.Password);
        }
    }
}

