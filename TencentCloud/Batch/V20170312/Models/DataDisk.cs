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
        /// Data disk type. For more information about limits on different data disk types, see [Storage Overview](https://intl.cloud.tencent.com/document/product/213/4952?from_cn_redirect=1). Valid values: <br><li>LOCAL_BASIC: local disk<br><li>LOCAL_SSD: local SSD disk<br><li>CLOUD_BASIC: HDD cloud disk<br><li>CLOUD_PREMIUM: Premium Cloud Storage<br><li>CLOUD_SSD: SSD<br><li>CLOUD_HSSD: Enhanced SSD<br><br>Default value: LOCAL_BASIC.<br><br>This parameter is invalid for the `ResizeInstanceDisk` API.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Data disk ID. Data disks of the type `LOCAL_BASIC` or `LOCAL_SSD` do not have IDs and do not support this parameter.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// Whether to terminate the data disk when its CVM is terminated. Valid values:
        /// <li>TRUE: terminate the data disk when its CVM is terminated. This value only supports pay-as-you-go cloud disks billed on an hourly basis.
        /// <li>FALSE: retain the data disk when its CVM is terminated.<br>
        /// Default value: TRUE<br>
        /// Currently this parameter is only used in the `RunInstances` API.
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
        /// Specifies whether the data disk is encrypted. Valid values: 
        /// <li>TRUE: encrypted
        /// <li>FALSE: not encrypted<br>
        /// Default value: FALSE<br>
        /// This parameter is only used with `RunInstances`.
        /// Note: this field may return `null`, indicating that no valid value is obtained.
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
        }
    }
}

