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

    public class CreateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Availability zone code, such as ap-guangzhou-1.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Model specifications, such as BMS5.MEDIUM8.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Private network instance ID in the format of net-xxx.
        /// </summary>
        [JsonProperty("PrivateNetworkId")]
        public string PrivateNetworkId{ get; set; }

        /// <summary>
        /// Public network instance ID, in the format of net-xxx.
        /// </summary>
        [JsonProperty("PublicNetworkId")]
        public string PublicNetworkId{ get; set; }

        /// <summary>
        /// Image ID, for example img-centos-7.9.
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Specify the quantity. Default is 1. Maximum is 50.
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// Image version number. Only public images have the concept of version.
        /// </summary>
        [JsonProperty("VersionNumber")]
        public string VersionNumber{ get; set; }

        /// <summary>
        /// Whether to enable public IPv6, default false. Enabled, the system will allocate an additional IPv6 address after assigning an IPv4 address.
        /// </summary>
        [JsonProperty("EnableIpv6")]
        public bool? EnableIpv6{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PrivateNetworkId", this.PrivateNetworkId);
            this.SetParamSimple(map, prefix + "PublicNetworkId", this.PublicNetworkId);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "VersionNumber", this.VersionNumber);
            this.SetParamSimple(map, prefix + "EnableIpv6", this.EnableIpv6);
        }
    }
}

