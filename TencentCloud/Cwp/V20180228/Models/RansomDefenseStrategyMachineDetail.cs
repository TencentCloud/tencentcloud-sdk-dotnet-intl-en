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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RansomDefenseStrategyMachineDetail : AbstractModel
    {
        
        /// <summary>
        /// Host UUID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Host QUUID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Host name
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Host Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Private IP address
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Public IP address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// Cloud tag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tag[] CloudTags{ get; set; }

        /// <summary>
        /// Availability zone information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// CWPP tag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tag")]
        public MachineTag[] Tag{ get; set; }

        /// <summary>
        /// Protection status: 0 Disabled, 1 Enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Policy ID. 0 indicates no binding to any policy.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// Hard disk information, all hard disks take effect when left blank:
        /// Separate diskId1|diskName1;diskId2|diskName2
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskInfo")]
        public string DiskInfo{ get; set; }

        /// <summary>
        /// Edition information. 0: Basic Edition; 1: Pro Edition; 2: Ultimate Edition; 3: Inclusive Edition.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostVersion")]
        public ulong? HostVersion{ get; set; }

        /// <summary>
        /// Policy name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "DiskInfo", this.DiskInfo);
            this.SetParamSimple(map, prefix + "HostVersion", this.HostVersion);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
        }
    }
}

