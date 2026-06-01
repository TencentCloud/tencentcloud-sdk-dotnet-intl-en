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

    public class AdjustCdbProxyAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Proxy group ID, which can be obtained through the <a href="https://www.tencentcloud.com/document/api/236/90585?from_cn_redirect=1">DescribeCdbProxyInfo</a> API.</p>
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// <p>Weight allocation mode,<br>system Auto-Assignment: "system", custom: "custom"</p>
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// <p>Whether delay removal is enabled. Value: "true" | "false"</p>
        /// </summary>
        [JsonProperty("IsKickOut")]
        public bool? IsKickOut{ get; set; }

        /// <summary>
        /// <p>Minimum retention quantity, minimum value: 0.<br>Description: Valid only when IsKickOut is true.</p>
        /// </summary>
        [JsonProperty("MinCount")]
        public ulong? MinCount{ get; set; }

        /// <summary>
        /// <p>Delay removal threshold, minimum value: 1, value ranges from 1 to 10000, integer.</p>
        /// </summary>
        [JsonProperty("MaxDelay")]
        public ulong? MaxDelay{ get; set; }

        /// <summary>
        /// <p>Whether fault migration is enabled, value: "true" | "false"</p>
        /// </summary>
        [JsonProperty("FailOver")]
        public bool? FailOver{ get; set; }

        /// <summary>
        /// <p>Automatically add RO. Parameter: "true" | "false"</p>
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public bool? AutoAddRo{ get; set; }

        /// <summary>
        /// <p>Whether it is read-only. Value: "true" | "false".</p>
        /// </summary>
        [JsonProperty("ReadOnly")]
        public bool? ReadOnly{ get; set; }

        /// <summary>
        /// <p>Proxy group address ID. Obtain through the <a href="https://www.tencentcloud.com/document/api/236/90585?from_cn_redirect=1">DescribeCdbProxyInfo</a> API.</p>
        /// </summary>
        [JsonProperty("ProxyAddressId")]
        public string ProxyAddressId{ get; set; }

        /// <summary>
        /// <p>Whether transaction splitting is enabled. Value: "true" | "false". Default value: false.</p>
        /// </summary>
        [JsonProperty("TransSplit")]
        public bool? TransSplit{ get; set; }

        /// <summary>
        /// <p>Whether the connection pool is enabled. Off by default.<br>Note: If you need to use the database proxy connection pool capability, the kernel minor version of the MySQL 8.0 primary instance must be at least MySQL 8.0 20230630.</p>
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public bool? ConnectionPool{ get; set; }

        /// <summary>
        /// <p>Read-write weight allocation. If WeightMode is passed in as system, the passed-in weight does not take effect and the default weight is assigned by the system.</p>
        /// </summary>
        [JsonProperty("ProxyAllocation")]
        public ProxyAllocation[] ProxyAllocation{ get; set; }

        /// <summary>
        /// <p>Whether self-adaptive load balancing is enabled. Off by default.</p>
        /// </summary>
        [JsonProperty("AutoLoadBalance")]
        public bool? AutoLoadBalance{ get; set; }

        /// <summary>
        /// <p>Access mode: nearby - proximity access, balance - balanced allocation. Default is proximity access.</p>
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// <p>Whether to treat the libra node as an ordinary RO node</p>
        /// </summary>
        [JsonProperty("ApNodeAsRoNode")]
        public bool? ApNodeAsRoNode{ get; set; }

        /// <summary>
        /// <p>Whether to forward to other nodes in case of a libra node fault</p>
        /// </summary>
        [JsonProperty("ApQueryToOtherNode")]
        public bool? ApQueryToOtherNode{ get; set; }


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
            this.SetParamSimple(map, prefix + "ProxyAddressId", this.ProxyAddressId);
            this.SetParamSimple(map, prefix + "TransSplit", this.TransSplit);
            this.SetParamSimple(map, prefix + "ConnectionPool", this.ConnectionPool);
            this.SetParamArrayObj(map, prefix + "ProxyAllocation.", this.ProxyAllocation);
            this.SetParamSimple(map, prefix + "AutoLoadBalance", this.AutoLoadBalance);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "ApNodeAsRoNode", this.ApNodeAsRoNode);
            this.SetParamSimple(map, prefix + "ApQueryToOtherNode", this.ApQueryToOtherNode);
        }
    }
}

