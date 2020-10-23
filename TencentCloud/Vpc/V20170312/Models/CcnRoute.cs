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

    public class CcnRoute : AbstractModel
    {
        
        /// <summary>
        /// The ID of the routing policy
        /// </summary>
        [JsonProperty("RouteId")]
        public string RouteId{ get; set; }

        /// <summary>
        /// Destination
        /// </summary>
        [JsonProperty("DestinationCidrBlock")]
        public string DestinationCidrBlock{ get; set; }

        /// <summary>
        /// The type of the next hop (associated instance type). Available types: VPC, DIRECTCONNECT
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// The next hop (associated instance)
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The name of the next hop (associated instance name)
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// The region of the next hop (the region of the associated instance)
        /// </summary>
        [JsonProperty("InstanceRegion")]
        public string InstanceRegion{ get; set; }

        /// <summary>
        /// Update Time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Whether the route is enabled
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// The UIN (root account) to which the associated instance belongs
        /// </summary>
        [JsonProperty("InstanceUin")]
        public string InstanceUin{ get; set; }

        /// <summary>
        /// Additional status of the route
        /// </summary>
        [JsonProperty("ExtraState")]
        public string ExtraState{ get; set; }

        /// <summary>
        /// Whether it is a dynamic route
        /// </summary>
        [JsonProperty("IsBgp")]
        public bool? IsBgp{ get; set; }

        /// <summary>
        /// Route priority
        /// </summary>
        [JsonProperty("RoutePriority")]
        public ulong? RoutePriority{ get; set; }

        /// <summary>
        /// Next hop port name (associated instance’s port name)
        /// </summary>
        [JsonProperty("InstanceExtraName")]
        public string InstanceExtraName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RouteId", this.RouteId);
            this.SetParamSimple(map, prefix + "DestinationCidrBlock", this.DestinationCidrBlock);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceRegion", this.InstanceRegion);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "InstanceUin", this.InstanceUin);
            this.SetParamSimple(map, prefix + "ExtraState", this.ExtraState);
            this.SetParamSimple(map, prefix + "IsBgp", this.IsBgp);
            this.SetParamSimple(map, prefix + "RoutePriority", this.RoutePriority);
            this.SetParamSimple(map, prefix + "InstanceExtraName", this.InstanceExtraName);
        }
    }
}

