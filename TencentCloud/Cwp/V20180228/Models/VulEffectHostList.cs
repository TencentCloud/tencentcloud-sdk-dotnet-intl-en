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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulEffectHostList : AbstractModel
    {
        
        /// <summary>
        /// Event ID
        /// </summary>
        [JsonProperty("EventId")]
        public ulong? EventId{ get; set; }

        /// <summary>
        /// Status: 0 - pending processing; 1 - ignored; 3 - fixed; 5 - detecting; 6 - in remediation; 7 - rolling back; 8 - fix failed.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Last detection time
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// Hazard level: 1-Low-risk; 2-Medium-risk; 3-High-risk; 4-Critical
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// Host QUUID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Host UUID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Host IP address
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// Host alias
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// Host tag
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Version information: 0-Basic version, 1-Pro edition, 2-Flagship edition, 3-Lightweight edition
        /// </summary>
        [JsonProperty("HostVersion")]
        public ulong? HostVersion{ get; set; }

        /// <summary>
        /// Whether automatic fixing is supported 0: Cannot be automatically repaired, 1: Can be automatically repaired, 2: Client offline, 3: Host can only be manually repaired if not flagship, 4: Not supported for this model, 5: In remediation, 6: Fixed, 7: In-progress detection, 9: Fix failed, 10: Ignored, 11: Vulnerability supported only on linux, not Windows, 12: Vulnerability supported only on Windows, not on linux, 13: Fixing failed but host is offline, 14: Fixing failed but host is not flagship, 15: Manually fixed
        /// </summary>
        [JsonProperty("IsSupportAutoFix")]
        public ulong? IsSupportAutoFix{ get; set; }

        /// <summary>
        /// Reason for failure
        /// </summary>
        [JsonProperty("FixStatusMsg")]
        public string FixStatusMsg{ get; set; }

        /// <summary>
        /// First detection time
        /// </summary>
        [JsonProperty("FirstDiscoveryTime")]
        public string FirstDiscoveryTime{ get; set; }

        /// <summary>
        /// Instance status: "PENDING" - creating, "LAUNCH_FAILED" - creation failed, "RUNNING" - running, "STOPPED" - shutdown, "STARTING" - starting, "STOPPING" - indicates shutdown in progress, "REBOOTING" - restarting, "SHUTDOWN" - indicate shutdown and pending termination, "TERMINATING" - indicates terminating in progress.
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// Public IP address
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string PublicIpAddresses{ get; set; }

        /// <summary>
        /// Cloud Tag Information
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tags[] CloudTags{ get; set; }

        /// <summary>
        /// Host Additional Information
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// Host type
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Availability zone ID.
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// Whether to create a snapshot for the fix task: 0: not created; other: created.
        /// </summary>
        [JsonProperty("HasSnapshot")]
        public ulong? HasSnapshot{ get; set; }

        /// <summary>
        /// Last repair time
        /// </summary>
        [JsonProperty("LatestFixTime")]
        public string LatestFixTime{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("DescriptionEn")]
        public string DescriptionEn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "HostVersion", this.HostVersion);
            this.SetParamSimple(map, prefix + "IsSupportAutoFix", this.IsSupportAutoFix);
            this.SetParamSimple(map, prefix + "FixStatusMsg", this.FixStatusMsg);
            this.SetParamSimple(map, prefix + "FirstDiscoveryTime", this.FirstDiscoveryTime);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "PublicIpAddresses", this.PublicIpAddresses);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "HasSnapshot", this.HasSnapshot);
            this.SetParamSimple(map, prefix + "LatestFixTime", this.LatestFixTime);
            this.SetParamSimple(map, prefix + "DescriptionEn", this.DescriptionEn);
        }
    }
}

