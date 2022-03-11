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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Address : AbstractModel
    {
        
        /// <summary>
        /// Unique EIP ID.
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// EIP name.
        /// </summary>
        [JsonProperty("AddressName")]
        public string AddressName{ get; set; }

        /// <summary>
        /// EIP status, including 'CREATING' (creating), 'BINDING' (binding), 'BIND' (bound), 'UNBINDING' (unbinding), 'UNBIND' (unbound), 'OFFLINING' (releasing), and 'BIND_ENI' (binding dangling ENI)
        /// </summary>
        [JsonProperty("AddressStatus")]
        public string AddressStatus{ get; set; }

        /// <summary>
        /// Public IP address
        /// </summary>
        [JsonProperty("AddressIp")]
        public string AddressIp{ get; set; }

        /// <summary>
        /// ID of the bound resource instance.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Creation time in ISO 8601 format (YYYY-MM-DDTHH:mm:ss.sssZ)
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// ID of the bound ENI
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// Private IP of the bound resource
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PrivateAddressIp")]
        public string PrivateAddressIp{ get; set; }

        /// <summary>
        /// Isolation status of the resource. true: isolated; false: not isolated.
        /// </summary>
        [JsonProperty("IsArrears")]
        public bool? IsArrears{ get; set; }

        /// <summary>
        /// Blockage status of the EIP resource. true: blocked; false: not blocked
        /// </summary>
        [JsonProperty("IsBlocked")]
        public bool? IsBlocked{ get; set; }

        /// <summary>
        /// Whether the EIP supports direct access mode. true: yes; false: no.
        /// </summary>
        [JsonProperty("IsEipDirectConnection")]
        public bool? IsEipDirectConnection{ get; set; }

        /// <summary>
        /// Resource type of the EIP, including `CalcIP` (device IP), `WanIP` (general public IP), `EIP` (elastic IP), and `AnycastEip` (accelerated EIP).
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// Whether the EIP is automatically released after being unbound. true: yes; false: no
        /// </summary>
        [JsonProperty("CascadeRelease")]
        public bool? CascadeRelease{ get; set; }

        /// <summary>
        /// ISP. CTCC: China Telecom; CUCC: China Unicom; CMCC: China Mobile
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// Bandwidth cap
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// Billing mode
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "AddressName", this.AddressName);
            this.SetParamSimple(map, prefix + "AddressStatus", this.AddressStatus);
            this.SetParamSimple(map, prefix + "AddressIp", this.AddressIp);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "PrivateAddressIp", this.PrivateAddressIp);
            this.SetParamSimple(map, prefix + "IsArrears", this.IsArrears);
            this.SetParamSimple(map, prefix + "IsBlocked", this.IsBlocked);
            this.SetParamSimple(map, prefix + "IsEipDirectConnection", this.IsEipDirectConnection);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "CascadeRelease", this.CascadeRelease);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
        }
    }
}

