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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataDisk : AbstractModel
    {
        
        /// <summary>
        /// <p>Data disk type. For detailed restrictions on data disk types, see <a href="https://www.tencentcloud.com/document/product/362/2353?from_cn_redirect=1">Cloud Disk Types</a>. Value range:</p><li>LOCAL_BASIC: local hard disk</li><li>LOCAL_SSD: local SSD</li><li>CLOUD_BASIC: basic cloud disk</li><li>CLOUD_PREMIUM: high-performance cloud block storage</li><li>CLOUD_SSD: SSD cloud disk</li><li>CLOUD_HSSD: enhanced SSD cloud disk</li><li>CLOUD_TSSD: ultra-fast SSD CBS</li><li>CLOUD_BSSD: universal SSD cloud disk</li>The default value is consistent with the system disk type (SystemDisk.DiskType).
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>Data disk size, in GB. The value range varies according to the data disk type. For specific restrictions, see <a href="https://www.tencentcloud.com/document/product/213/2177?from_cn_redirect=1">CVM instance configuration</a>. Default value: 0, which means that no data disk is purchased. For more restrictions, see the <a href="https://www.tencentcloud.com/document/product/362/5145?from_cn_redirect=1">product documentation</a>.</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// <p>Data disk snapshot ID, obtain this parameter through the <a href="https://www.tencentcloud.com/document/product/362/15647?from_cn_redirect=1">DescribeSnapshots</a> API.</p>
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// <p>Whether the data disk is destroyed with the instance. Value ranges from:</p><li>TRUE: When the instance is terminated, destroy the data disk. Only hourly postpaid cloud disks are supported.</li><li>FALSE: When the instance is terminated, retain the data disk.</li>
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }

        /// <summary>
        /// <p>Whether to encrypt the data disk. TRUE means encrypted, FALSE means not encrypted; the specific disk type, region, and KMS rules are validated by CVM.</p>
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// <p>Cloud disk performance, unit: MB/s. Using this parameter can purchase additional performance for cloud disks. For feature introduction and type limitations, see: <a href="https://www.tencentcloud.com/document/product/362/51896?from_cn_redirect=1#.E5.A2.9E.E5.BC.BA.E5.9E.8B-ssd-.E4.BA.91.E7.A1.AC.E7.9B.98.E9.A2.9D.E5.A4.96.E6.80.A7.E8.83.BD">enhanced SSD cloud disk additional performance note</a>.<br>Currently only supports Extreme CBS (CLOUD_TSSD) and enhanced SSD cloud disks (CLOUD_HSSD) with capacity &gt; 460 GB.</p>
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public ulong? ThroughputPerformance{ get; set; }

        /// <summary>
        /// <p>Burst performance. Whether to enable burst performance. The default value is false. Currently, this parameter only supports Extreme CBS (CLOUD_TSSD) and enhanced SSD CLOUD disk (CLOUD_HSSD) with capacity greater than 460 GB.<br>Note: In beta test. Requires ticket submission before usage.</p>
        /// </summary>
        [JsonProperty("BurstPerformance")]
        public bool? BurstPerformance{ get; set; }

        /// <summary>
        /// <p>KMS Key ID used for data disk encryption. The key validity, permission, as well as adaptability to disk type and region are validated by CVM.</p>
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "DeleteWithInstance", this.DeleteWithInstance);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "ThroughputPerformance", this.ThroughputPerformance);
            this.SetParamSimple(map, prefix + "BurstPerformance", this.BurstPerformance);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
        }
    }
}

