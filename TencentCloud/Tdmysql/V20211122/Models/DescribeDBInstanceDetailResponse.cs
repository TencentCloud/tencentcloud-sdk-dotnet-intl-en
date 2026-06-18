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

    public class DescribeDBInstanceDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance name</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Region</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Character type vpcid</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Character type subnetid</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Create an instance version</p>
        /// </summary>
        [JsonProperty("CreateVersion")]
        public string CreateVersion{ get; set; }

        /// <summary>
        /// <p>Subnet IP</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>Subnet port</p>
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// <p>Instance status</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Node disk capacity (unit: GB)</p>
        /// </summary>
        [JsonProperty("Disk")]
        public long? Disk{ get; set; }

        /// <summary>
        /// <p>Number of storage nodes</p>
        /// </summary>
        [JsonProperty("StorageNodeNum")]
        public long? StorageNodeNum{ get; set; }

        /// <summary>
        /// <p>Initialize instance parameters</p>
        /// </summary>
        [JsonProperty("InitParams")]
        public InstanceParam[] InitParams{ get; set; }

        /// <summary>
        /// <p>Instance tag information.</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Update time.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Number of storage node replicas</p>
        /// </summary>
        [JsonProperty("Replications")]
        public long? Replications{ get; set; }

        /// <summary>
        /// <p>Number of replicas</p>
        /// </summary>
        [JsonProperty("FullReplications")]
        public long? FullReplications{ get; set; }

        /// <summary>
        /// <p>Character set</p>
        /// </summary>
        [JsonProperty("CharSet")]
        public string CharSet{ get; set; }

        /// <summary>
        /// <p>Node information</p>
        /// </summary>
        [JsonProperty("Node")]
        public NodeInfo[] Node{ get; set; }

        /// <summary>
        /// <p>Region of the instance</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Instance specification</p>
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Status description in Chinese of the instance</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>CPU cores of the storage node</p>
        /// </summary>
        [JsonProperty("StorageNodeCpu")]
        public long? StorageNodeCpu{ get; set; }

        /// <summary>
        /// <p>Storage node memory size</p>
        /// </summary>
        [JsonProperty("StorageNodeMem")]
        public long? StorageNodeMem{ get; set; }

        /// <summary>
        /// <p>Renewal flag</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>Payment mode, 0 pay-as-you-go, 1 prepaid</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>Expiration time</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireAt")]
        public string ExpireAt{ get; set; }

        /// <summary>
        /// <p>Isolation time</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsolatedAt")]
        public string IsolatedAt{ get; set; }

        /// <summary>
        /// <p>Instance Architecture Type, separate: decoupled architecture; hybrid: peer-to-peer architecture</p>
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
        /// <p>List of instance node availability zones. Zones[0] refers to the primary AZ</p>
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// <p>Disk usage of the largest node</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskUsage")]
        public long? DiskUsage{ get; set; }

        /// <summary>
        /// <p>Whether binlog is enabled</p>
        /// </summary>
        [JsonProperty("BinlogStatus")]
        public long? BinlogStatus{ get; set; }

        /// <summary>
        /// <p>az mode. 1: Single az 2: Multi-az non-primary az mode 3: Multi-az primary az mode</p>
        /// </summary>
        [JsonProperty("AZMode")]
        public long? AZMode{ get; set; }

        /// <summary>
        /// <p>Disaster recovery flag. 1: No disaster recovery relationship; 2: Primary instance for disaster recovery; 3: Disaster Recovery Standby Instance</p>
        /// </summary>
        [JsonProperty("StandbyFlag")]
        public long? StandbyFlag{ get; set; }

        /// <summary>
        /// <p>cdc node type</p>
        /// </summary>
        [JsonProperty("BinlogType")]
        public string BinlogType{ get; set; }

        /// <summary>
        /// <p>1 means supported, 0 means unsupported</p>
        /// </summary>
        [JsonProperty("TimingModifyInstanceFlag")]
        public long? TimingModifyInstanceFlag{ get; set; }

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
        /// <p>Columnar node disk size</p>
        /// </summary>
        [JsonProperty("ColumnarNodeDisk")]
        public long? ColumnarNodeDisk{ get; set; }

        /// <summary>
        /// <p>Columnar node disk type</p>
        /// </summary>
        [JsonProperty("ColumnarNodeStorageType")]
        public string ColumnarNodeStorageType{ get; set; }

        /// <summary>
        /// <p>Columnar node specification</p>
        /// </summary>
        [JsonProperty("ColumnarNodeSpecCode")]
        public string ColumnarNodeSpecCode{ get; set; }

        /// <summary>
        /// <p>Columnar storage vip</p>
        /// </summary>
        [JsonProperty("ColumnarVip")]
        public string ColumnarVip{ get; set; }

        /// <summary>
        /// <p>Columnar vport</p>
        /// </summary>
        [JsonProperty("ColumnarVport")]
        public long? ColumnarVport{ get; set; }

        /// <summary>
        /// <p>Whether the instance supports columnar storage</p>
        /// </summary>
        [JsonProperty("IsSupportColumnar")]
        public bool? IsSupportColumnar{ get; set; }

        /// <summary>
        /// <p>Instance type</p>
        /// </summary>
        [JsonProperty("InstanceCategory")]
        public long? InstanceCategory{ get; set; }

        /// <summary>
        /// <p>Compatible mode</p>
        /// </summary>
        [JsonProperty("SQLMode")]
        public string SQLMode{ get; set; }

        /// <summary>
        /// <p>Whether modification of the number of replicas is supported</p>
        /// </summary>
        [JsonProperty("IsSwitchFullReplicationsEnable")]
        public bool? IsSwitchFullReplicationsEnable{ get; set; }

        /// <summary>
        /// <p>Instance type</p>
        /// </summary>
        [JsonProperty("InstanceMode")]
        public string InstanceMode{ get; set; }

        /// <summary>
        /// <p>dumper vip</p>
        /// </summary>
        [JsonProperty("DumperVip")]
        public string DumperVip{ get; set; }

        /// <summary>
        /// <p>dumper vport</p>
        /// </summary>
        [JsonProperty("DumperVport")]
        public long? DumperVport{ get; set; }

        /// <summary>
        /// <p>ccu adjustment range of the svls instance</p>
        /// </summary>
        [JsonProperty("AutoScaleConfig")]
        public AutoScalingConfig AutoScaleConfig{ get; set; }

        /// <summary>
        /// <p>Parameter template id</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>Parameter template name</p>
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// <p>Instance analysis engine mode</p><p>Enumeration value:</p><ul><li>libra: LibraDB analysis engine instance</li></ul>
        /// </summary>
        [JsonProperty("AnalysisMode")]
        public string AnalysisMode{ get; set; }

        /// <summary>
        /// <p>Analysis engine instance relationship</p>
        /// </summary>
        [JsonProperty("AnalysisRelationInfos")]
        public AnalysisRelationInfo[] AnalysisRelationInfos{ get; set; }

        /// <summary>
        /// <p>Analysis engine instance info</p><p>Cpu, Memory, and Disk reuse top-level fields</p>
        /// </summary>
        [JsonProperty("AnalysisInstanceInfo")]
        public AnalysisInstanceInfo AnalysisInstanceInfo{ get; set; }

        /// <summary>
        /// <p>Maintenance window configuration</p>
        /// </summary>
        [JsonProperty("MaintenanceWindow")]
        public MaintenanceWindowInfo MaintenanceWindow{ get; set; }

        /// <summary>
        /// <p>Whether transparent data encryption is enabled. 0: not enabled; 1: enabled</p>
        /// </summary>
        [JsonProperty("EncryptionEnable")]
        public long? EncryptionEnable{ get; set; }

        /// <summary>
        /// <p>Real-use kms region for subsequent call to kms service</p>
        /// </summary>
        [JsonProperty("EncryptionKmsRegion")]
        public string EncryptionKmsRegion{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CreateVersion", this.CreateVersion);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Disk", this.Disk);
            this.SetParamSimple(map, prefix + "StorageNodeNum", this.StorageNodeNum);
            this.SetParamArrayObj(map, prefix + "InitParams.", this.InitParams);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Replications", this.Replications);
            this.SetParamSimple(map, prefix + "FullReplications", this.FullReplications);
            this.SetParamSimple(map, prefix + "CharSet", this.CharSet);
            this.SetParamArrayObj(map, prefix + "Node.", this.Node);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "StorageNodeCpu", this.StorageNodeCpu);
            this.SetParamSimple(map, prefix + "StorageNodeMem", this.StorageNodeMem);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ExpireAt", this.ExpireAt);
            this.SetParamSimple(map, prefix + "IsolatedAt", this.IsolatedAt);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "BinlogStatus", this.BinlogStatus);
            this.SetParamSimple(map, prefix + "AZMode", this.AZMode);
            this.SetParamSimple(map, prefix + "StandbyFlag", this.StandbyFlag);
            this.SetParamSimple(map, prefix + "BinlogType", this.BinlogType);
            this.SetParamSimple(map, prefix + "TimingModifyInstanceFlag", this.TimingModifyInstanceFlag);
            this.SetParamSimple(map, prefix + "ColumnarNodeCpu", this.ColumnarNodeCpu);
            this.SetParamSimple(map, prefix + "ColumnarNodeMem", this.ColumnarNodeMem);
            this.SetParamSimple(map, prefix + "ColumnarNodeNum", this.ColumnarNodeNum);
            this.SetParamSimple(map, prefix + "ColumnarNodeDisk", this.ColumnarNodeDisk);
            this.SetParamSimple(map, prefix + "ColumnarNodeStorageType", this.ColumnarNodeStorageType);
            this.SetParamSimple(map, prefix + "ColumnarNodeSpecCode", this.ColumnarNodeSpecCode);
            this.SetParamSimple(map, prefix + "ColumnarVip", this.ColumnarVip);
            this.SetParamSimple(map, prefix + "ColumnarVport", this.ColumnarVport);
            this.SetParamSimple(map, prefix + "IsSupportColumnar", this.IsSupportColumnar);
            this.SetParamSimple(map, prefix + "InstanceCategory", this.InstanceCategory);
            this.SetParamSimple(map, prefix + "SQLMode", this.SQLMode);
            this.SetParamSimple(map, prefix + "IsSwitchFullReplicationsEnable", this.IsSwitchFullReplicationsEnable);
            this.SetParamSimple(map, prefix + "InstanceMode", this.InstanceMode);
            this.SetParamSimple(map, prefix + "DumperVip", this.DumperVip);
            this.SetParamSimple(map, prefix + "DumperVport", this.DumperVport);
            this.SetParamObj(map, prefix + "AutoScaleConfig.", this.AutoScaleConfig);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "AnalysisMode", this.AnalysisMode);
            this.SetParamArrayObj(map, prefix + "AnalysisRelationInfos.", this.AnalysisRelationInfos);
            this.SetParamObj(map, prefix + "AnalysisInstanceInfo.", this.AnalysisInstanceInfo);
            this.SetParamObj(map, prefix + "MaintenanceWindow.", this.MaintenanceWindow);
            this.SetParamSimple(map, prefix + "EncryptionEnable", this.EncryptionEnable);
            this.SetParamSimple(map, prefix + "EncryptionKmsRegion", this.EncryptionKmsRegion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

