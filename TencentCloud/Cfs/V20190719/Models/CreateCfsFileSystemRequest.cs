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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCfsFileSystemRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>AZ name</p><p>For valid values, see <a href="https://www.tencentcloud.com/document/product/213/15707??from_cn_redirect=1">Querying the List of AZs</a></p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Network type</p><p>Valid values:</p><ul><li><p>VPC: Virtual Private Cloud</p></li><li><p>CCN: Cloud Connect Network</p></li><li><p>For General-purpose Standard/Performance (including enhanced) and Throughput types, select VPC.</p></li><li><p>For Turbo Standard/Performance types, VPC or CCN can be selected.</p></li><li><p>When Scenario=AgentSandbox, this parameter is not required for creating AgentCFS and will be ignored if passed in.</p></li></ul>
        /// </summary>
        [JsonProperty("NetInterface")]
        public string NetInterface{ get; set; }

        /// <summary>
        /// <p>Permission group ID. A permission group defines a set of allowlisted visitors and operation permissions.</p><p>For valid values, see <a href="https://www.tencentcloud.com/document/api/582/38157?from_cn_redirect=1">DescribeCfsPGroups</a></p><ul><li>pgroupbasic is the default permission group, which allows access and read/write permissions for all IP addresses. </li><li>Note: When Scenario=AgentSandbox, that is, when creating AgentCFS, pgroupbasic (the default permission group) must be passed in. Passing in other values will cause an error.</li></ul>
        /// </summary>
        [JsonProperty("PGroupId")]
        public string PGroupId{ get; set; }

        /// <summary>
        /// <p>File system protocol type</p><p>Valid values:</p><ul><li>NFS: Instances of General-purpose Standard (including enhanced) and General-purpose Performance (including enhanced) types can be created with this protocol.</li><li>CIFS: The SMB protocol. Only General-purpose Standard and Throughput types in certain AZs support this protocol.</li><li>TURBO: Instances of Turbo Standard/Turbo Performance/AgentCFS types can be created with this protocol.</li></ul><p>Default value: NFS</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>File system storage type. SD indicates General-purpose Standard storage, HP indicates General-purpose Performance storage, TB indicates Turbo Standard, and TP indicates Turbo Performance.</p><p>Valid values:</p><ul><li>SD: General-purpose Standard (including enhanced). For General-purpose Standard, version = v1.5; for General-purpose Standard (enhanced), version = v3.1.</li><li>HP: General-purpose Performance (including enhanced). For General-purpose Performance, version = v1.5; for General-purpose Performance (enhanced), version = v3.1.</li><li>TB: Turbo Standard</li><li>TP: Turbo Performance</li><li>THP: Throughput</li></ul><p>Default value: SD</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>VPC ID. This field is required if VPC is selected as the network type.</p><p>For valid values, see <a href="https://www.tencentcloud.com/document/product/215/15778?from_cn_redirect=1">Querying the List of VPCs</a></p><p>When Scenario=AgentSandbox, that is, when creating AgentCFS, this parameter is not required and will be ignored if passed in.</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID. This field is required if VPC is selected as the network type.</p><p>For valid values, see <a href="https://www.tencentcloud.com/document/product/215/15784?from_cn_redirect=1">Querying the List of Subnets</a></p><p>When Scenario=AgentSandbox, that is, when creating AgentCFS, this parameter is not required and will be ignored if passed in.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Specifies the IP address. Only VPC networks support this. If this parameter is not specified, an IP address will be randomly assigned from the subnet. Turbo series currently does not support specifying an IP address.</p>
        /// </summary>
        [JsonProperty("MountIP")]
        public string MountIP{ get; set; }

        /// <summary>
        /// <p>User-defined file system name</p>
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// <p>Indicates whether the file system is encrypted. If this parameter is left empty, the file system is not encrypted by default.</p>
        /// </summary>
        [JsonProperty("Encrypted")]
        public bool? Encrypted{ get; set; }

        /// <summary>
        /// <p>File system tag</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public TagInfo[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>String used to ensure the idempotency of the request. This string is generated by the customer and must be unique across different requests, with a maximum length of 64 ASCII characters. If this parameter is not specified, the idempotency of the request cannot be guaranteed. The string used to ensure idempotency expires after 2 hours.</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>CCN ID. This field is required if CCN is selected as the network type.</p><p>For valid values, see <a href="https://www.tencentcloud.com/document/product/215/19199?from_cn_redirect=1">Querying the List of CCNs</a></p><p>When Scenario=AgentSandbox, that is, when creating AgentCFS, this parameter is not required and will be ignored if passed in.</p>
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// <p>CIDR block used by CFS in the CCN. This field is required if CCN is selected as the network type, and it cannot conflict with CIDR blocks already bound in the CCN.</p><p>When Scenario=AgentSandbox, that is, when creating AgentCFS, this parameter is not required and will be ignored if passed in.</p>
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// <p>File system capacity. This parameter is required for Turbo series.</p><p>Unit: GiB</p><p>Turbo Standard starts at 20 TiB, that is, 20,480 GiB, with a scale-out step of 10 TiB, that is, 10,240 GiB. Turbo Performance starts at 10 TiB, that is, 10,240 GiB, with a scale-out step of 10 TiB, that is, 10,240 GiB.</p>
        /// </summary>
        [JsonProperty("Capacity")]
        public ulong? Capacity{ get; set; }

        /// <summary>
        /// <p>File system snapshot ID</p><p>For valid values, see <a href="https://www.tencentcloud.com/document/api/582/80206?from_cn_redirect=1">DescribeCfsSnapshots</a></p>
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// <p>Scheduled snapshot policy ID</p><p>For valid values, see <a href="https://www.tencentcloud.com/document/api/582/80208?from_cn_redirect=1">DescribeAutoSnapshotPolicies</a></p>
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// <p>Indicates whether to enable the automatic scale-out policy. Only turbo file storage supports this feature.</p>
        /// </summary>
        [JsonProperty("EnableAutoScaleUp")]
        public bool? EnableAutoScaleUp{ get; set; }

        /// <summary>
        /// <p>File system version.</p><p>Valid values:</p><ul><li>v1.5: Creates a General Purpose Standard or General Purpose Performance file system.</li><li>v3.1: Creates a General Purpose Standard (Enhanced) or General Purpose Performance (Enhanced) file system. This parameter is required if you want to create an enhanced file system.</li><li>v4.0: Creates a Turbo Standard, Turbo Performance, or Throughput file system. This parameter is optional.</li></ul><p>To create a General Purpose Standard (Enhanced) or General Purpose Performance (Enhanced) file system, the root account must be added to the allowlist. Contact us if needed.</p>
        /// </summary>
        [JsonProperty("CfsVersion")]
        public string CfsVersion{ get; set; }

        /// <summary>
        /// <p>Metadata type of the Turbo file system.</p><p>Valid values:</p><ul><li>basic: Creates standard metadata.</li><li>enhanced: Creates enhanced metadata.</li></ul><p>For details, see <a href="https://www.tencentcloud.com/document/product/582/116836?from_cn_redirect=1">Turbo File System Metadata Types</a></p>
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// <p>Business scenario.</p><p>Valid values:</p><ul><li>AgentSandbox: Required when creating AgentCFS.</li></ul>
        /// </summary>
        [JsonProperty("Scenario")]
        public string Scenario{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NetInterface", this.NetInterface);
            this.SetParamSimple(map, prefix + "PGroupId", this.PGroupId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "MountIP", this.MountIP);
            this.SetParamSimple(map, prefix + "FsName", this.FsName);
            this.SetParamSimple(map, prefix + "Encrypted", this.Encrypted);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamSimple(map, prefix + "EnableAutoScaleUp", this.EnableAutoScaleUp);
            this.SetParamSimple(map, prefix + "CfsVersion", this.CfsVersion);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "Scenario", this.Scenario);
        }
    }
}

