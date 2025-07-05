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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySubnetAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Subnet instance ID, such as `subnet-pxir56ns`.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// ECM region
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }

        /// <summary>
        /// Subnet name, which can contain up to 60 bytes.
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// Whether to enable broadcast for the subnet.
        /// </summary>
        [JsonProperty("EnableBroadcast")]
        public string EnableBroadcast{ get; set; }

        /// <summary>
        /// Tag key value of the subnet
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "EnableBroadcast", this.EnableBroadcast);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

