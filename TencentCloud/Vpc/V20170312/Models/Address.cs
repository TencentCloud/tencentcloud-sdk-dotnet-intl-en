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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Address : AbstractModel
    {
        
        /// <summary>
        /// `EIP` `ID`, the unique ID of the `EIP`.
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// The `EIP` name.
        /// </summary>
        [JsonProperty("AddressName")]
        public string AddressName{ get; set; }

        /// <summary>
        /// Possible `EIP` states are 'CREATING', 'BINDING', 'BIND', 'UNBINDING', 'UNBIND', 'OFFLINING', and 'BIND_ENI'.
        /// </summary>
        [JsonProperty("AddressStatus")]
        public string AddressStatus{ get; set; }

        /// <summary>
        /// The public IP address
        /// </summary>
        [JsonProperty("AddressIp")]
        public string AddressIp{ get; set; }

        /// <summary>
        /// The ID of the bound resource instance. This can be a `CVM` or `NAT`.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The creation time, which follows the `ISO8601` standard and uses `UTC` time in the format of `YYYY-MM-DDThh:mm:ssZ`.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// The ID of the bound ENI
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// The private IP of the bound resources
        /// </summary>
        [JsonProperty("PrivateAddressIp")]
        public string PrivateAddressIp{ get; set; }

        /// <summary>
        /// The isolation status of the resource. `True` indicates the EIP is isolated. `False` indicates that the resource is not isolated.
        /// </summary>
        [JsonProperty("IsArrears")]
        public bool? IsArrears{ get; set; }

        /// <summary>
        /// The block status of the resource. `True` indicates the EIP is blocked. `False` indicates that the EIP is not blocked.
        /// </summary>
        [JsonProperty("IsBlocked")]
        public bool? IsBlocked{ get; set; }

        /// <summary>
        /// Whether the EIP supports direct connection mode. `True` indicates the EIP supports direct connection. `False` indicates that the resource does not support direct connection.
        /// </summary>
        [JsonProperty("IsEipDirectConnection")]
        public bool? IsEipDirectConnection{ get; set; }

        /// <summary>
        /// The resource type of the EIP. This includes `CalcIP`, `WanIP`, `EIP`, and `AnycastEIP`. Among these, `CalcIP` indicates the device IP, `WanIP` indicates the common public IP, `EIP` indicates Elastic IP, and `AnycastEip` indicates accelerated EIP.
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// Whether the EIP is automatically released after being unbound. `True` indicates the EIP will be automatically released after being unbound. `False` indicates the EIP will not be automatically released after being unbound.
        /// </summary>
        [JsonProperty("CascadeRelease")]
        public bool? CascadeRelease{ get; set; }

        /// <summary>
        /// Type of the protocol used in EIP ALG
        /// </summary>
        [JsonProperty("EipAlgType")]
        public AlgType EipAlgType{ get; set; }

        /// <summary>
        /// The ISP of an EIP/Elastic IP, with possible return values currently including "CMCC", "CTCC", "CUCC" and "BGP"
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamObj(map, prefix + "EipAlgType.", this.EipAlgType);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
        }
    }
}

