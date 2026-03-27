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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpecSellStatus : AbstractModel
    {
        
        /// <summary>
        /// Sellable Specification Unique ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Instance Type ID
        /// </summary>
        [JsonProperty("SpecId")]
        public ulong? SpecId{ get; set; }

        /// <summary>
        /// Supported payment modes for this specification: POST - only supports pay-as-you-go, PRE - only supports yearly/monthly subscription, ALL - supports all.
        /// </summary>
        [JsonProperty("PayModeStatus")]
        public string PayModeStatus{ get; set; }

        /// <summary>
        /// Product type. Types of instances for purchase: HA - Local Disk High Availability (including dual-node high availability, alwaysOn cluster), RO - Local Disk Read-Only Replica, SI - Cloud Disk Edition Single Node, BI - Business Intelligence Service, cvmHA - Cloud Disk Edition High Availability, cvmRO - Cloud Disk Edition Read-Only Replica, MultiHA - Multi-node, cvmMultiHA - Cloud Disk Multi-node.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Whether this specification supports cross-AZ deployment: MultiZones - only supports cross-AZ, SameZones - only supports same-AZ, ALL - supports all.
        /// </summary>
        [JsonProperty("MultiZonesStatus")]
        public string MultiZonesStatus{ get; set; }

        /// <summary>
        /// Architecture Type, SINGLE - single node, DOUBLE - dual node, TRIPLE - three-node, MULTI - multi-node
        /// Example value: SINGLE
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }

        /// <summary>
        /// Type identifier, EXCLUSIVE - Dedicated, SHARED - Shared
        /// </summary>
        [JsonProperty("Style")]
        public string Style{ get; set; }

        /// <summary>
        /// Database Version Information
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Sellable Status Set Per AZ
        /// </summary>
        [JsonProperty("ZoneStatusSet")]
        public ZoneStatus[] ZoneStatusSet{ get; set; }

        /// <summary>
        /// Reference price for specifications. The actual price is subject to the quotation API.
        /// </summary>
        [JsonProperty("Price")]
        public Price Price{ get; set; }

        /// <summary>
        /// Specification Sale Status: 1 - Normal, 2 - Sale disabled but upgradable, 3 - Sale completely disabled.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamSimple(map, prefix + "PayModeStatus", this.PayModeStatus);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "MultiZonesStatus", this.MultiZonesStatus);
            this.SetParamSimple(map, prefix + "Architecture", this.Architecture);
            this.SetParamSimple(map, prefix + "Style", this.Style);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamArrayObj(map, prefix + "ZoneStatusSet.", this.ZoneStatusSet);
            this.SetParamObj(map, prefix + "Price.", this.Price);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

