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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChcHost : AbstractModel
    {
        
        /// <summary>
        /// CHC host ID
        /// </summary>
        [JsonProperty("ChcId")]
        public string ChcId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Server serial number
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// CHC host status<br/>
        /// <ul>
        /// <li>REGISTERED: The CHC host is registered, but the out-of-band network and deployment network are not configured.</li>
        /// <li>VPC_READY: The out-of-band network and deployment network are configured.</li>
        /// <li>PREPARED: It’s ready and can be associated with a CVM.</li>
        /// <li>ONLINE: It’s already associated with a CVM.</li>
        /// </ul>
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// Device type
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// Availability zone
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// Out-of-band network
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BmcVirtualPrivateCloud")]
        public VirtualPrivateCloud BmcVirtualPrivateCloud{ get; set; }

        /// <summary>
        /// Out-of-band network IP
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BmcIp")]
        public string BmcIp{ get; set; }

        /// <summary>
        /// Out-of-band network security group ID
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BmcSecurityGroupIds")]
        public string[] BmcSecurityGroupIds{ get; set; }

        /// <summary>
        /// Deployment network
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeployVirtualPrivateCloud")]
        public VirtualPrivateCloud DeployVirtualPrivateCloud{ get; set; }

        /// <summary>
        /// Deployment network IP
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeployIp")]
        public string DeployIp{ get; set; }

        /// <summary>
        /// Deployment network security group ID
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeploySecurityGroupIds")]
        public string[] DeploySecurityGroupIds{ get; set; }

        /// <summary>
        /// ID of the associated CVM
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CvmInstanceId")]
        public string CvmInstanceId{ get; set; }

        /// <summary>
        /// Server creation time
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Instance hardware description, including CPU cores, memory capacity and disk capacity.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HardwareDescription")]
        public string HardwareDescription{ get; set; }

        /// <summary>
        /// CPU cores of the CHC host
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CPU")]
        public long? CPU{ get; set; }

        /// <summary>
        /// Memory capacity of the CHC host (unit: GB)
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Disk capacity of the CHC host
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Disk")]
        public string Disk{ get; set; }

        /// <summary>
        /// MAC address assigned under the out-of-band network
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BmcMAC")]
        public string BmcMAC{ get; set; }

        /// <summary>
        /// MAC address assigned under the deployment network
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeployMAC")]
        public string DeployMAC{ get; set; }

        /// <summary>
        /// Management type
        /// HOSTING: Hosting
        /// TENANT: Leasing
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TenantType")]
        public string TenantType{ get; set; }

        /// <summary>
        /// CHC DHCP option, which is used for MiniOS debugging.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeployExtraConfig")]
        public ChcDeployExtraConfig DeployExtraConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChcId", this.ChcId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamObj(map, prefix + "BmcVirtualPrivateCloud.", this.BmcVirtualPrivateCloud);
            this.SetParamSimple(map, prefix + "BmcIp", this.BmcIp);
            this.SetParamArraySimple(map, prefix + "BmcSecurityGroupIds.", this.BmcSecurityGroupIds);
            this.SetParamObj(map, prefix + "DeployVirtualPrivateCloud.", this.DeployVirtualPrivateCloud);
            this.SetParamSimple(map, prefix + "DeployIp", this.DeployIp);
            this.SetParamArraySimple(map, prefix + "DeploySecurityGroupIds.", this.DeploySecurityGroupIds);
            this.SetParamSimple(map, prefix + "CvmInstanceId", this.CvmInstanceId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "HardwareDescription", this.HardwareDescription);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Disk", this.Disk);
            this.SetParamSimple(map, prefix + "BmcMAC", this.BmcMAC);
            this.SetParamSimple(map, prefix + "DeployMAC", this.DeployMAC);
            this.SetParamSimple(map, prefix + "TenantType", this.TenantType);
            this.SetParamObj(map, prefix + "DeployExtraConfig.", this.DeployExtraConfig);
        }
    }
}

