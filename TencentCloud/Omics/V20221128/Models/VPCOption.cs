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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VPCOption : AbstractModel
    {
        
        /// <summary>
        /// VPC ID (Either VPCId or VPCCIDRBlock must be selected. If VPCId is selected, the existing VPCs will be used; if VPCCIDRBlock is selected, a new VPC will be created.)
        /// </summary>
        [JsonProperty("VPCId")]
        public string VPCId{ get; set; }

        /// <summary>
        /// Subnet ID (Either SubnetId or SubnetZone&SubnetCIDRBlock must be selected. If SubnetId is selected, the existing subnet will be used; if SubnetZone&SubnetCIDRBlock is selected, a new subnet will be created.)
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Subnet availability zone
        /// </summary>
        [JsonProperty("SubnetZone")]
        public string SubnetZone{ get; set; }

        /// <summary>
        ///  VPC CIDR.
        /// </summary>
        [JsonProperty("VPCCIDRBlock")]
        public string VPCCIDRBlock{ get; set; }

        /// <summary>
        /// Subnet CIDR
        /// </summary>
        [JsonProperty("SubnetCIDRBlock")]
        public string SubnetCIDRBlock{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VPCId", this.VPCId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetZone", this.SubnetZone);
            this.SetParamSimple(map, prefix + "VPCCIDRBlock", this.VPCCIDRBlock);
            this.SetParamSimple(map, prefix + "SubnetCIDRBlock", this.SubnetCIDRBlock);
        }
    }
}

