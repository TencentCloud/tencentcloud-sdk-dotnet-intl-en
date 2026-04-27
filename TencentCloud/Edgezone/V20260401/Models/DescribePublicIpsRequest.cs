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

namespace TencentCloud.Edgezone.V20260401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePublicIpsRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter by public network instance ID (substring match, union of multiple values)
        /// </summary>
        [JsonProperty("NetworkInstanceId")]
        public string[] NetworkInstanceId{ get; set; }

        /// <summary>
        /// Filter by availability zone/IDC
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Filter by IP (substring match, union of multiple values)
        /// </summary>
        [JsonProperty("Ip")]
        public string[] Ip{ get; set; }

        /// <summary>
        /// Filter by status, available values: `InUse`, `Unbound` (multiple values are combined with OR)
        /// </summary>
        [JsonProperty("State")]
        public string[] State{ get; set; }

        /// <summary>
        /// Filter by IP version. Available values: `Ipv4`, `Ipv6` (multiple values are combined).
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// Sort by creation time, available values: `asc`, `desc` (default `desc`)
        /// </summary>
        [JsonProperty("OrderByCreateTime")]
        public string OrderByCreateTime{ get; set; }

        /// <summary>
        /// Sort by update time, available values: `asc`, `desc` (priority is higher than sort by creation time)
        /// </summary>
        [JsonProperty("OrderByUpdateTime")]
        public string OrderByUpdateTime{ get; set; }

        /// <summary>
        /// Pagination offset, default 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of items per page. Default 20. Maximum 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NetworkInstanceId.", this.NetworkInstanceId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Ip.", this.Ip);
            this.SetParamArraySimple(map, prefix + "State.", this.State);
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
            this.SetParamSimple(map, prefix + "OrderByCreateTime", this.OrderByCreateTime);
            this.SetParamSimple(map, prefix + "OrderByUpdateTime", this.OrderByUpdateTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

