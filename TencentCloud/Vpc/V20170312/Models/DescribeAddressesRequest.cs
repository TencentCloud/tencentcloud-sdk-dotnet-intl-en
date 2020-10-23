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
        /// The list of unique IDs of EIPs, such as `eip-11112222`. `AddressIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("AddressIds")]
        public string[] AddressIds{ get; set; }

        /// <summary>
        /// The upper limit for `Filters` in each request is 10 and 5 for `Filter.Values`. `AddressIds` and `Filters` cannot be specified at the same time. Detailed filter conditions are as follows:
        /// <li> address-id - String - Required: no - (Filter condition) The unique EIP ID, such as `eip-11112222`.</li>
        /// <li> address-name - String - Required: no - (Filter condition) The EIP name. Fuzzy filtering is not supported.</li>
        /// <li> address-ip - String - Required: no - (Filter condition) Filters by EIP.</li>
        /// <li> address-status - String - Required: no - (Filter condition) The EIP state. Possible EIP states are: 'CREATING', 'BINDING', 'BIND', 'UNBINDING', 'UNBIND', 'OFFLINING', and 'BIND_ENI'.</li>
        /// <li> instance-id - String - Required: no - (Filter condition) The ID of the instance bound to the EIP, such as `ins-11112222`.</li>
        /// <li> private-ip-address - String - Required: no - (Filter condition) The private IP address bound to the EIP.</li>
        /// <li> network-interface-id - String - Required: no - (Filter condition) The ID of the ENI bound to the EIP, such as `eni-11112222`.</li>
        /// <li> is-arrears - String - Required: no - (Filter condition) Whether the EIP is in arrears. (TRUE: the EIP is in arrears | FALSE: the billing status of the EIP is normal)</li>
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

