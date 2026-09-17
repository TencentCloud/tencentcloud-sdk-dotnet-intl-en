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
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Instance name.</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Bound Physical Machine ID</p>
        /// </summary>
        [JsonProperty("MachineId")]
        public string MachineId{ get; set; }

        /// <summary>
        /// <p>Model specifications</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>Availability zone code</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Image ID.</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>Image version number</p>
        /// </summary>
        [JsonProperty("VersionNumber")]
        [System.Obsolete]
        public string VersionNumber{ get; set; }

        /// <summary>
        /// <p>Instance status, value range: allocating, running, isolating, isolated, terminating, error.</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>Operation status: normal, starting, stopping, stopped, rebooting.</p>
        /// </summary>
        [JsonProperty("OperateStatus")]
        public string OperateStatus{ get; set; }

        /// <summary>
        /// <p>VPC ID.</p>
        /// </summary>
        [JsonProperty("PrivateNetworkId")]
        public string PrivateNetworkId{ get; set; }

        /// <summary>
        /// <p>Private IPv4 address</p>
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// <p>Private IPv6 address</p>
        /// </summary>
        [JsonProperty("PrivateIpV6")]
        public string PrivateIpV6{ get; set; }

        /// <summary>
        /// <p>Public network ID.</p>
        /// </summary>
        [JsonProperty("PublicNetworkId")]
        public string PublicNetworkId{ get; set; }

        /// <summary>
        /// <p>Public IPv4 address</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>Public IPv6 address</p>
        /// </summary>
        [JsonProperty("PublicIpV6")]
        public string PublicIpV6{ get; set; }

        /// <summary>
        /// <p>File System Type</p>
        /// </summary>
        [JsonProperty("FileSystemType")]
        public string FileSystemType{ get; set; }

        /// <summary>
        /// <p>Creation time, in the ISO 8601 standard format, using UTC time. Format: YYYY-MM-DDThh:mm:ssZ.</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>Instance family flag</p>
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// <p>Model Family Name</p>
        /// </summary>
        [JsonProperty("InstanceFamilyName")]
        public string InstanceFamilyName{ get; set; }

        /// <summary>
        /// <p>CPU Model</p>
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// <p>CPU cores.</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>Memory size.</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }


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
            this.SetParamSimple(map, prefix + "FileSystemType", this.FileSystemType);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "InstanceFamilyName", this.InstanceFamilyName);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
        }
    }
}

