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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDosPolicy : AbstractModel
    {
        
        /// <summary>
        /// Resource bound to policy
        /// </summary>
        [JsonProperty("Resources")]
        public ResourceIp[] Resources{ get; set; }

        /// <summary>
        /// Disabled protocol
        /// </summary>
        [JsonProperty("DropOptions")]
        public DDoSPolicyDropOption DropOptions{ get; set; }

        /// <summary>
        /// Disabled port
        /// </summary>
        [JsonProperty("PortLimits")]
        public DDoSPolicyPortLimit[] PortLimits{ get; set; }

        /// <summary>
        /// Packet filter
        /// </summary>
        [JsonProperty("PacketFilters")]
        public DDoSPolicyPacketFilter[] PacketFilters{ get; set; }

        /// <summary>
        /// IP blocklist/allowlist
        /// </summary>
        [JsonProperty("IpBlackWhiteLists")]
        public IpBlackWhite[] IpBlackWhiteLists{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Policy creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Watermarking policy parameter. There can be only one policy. If there are no policies, the array is empty
        /// </summary>
        [JsonProperty("WaterPrint")]
        public WaterPrintPolicy[] WaterPrint{ get; set; }

        /// <summary>
        /// Watermark key. There can be up to two keys. If there are no policies, the array is empty
        /// </summary>
        [JsonProperty("WaterKey")]
        public WaterPrintKey[] WaterKey{ get; set; }

        /// <summary>
        /// Resource instance bound to policy
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BoundResources")]
        public string[] BoundResources{ get; set; }

        /// <summary>
        /// Policy scenario
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamObj(map, prefix + "DropOptions.", this.DropOptions);
            this.SetParamArrayObj(map, prefix + "PortLimits.", this.PortLimits);
            this.SetParamArrayObj(map, prefix + "PacketFilters.", this.PacketFilters);
            this.SetParamArrayObj(map, prefix + "IpBlackWhiteLists.", this.IpBlackWhiteLists);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "WaterPrint.", this.WaterPrint);
            this.SetParamArrayObj(map, prefix + "WaterKey.", this.WaterKey);
            this.SetParamArraySimple(map, prefix + "BoundResources.", this.BoundResources);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
        }
    }
}

