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

    public class ProxyAddress : AbstractModel
    {
        
        /// <summary>
        /// Address ID of the proxy group
        /// </summary>
        [JsonProperty("ProxyAddressId")]
        public string ProxyAddressId{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// VPC subnet ID
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// IP address
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Port
        /// </summary>
        [JsonProperty("VPort")]
        public ulong? VPort{ get; set; }

        /// <summary>
        /// Weight allocation mode.
        /// System Auto-Assignment: "system", Custom: "custom"
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// Whether to enable delay removal. Parameter value: "true" | "false"
        /// </summary>
        [JsonProperty("IsKickOut")]
        public bool? IsKickOut{ get; set; }

        /// <summary>
        /// Minimum retention quantity, minimum value: 0.
        /// </summary>
        [JsonProperty("MinCount")]
        public ulong? MinCount{ get; set; }

        /// <summary>
        /// Delay removal threshold, minimum value: 0
        /// </summary>
        [JsonProperty("MaxDelay")]
        public ulong? MaxDelay{ get; set; }

        /// <summary>
        /// Automatically add RO. Value: "true" | "false"
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public bool? AutoAddRo{ get; set; }

        /// <summary>
        /// Whether it is read-only. Value: "true" | "false".
        /// </summary>
        [JsonProperty("ReadOnly")]
        public bool? ReadOnly{ get; set; }

        /// <summary>
        /// Whether transaction splitting is enabled
        /// </summary>
        [JsonProperty("TransSplit")]
        public bool? TransSplit{ get; set; }

        /// <summary>
        /// Whether fault migration is enabled
        /// </summary>
        [JsonProperty("FailOver")]
        public bool? FailOver{ get; set; }

        /// <summary>
        /// Whether to enable connection pool
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public bool? ConnectionPool{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Read weight distribution of an instance
        /// </summary>
        [JsonProperty("ProxyAllocation")]
        public ProxyAllocation[] ProxyAllocation{ get; set; }

        /// <summary>
        /// Access mode
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// Whether automatic CLB is enabled
        /// </summary>
        [JsonProperty("AutoLoadBalance")]
        public bool? AutoLoadBalance{ get; set; }

        /// <summary>
        /// Whether to treat libra as a read-only node
        /// </summary>
        [JsonProperty("ApNodeAsRoNode")]
        public bool? ApNodeAsRoNode{ get; set; }

        /// <summary>
        /// libra node fault, whether to forward to other nodes
        /// </summary>
        [JsonProperty("ApQueryToOtherNode")]
        public bool? ApQueryToOtherNode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyAddressId", this.ProxyAddressId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "IsKickOut", this.IsKickOut);
            this.SetParamSimple(map, prefix + "MinCount", this.MinCount);
            this.SetParamSimple(map, prefix + "MaxDelay", this.MaxDelay);
            this.SetParamSimple(map, prefix + "AutoAddRo", this.AutoAddRo);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
            this.SetParamSimple(map, prefix + "TransSplit", this.TransSplit);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "ConnectionPool", this.ConnectionPool);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamArrayObj(map, prefix + "ProxyAllocation.", this.ProxyAllocation);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "AutoLoadBalance", this.AutoLoadBalance);
            this.SetParamSimple(map, prefix + "ApNodeAsRoNode", this.ApNodeAsRoNode);
            this.SetParamSimple(map, prefix + "ApQueryToOtherNode", this.ApQueryToOtherNode);
        }
    }
}

