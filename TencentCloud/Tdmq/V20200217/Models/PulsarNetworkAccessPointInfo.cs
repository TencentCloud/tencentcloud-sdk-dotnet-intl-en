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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PulsarNetworkAccessPointInfo : AbstractModel
    {
        
        /// <summary>
        /// VPC ID. This field is left empty for supporting network and public network access points.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID. This field is left empty for supporting network and public network access points.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Access address
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Access point type: 
        /// `0`: Supporting network access point 
        /// `1`: VPC access point 
        /// `2`: Public network access point
        /// </summary>
        [JsonProperty("RouteType")]
        public ulong? RouteType{ get; set; }

        /// <summary>
        /// 0: local region access. since cross-region disaster recovery is not configured, this type of access point cannot perform cross-region switchover or switch back from remote access.
        /// Local region access. due to the configuration of cross-region disaster recovery, switchover can be performed at any time in a different location. this state is used for the primary cluster access point.
        /// Cross-Region access, completed offsite switchover, this state is used for the access point of the source cluster. the access point in this state is non-deletable.
        /// 3: cross-region access can be switched back from remote access at any time. this state is for the access point of the target cluster. the access point in this state is non-deletable.
        /// Cross-Region access. the target cluster has completed offsite switchback and is in the state of waiting for deletion.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OperationType")]
        public ulong? OperationType{ get; set; }

        /// <summary>
        /// Access point type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccessPointsType")]
        public string AccessPointsType{ get; set; }

        /// <summary>
        /// Bandwidth. currently only public network has this value.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// Class.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecurityPolicy")]
        public SecurityPolicy[] SecurityPolicy{ get; set; }

        /// <summary>
        /// Indicates whether it is a standard access point. valid values: true (standard), false (not standard).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StandardAccessPoint")]
        public bool? StandardAccessPoint{ get; set; }

        /// <summary>
        /// AZ information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Specifies whether TLS encryption is enabled.
        /// </summary>
        [JsonProperty("Tls")]
        public bool? Tls{ get; set; }

        /// <summary>
        /// Access point custom domain name.
        /// </summary>
        [JsonProperty("CustomUrl")]
        public string CustomUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
            this.SetParamSimple(map, prefix + "AccessPointsType", this.AccessPointsType);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamArrayObj(map, prefix + "SecurityPolicy.", this.SecurityPolicy);
            this.SetParamSimple(map, prefix + "StandardAccessPoint", this.StandardAccessPoint);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "Tls", this.Tls);
            this.SetParamSimple(map, prefix + "CustomUrl", this.CustomUrl);
        }
    }
}

