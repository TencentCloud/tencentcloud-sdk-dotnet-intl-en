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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIPv6AddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique ID column identifying IPv6.
        /// 
        /// - Unique ID of the traditional EIPv6, such as `eip-11112222`
        /// - Unique ID of the EIPv6, such as `eipv6-11112222`
        /// 
        /// Note: `IPv6AddressIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("IPv6AddressIds")]
        public string[] IPv6AddressIds{ get; set; }

        /// <summary>
        /// Each request can have up to 10 `Filters` and 100 `Filter.Values`. `IPv6AddressIds` and `Filters` cannot be specified at the same time. The detailed filter conditions are as follows:
        /// 
        /// - address-id - String - Required: No - (Filter condition) Filter by the unique ID of the EIPv6.
        /// - public-ipv6-address - String - Required: No - (Filter condition) Filter by the public IPv6 address.
        /// - network-interface-id - String - Required: No - (Filter condition) Filter by the unique ID of the ENI.
        /// - instance-id - String - Required: No - (Filter condition) Filter by the unique ID of the bound instance.
        /// - charge-type - String - Required: No - (Filter condition) Filter by the billing type.
        /// - private-ipv6-address - String - Required: No - (Filter condition) Filter by the bound private IPv6 address.
        /// - egress - String - Required: No - (Filter condition) Filter by the egress.
        /// - address-type - String - Required: No - (Filter condition) Filter by the IPv6 type. Valid values: 'EIP6', 'EIPv6', 'WanIPv6', and 'HighQualityEIPv6'. Default: 'EIPv6'.
        /// - address-isp - String - Required: No - (Filter condition) Filter by the ISP type. Valid values: 'BGP', 'CMCC', 'CUCC', and 'CTCC'.
        /// - address-status - String - Required: No - (Filter condition) Filter by the EIP status. Valid values: 'CREATING', 'BINDING', 'BIND', 'UNBINDING', 'UNBIND', 'OFFLINING', 'BIND_ENI', and 'PRIVATE'.
        /// - address-name - String - Required: No - (Filter condition) Filter by the EIP name. Fuzzy filtering is not supported.
        /// - tag-key - String - Required: No - (Filter condition) Filter by the tag key.
        /// - tag-value - String - Required: No - (Filter condition) Filter by the tag value.
        /// - tag:tag-key - String - Required: No - (Filter condition) Filter by the tag-key - value pair. Replace tag-key with a specific tag key.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Indicates whether to query the traditional IPv6 address information.
        /// </summary>
        [JsonProperty("Traditional")]
        public bool? Traditional{ get; set; }

        /// <summary>
        /// Offset. Default: 0. For more information on Offset, see the relevant section in the API [Overview](https://intl.cloud.tencent.com/document/api/213/11646?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default: 20. Maximum: 100. For more information on Limit, see the relevant section in the API [Overview](https://intl.cloud.tencent.com/document/api/213/11646?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "IPv6AddressIds.", this.IPv6AddressIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Traditional", this.Traditional);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

