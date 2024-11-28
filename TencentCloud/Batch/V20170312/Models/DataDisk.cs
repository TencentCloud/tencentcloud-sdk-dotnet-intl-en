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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataDisk : AbstractModel
    {
        
        /// <summary>
        /// Data disk size (in GB). The minimum adjustment increment is 10 GB. The value range varies by data disk type. For more information on limits, see [Storage Overview](https://intl.cloud.tencent.com/document/product/213/4952?from_cn_redirect=1). The default value is 0, indicating that no data disk is purchased. For more information, see the product documentation.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Data disk type. For restrictions on data disk types, refer to [Storage Overview](https://intl.cloud.tencent.com/document/product/213/4952?from_cn_redirect=1). Valid values:<br/>
        /// <li>
        ///   LOCAL_BASIC: local disk.<br/>
        ///   <li>
        ///     LOCAL_SSD: local SSD.<br/>
        ///     <li>
        ///       LOCAL_NVME: local NVMe disk, which is closely related to InstanceType, and cannot be specified.<br/>
        ///       <li>
        ///         LOCAL_PRO: local HDD, which is closely related to InstanceType, and cannot be specified.<br/>
        ///         <li>
        ///           CLOUD_BASIC: basic cloud disk.<br/>
        ///           <li>
        ///             CLOUD_PREMIUM: premium cloud disk.<br/>
        ///             <li>
        ///               CLOUD_SSD: cloud SSD.<br />
        ///               <li>
        ///                 CLOUD_HSSD: enhanced SSD.<br/>
        ///                 <li>
        ///                   CLOUD_TSSD: tremendous SSD.<br/>
        ///                   <li>
        ///                     CLOUD_BSSD: balanced SSD.<br/><br/>Default value: LOCAL_BASIC.<br/><br/>This parameter is invalid for the `ResizeInstanceDisk` API.
        ///                   </li>
        ///                 </li>
        ///               </li>
        ///             </li>
        ///           </li>
        ///         </li>
        ///       </li>
        ///     </li>
        ///   </li>
        /// </li>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Data disk ID. Note that it’s not available for `LOCAL_BASIC` and `LOCAL_SSD` disks.
        /// It is only used as a response parameter for APIs such as `DescribeInstances`, and cannot be used as a request parameter for APIs such as `RunInstances`.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// Whether a data disk is terminated when the associated CVM instance is terminated. Valid values:
        /// <li>TRUE: The data disk is terminated when the associated CVM instance is terminated. This only supports pay-as-you-go cloud disks that are billed by hour.</li>
        /// <li>
        ///   FALSE: The data disk is retained when the associated CVM instance is terminated.<br/>
        ///   Default value: TRUE.<br/>
        ///   This parameter is currently used only in the `RunInstances` API.
        /// </li>
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }

        /// <summary>
        /// Data disk snapshot ID. The size of the selected data disk snapshot must be smaller than that of the data disk.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// Whether a data disk is encrypted. Valid values:
        /// <li>true: encrypted.</li>
        /// <li>
        ///   false: not encrypted.<br/>
        ///   Default value: false.<br/>
        ///   This parameter is currently used only in the `RunInstances` API.
        /// </li>
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// ID of the custom CMK in the format of UUID or “kms-abcd1234”. This parameter is used to encrypt cloud disks.
        /// 
        /// Currently, this parameter is only used in the `RunInstances` API.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// Cloud disk performance, in MB/s
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public long? ThroughputPerformance{ get; set; }

        /// <summary>
        /// ID of the dedicated cluster to which the instance belongs.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// Burst performance.
        /// 
        ///  <b>Note: This field is in beta test.</b>
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("BurstPerformance")]
        public bool? BurstPerformance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "DeleteWithInstance", this.DeleteWithInstance);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "ThroughputPerformance", this.ThroughputPerformance);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "BurstPerformance", this.BurstPerformance);
        }
    }
}

