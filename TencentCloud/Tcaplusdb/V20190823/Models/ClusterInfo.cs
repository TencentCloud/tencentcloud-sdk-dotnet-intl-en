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

    public class ClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// Cluster name
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Cluster region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Cluster data description language type, such as `PROTO`, `TDR`, or `MIX`
        /// </summary>
        [JsonProperty("IdlType")]
        public string IdlType{ get; set; }

        /// <summary>
        /// Network type
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// ID of the VPC instance with which a cluster is associated
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// ID of the subnet instance with which a cluster is associated
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Cluster password
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Password status
        /// </summary>
        [JsonProperty("PasswordStatus")]
        public string PasswordStatus{ get; set; }

        /// <summary>
        /// TcaplusDB SDK connection parameter: access ID
        /// </summary>
        [JsonProperty("ApiAccessId")]
        public string ApiAccessId{ get; set; }

        /// <summary>
        /// TcaplusDB SDK connection parameter: access address
        /// </summary>
        [JsonProperty("ApiAccessIp")]
        public string ApiAccessIp{ get; set; }

        /// <summary>
        /// TcaplusDB SDK connection parameter: access port
        /// </summary>
        [JsonProperty("ApiAccessPort")]
        public long? ApiAccessPort{ get; set; }

        /// <summary>
        /// If `PasswordStatus` is `unmodifiable`, the old password has not expired, and this field will display its expiration time; otherwise, this field will be empty
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OldPasswordExpireTime")]
        public string OldPasswordExpireTime{ get; set; }

        /// <summary>
        /// TcaplusDB SDK connection parameter for accessing IPv6 addresses
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApiAccessIpv6")]
        public string ApiAccessIpv6{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "IdlType", this.IdlType);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "PasswordStatus", this.PasswordStatus);
            this.SetParamSimple(map, prefix + "ApiAccessId", this.ApiAccessId);
            this.SetParamSimple(map, prefix + "ApiAccessIp", this.ApiAccessIp);
            this.SetParamSimple(map, prefix + "ApiAccessPort", this.ApiAccessPort);
            this.SetParamSimple(map, prefix + "OldPasswordExpireTime", this.OldPasswordExpireTime);
            this.SetParamSimple(map, prefix + "ApiAccessIpv6", this.ApiAccessIpv6);
        }
    }
}

