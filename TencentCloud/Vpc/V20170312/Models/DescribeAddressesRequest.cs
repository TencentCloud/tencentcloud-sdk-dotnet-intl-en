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

    public class DescribeAddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// The list of unique IDs of EIPs in the format of `eip-11112222`. `AddressIds` and `Filters.address-id` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("AddressIds")]
        public string[] AddressIds{ get; set; }

        /// <summary>
        /// Each request can have up to 10 `Filters` and 5 `Filter.Values`. `AddressIds` and `Filters` cannot be specified at the same time. The specific filter conditions are as follows:
        /// <li> address-id - String - Required: No - (Filter condition) Filter by the unique EIP ID in the format of `eip-11112222`.</li>
        /// <li> address-name - String - Required: No - (Filter condition) Filter by the EIP name. Fuzzy filtering is not supported.</li>
        /// <li> address-ip - String - Required: No - (Filter condition) Filter by EIP.</li>
        /// <li> address-status - String - Required: No - (Filter condition) Filter by the EIP state. Valid values: `CREATING`, `BINDING`, `BIND`, `UNBINDING`, `UNBIND`, `OFFLINING`, and `BIND_ENI`.</li>
        /// <li> instance-id - String - Required: No - (Filter condition) Filter by the ID of the instance bound to the EIP in the format of `ins-11112222`.</li>
        /// <li> private-ip-address - String - Required: No - (Filter condition) Filter by the private IP address bound to the EIP.</li>
        /// <li> network-interface-id - String - Required: No - (Filter condition) Filter by the ID of the ENI bound to the EIP in the format of `eni-11112222`.</li>
        /// <li> is-arrears - String - Required: No - (Filter condition) Whether the EIP is overdue (TRUE: the EIP is overdue | FALSE: the billing status of the EIP is normal).</li>
        /// <li> address-type - String - Required: No - (Filter condition) Filter by the IP type. Valid values: `EIP`, `AnycastEIP`, and `HighQualityEIP`.</li>
        /// <li> address-isp - String - Required: No - (Filter condition) Filter by the ISP type. Valid values: `BGP`, `CMCC`, `CUCC`, and `CTCC`.</li>
        /// <li> dedicated-cluster-id - String - Required: No - (Filter condition) Filter by the unique CDC ID in the format of `cluster-11112222`.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// The Offset. The default value is 0. For more information on `Offset`, see the relevant sections in API [Overview](https://intl.cloud.tencent.com/document/product/11646).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. The default value is 20. The maximum is 100. For more information on `Limit`, see the relevant sections in API [Overview](https://intl.cloud.tencent.com/document/product/11646).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AddressIds.", this.AddressIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

