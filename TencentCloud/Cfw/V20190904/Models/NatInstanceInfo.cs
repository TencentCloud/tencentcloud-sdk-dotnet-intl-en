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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NatInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// NAT instance ID
        /// </summary>
        [JsonProperty("NatinsId")]
        public string NatinsId{ get; set; }

        /// <summary>
        /// NAT instance name
        /// </summary>
        [JsonProperty("NatinsName")]
        public string NatinsName{ get; set; }

        /// <summary>
        /// Instance region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 0: create new; 1: use existing
        /// </summary>
        [JsonProperty("FwMode")]
        public long? FwMode{ get; set; }

        /// <summary>
        /// Instance bandwidth (Mbps)
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// Inbound traffic peak bandwidth (bps)
        /// </summary>
        [JsonProperty("InFlowMax")]
        public long? InFlowMax{ get; set; }

        /// <summary>
        /// Outbound traffic peak bandwidth (bps)
        /// </summary>
        [JsonProperty("OutFlowMax")]
        public ulong? OutFlowMax{ get; set; }

        /// <summary>
        /// Chinese region information
        /// </summary>
        [JsonProperty("RegionZh")]
        public string RegionZh{ get; set; }

        /// <summary>
        /// Public IP array
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EipAddress")]
        public string[] EipAddress{ get; set; }

        /// <summary>
        /// Array of internal and external IPs
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("VpcIp")]
        public string[] VpcIp{ get; set; }

        /// <summary>
        /// Array of subnets associated with an instance
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Subnets")]
        public string[] Subnets{ get; set; }

        /// <summary>
        /// 0: normal 1: initializing
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Region information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionDetail")]
        public string RegionDetail{ get; set; }

        /// <summary>
        /// Availability zone of the instance
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneZh")]
        public string ZoneZh{ get; set; }

        /// <summary>
        /// Availability zone of the instance
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneZhBak")]
        public string ZoneZhBak{ get; set; }

        /// <summary>
        /// Number of used rules.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleUsed")]
        public ulong? RuleUsed{ get; set; }

        /// <summary>
        /// The maximum number of rules allowed in the instance.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleMax")]
        public ulong? RuleMax{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatinsId", this.NatinsId);
            this.SetParamSimple(map, prefix + "NatinsName", this.NatinsName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "FwMode", this.FwMode);
            this.SetParamSimple(map, prefix + "BandWidth", this.BandWidth);
            this.SetParamSimple(map, prefix + "InFlowMax", this.InFlowMax);
            this.SetParamSimple(map, prefix + "OutFlowMax", this.OutFlowMax);
            this.SetParamSimple(map, prefix + "RegionZh", this.RegionZh);
            this.SetParamArraySimple(map, prefix + "EipAddress.", this.EipAddress);
            this.SetParamArraySimple(map, prefix + "VpcIp.", this.VpcIp);
            this.SetParamArraySimple(map, prefix + "Subnets.", this.Subnets);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RegionDetail", this.RegionDetail);
            this.SetParamSimple(map, prefix + "ZoneZh", this.ZoneZh);
            this.SetParamSimple(map, prefix + "ZoneZhBak", this.ZoneZhBak);
            this.SetParamSimple(map, prefix + "RuleUsed", this.RuleUsed);
            this.SetParamSimple(map, prefix + "RuleMax", this.RuleMax);
        }
    }
}

