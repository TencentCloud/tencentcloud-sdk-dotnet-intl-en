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

    public class SystemDisk : AbstractModel
    {
        
        /// <summary>
        /// System disk type. For the restrictions on the system disk type, refer to [Storage Overview] (https://intl.cloud.tencent.com/document/product/213/4952?from_cn_redirect=1). Value range:<br>
        /// <li>LOCAL_BASIC: Local Disk</li>
        /// <li>LOCAL_SSD: Local SSD Disk</li>
        /// <li>CLOUD_BASIC: HDD Cloud Disk</li>
        /// <li>CLOUD_SSD: Cloud SSD</li>
        /// <li>CLOUD_PREMIUM: Premium Cloud Disk</li>
        /// <li>CLOUD_BSSD: Balanced SSD</li>
        /// <li>CLOUD_HSSD: Enhanced SSD</li>
        /// <li>CLOUD_TSSD: ulTra SSD</li><br>
        /// Default value: Current disk types with inventory available.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// System disk ID. System disks whose type is `LOCAL_BASIC` or `LOCAL_SSD` do not have an ID and do not support this parameter.
        /// It is only used as a response parameter for APIs such as `DescribeInstances`, and cannot be used as a request parameter for APIs such as `RunInstances`.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// System disk size; unit: GB; default value: 50 GB.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// ID of the dedicated cluster to which the instance belongs.
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// Disk name, with a length of not more than 128 characters.
        /// 
        /// This parameter is in invite-only testing and is not yet open for use.
        /// Note: This field may return null, indicating that no valid value is found.
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

