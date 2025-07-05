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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIntlDomainListRequest : AbstractModel
    {
        
        /// <summary>
        /// The page number in pagination cases.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// The number of records on each page in pagination cases.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// The domain keyword for fuzzy search.
        /// </summary>
        [JsonProperty("KeyWord")]
        public string KeyWord{ get; set; }

        /// <summary>
        /// The registration time sort order. Valid values: `1` (descending), `2` (ascending).
        /// </summary>
        [JsonProperty("OrderByRegTime")]
        public long? OrderByRegTime{ get; set; }

        /// <summary>
        /// The expiration time sort order. Valid values: `1` (descending), `2` (ascending).
        /// </summary>
        [JsonProperty("OrderByExpireTime")]
        public long? OrderByExpireTime{ get; set; }

        /// <summary>
        /// The domain status.
        /// `all`: All domains.
        /// `UrgentNeedRenew`: The domains that are in urgent need of renewal.
        /// `RedemptionPending`: The domains that are in urgent need of redemption.
        /// `nosubmit`: The domains with unverified identities.
        /// `tran`: The domains that are being transferred in.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// The DNS type. Valid values: `1` (DNSPod), `2` (others).
        /// </summary>
        [JsonProperty("DnsStatus")]
        public ulong? DnsStatus{ get; set; }

        /// <summary>
        /// The domain sort order. Valid values: `1` (descending), `2` (ascending).
        /// </summary>
        [JsonProperty("OrderByDomainName")]
        public ulong? OrderByDomainName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "KeyWord", this.KeyWord);
            this.SetParamSimple(map, prefix + "OrderByRegTime", this.OrderByRegTime);
            this.SetParamSimple(map, prefix + "OrderByExpireTime", this.OrderByExpireTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DnsStatus", this.DnsStatus);
            this.SetParamSimple(map, prefix + "OrderByDomainName", this.OrderByDomainName);
        }
    }
}

