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

    public class PrivateIpAddressSpecification : AbstractModel
    {
        
        /// <summary>
        /// Private IP address.
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public string PrivateIpAddress{ get; set; }

        /// <summary>
        /// Whether it is a primary IP.
        /// </summary>
        [JsonProperty("Primary")]
        public bool? Primary{ get; set; }

        /// <summary>
        /// Public IP address.
        /// </summary>
        [JsonProperty("PublicIpAddress")]
        public string PublicIpAddress{ get; set; }

        /// <summary>
        /// EIP instance ID, such as `eip-11112222`.
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// Private IP description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Whether the public IP is blocked.
        /// </summary>
        [JsonProperty("IsWanIpBlocked")]
        public bool? IsWanIpBlocked{ get; set; }

        /// <summary>
        /// IP status:
        /// PENDING: Creating
        /// MIGRATING: Migrating
        /// DELETING: Deleting
        /// AVAILABLE: Available
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// IP service level. Values: `PT` (Gold), `AU` (Silver), `AG` (Bronze) and `DEFAULT`
        /// </summary>
        [JsonProperty("QosLevel")]
        public string QosLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrivateIpAddress", this.PrivateIpAddress);
            this.SetParamSimple(map, prefix + "Primary", this.Primary);
            this.SetParamSimple(map, prefix + "PublicIpAddress", this.PublicIpAddress);
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsWanIpBlocked", this.IsWanIpBlocked);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "QosLevel", this.QosLevel);
        }
    }
}

