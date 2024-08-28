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

    public class VulEffectHostList : AbstractModel
    {
        
        /// <summary>
        /// Event ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EventId")]
        public ulong? EventId{ get; set; }

        /// <summary>
        /// Status. 0: pending; 1: ignored; 3: fixed; 5: detecting; 6: fixing; 7: rolling back; 8: fixing failed.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Last detection time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// Hazard level: 1-Low-risk; 2-Medium-risk; 3-High-risk; 4-Critical
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// Host QUUID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Host UUID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Host IP address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// Host alias
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// Host tag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Edition information. 0: Basic Edition; 1: Pro Edition; 2: Ultimate Edition; 3: Inclusive Edition.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostVersion")]
        public ulong? HostVersion{ get; set; }

        /// <summary>
        /// Whether automatic fixing is supported. 0: not supported; 1: supported; 2: client offline; 3: manual fixing supported for Ultimate Edition hosts; 4: not supported for this model; 5: fixing, 6: fixed; 7: detecting; 9: fixing failed; 10: ignored; 11: supported for Linux but not Windows; 12: supported for Windows but not Linux; 13: fixing failed but host is offline; 14: fixing failed but host is not of the Ultimate edition; 15: manually fixed.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsSupportAutoFix")]
        public ulong? IsSupportAutoFix{ get; set; }

        /// <summary>
        /// Failure cause
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FixStatusMsg")]
        public string FixStatusMsg{ get; set; }

        /// <summary>
        /// First detection time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FirstDiscoveryTime")]
        public string FirstDiscoveryTime{ get; set; }

        /// <summary>
        /// Instance status. "PENDING": creating; "LAUNCH_FAILED" : creation failed; "RUNNING": running; "STOPPED": shut down; "STARTING": starting; "STOPPING": shutting down; "REBOOTING": restarting; "SHUTDOWN": shut down and pending termination; "TERMINATING": terminating.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// Public IP address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string PublicIpAddresses{ get; set; }

        /// <summary>
        /// Cloud tag information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tags[] CloudTags{ get; set; }

        /// <summary>
        /// Host additional information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }


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
        }
    }
}

