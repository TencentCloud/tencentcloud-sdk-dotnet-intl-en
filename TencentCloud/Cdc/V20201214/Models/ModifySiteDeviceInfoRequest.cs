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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySiteDeviceInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// Equipment room ID
        /// </summary>
        [JsonProperty("SiteId")]
        public string SiteId{ get; set; }

        /// <summary>
        /// You are using optical fiber type to connect the CDC device to the network Single-mode or multi-mode fibers are available.
        /// </summary>
        [JsonProperty("FiberType")]
        public string FiberType{ get; set; }

        /// <summary>
        /// Optical standard used to connect the CDC device to the network This field depends on the uplink speed, optical fiber type, and distance to upstream equipment.
        /// </summary>
        [JsonProperty("OpticalStandard")]
        public string OpticalStandard{ get; set; }

        /// <summary>
        /// Type of power connector
        /// </summary>
        [JsonProperty("PowerConnectors")]
        public string PowerConnectors{ get; set; }

        /// <summary>
        /// Whether power is supplied from above or below the rack
        /// </summary>
        [JsonProperty("PowerFeedDrop")]
        public string PowerFeedDrop{ get; set; }

        /// <summary>
        /// Maximum weight capacity (KG)
        /// </summary>
        [JsonProperty("MaxWeight")]
        public long? MaxWeight{ get; set; }

        /// <summary>
        /// Power consumption (KW)
        /// </summary>
        [JsonProperty("PowerDrawKva")]
        public long? PowerDrawKva{ get; set; }

        /// <summary>
        /// Uplink speed from the network to Tencent Cloud Region
        /// </summary>
        [JsonProperty("UplinkSpeedGbps")]
        public long? UplinkSpeedGbps{ get; set; }

        /// <summary>
        /// Number of uplinks used by each CDC device (2 devices per rack) when connected to the network
        /// </summary>
        [JsonProperty("UplinkCount")]
        public long? UplinkCount{ get; set; }

        /// <summary>
        /// Whether the following environmental conditions are met: 
        /// 1. There are no material requirements or the acceptance standard on site that will affect the delivery and installation of the CDC device. 
        /// 2. The following conditions are met for finalized rack positions: 
        /// Temperature ranges from 41 to 104°F (5 to 40°C). 
        /// Humidity ranges from 10°F (-12°C) to 70°F (21°C) and relative humidity ranges from 8% RH to 80% RH. 
        /// Air flows from front to back at the rack position and there is sufficient air in CFM (cubic feet per minute). The air quantity in CFM must be 145.8 times the power consumption (in KVA) of CDC.
        /// </summary>
        [JsonProperty("ConditionRequirement")]
        public bool? ConditionRequirement{ get; set; }

        /// <summary>
        /// Whether the following dimension conditions are met: 
        /// Your loading dock can accommodate one rack container (H x W x D = 94" x 54" x 48"). 
        /// You can provide a clear route from the delivery point of your rack (H x W x D = 80" x 24" x 48") to its final installation location. You should consider platforms, corridors, doors, turns, ramps, freight elevators as well as other access restrictions when measuring the depth. 
        /// There shall be a 48" or greater front clearance and a 24" or greater rear clearance where the CDC is finally installed.
        /// </summary>
        [JsonProperty("DimensionRequirement")]
        public bool? DimensionRequirement{ get; set; }

        /// <summary>
        /// Whether redundant upstream equipment (switch or router) is provided so that both network devices can be connected to the network.
        /// </summary>
        [JsonProperty("RedundantNetworking")]
        public bool? RedundantNetworking{ get; set; }

        /// <summary>
        /// Whether you need help from Tencent Cloud for rack installation?
        /// </summary>
        [JsonProperty("NeedHelp")]
        public bool? NeedHelp{ get; set; }

        /// <summary>
        /// Whether there is power redundancy?
        /// </summary>
        [JsonProperty("RedundantPower")]
        public bool? RedundantPower{ get; set; }

        /// <summary>
        /// Whether there is an upstream circuit breaker?
        /// </summary>
        [JsonProperty("BreakerRequirement")]
        public bool? BreakerRequirement{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SiteId", this.SiteId);
            this.SetParamSimple(map, prefix + "FiberType", this.FiberType);
            this.SetParamSimple(map, prefix + "OpticalStandard", this.OpticalStandard);
            this.SetParamSimple(map, prefix + "PowerConnectors", this.PowerConnectors);
            this.SetParamSimple(map, prefix + "PowerFeedDrop", this.PowerFeedDrop);
            this.SetParamSimple(map, prefix + "MaxWeight", this.MaxWeight);
            this.SetParamSimple(map, prefix + "PowerDrawKva", this.PowerDrawKva);
            this.SetParamSimple(map, prefix + "UplinkSpeedGbps", this.UplinkSpeedGbps);
            this.SetParamSimple(map, prefix + "UplinkCount", this.UplinkCount);
            this.SetParamSimple(map, prefix + "ConditionRequirement", this.ConditionRequirement);
            this.SetParamSimple(map, prefix + "DimensionRequirement", this.DimensionRequirement);
            this.SetParamSimple(map, prefix + "RedundantNetworking", this.RedundantNetworking);
            this.SetParamSimple(map, prefix + "NeedHelp", this.NeedHelp);
            this.SetParamSimple(map, prefix + "RedundantPower", this.RedundantPower);
            this.SetParamSimple(map, prefix + "BreakerRequirement", this.BreakerRequirement);
        }
    }
}

