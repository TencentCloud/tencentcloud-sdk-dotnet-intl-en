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

namespace TencentCloud.Region.V20220627.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneInfo : AbstractModel
    {
        
        /// <summary>
        /// Availability zone name, for example, ap-guangzhou-3.
        /// 
        /// The names of availability zones across the network are as follows:.
        /// <li> ap-chongqing-1 </li>
        /// <li> ap-seoul-1 </li>
        /// <li> ap-seoul-2 </li>
        /// <li> ap-chengdu-1 </li>
        /// <li> ap-chengdu-2 </li>
        /// <li> ap-hongkong-1 </li>
        /// <li> ap-hongkong-2 </li>
        /// <li> ap-shenzhen-fsi-1 </li>
        /// <li> ap-shenzhen-fsi-2 </li>
        /// <li> ap-shenzhen-fsi-3 </li>
        /// <Li> ap-guangzhou-1 (sold-out)</li>.
        /// <Li> ap-guangzhou-2 (resource out of stock)</li>.
        /// <li> ap-guangzhou-3 </li>
        /// <li> ap-guangzhou-4 </li>
        /// <li> ap-guangzhou-6 </li>
        /// <li> ap-tokyo-1 </li>
        /// <li> ap-singapore-1 </li>
        /// <li> ap-singapore-2 </li>
        /// <li> ap-shanghai-fsi-1 </li>
        /// <li> ap-shanghai-fsi-2 </li>
        /// <li> ap-shanghai-fsi-3 </li>
        /// <li> ap-bangkok-1 </li>
        /// <Li> ap-shanghai-1 (resource out of stock) </li>.
        /// <li> ap-shanghai-2 </li>
        /// <li> ap-shanghai-3 </li>
        /// <li> ap-shanghai-4 </li>
        /// <li> ap-shanghai-5 </li>
        /// <li> ap-mumbai-1 </li>
        /// <li> ap-mumbai-2 </li>
        /// <li> ap-beijing-1 </li>
        /// <li> ap-beijing-2 </li>
        /// <li> ap-beijing-3 </li>
        /// <li> ap-beijing-4 </li>
        /// <li> ap-beijing-5 </li>
        /// <li> na-siliconvalley-1 </li>
        /// <li> na-siliconvalley-2 </li>
        /// <li> eu-frankfurt-1 </li>
        /// <li> na-ashburn-1 </li>
        /// <li> na-ashburn-2 </li>
        /// <li> ap-nanjing-1 </li>
        /// <li> ap-nanjing-2 </li>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Availability zone description, such as Guangzhou Zone 3.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// AZ ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Availability zone status, including AVAILABLE and UNAVAILABLE. AVAILABLE indicates available, and UNAVAILABLE indicates unavailable.
        /// </summary>
        [JsonProperty("ZoneState")]
        public string ZoneState{ get; set; }

        /// <summary>
        /// Parent zone.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ParentZone")]
        public string ParentZone{ get; set; }

        /// <summary>
        /// Parent availability zone ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ParentZoneId")]
        public string ParentZoneId{ get; set; }

        /// <summary>
        /// Describes the parent availability zone.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ParentZoneName")]
        public string ParentZoneName{ get; set; }

        /// <summary>
        /// zone type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneType")]
        public string ZoneType{ get; set; }

        /// <summary>
        /// Console type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineRoomTypeMC")]
        public string MachineRoomTypeMC{ get; set; }

        /// <summary>
        /// Same as ZoneId. suitable for console invocation.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneIdMC")]
        public string ZoneIdMC{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneState", this.ZoneState);
            this.SetParamSimple(map, prefix + "ParentZone", this.ParentZone);
            this.SetParamSimple(map, prefix + "ParentZoneId", this.ParentZoneId);
            this.SetParamSimple(map, prefix + "ParentZoneName", this.ParentZoneName);
            this.SetParamSimple(map, prefix + "ZoneType", this.ZoneType);
            this.SetParamSimple(map, prefix + "MachineRoomTypeMC", this.MachineRoomTypeMC);
            this.SetParamSimple(map, prefix + "ZoneIdMC", this.ZoneIdMC);
        }
    }
}

