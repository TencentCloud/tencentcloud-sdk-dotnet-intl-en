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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MachineSimple : AbstractModel
    {
        
        /// <summary>
        /// Host name.
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Host System.
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// Yunjing client UUID. If the client is offline for a long time, an empty string is returned.
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// CVM or BM Machine Unique UUID.
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Host IP.
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Whether the edition is Pro Edition
        /// <li>true: yes</li>
        /// <li>false: no</li>
        /// </summary>
        [JsonProperty("IsProVersion")]
        public bool? IsProVersion{ get; set; }

        /// <summary>
        /// Public IP address of the host
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// Host status
        /// <li>POSTPAY: postpaid, indicating pay-as-you-go mode </li>
        /// <li>PREPAY: prepaid, indicating monthly subscription mode</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Tag information
        /// </summary>
        [JsonProperty("Tag")]
        public MachineTag[] Tag{ get; set; }

        /// <summary>
        /// Region information
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// Instance status. TERMINATED_PRO_VERSION: terminated.
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Machine Zone Type. CVM - Cloud Virtual Machine; BM: Bare Metal; ECM: Edge Computing Machine; LH: Lightweight Application Server; Other: Hybrid Cloud Zone
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Kernel version
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// Protection Edition. BASIC_VERSION: Basic Edition; PRO_VERSION: Professional Edition; Flagship: Premium Edition; GENERAL_DISCOUNT: General Discount Edition
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

        /// <summary>
        /// Authorization order object
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LicenseOrder")]
        public LicenseOrder LicenseOrder{ get; set; }

        /// <summary>
        /// Cloud Tag Information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tags[] CloudTags{ get; set; }

        /// <summary>
        /// Instance ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "IsProVersion", this.IsProVersion);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
            this.SetParamObj(map, prefix + "LicenseOrder.", this.LicenseOrder);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

