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
        /// AZ name, such as "ap-beijing-1". For the list of regions and AZs, please see [Overview](https://intl.cloud.tencent.com/document/product/582/13225?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Network type. Valid values: `VPC` and `CCN`. Select `VPC` for a Standard or High-Performance file system, and `CCN` for a Standard Turbo or High-Performance Turbo one.
        /// </summary>
        [JsonProperty("NetInterface")]
        public string NetInterface{ get; set; }

        /// <summary>
        /// Permission group ID. pgroupbasic is the default permission group. obtain through the api [DescribeCfsPGroups](https://www.tencentcloud.com/document/product/582/38157?from_cn_redirect=1) to query the permission group list.
        /// </summary>
        [JsonProperty("PGroupId")]
        public string PGroupId{ get; set; }

        /// <summary>
        /// File system protocol type. valid values: NFS, CIFS, and TURBO. if left blank, NFS by default. the TURBO series must select TURBO. NFS and CIFS are not supported.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Storage type of the file system. Valid values: `SD` (Standard), `HP` (High-Performance), `TB` (Standard Turbo), and `TP` (High-Performance Turbo). Default value: `SD`.
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// Private network (VPC) ID. if the network type is VPC, this field must be specified. obtain it by querying the private network interface.
        /// [DescribeVpcs](https://www.tencentcloud.com/document/product/215/15778?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID. this field must be specified if the network type is VPC. obtain through the api for querying subnets.
        /// [DescribeSubnets](https://www.tencentcloud.com/document/product/215/15784?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// IP address (this parameter supports only the VPC network type, and the Turbo series is not supported). If this parameter is left empty, a random IP in the subnet will be assigned.
        /// </summary>
        [JsonProperty("MountIP")]
        public string MountIP{ get; set; }

        /// <summary>
        /// Custom file system name
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// File system tag
        /// </summary>
        [JsonProperty("ResourceTags")]
        public TagInfo[] ResourceTags{ get; set; }

        /// <summary>
        /// A unique string supplied by the client to ensure that the request is idempotent. Its maximum length is 64 ASCII characters. If this parameter is not specified, the idempotency of the request cannot be guaranteed. This string is valid for 2 hours.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Cloud connect network ID. this field must be specified if the network type is CCN. obtain it by querying the CCN list through the api.
        /// [DescribeCcns](https://www.tencentcloud.com/document/product/215/19199?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// CCN IP range used by the CFS (required if the network type is CCN), which cannot conflict with other IP ranges bound in CCN
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// File system capacity, required for the turbo series, in GiB. turbo standard type in GB, starting from 20 TiB (20480 GiB); scaling increment 10 TiB (10240 GiB). turbo performance type starts from 10 TiB (10240 GiB); capacity expansion step 10 TiB (10240 GiB).
        /// </summary>
        [JsonProperty("Capacity")]
        public ulong? Capacity{ get; set; }

        /// <summary>
        /// File system snapshot ID. this parameter can be obtained by querying the snapshot list.
        /// [DescribeCfsSnapshots](https://www.tencentcloud.com/document/product/582/80206?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// Scheduled snapshot policy ID, which can be obtained by querying the snapshot policy information.
        /// [DescribeAutoSnapshotPolicies](https://www.tencentcloud.com/document/product/582/38157?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// Whether default expansion is enabled. only turbo file storage supports this feature.
        /// </summary>
        [JsonProperty("EnableAutoScaleUp")]
        public bool? EnableAutoScaleUp{ get; set; }

        /// <summary>
        /// v1.5: create a standard edition general file system.
        /// v3.1: create an enhanced general file system.
        /// Description: the enhanced universal system requires enabling the allowlist to use. if needed, submit a ticket to contact us.
        /// </summary>
        [JsonProperty("CfsVersion")]
        public string CfsVersion{ get; set; }

        /// <summary>
        /// turbo file system metadata attribute.
        /// basic: creates metadata of the standard type.
        /// Enhanced: creates enhanced metadata.
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }


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
        }
    }
}

