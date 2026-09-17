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

namespace TencentCloud.Edgezone.V20260401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID list for filtering by instance ID</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>Instance name, supports fuzzy matching.</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Availability zone code for filtering instances in the specified availability zone</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Instance status list for status filtering. Available values: allocating, running, isolating, isolated, terminating, error.</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string[] InstanceStatus{ get; set; }

        /// <summary>
        /// <p>Public network ID.</p>
        /// </summary>
        [JsonProperty("PublicNetworkId")]
        public string PublicNetworkId{ get; set; }

        /// <summary>
        /// <p>VPC ID.</p>
        /// </summary>
        [JsonProperty("PrivateNetworkId")]
        public string PrivateNetworkId{ get; set; }

        /// <summary>
        /// <p>Public IPv4 address list, used for filtering instances by public IP address</p>
        /// </summary>
        [JsonProperty("PublicIps")]
        public string[] PublicIps{ get; set; }

        /// <summary>
        /// <p>Offset. Default value: 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Number of returned results. Default 20. Maximum 100.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArraySimple(map, prefix + "InstanceStatus.", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "PublicNetworkId", this.PublicNetworkId);
            this.SetParamSimple(map, prefix + "PrivateNetworkId", this.PrivateNetworkId);
            this.SetParamArraySimple(map, prefix + "PublicIps.", this.PublicIps);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

