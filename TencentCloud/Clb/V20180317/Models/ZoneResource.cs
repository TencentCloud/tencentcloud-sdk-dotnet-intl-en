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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneResource : AbstractModel
    {
        
        /// <summary>
        /// Primary AZ, such as "ap-guangzhou-1".
        /// </summary>
        [JsonProperty("MasterZone")]
        public string MasterZone{ get; set; }

        /// <summary>
        /// List of resources
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceSet")]
        public Resource[] ResourceSet{ get; set; }

        /// <summary>
        /// Secondary AZ, such as "ap-guangzhou-2". 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SlaveZone")]
        public string SlaveZone{ get; set; }

        /// <summary>
        /// IP version. Values: `IPv4`, `IPv6`, and `IPv6_Nat`.
        /// </summary>
        [JsonProperty("IPVersion")]
        public string IPVersion{ get; set; }

        /// <summary>
        /// Region of the AZ, such as `ap-guangzhou`.
        /// </summary>
        [JsonProperty("ZoneRegion")]
        public string ZoneRegion{ get; set; }

        /// <summary>
        /// Whether the AZ is a `LocalZone`. Values: `true`, `false`.
        /// </summary>
        [JsonProperty("LocalZone")]
        public bool? LocalZone{ get; set; }

        /// <summary>
        /// Type of resources in the zone. Values: `SHARED`, `EXCLUSIVE`
        /// </summary>
        [JsonProperty("ZoneResourceType")]
        public string ZoneResourceType{ get; set; }

        /// <summary>
        /// Whether the AZ is an edge zone. Values: `true`, `false`.
        /// </summary>
        [JsonProperty("EdgeZone")]
        public bool? EdgeZone{ get; set; }

        /// <summary>
        /// Network egress
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MasterZone", this.MasterZone);
            this.SetParamArrayObj(map, prefix + "ResourceSet.", this.ResourceSet);
            this.SetParamSimple(map, prefix + "SlaveZone", this.SlaveZone);
            this.SetParamSimple(map, prefix + "IPVersion", this.IPVersion);
            this.SetParamSimple(map, prefix + "ZoneRegion", this.ZoneRegion);
            this.SetParamSimple(map, prefix + "LocalZone", this.LocalZone);
            this.SetParamSimple(map, prefix + "ZoneResourceType", this.ZoneResourceType);
            this.SetParamSimple(map, prefix + "EdgeZone", this.EdgeZone);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
        }
    }
}

