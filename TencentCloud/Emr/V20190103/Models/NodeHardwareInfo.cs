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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeHardwareInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>User APPID.</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>Serial number.</p>
        /// </summary>
        [JsonProperty("SerialNo")]
        public string SerialNo{ get; set; }

        /// <summary>
        /// <p>Machine instance ID.</p>
        /// </summary>
        [JsonProperty("OrderNo")]
        public string OrderNo{ get; set; }

        /// <summary>
        /// <p>Public IP address bound to the Master node.</p>
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// <p>Node type. Valid values: 0 (Common node), 1 (Master node)<br>2 (Core node) and 3 (Task node).</p>
        /// </summary>
        [JsonProperty("Flag")]
        public long? Flag{ get; set; }

        /// <summary>
        /// <p>Node specifications.</p>
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// <p>Number of node cores.</p>
        /// </summary>
        [JsonProperty("CpuNum")]
        public long? CpuNum{ get; set; }

        /// <summary>
        /// <p>Node memory (bytes).</p>
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// <p>Node memory description (GB).</p>
        /// </summary>
        [JsonProperty("MemDesc")]
        public string MemDesc{ get; set; }

        /// <summary>
        /// <p>Region where the node is located.</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// <p>Zone where the node is located.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <p>Application time.</p>
        /// </summary>
        [JsonProperty("ApplyTime")]
        public string ApplyTime{ get; set; }

        /// <summary>
        /// <p>Release time.</p>
        /// </summary>
        [JsonProperty("FreeTime")]
        public string FreeTime{ get; set; }

        /// <summary>
        /// <p>Hard disk size.</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public string DiskSize{ get; set; }

        /// <summary>
        /// <p>Node description.</p>
        /// </summary>
        [JsonProperty("NameTag")]
        public string NameTag{ get; set; }

        /// <summary>
        /// <p>Services deployed on the node.</p>
        /// </summary>
        [JsonProperty("Services")]
        public string Services{ get; set; }

        /// <summary>
        /// <p>Disk type. Valid values: 1 (Local Basic Disk), 2 (Cloud Basic Disk), 3 (Local SSD), 4 (Cloud SSD), 5 (Premium Disk), 6 (Enhanced SSD), 11 (Throughput-Optimized Cloud Disk), 12 (Tremendous SSD), 13 (Balanced SSD), 14 (Big Data Cloud Disk), 15 (High-IO Cloud Disk), and 16 (Remote SSD Disk).</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public long? StorageType{ get; set; }

        /// <summary>
        /// <p>System disk size (GB).</p>
        /// </summary>
        [JsonProperty("RootSize")]
        public long? RootSize{ get; set; }

        /// <summary>
        /// <p>Payment type. Valid values: 0 (pay-as-you-go) and 1 (yearly/monthly subscription).</p>
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }

        /// <summary>
        /// <p>Database IP address.</p>
        /// </summary>
        [JsonProperty("CdbIp")]
        public string CdbIp{ get; set; }

        /// <summary>
        /// <p>Database port.</p>
        /// </summary>
        [JsonProperty("CdbPort")]
        public long? CdbPort{ get; set; }

        /// <summary>
        /// <p>Hard disk capacity (bytes).</p>
        /// </summary>
        [JsonProperty("HwDiskSize")]
        public long? HwDiskSize{ get; set; }

        /// <summary>
        /// <p>Hard disk capacity description.</p>
        /// </summary>
        [JsonProperty("HwDiskSizeDesc")]
        public string HwDiskSizeDesc{ get; set; }

        /// <summary>
        /// <p>Memory capacity (bytes).</p>
        /// </summary>
        [JsonProperty("HwMemSize")]
        public long? HwMemSize{ get; set; }

        /// <summary>
        /// <p>Memory capacity description.</p>
        /// </summary>
        [JsonProperty("HwMemSizeDesc")]
        public string HwMemSizeDesc{ get; set; }

        /// <summary>
        /// <p>Expiration time.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>Node resource ID.</p>
        /// </summary>
        [JsonProperty("EmrResourceId")]
        public string EmrResourceId{ get; set; }

        /// <summary>
        /// <p>Renewal flag.</p>
        /// </summary>
        [JsonProperty("IsAutoRenew")]
        public long? IsAutoRenew{ get; set; }

        /// <summary>
        /// <p>Device identifier.</p>
        /// </summary>
        [JsonProperty("DeviceClass")]
        public string DeviceClass{ get; set; }

        /// <summary>
        /// <p>Supports configuration change.</p>
        /// </summary>
        [JsonProperty("Mutable")]
        public long? Mutable{ get; set; }

        /// <summary>
        /// <p>Multi-cloud disk.</p>
        /// </summary>
        [JsonProperty("MCMultiDisk")]
        public MultiDiskMC[] MCMultiDisk{ get; set; }

        /// <summary>
        /// <p>Database information.</p>
        /// </summary>
        [JsonProperty("CdbNodeInfo")]
        public CdbInfo CdbNodeInfo{ get; set; }

        /// <summary>
        /// <p>Private IP address.</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>Whether this node can be terminated. Valid values: 1 (yes) and 0 (no).</p>
        /// </summary>
        [JsonProperty("Destroyable")]
        public long? Destroyable{ get; set; }

        /// <summary>
        /// <p>Tag bound to the node.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Whether it is an auto scaling node. Valid values: 0 (regular node) and 1 (auto scaling node).</p>
        /// </summary>
        [JsonProperty("AutoFlag")]
        public long? AutoFlag{ get; set; }

        /// <summary>
        /// <p>Resource type. Valid values: host and pod.</p>
        /// </summary>
        [JsonProperty("HardwareResourceType")]
        public string HardwareResourceType{ get; set; }

        /// <summary>
        /// <p>Whether it is a floating specification. Valid values: 1 (yes) and 0 (no).</p>
        /// </summary>
        [JsonProperty("IsDynamicSpec")]
        public long? IsDynamicSpec{ get; set; }

        /// <summary>
        /// <p>JSON string of the floating specification value.</p>
        /// </summary>
        [JsonProperty("DynamicPodSpec")]
        public string DynamicPodSpec{ get; set; }

        /// <summary>
        /// <p>Whether changing the billing mode is supported. Valid values: 1 (yes) and 0 (no).</p>
        /// </summary>
        [JsonProperty("SupportModifyPayMode")]
        public long? SupportModifyPayMode{ get; set; }

        /// <summary>
        /// <p>System disk type. Valid values: 1 (Local Basic Disk), 2 (Cloud Basic Disk), 3 (Local SSD), 4 (Cloud SSD), 5 (Premium Disk), 6 (Enhanced SSD), 11 (Throughput-Optimized Cloud Disk), 12 (Tremendous SSD), 13 (Balanced SSD), 14 (Big Data Cloud Disk), 15 (High-IO Cloud Disk), and 16 (Remote SSD Disk).</p>
        /// </summary>
        [JsonProperty("RootStorageType")]
        public long? RootStorageType{ get; set; }

        /// <summary>
        /// <p>AZ information.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Subnet.</p>
        /// </summary>
        [JsonProperty("SubnetInfo")]
        public SubnetInfo SubnetInfo{ get; set; }

        /// <summary>
        /// <p>Client.</p>
        /// </summary>
        [JsonProperty("Clients")]
        public string Clients{ get; set; }

        /// <summary>
        /// <p>Current system time.</p>
        /// </summary>
        [JsonProperty("CurrentTime")]
        public string CurrentTime{ get; set; }

        /// <summary>
        /// <p>Whether it is used for federation. Valid values: 1 (yes) and 0 (no).</p>
        /// </summary>
        [JsonProperty("IsFederation")]
        public long? IsFederation{ get; set; }

        /// <summary>
        /// <p>Device name.</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>Service.</p>
        /// </summary>
        [JsonProperty("ServiceClient")]
        public string ServiceClient{ get; set; }

        /// <summary>
        /// <p>Whether instance protection is enabled for this instance. Valid values: true (enabled) and false (disabled).</p>
        /// </summary>
        [JsonProperty("DisableApiTermination")]
        public bool? DisableApiTermination{ get; set; }

        /// <summary>
        /// <p>0 indicates the old billing mode, and 1 indicates the new billing mode.</p>
        /// </summary>
        [JsonProperty("TradeVersion")]
        public long? TradeVersion{ get; set; }

        /// <summary>
        /// <p>Status of each component. ZooKeeper: STARTED; ResourceManager: STARTED. STARTED means started, and STOPPED means stopped.</p>
        /// </summary>
        [JsonProperty("ServicesStatus")]
        public string ServicesStatus{ get; set; }

        /// <summary>
        /// <p>Remarks.</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Shared cluster ID.</p>
        /// </summary>
        [JsonProperty("SharedClusterId")]
        public string SharedClusterId{ get; set; }

        /// <summary>
        /// <p>Description of the shared cluster ID.</p>
        /// </summary>
        [JsonProperty("SharedClusterIdDesc")]
        public string SharedClusterIdDesc{ get; set; }

        /// <summary>
        /// <p>Whether it is a scheduled termination resource.</p>
        /// </summary>
        [JsonProperty("TimingResource")]
        public bool? TimingResource{ get; set; }

        /// <summary>
        /// <p>TKE cluster ID when the resource type (HardwareResourceType) is pod.</p>
        /// </summary>
        [JsonProperty("TkeClusterId")]
        public string TkeClusterId{ get; set; }

        /// <summary>
        /// <p>Name list of services that can be configured when a new disk is mounted.</p>
        /// </summary>
        [JsonProperty("ConfigurableServices")]
        public string[] ConfigurableServices{ get; set; }

        /// <summary>
        /// <p>Node annotation information, which is currently only provided for the Terraform platform.</p>
        /// </summary>
        [JsonProperty("NodeMark")]
        public string NodeMark{ get; set; }

        /// <summary>
        /// <p>Whether the committed use resource supports setting auto-renewal.</p>
        /// </summary>
        [JsonProperty("UnderwriteSetAutoRenew")]
        public bool? UnderwriteSetAutoRenew{ get; set; }

        /// <summary>
        /// <p>GPU information.</p>
        /// </summary>
        [JsonProperty("GpuDesc")]
        public string GpuDesc{ get; set; }

        /// <summary>
        /// <p>Disk issue description.</p>
        /// </summary>
        [JsonProperty("DiskHealthIssues")]
        public DiskHealthIssue[] DiskHealthIssues{ get; set; }

        /// <summary>
        /// <p>ID of the node group where the node resides.</p>
        /// </summary>
        [JsonProperty("NodeGroupId")]
        public string NodeGroupId{ get; set; }

        /// <summary>
        /// <p>Name of the node group where the node resides.</p>
        /// </summary>
        [JsonProperty("NodeGroupName")]
        public string NodeGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "SerialNo", this.SerialNo);
            this.SetParamSimple(map, prefix + "OrderNo", this.OrderNo);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "MemDesc", this.MemDesc);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamSimple(map, prefix + "FreeTime", this.FreeTime);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "NameTag", this.NameTag);
            this.SetParamSimple(map, prefix + "Services", this.Services);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "RootSize", this.RootSize);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "CdbIp", this.CdbIp);
            this.SetParamSimple(map, prefix + "CdbPort", this.CdbPort);
            this.SetParamSimple(map, prefix + "HwDiskSize", this.HwDiskSize);
            this.SetParamSimple(map, prefix + "HwDiskSizeDesc", this.HwDiskSizeDesc);
            this.SetParamSimple(map, prefix + "HwMemSize", this.HwMemSize);
            this.SetParamSimple(map, prefix + "HwMemSizeDesc", this.HwMemSizeDesc);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "EmrResourceId", this.EmrResourceId);
            this.SetParamSimple(map, prefix + "IsAutoRenew", this.IsAutoRenew);
            this.SetParamSimple(map, prefix + "DeviceClass", this.DeviceClass);
            this.SetParamSimple(map, prefix + "Mutable", this.Mutable);
            this.SetParamArrayObj(map, prefix + "MCMultiDisk.", this.MCMultiDisk);
            this.SetParamObj(map, prefix + "CdbNodeInfo.", this.CdbNodeInfo);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Destroyable", this.Destroyable);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoFlag", this.AutoFlag);
            this.SetParamSimple(map, prefix + "HardwareResourceType", this.HardwareResourceType);
            this.SetParamSimple(map, prefix + "IsDynamicSpec", this.IsDynamicSpec);
            this.SetParamSimple(map, prefix + "DynamicPodSpec", this.DynamicPodSpec);
            this.SetParamSimple(map, prefix + "SupportModifyPayMode", this.SupportModifyPayMode);
            this.SetParamSimple(map, prefix + "RootStorageType", this.RootStorageType);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamObj(map, prefix + "SubnetInfo.", this.SubnetInfo);
            this.SetParamSimple(map, prefix + "Clients", this.Clients);
            this.SetParamSimple(map, prefix + "CurrentTime", this.CurrentTime);
            this.SetParamSimple(map, prefix + "IsFederation", this.IsFederation);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ServiceClient", this.ServiceClient);
            this.SetParamSimple(map, prefix + "DisableApiTermination", this.DisableApiTermination);
            this.SetParamSimple(map, prefix + "TradeVersion", this.TradeVersion);
            this.SetParamSimple(map, prefix + "ServicesStatus", this.ServicesStatus);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SharedClusterId", this.SharedClusterId);
            this.SetParamSimple(map, prefix + "SharedClusterIdDesc", this.SharedClusterIdDesc);
            this.SetParamSimple(map, prefix + "TimingResource", this.TimingResource);
            this.SetParamSimple(map, prefix + "TkeClusterId", this.TkeClusterId);
            this.SetParamArraySimple(map, prefix + "ConfigurableServices.", this.ConfigurableServices);
            this.SetParamSimple(map, prefix + "NodeMark", this.NodeMark);
            this.SetParamSimple(map, prefix + "UnderwriteSetAutoRenew", this.UnderwriteSetAutoRenew);
            this.SetParamSimple(map, prefix + "GpuDesc", this.GpuDesc);
            this.SetParamArrayObj(map, prefix + "DiskHealthIssues.", this.DiskHealthIssues);
            this.SetParamSimple(map, prefix + "NodeGroupId", this.NodeGroupId);
            this.SetParamSimple(map, prefix + "NodeGroupName", this.NodeGroupName);
        }
    }
}

