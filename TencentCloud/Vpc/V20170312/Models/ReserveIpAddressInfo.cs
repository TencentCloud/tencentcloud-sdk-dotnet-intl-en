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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReserveIpAddressInfo : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of the reserved private IP address.
        /// </summary>
        [JsonProperty("ReserveIpId")]
        public string ReserveIpId{ get; set; }

        /// <summary>
        /// Unique ID of the VPC.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Unique ID of the subnet.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Reserved private IP address.
        /// </summary>
        [JsonProperty("ReserveIpAddress")]
        public string ReserveIpAddress{ get; set; }

        /// <summary>
        /// Resource instance ID bound to the reserved private IP address.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// IpType applied for the product.
        /// </summary>
        [JsonProperty("IpType")]
        public ulong? IpType{ get; set; }

        /// <summary>
        /// Binding status. UnBind: unbound; Bind: bound.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Name of the reserved private IP address.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Description of the reserved private IP address.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Tag key-value pair.
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReserveIpId", this.ReserveIpId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ReserveIpAddress", this.ReserveIpAddress);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "IpType", this.IpType);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

