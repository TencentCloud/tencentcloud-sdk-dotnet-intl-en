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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of compute nodes</p>
        /// </summary>
        [JsonProperty("ComputeNodeNum")]
        [System.Obsolete]
        public long? ComputeNodeNum{ get; set; }

        /// <summary>
        /// <p>Region</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Creating an Instance Version</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateVersion")]
        public string CreateVersion{ get; set; }

        /// <summary>
        /// <p>Initialize instance parameter</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InitParams")]
        public InstanceParam[] InitParams{ get; set; }

        /// <summary>
        /// <p>Instance status: creating, created, initializing, running, modifying, isolating, isolated, destroying, destroyed</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Instance id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Number of storage nodes</p>
        /// </summary>
        [JsonProperty("StorageNodeNum")]
        public long? StorageNodeNum{ get; set; }

        /// <summary>
        /// <p>Instance tag information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>Instance name</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>cpu cores of the computing node</p>
        /// </summary>
        [JsonProperty("Cpu")]
        [System.Obsolete]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>Character type vpcid</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Computing node mem, in GB</p>
        /// </summary>
        [JsonProperty("Mem")]
        [System.Obsolete]
        public long? Mem{ get; set; }

        /// <summary>
        /// <p>Subnet IP</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>Character type subnetid</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Subnet port</p>
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// <p>Node disk capacity (unit: GB)</p>
        /// </summary>
        [JsonProperty("Disk")]
        public long? Disk{ get; set; }

        /// <summary>
        /// <p>Instance Creation Time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Region of the instance</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Status description in Chinese of the instance</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>CPU cores of the control node</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MCCpu")]
        [System.Obsolete]
        public long? MCCpu{ get; set; }

        /// <summary>
        /// <p>CPU size of the control node</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MCMem")]
        [System.Obsolete]
        public long? MCMem{ get; set; }

        /// <summary>
        /// <p>CPU cores of the computing node</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComputerNodeCpu")]
        [System.Obsolete]
        public long? ComputerNodeCpu{ get; set; }

        /// <summary>
        /// <p>Compute node memory size</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComputerNodeMem")]
        [System.Obsolete]
        public long? ComputerNodeMem{ get; set; }

        /// <summary>
        /// <p>CPU cores of the storage node</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StorageNodeCpu")]
        public long? StorageNodeCpu{ get; set; }

        /// <summary>
        /// <p>Storage node memory size</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StorageNodeMem")]
        public long? StorageNodeMem{ get; set; }

        /// <summary>
        /// <p>Number of control nodes</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MCNum")]
        [System.Obsolete]
        public long? MCNum{ get; set; }

        /// <summary>
        /// <p>Renewal flag</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>Payment mode, 0 pay-as-you-go; 1 annual/monthly subscription</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>User tag, inner: internal user; external: external user</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccountTag")]
        public string AccountTag{ get; set; }

        /// <summary>
        /// <p>Instance Architecture Type, separate: decoupled architecture; hyper: peer-to-peer architecture</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>Disk Type, CLOUD_HSSD enhanced SSD, CLOUD_TCS local SSD disk</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>&quot;0000-00-00 00:00:00&quot;</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DestroyedAt")]
        public string DestroyedAt{ get; set; }

        /// <summary>
        /// <p>&quot;0000-00-00 00:00:00&quot;</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireAt")]
        public string ExpireAt{ get; set; }

        /// <summary>
        /// <p>&quot;0000-00-00 00:00:00&quot;</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsolatedAt")]
        public string IsolatedAt{ get; set; }

        /// <summary>
        /// <p>&quot;0000-00-00 00:00:00&quot;</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsolatedFrom")]
        public string IsolatedFrom{ get; set; }

        /// <summary>
        /// <p>1</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Replications")]
        public long? Replications{ get; set; }

        /// <summary>
        /// <p>Number of replicas</p>
        /// </summary>
        [JsonProperty("FullReplications")]
        public long? FullReplications{ get; set; }

        /// <summary>
        /// <p>Account information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>Account information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// <p>Account information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>AZ information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// <p>Instance node</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Nodes")]
        public InstanceNode[] Nodes{ get; set; }

        /// <summary>
        /// <p>Whether binlog is on</p>
        /// </summary>
        [JsonProperty("BinlogStatus")]
        public long? BinlogStatus{ get; set; }

        /// <summary>
        /// <p>Number of cdc node cores</p>
        /// </summary>
        [JsonProperty("CdcNodeCpu")]
        [System.Obsolete]
        public long? CdcNodeCpu{ get; set; }

        /// <summary>
        /// <p>cdc node memory size</p>
        /// </summary>
        [JsonProperty("CdcNodeMem")]
        [System.Obsolete]
        public long? CdcNodeMem{ get; set; }

        /// <summary>
        /// <p>Number of cdc nodes</p>
        /// </summary>
        [JsonProperty("CdcNodeNum")]
        [System.Obsolete]
        public long? CdcNodeNum{ get; set; }

        /// <summary>
        /// <p>az mode. 1: Single az, 2: Multi-az non-primary az mode, 3: Multi-az primary az mode</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AZMode")]
        public long? AZMode{ get; set; }

        /// <summary>
        /// <p>Disaster recovery flag. 1: No disaster recovery relationship; 2: Primary instance for disaster recovery; 3: Disaster Recovery Standby Instance</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StandbyFlag")]
        public long? StandbyFlag{ get; set; }

        /// <summary>
        /// <p>Number of connected standby instances (Valid only when StandbyFlag == 2)</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StandbySecondaryNum")]
        public long? StandbySecondaryNum{ get; set; }

        /// <summary>
        /// <p>cpu cores of the columnar node</p>
        /// </summary>
        [JsonProperty("ColumnarNodeCpu")]
        public long? ColumnarNodeCpu{ get; set; }

        /// <summary>
        /// <p>Columnar node memory size</p>
        /// </summary>
        [JsonProperty("ColumnarNodeMem")]
        public long? ColumnarNodeMem{ get; set; }

        /// <summary>
        /// <p>Number of columnar nodes</p>
        /// </summary>
        [JsonProperty("ColumnarNodeNum")]
        public long? ColumnarNodeNum{ get; set; }

        /// <summary>
        /// <p>Columnar node disk capacity (unit: GB)</p>
        /// </summary>
        [JsonProperty("ColumnarNodeDisk")]
        public long? ColumnarNodeDisk{ get; set; }

        /// <summary>
        /// <p>Columnar node disk type</p>
        /// </summary>
        [JsonProperty("ColumnarNodeStorageType")]
        public string ColumnarNodeStorageType{ get; set; }

        /// <summary>
        /// <p>Exclusive flags, 1: Primary instance (dedicated), 2: Primary instance, 3: Disaster recovery instance, 4: Disaster recovery instance (dedicated)</p>
        /// </summary>
        [JsonProperty("InstanceCategory")]
        public long? InstanceCategory{ get; set; }

        /// <summary>
        /// <p>dbdc-xxxxx</p>
        /// </summary>
        [JsonProperty("ExclusiveClusterId")]
        public string ExclusiveClusterId{ get; set; }

        /// <summary>
        /// <p>Compatible mode</p>
        /// </summary>
        [JsonProperty("SQLMode")]
        public string SQLMode{ get; set; }

        /// <summary>
        /// <p>Instance mode</p>
        /// </summary>
        [JsonProperty("InstanceMode")]
        public string InstanceMode{ get; set; }

        /// <summary>
        /// <p>Instance delivery platform</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        [System.Obsolete]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Auto-scaling configuration</p>
        /// </summary>
        [JsonProperty("AutoScaleConfig")]
        public AutoScalingConfig AutoScaleConfig{ get; set; }

        /// <summary>
        /// <p>Analytical engine mode</p><p>Enumeration value:</p><ul><li>libra: LibraDB analytical engine mode</li></ul>
        /// </summary>
        [JsonProperty("AnalysisMode")]
        public string AnalysisMode{ get; set; }

        /// <summary>
        /// <p>Analysis engine relationship information</p>
        /// </summary>
        [JsonProperty("AnalysisRelationInfos")]
        public AnalysisRelationInfo[] AnalysisRelationInfos{ get; set; }

        /// <summary>
        /// <p>Analysis engine instance info</p>
        /// </summary>
        [JsonProperty("AnalysisInstanceInfo")]
        public AnalysisInstanceInfo AnalysisInstanceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComputeNodeNum", this.ComputeNodeNum);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CreateVersion", this.CreateVersion);
            this.SetParamArrayObj(map, prefix + "InitParams.", this.InitParams);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StorageNodeNum", this.StorageNodeNum);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "Disk", this.Disk);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "MCCpu", this.MCCpu);
            this.SetParamSimple(map, prefix + "MCMem", this.MCMem);
            this.SetParamSimple(map, prefix + "ComputerNodeCpu", this.ComputerNodeCpu);
            this.SetParamSimple(map, prefix + "ComputerNodeMem", this.ComputerNodeMem);
            this.SetParamSimple(map, prefix + "StorageNodeCpu", this.StorageNodeCpu);
            this.SetParamSimple(map, prefix + "StorageNodeMem", this.StorageNodeMem);
            this.SetParamSimple(map, prefix + "MCNum", this.MCNum);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "AccountTag", this.AccountTag);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "DestroyedAt", this.DestroyedAt);
            this.SetParamSimple(map, prefix + "ExpireAt", this.ExpireAt);
            this.SetParamSimple(map, prefix + "IsolatedAt", this.IsolatedAt);
            this.SetParamSimple(map, prefix + "IsolatedFrom", this.IsolatedFrom);
            this.SetParamSimple(map, prefix + "Replications", this.Replications);
            this.SetParamSimple(map, prefix + "FullReplications", this.FullReplications);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamArrayObj(map, prefix + "Nodes.", this.Nodes);
            this.SetParamSimple(map, prefix + "BinlogStatus", this.BinlogStatus);
            this.SetParamSimple(map, prefix + "CdcNodeCpu", this.CdcNodeCpu);
            this.SetParamSimple(map, prefix + "CdcNodeMem", this.CdcNodeMem);
            this.SetParamSimple(map, prefix + "CdcNodeNum", this.CdcNodeNum);
            this.SetParamSimple(map, prefix + "AZMode", this.AZMode);
            this.SetParamSimple(map, prefix + "StandbyFlag", this.StandbyFlag);
            this.SetParamSimple(map, prefix + "StandbySecondaryNum", this.StandbySecondaryNum);
            this.SetParamSimple(map, prefix + "ColumnarNodeCpu", this.ColumnarNodeCpu);
            this.SetParamSimple(map, prefix + "ColumnarNodeMem", this.ColumnarNodeMem);
            this.SetParamSimple(map, prefix + "ColumnarNodeNum", this.ColumnarNodeNum);
            this.SetParamSimple(map, prefix + "ColumnarNodeDisk", this.ColumnarNodeDisk);
            this.SetParamSimple(map, prefix + "ColumnarNodeStorageType", this.ColumnarNodeStorageType);
            this.SetParamSimple(map, prefix + "InstanceCategory", this.InstanceCategory);
            this.SetParamSimple(map, prefix + "ExclusiveClusterId", this.ExclusiveClusterId);
            this.SetParamSimple(map, prefix + "SQLMode", this.SQLMode);
            this.SetParamSimple(map, prefix + "InstanceMode", this.InstanceMode);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamObj(map, prefix + "AutoScaleConfig.", this.AutoScaleConfig);
            this.SetParamSimple(map, prefix + "AnalysisMode", this.AnalysisMode);
            this.SetParamArrayObj(map, prefix + "AnalysisRelationInfos.", this.AnalysisRelationInfos);
            this.SetParamObj(map, prefix + "AnalysisInstanceInfo.", this.AnalysisInstanceInfo);
        }
    }
}

