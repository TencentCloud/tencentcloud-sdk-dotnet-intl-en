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
        /// User AppID.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Serial number.
        /// </summary>
        [JsonProperty("SerialNo")]
        public string SerialNo{ get; set; }

        /// <summary>
        /// Machine instance ID.
        /// </summary>
        [JsonProperty("OrderNo")]
        public string OrderNo{ get; set; }

        /// <summary>
        /// Public network IP address bound for the Master node.
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// Node type. 0: Common node; 1: Master node.
        ///  2: Core node; 3: Task node.
        /// </summary>
        [JsonProperty("Flag")]
        public long? Flag{ get; set; }

        /// <summary>
        /// Node specifications.
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// Number of node cores.
        /// </summary>
        [JsonProperty("CpuNum")]
        public long? CpuNum{ get; set; }

        /// <summary>
        /// Node memory (bytes).
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// Node memory (GB).
        /// </summary>
        [JsonProperty("MemDesc")]
        public string MemDesc{ get; set; }

        /// <summary>
        /// The region where the node is located.
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// The zone where the node is located.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// Application time.
        /// </summary>
        [JsonProperty("ApplyTime")]
        public string ApplyTime{ get; set; }

        /// <summary>
        /// Release time.
        /// </summary>
        [JsonProperty("FreeTime")]
        public string FreeTime{ get; set; }

        /// <summary>
        /// Hard disk size.
        /// </summary>
        [JsonProperty("DiskSize")]
        public string DiskSize{ get; set; }

        /// <summary>
        /// Node description.
        /// </summary>
        [JsonProperty("NameTag")]
        public string NameTag{ get; set; }

        /// <summary>
        /// Node deployment service.
        /// </summary>
        [JsonProperty("Services")]
        public string Services{ get; set; }

        /// <summary>
        /// Disk type. Valid values: 1 (Local Disk), 2 (Cloud Disk), 3 (Local SSD), 4 (Cloud SSD), 5 (Premium Cloud Disk), 6 (Enhanced SSD), 11 (Throughput SSD), 12 (Tremendous SSD), 13 (Balanced SSD), 14 (Big Data Cloud Disk), 15 (High IO Cloud Disk), and 16 (Remote SSD).
        /// </summary>
        [JsonProperty("StorageType")]
        public long? StorageType{ get; set; }

        /// <summary>
        /// System disk size (GB).
        /// </summary>
        [JsonProperty("RootSize")]
        public long? RootSize{ get; set; }

        /// <summary>
        /// Payment type. Valid values: 0 (pay-as-you-go); 1 (yearly/monthly subscription).
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }

        /// <summary>
        /// Database IP address.
        /// </summary>
        [JsonProperty("CdbIp")]
        public string CdbIp{ get; set; }

        /// <summary>
        /// Database port.
        /// </summary>
        [JsonProperty("CdbPort")]
        public long? CdbPort{ get; set; }

        /// <summary>
        /// Hard disk capacity (bytes).
        /// </summary>
        [JsonProperty("HwDiskSize")]
        public long? HwDiskSize{ get; set; }

        /// <summary>
        /// Hard disk capacity description.
        /// </summary>
        [JsonProperty("HwDiskSizeDesc")]
        public string HwDiskSizeDesc{ get; set; }

        /// <summary>
        /// Memory capacity (bytes).
        /// </summary>
        [JsonProperty("HwMemSize")]
        public long? HwMemSize{ get; set; }

        /// <summary>
        /// Memory capacity description.
        /// </summary>
        [JsonProperty("HwMemSizeDesc")]
        public string HwMemSizeDesc{ get; set; }

        /// <summary>
        /// Expiration time.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Node resource ID.
        /// </summary>
        [JsonProperty("EmrResourceId")]
        public string EmrResourceId{ get; set; }

        /// <summary>
        /// Renewal flag.
        /// </summary>
        [JsonProperty("IsAutoRenew")]
        public long? IsAutoRenew{ get; set; }

        /// <summary>
        /// Device identification.
        /// </summary>
        [JsonProperty("DeviceClass")]
        public string DeviceClass{ get; set; }

        /// <summary>
        /// Supporting resizing.
        /// </summary>
        [JsonProperty("Mutable")]
        public long? Mutable{ get; set; }

        /// <summary>
        /// Multi-cloud disk
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MCMultiDisk")]
        public MultiDiskMC[] MCMultiDisk{ get; set; }

        /// <summary>
        /// Database information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CdbNodeInfo")]
        public CdbInfo CdbNodeInfo{ get; set; }

        /// <summary>
        /// Private network IP address.
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Whether this node can be terminated. 1: Yes, 0: No.
        /// </summary>
        [JsonProperty("Destroyable")]
        public long? Destroyable{ get; set; }

        /// <summary>
        /// Tags bound to node
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Whether it is an automatic scaling node. 0: common node, 1: automatic scaling node.
        /// </summary>
        [JsonProperty("AutoFlag")]
        public long? AutoFlag{ get; set; }

        /// <summary>
        /// Resource type, with the valid values of "host" and "pod".
        /// </summary>
        [JsonProperty("HardwareResourceType")]
        public string HardwareResourceType{ get; set; }

        /// <summary>
        /// Whether it is a floating specification. 1: Yes, 0: No.
        /// </summary>
        [JsonProperty("IsDynamicSpec")]
        public long? IsDynamicSpec{ get; set; }

        /// <summary>
        /// Floating specification value in the JSON string format.
        /// </summary>
        [JsonProperty("DynamicPodSpec")]
        public string DynamicPodSpec{ get; set; }

        /// <summary>
        /// Whether the billing type can be changed. 1: Yes, 0: No.
        /// </summary>
        [JsonProperty("SupportModifyPayMode")]
        public long? SupportModifyPayMode{ get; set; }

        /// <summary>
        /// System disk type. Valid values: 1 (Local Disk), 2 (Cloud Disk), 3 (Local SSD), 4 (Cloud SSD), 5 (Premium Cloud Disk), 6 (Enhanced SSD), 11 (Throughput HDD), 12 (Tremendous SSD), 13 (Balanced SSD), 14 (Big Data Cloud Disk), 15 (High IO Cloud Disk), and 16 (Remote SSD).
        /// </summary>
        [JsonProperty("RootStorageType")]
        public long? RootStorageType{ get; set; }

        /// <summary>
        /// Availability information.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Subnet
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SubnetInfo")]
        public SubnetInfo SubnetInfo{ get; set; }

        /// <summary>
        /// Client.
        /// </summary>
        [JsonProperty("Clients")]
        public string Clients{ get; set; }

        /// <summary>
        /// Current system time.
        /// </summary>
        [JsonProperty("CurrentTime")]
        public string CurrentTime{ get; set; }

        /// <summary>
        /// Indicates whether it is for federation. 1: Yes, 0: No.
        /// </summary>
        [JsonProperty("IsFederation")]
        public long? IsFederation{ get; set; }

        /// <summary>
        /// Device name.
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// Service.
        /// </summary>
        [JsonProperty("ServiceClient")]
        public string ServiceClient{ get; set; }

        /// <summary>
        /// Whether instance protection is enabled. True: enabled, false: disabled.
        /// </summary>
        [JsonProperty("DisableApiTermination")]
        public bool? DisableApiTermination{ get; set; }

        /// <summary>
        /// 0: old billing, 1: new billing.
        /// </summary>
        [JsonProperty("TradeVersion")]
        public long? TradeVersion{ get; set; }

        /// <summary>
        /// Component status. ZooKeeper: STARTED, ResourceManager: STARTED, STARTED: Component is running, STOPPED: Component is halted.
        /// </summary>
        [JsonProperty("ServicesStatus")]
        public string ServicesStatus{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Shared cluster ID.
        /// </summary>
        [JsonProperty("SharedClusterId")]
        public string SharedClusterId{ get; set; }

        /// <summary>
        /// Shared cluster ID description.
        /// </summary>
        [JsonProperty("SharedClusterIdDesc")]
        public string SharedClusterIdDesc{ get; set; }

        /// <summary>
        /// Whether the resource is set for scheduled termination.
        /// </summary>
        [JsonProperty("TimingResource")]
        public bool? TimingResource{ get; set; }

        /// <summary>
        /// Corresponding TKE cluster ID in the case that the resource type (HardwareResourceType) is pod.
        /// </summary>
        [JsonProperty("TkeClusterId")]
        public string TkeClusterId{ get; set; }

        /// <summary>
        /// Name list of services that can be configured when a new disk is mounted.
        /// </summary>
        [JsonProperty("ConfigurableServices")]
        public string[] ConfigurableServices{ get; set; }

        /// <summary>
        /// Node labeling information: currently used only in the Terraform.
        /// </summary>
        [JsonProperty("NodeMark")]
        public string NodeMark{ get; set; }

        /// <summary>
        /// Whether auto-renewal is available for committed use resources.
        /// </summary>
        [JsonProperty("UnderwriteSetAutoRenew")]
        public bool? UnderwriteSetAutoRenew{ get; set; }

        /// <summary>
        /// GPU information.
        /// </summary>
        [JsonProperty("GpuDesc")]
        public string GpuDesc{ get; set; }


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
        }
    }
}

