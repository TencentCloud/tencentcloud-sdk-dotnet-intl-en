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

    public class DescribeAddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// ECM region
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }

        /// <summary>
        /// List of unique IDs of EIPs, such as `eip-11112222`. `AddressIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("AddressIds")]
        public string[] AddressIds{ get; set; }

        /// <summary>
        /// Each request can contain up to 10 `Filters` and 5 `Filter.Values`. `AddressIds` and `Filters` cannot be specified at the same time. The detailed filters are as follows:
        /// address-id - String - Required: no - (Filter) Filter by unique EIP ID, such as `eip-11112222`.
        /// address-name - String - Required: no - (Filter) Filter by EIP name. Fuzzy filtering is not supported.
        /// address-ip - String - Required: no - (Filter) Filter by EIP IP address.
        /// address-status - String - Required: no - (Filter) Filter by EIP status. Value range: see the list of EIP status.
        /// instance-id - String - Required: no - (Filter) Filter by the ID of the instance bound to the EIP, such as `ins-11112222`.
        /// private-ip-address - String - Required: no - (Filter) Filter by the private IP bound to the EIP.
        /// network-interface-id - String - Required: no - (Filter) Filter by ID of the ENI bound to the EIP, such as `eni-11112222`.
        /// is-arrears - String - Required: no - (Filter) Filter by whether the EIP is overdue (TRUE: the EIP is overdue | FALSE: the billing status of the EIP is normal)
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of results to be returned. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamArraySimple(map, prefix + "AddressIds.", this.AddressIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

