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
        /// <p>Availability zone code, such as ap-guangzhou-1.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Model specifications, such as BMS5.MEDIUM8.</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>Private network instance ID in the format of net-xxx.</p>
        /// </summary>
        [JsonProperty("PrivateNetworkId")]
        public string PrivateNetworkId{ get; set; }

        /// <summary>
        /// <p>Public network instance ID, in the format of net-xxx.</p>
        /// </summary>
        [JsonProperty("PublicNetworkId")]
        public string PublicNetworkId{ get; set; }

        /// <summary>
        /// <p>Instance name.</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Image ID, for example img-centos-7.9.</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>Specify the quantity. Default is 1. Maximum is 50.</p>
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// <p>Login password. Either it or SSHKey is required.</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Public key string of the SSH key. Either this parameter or Password must be specified.</p>
        /// </summary>
        [JsonProperty("SSHKey")]
        public string SSHKey{ get; set; }

        /// <summary>
        /// <p>Image version number. Only public images have the concept of version.</p>
        /// </summary>
        [JsonProperty("VersionNumber")]
        [System.Obsolete]
        public string VersionNumber{ get; set; }

        /// <summary>
        /// <p>Whether to enable public IPv6, default false. Enabled, the system will allocate an additional IPv6 address after assigning an IPv4 address.</p>
        /// </summary>
        [JsonProperty("EnableIpv6")]
        [System.Obsolete]
        public bool? EnableIpv6{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "PrivateNetworkId", this.PrivateNetworkId);
            this.SetParamSimple(map, prefix + "PublicNetworkId", this.PublicNetworkId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "SSHKey", this.SSHKey);
            this.SetParamSimple(map, prefix + "VersionNumber", this.VersionNumber);
            this.SetParamSimple(map, prefix + "EnableIpv6", this.EnableIpv6);
        }
    }
}

