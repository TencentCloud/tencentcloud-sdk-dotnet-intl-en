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
        /// Specifies the system disk type. for the restrictions on the system disk type, refer to [storage overview](https://intl.cloud.tencent.com/document/product/213/4952?from_cn_redirect=1). value range:<br>.
        /// <Li>LOCAL_BASIC: specifies a local hard disk.</li>.
        /// <Li>LOCAL_SSD: specifies a local ssd.</li>.
        /// <Li>CLOUD_BASIC: ordinary cloud disk.</li>.
        /// <Li>CLOUD_SSD: ssd cloud disk</li>.
        /// <Li>CLOUD_PREMIUM: high-performance cloud block storage.</li>.
        /// <Li>CLOUD_BSSD: universal type ssd cloud disk</li>.
        /// <Li>CLOUD_HSSD: enhanced ssd cloud disk</li>.
        /// <li>CLOUD_TSSD: ultra-fast SSD cbs</li.
        /// Default value: Current disk types with inventory available.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Specifies the system disk ID.
        /// This parameter currently only serves as a response parameter for query apis such as `DescribeInstances`, and cannot be used as an input parameter for write apis such as `RunInstances`.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// System disk size; unit: GiB; default value: 50 GiB.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Specifies the exclusive cluster ID it belongs to.
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

