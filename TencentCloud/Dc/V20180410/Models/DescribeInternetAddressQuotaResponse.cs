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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInternetAddressQuotaResponse : AbstractModel
    {
        
        /// <summary>
        /// Minimum prefix length allowed for a public IPv6 address
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ipv6PrefixLen")]
        public long? Ipv6PrefixLen{ get; set; }

        /// <summary>
        /// Quota of BGP IPv4 addresses
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ipv4BgpQuota")]
        public long? Ipv4BgpQuota{ get; set; }

        /// <summary>
        /// Quota of non-BGP IPv4 addresses
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ipv4OtherQuota")]
        public long? Ipv4OtherQuota{ get; set; }

        /// <summary>
        /// Used number of BGP IPv4 addresses
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ipv4BgpNum")]
        public long? Ipv4BgpNum{ get; set; }

        /// <summary>
        /// Used number of non-BGP IPv4 addresses
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ipv4OtherNum")]
        public long? Ipv4OtherNum{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ipv6PrefixLen", this.Ipv6PrefixLen);
            this.SetParamSimple(map, prefix + "Ipv4BgpQuota", this.Ipv4BgpQuota);
            this.SetParamSimple(map, prefix + "Ipv4OtherQuota", this.Ipv4OtherQuota);
            this.SetParamSimple(map, prefix + "Ipv4BgpNum", this.Ipv4BgpNum);
            this.SetParamSimple(map, prefix + "Ipv4OtherNum", this.Ipv4OtherNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

