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

    public class DescribeIp6AddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// List of unique IDs that identify IPv6 instances. The unique ID of an IPv6 instance is in the format of `eip-11112222`. Parameters `Ip6AddressIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("Ip6AddressIds")]
        public string[] Ip6AddressIds{ get; set; }

        /// <summary>
        /// Each request can have up to 10 `Filters` values and 100 `Filter.Values` values. Parameters `AddressIds` and `Filters` cannot be specified at the same time. The specific filter conditions are as follows:
        /// <li>address-ip - String - Required: No - (Filter condition) Filter by the IP address of IPv6 instances.</li>
        /// <li>network-interface-id - String - Required: No - (Filter condition) Filter by the unique ID of ENIs.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: 0. For more information on `Offset`, see the relevant section in the API [overview](https://intl.cloud.tencent.com/document/api/213/11646?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100. For more information on `Limit`, see the relevant section in the API [overview](https://intl.cloud.tencent.com/document/api/213/11646?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Ip6AddressIds.", this.Ip6AddressIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

