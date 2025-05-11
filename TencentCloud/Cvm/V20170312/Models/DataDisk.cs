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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataDisk : AbstractModel
    {
        
        /// <summary>
        /// Data disk size, unit: GiB. the minimum adjustment step size is 10 GiB. the value ranges of different data disk types vary. for specific limitations, see the storage overview (https://intl.cloud.tencent.com/document/product/213/4952?from_cn_redirect=1). the default value is 0, which means no data disk purchase. for more restrictions, see the product document.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Data disk type. For the detailed restrictions on the data disk type, refer to [Storage Overview](https://cloud.tencent.com/document/product/213/4952). Valid values: <br /><li>LOCAL_BASIC: Local Disk <br /><li>LOCAL_SSD: Local SSD <br /><li>LOCAL_NVME: Local NVMe Disk, which is strongly related with InstanceType and can not be specified <br /><li>LOCAL_PRO: Local HDD, which is strongly related with InstanceType and can not be specified <br /><li>CLOUD_BASIC: Basic Cloud Disk <br /><li>CLOUD_PREMIUM: Premium Disk <br /><li>CLOUD_SSD: Cloud SSD <br /><li>CLOUD_HSSD: Enhanced SSD <br /><li>CLOUD_TSSD: Tremendous SSD <br /><li>CLOUD_BSSD: Balanced SSD <br /><br />Default value: LOCAL_BASIC. <br /><br />This parameter is invalid for the `ResizeInstanceDisk` API.</li></li></li> </li> </li></li></li></li></li></li>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Specifies the data disk ID.
        /// This parameter currently only serves as a response parameter for query apis such as `DescribeInstances`, and cannot be used as an input parameter for write apis such as `RunInstances`.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// Whether the data disk is terminated with the instance. value range: <li>true: when the instance is terminated, the data disk is also terminated. only hourly postpaid cloud disks are supported. <li>false: when the instance is terminated, the data disk is retained. <br>default value: true <br>currently, this parameter is only used for the API `RunInstances`.
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }

        /// <summary>
        /// Data disk snapshot ID. the size of the selected data disk snapshot must be less than the data disk size.
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// Specifies whether the data disk is encrypted. value range: <li>true: encrypted</li> <li>false: unencrypted</li><br/> default value: false<br/> this parameter is currently only used for the `RunInstances` api.
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// Custom CMK's corresponding ID, with a value of UUID or something similar to kms - abcd1234. used for encrypting cloud disks.
        /// 
        /// This parameter is currently only used for the `RunInstances` api.
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// Specifies the cloud disk performance (unit: MiB/s). using this parameter allows you to purchase additional performance for the cloud disk.
        /// Currently only supports ultra-fast CLOUD disk (CLOUD_TSSD) and enhanced SSD CLOUD disk (CLOUD_HSSD).
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public long? ThroughputPerformance{ get; set; }

        /// <summary>
        /// Specifies the exclusive cluster ID it belongs to.
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// Burst performance.
        /// 
        /// <B>Note: this feature is in beta test.</b>.
        /// </summary>
        [JsonProperty("BurstPerformance")]
        public bool? BurstPerformance{ get; set; }

        /// <summary>
        /// Disk name, with a length not exceeding 128 characters.
        /// </summary>
        [JsonProperty("DiskName")]
        public string DiskName{ get; set; }


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
            this.SetParamSimple(map, prefix + "DiskName", this.DiskName);
        }
    }
}

