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

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Bound Physical Machine ID
        /// </summary>
        [JsonProperty("MachineId")]
        public string MachineId{ get; set; }

        /// <summary>
        /// Model specifications
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Availability zone code
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Image ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Image version number
        /// </summary>
        [JsonProperty("VersionNumber")]
        public string VersionNumber{ get; set; }

        /// <summary>
        /// Instance status, value range: allocating, running, isolating, isolated, terminating, error.
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// Operation status: normal, starting, stopping, stopped, rebooting.
        /// </summary>
        [JsonProperty("OperateStatus")]
        public string OperateStatus{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("PrivateNetworkId")]
        public string PrivateNetworkId{ get; set; }

        /// <summary>
        /// private IPv4 address
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// private IPv6 address
        /// </summary>
        [JsonProperty("PrivateIpV6")]
        public string PrivateIpV6{ get; set; }

        /// <summary>
        /// Public network ID
        /// </summary>
        [JsonProperty("PublicNetworkId")]
        public string PublicNetworkId{ get; set; }

        /// <summary>
        /// Public IPv4 address
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// Public IPv6 address
        /// </summary>
        [JsonProperty("PublicIpV6")]
        public string PublicIpV6{ get; set; }

        /// <summary>
        /// Creation time, expressed according to the ISO8601 standard and using the UTC time. The format is YYYY-MM-DDThh:mm:ssZ.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "MachineId", this.MachineId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "VersionNumber", this.VersionNumber);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "OperateStatus", this.OperateStatus);
            this.SetParamSimple(map, prefix + "PrivateNetworkId", this.PrivateNetworkId);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "PrivateIpV6", this.PrivateIpV6);
            this.SetParamSimple(map, prefix + "PublicNetworkId", this.PublicNetworkId);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PublicIpV6", this.PublicIpV6);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

