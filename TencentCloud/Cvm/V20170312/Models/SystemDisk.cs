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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SystemDisk : AbstractModel
    {
        
        /// <summary>
        /// Specifies the system disk type. for the restrictions on the system disk type, refer to [storage overview](https://www.tencentcloud.com/document/product/362/31636). value range:<br>
        /// <li>LOCAL_BASIC: Local SATA disk</li>
        /// <li>LOCAL_SSD: Local NVMe SSD</li>
        /// <li>CLOUD_BASIC: Cloud SATA disk</li>
        /// <li>CLOUD_SSD: Cloud SSD</li>
        /// <li>CLOUD_PREMIUM: Premium SSD</li>
        /// <li>CLOUD_BSSD: Balanced SSD</li>
        /// <li>CLOUD_HSSD: Enhanced SSD</li>
        /// <li>CLOUD_TSSD: Tremendous SSD</li>
        /// Default value: Current disk types with inventory available.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// System disk ID.
        /// Currently, this parameter is only used for response parameters in query apis such as [DescribeInstances](https://www.tencentcloud.com/document/api/213/33258) and is not applicable to request parameters in write apis such as [RunInstances](https://www.tencentcloud.com/document/api/213/33237).
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// System disk size; unit: GiB; default value: 50 GiB.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Specifies the dedicated cluster ID belonging to.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// Disk name, which specifies a length not exceeding 128 characters.
        /// </summary>
        [JsonProperty("DiskName")]
        public string DiskName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "DiskName", this.DiskName);
        }
    }
}

