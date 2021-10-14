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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster data description language type, such as `PROTO`, `TDR`, or `MIX`
        /// </summary>
        [JsonProperty("IdlType")]
        public string IdlType{ get; set; }

        /// <summary>
        /// Cluster name, which can contain up to 32 letters and digits
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// ID of the VPC instance bound to a cluster in the format of `vpc-f49l6u0z`
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// ID of the subnet instance bound to a cluster in the format of `subnet-pxir56ns`
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Cluster access password, which must contain lowercase letters (a-z), uppercase letters (A-Z), and digits (0-9).
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Cluster tag list
        /// </summary>
        [JsonProperty("ResourceTags")]
        public TagInfoUnit[] ResourceTags{ get; set; }

        /// <summary>
        /// Whether to enable IPv6 address access for clusters
        /// </summary>
        [JsonProperty("Ipv6Enable")]
        public long? Ipv6Enable{ get; set; }

        /// <summary>
        /// Information of the machine at the storage layer (tcapsvr) in a dedicated cluster
        /// </summary>
        [JsonProperty("ServerList")]
        public MachineInfo[] ServerList{ get; set; }

        /// <summary>
        /// Information of the machine at the access layer (tcaproxy) in a dedicated cluster
        /// </summary>
        [JsonProperty("ProxyList")]
        public MachineInfo[] ProxyList{ get; set; }

        /// <summary>
        /// Cluster type. Valid values: `1` (standard), `2` (dedicated)
        /// </summary>
        [JsonProperty("ClusterType")]
        public long? ClusterType{ get; set; }

        /// <summary>
        /// Authentication type. Valid values: `0` (static password), `1` (signature)
        /// </summary>
        [JsonProperty("AuthType")]
        public long? AuthType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdlType", this.IdlType);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "Ipv6Enable", this.Ipv6Enable);
            this.SetParamArrayObj(map, prefix + "ServerList.", this.ServerList);
            this.SetParamArrayObj(map, prefix + "ProxyList.", this.ProxyList);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
        }
    }
}

