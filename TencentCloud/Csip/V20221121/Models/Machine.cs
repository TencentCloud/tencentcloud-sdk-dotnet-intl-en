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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Machine : AbstractModel
    {
        
        /// <summary>
        /// <p>Agent status. Valid values: ONLINE: online; OFFLINE: offline; UNINSTALL: not installed</p>
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// <p>Agent version</p>
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// <p>Account AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>Cloud service provider</p>
        /// </summary>
        [JsonProperty("CloudFromEnum")]
        public string CloudFromEnum{ get; set; }

        /// <summary>
        /// <p>Cloud tag list</p>
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tag[] CloudTags{ get; set; }

        /// <summary>
        /// <p>CSIP protection type. Value: BASIC: basic version; PRO: pro edition; ULTIMATE: flagship edition</p>
        /// </summary>
        [JsonProperty("CsipProtectType")]
        public string CsipProtectType{ get; set; }

        /// <summary>
        /// <p>Exposure status</p>
        /// </summary>
        [JsonProperty("ExposedStatus")]
        public string ExposedStatus{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>Instance status. Value: RUNNING-running, STOPPED-shut down, EXPIRED-pending recycling</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>Network Card IP List</p>
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

        /// <summary>
        /// <p>Whether it is a new host (added within 15 days)</p>
        /// </summary>
        [JsonProperty("IsNew")]
        public bool? IsNew{ get; set; }

        /// <summary>
        /// <p>Kernel version</p>
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// <p>Last offline time (Unix timestamp).</p>
        /// </summary>
        [JsonProperty("LatestOfflineTime")]
        public long? LatestOfflineTime{ get; set; }

        /// <summary>
        /// <p>Private IP address.</p>
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// <p>Host name.</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>Operating system.</p>
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// <p>Public IP address.</p>
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// <p>Payment mode. Valid values: PREPAID: prepaid; POSTPAID: postpaid</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>Project ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// <p>Protection type. Value: NONE: no protection; BASIC: basic version; PRO: pro edition; ULTIMATE: flagship edition; PRO_LH: lightweight edition</p>
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

        /// <summary>
        /// <p>Host unique identifier</p>
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// <p>Region information.</p>
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// <p>Remarks.</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Asset tag list</p>
        /// </summary>
        [JsonProperty("TagItems")]
        public MiniTagItem[] TagItems{ get; set; }

        /// <summary>
        /// <p>Tag change information</p>
        /// </summary>
        [JsonProperty("TagModifyInfo")]
        public AssetTagModifyAssetItem TagModifyInfo{ get; set; }

        /// <summary>
        /// <p>TAT status. Valid values: ONLINE: online; OFFLINE: offline</p>
        /// </summary>
        [JsonProperty("TatStatus")]
        public string TatStatus{ get; set; }

        /// <summary>
        /// <p>Agent unique ID</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>VPC ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Host node type</p><p>Enumeration values:</p><ul><li>NONE: Host node</li><li>CLUSTER: Cluster node</li><li>CONTAINER: Container node</li></ul>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>Container protection status</p><p>Enumeration values:</p><ul><li>Enabled: Enable protection</li><li>Disabled: Disable protection</li><li>Unknown: Unknown</li></ul>
        /// </summary>
        [JsonProperty("ContainerDefendStatus")]
        public string ContainerDefendStatus{ get; set; }

        /// <summary>
        /// <p>Container count</p>
        /// </summary>
        [JsonProperty("ContainerCount")]
        public ulong? ContainerCount{ get; set; }

        /// <summary>
        /// <p>Number of cores.</p>
        /// </summary>
        [JsonProperty("CpuCoreCount")]
        public ulong? CpuCoreCount{ get; set; }

        /// <summary>
        /// <p>Whether migration is supported</p>
        /// </summary>
        [JsonProperty("MigrationRequired")]
        public bool? MigrationRequired{ get; set; }

        /// <summary>
        /// <p>Whether exposed surface scan is supported</p>
        /// </summary>
        [JsonProperty("IsSupportXSPM")]
        public bool? IsSupportXSPM{ get; set; }

        /// <summary>
        /// <p>Whether it can be unbound</p>
        /// </summary>
        [JsonProperty("CanUnbind")]
        public bool? CanUnbind{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CloudFromEnum", this.CloudFromEnum);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamSimple(map, prefix + "CsipProtectType", this.CsipProtectType);
            this.SetParamSimple(map, prefix + "ExposedStatus", this.ExposedStatus);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamSimple(map, prefix + "IsNew", this.IsNew);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "LatestOfflineTime", this.LatestOfflineTime);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "TagItems.", this.TagItems);
            this.SetParamObj(map, prefix + "TagModifyInfo.", this.TagModifyInfo);
            this.SetParamSimple(map, prefix + "TatStatus", this.TatStatus);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "ContainerDefendStatus", this.ContainerDefendStatus);
            this.SetParamSimple(map, prefix + "ContainerCount", this.ContainerCount);
            this.SetParamSimple(map, prefix + "CpuCoreCount", this.CpuCoreCount);
            this.SetParamSimple(map, prefix + "MigrationRequired", this.MigrationRequired);
            this.SetParamSimple(map, prefix + "IsSupportXSPM", this.IsSupportXSPM);
            this.SetParamSimple(map, prefix + "CanUnbind", this.CanUnbind);
        }
    }
}

