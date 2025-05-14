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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataDisk : AbstractModel
    {
        
        /// <summary>
        /// Data disk type. For restrictions on the data disk type, see [cloud block storage types](https://intl.cloud.tencent.com/document/product/362/2353?from_cn_redirect=1). Valid values:
        /// <li>LOCAL_BASIC: Local Disk.</li>
        /// <li>LOCAL_SSD: Local SSD.</li>
        /// <li>CLOUD_BASIC: Basic Cloud Disk.</li>
        /// <li>CLOUD_PREMIUM: Premium Disk.</li>
        /// <li>CLOUD_SSD: Cloud SSD.</li>
        /// <li>CLOUD_HSSD: Enhanced SSD.</li>
        /// <li>CLOUD_TSSD: Tremendous SSD.</li>
        /// The default value is consistent with the system disk type (SystemDisk.DiskType).
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Data disk size, in GB. The minimum adjustment step size is 10 GB. The value range varies according to the data disk type. For specific restrictions, see [CVM instance configuration](https://intl.cloud.tencent.com/document/product/213/2177?from_cn_redirect=1). Default value: 0, which means that no data disk is purchased. For more restrictions, see the product documentation.
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// Data disk snapshot ID, such as `snap-l8psqwnt`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// Whether the data disk is terminated along with the instance. Valid values:
        /// <li>TRUE: When the instance is terminated, the data disk is also terminated. This option is only supported for hourly postpaid cloud disks.</li>
        /// <li>FALSE: When the instance is terminated, the data disk is retained.</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }

        /// <summary>
        /// Whether the data disk is encrypted. Valid values:
        /// <li>TRUE: Encrypted.</li>
        /// <li>FALSE: Not encrypted.</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// Cloud disk performance (MB/s). This parameter is used to purchase extra performance for the cloud disk. For details on the feature and limits, see [Enhanced SSD Performance](https://intl.cloud.tencent.com/document/product/362/51896?from_cn_redirect=1#. E5.A2.9E.E5.BC.BA.E5.9E.8B-ssd-.E4.BA.91.E7.A1.AC.E7.9B.98.E9.A2.9D.E5.A4.96 .E6.80.A7.E8.83.BD).
        /// This feature is only available to enhanced SSD (`CLOUD_HSSD`) and tremendous SSD (`CLOUD_TSSD`) disks with a capacity greater than 460 GB.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public ulong? ThroughputPerformance{ get; set; }

        /// <summary>
        /// Burst performance: Whether to enable burst performance. The default value is false.
        /// 
        /// Note: This feature is in beta test and requires a ticket to be submitted for usage.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BurstPerformance")]
        public bool? BurstPerformance{ get; set; }


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
        }
    }
}

