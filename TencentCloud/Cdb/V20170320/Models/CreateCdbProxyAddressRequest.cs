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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCdbProxyAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// Proxy group ID, which can be obtained through the [DescribeCdbProxyInfo](https://www.tencentcloud.com/document/api/236/90585?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// Assignment mode of weights. Valid values: `system` (auto-assigned), `custom`.
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// Whether to remove delayed read-only instances from the proxy group. Valid values: `true`, `false`.
        /// </summary>
        [JsonProperty("IsKickOut")]
        public bool? IsKickOut{ get; set; }

        /// <summary>
        /// Least read-only instances. Minimum value:  `0`
        /// </summary>
        [JsonProperty("MinCount")]
        public ulong? MinCount{ get; set; }

        /// <summary>
        /// Delay removal threshold, minimum value: 1, range: 1–10000. The value is an integer.
        /// </summary>
        [JsonProperty("MaxDelay")]
        public ulong? MaxDelay{ get; set; }

        /// <summary>
        /// Whether to enable failover. Valid values: `true`, `false`.
        /// </summary>
        [JsonProperty("FailOver")]
        public bool? FailOver{ get; set; }

        /// <summary>
        /// Whether to automatically add newly created read-only instances. Valid values: `true`, `false`.
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public bool? AutoAddRo{ get; set; }

        /// <summary>
        /// Whether it is read-only. Valid values: `true`, `false`.
        /// </summary>
        [JsonProperty("ReadOnly")]
        public bool? ReadOnly{ get; set; }

        /// <summary>
        /// Whether to enable transaction splitting. Valid values: `true`, `false`.
        /// </summary>
        [JsonProperty("TransSplit")]
        public bool? TransSplit{ get; set; }

        /// <summary>
        /// Assignment of read/write weights
        /// </summary>
        [JsonProperty("ProxyAllocation")]
        public ProxyAllocation[] ProxyAllocation{ get; set; }

        /// <summary>
        /// VPC ID. Obtain through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Private subnet ID. Obtain through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// Whether to enable connection pool. Off by default.
        /// Note: If you need to use the database proxy connection pool capability, the kernel minor version of the MySQL 8.0 primary instance must be equal to or greater than MySQL 8.0 20230630.
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public bool? ConnectionPool{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// IP. Leave it blank to default to a random supported IP in the selected VPC.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Port. Default value 3306.
        /// </summary>
        [JsonProperty("VPort")]
        public ulong? VPort{ get; set; }

        /// <summary>
        /// Security group
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// Connection pool type. Available values: transaction (transaction-level connection pool), connection (session-level connection pool). This parameter is valid only when ConnectionPool is true. Default value: connection.
        /// </summary>
        [JsonProperty("ConnectionPoolType")]
        public string ConnectionPoolType{ get; set; }

        /// <summary>
        /// Whether adaptive load balancing is enabled. Off by default.
        /// </summary>
        [JsonProperty("AutoLoadBalance")]
        public bool? AutoLoadBalance{ get; set; }

        /// <summary>
        /// Access mode. nearBy - proximity access, balance - balanced allocation. Default value: nearBy.
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "IsKickOut", this.IsKickOut);
            this.SetParamSimple(map, prefix + "MinCount", this.MinCount);
            this.SetParamSimple(map, prefix + "MaxDelay", this.MaxDelay);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "AutoAddRo", this.AutoAddRo);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
            this.SetParamSimple(map, prefix + "TransSplit", this.TransSplit);
            this.SetParamArrayObj(map, prefix + "ProxyAllocation.", this.ProxyAllocation);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "ConnectionPool", this.ConnectionPool);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "ConnectionPoolType", this.ConnectionPoolType);
            this.SetParamSimple(map, prefix + "AutoLoadBalance", this.AutoLoadBalance);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
        }
    }
}

