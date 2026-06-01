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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceUpgradeTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID, which can be obtained through the <a href="https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1">DescribeDBInstances</a> API.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>The number of CPU cores of the target instance. To ensure the input value is valid, please use <a href="https://www.tencentcloud.com/document/product/236/80281?from_cn_redirect=1">DescribeCdbZoneConfig</a> to get the saleable CPU range of the instance.</p>
        /// </summary>
        [JsonProperty("DstCpu")]
        public float? DstCpu{ get; set; }

        /// <summary>
        /// <p>Target instance memory size, measurement unit: MB. To ensure the input value is valid, please use <a href="https://www.tencentcloud.com/document/product/236/80281?from_cn_redirect=1">DescribeCdbZoneConfig</a> to get the saleable memory size range of the instance.</p>
        /// </summary>
        [JsonProperty("DstMemory")]
        public ulong? DstMemory{ get; set; }

        /// <summary>
        /// <p>Target instance disk size, unit: GB. To ensure the input value is valid, please use <a href="https://www.tencentcloud.com/document/product/236/80281?from_cn_redirect=1">DescribeCdbZoneConfig</a> to get the saleable disk size range of the instance.</p>
        /// </summary>
        [JsonProperty("DstDisk")]
        public ulong? DstDisk{ get; set; }

        /// <summary>
        /// <p>Target instance database version. Available values: 5.6, 5.7, 8.0.</p>
        /// </summary>
        [JsonProperty("DstVersion")]
        public string DstVersion{ get; set; }

        /// <summary>
        /// <p>Deployment model of the target instance. Defaults to 0. Supported values include: 0 - means single availability zone, 1 - means multi-availability zone.</p>
        /// </summary>
        [JsonProperty("DstDeployMode")]
        public long? DstDeployMode{ get; set; }

        /// <summary>
        /// <p>Replication type of the target instance. Supported values include: 0 - means async replication, 1 - means semi-sync replication, 2 - means strong sync replication.</p>
        /// </summary>
        [JsonProperty("DstProtectMode")]
        public long? DstProtectMode{ get; set; }

        /// <summary>
        /// <p>AZ ID of the standby instance 1 of the target instance. You can use the <a href="https://www.tencentcloud.com/document/product/236/80281?from_cn_redirect=1">DescribeCdbZoneConfig</a> API to obtain the availability zone ID.</p>
        /// </summary>
        [JsonProperty("DstSlaveZone")]
        public long? DstSlaveZone{ get; set; }

        /// <summary>
        /// <p>AZ ID of the standby instance 2. You can use the <a href="https://www.tencentcloud.com/document/product/236/80281?from_cn_redirect=1">DescribeCdbZoneConfig</a> API to obtain the AZ ID.</p>
        /// </summary>
        [JsonProperty("DstBackupZone")]
        public long? DstBackupZone{ get; set; }

        /// <summary>
        /// <p>Target instance type. Supported values include: "CUSTOM" - general-purpose instance, "EXCLUSIVE" - dedicated instance, "ONTKE" - ONTKE single-node instance, "CLOUD_NATIVE_CLUSTER" - standard type for CLOUD disk, "CLOUD_NATIVE_CLUSTER_EXCLUSIVE" - enhanced type for CLOUD disk.</p>
        /// </summary>
        [JsonProperty("DstCdbType")]
        public string DstCdbType{ get; set; }

        /// <summary>
        /// <p>Primary availability zone ID of the target instance. You can use the <a href="https://www.tencentcloud.com/document/product/236/80281?from_cn_redirect=1">DescribeCdbZoneConfig</a> API to obtain the AZ ID.</p>
        /// </summary>
        [JsonProperty("DstZoneId")]
        public long? DstZoneId{ get; set; }

        /// <summary>
        /// <p>Node distribution of CDB instances in the dedicated cluster.</p>
        /// </summary>
        [JsonProperty("NodeDistribution")]
        public NodeDistribution NodeDistribution{ get; set; }

        /// <summary>
        /// <p>Topology configuration for cloud disk edition nodes. Nodeld information can be obtained through the <a href="https://www.tencentcloud.com/document/api/236/105116?from_cn_redirect=1">DescribeClusterInfo</a> API.</p>
        /// </summary>
        [JsonProperty("ClusterTopology")]
        public ClusterTopology ClusterTopology{ get; set; }

        /// <summary>
        /// <p>AZ ID of the standby instance 3 in the target instance. Use the <a href="https://www.tencentcloud.com/document/product/236/80281?from_cn_redirect=1">DescribeCdbZoneConfig</a> API to obtain the availability zone ID.</p>
        /// </summary>
        [JsonProperty("DstFourthZone")]
        public long? DstFourthZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DstCpu", this.DstCpu);
            this.SetParamSimple(map, prefix + "DstMemory", this.DstMemory);
            this.SetParamSimple(map, prefix + "DstDisk", this.DstDisk);
            this.SetParamSimple(map, prefix + "DstVersion", this.DstVersion);
            this.SetParamSimple(map, prefix + "DstDeployMode", this.DstDeployMode);
            this.SetParamSimple(map, prefix + "DstProtectMode", this.DstProtectMode);
            this.SetParamSimple(map, prefix + "DstSlaveZone", this.DstSlaveZone);
            this.SetParamSimple(map, prefix + "DstBackupZone", this.DstBackupZone);
            this.SetParamSimple(map, prefix + "DstCdbType", this.DstCdbType);
            this.SetParamSimple(map, prefix + "DstZoneId", this.DstZoneId);
            this.SetParamObj(map, prefix + "NodeDistribution.", this.NodeDistribution);
            this.SetParamObj(map, prefix + "ClusterTopology.", this.ClusterTopology);
            this.SetParamSimple(map, prefix + "DstFourthZone", this.DstFourthZone);
        }
    }
}

