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

    public class SystemDisk : AbstractModel
    {
        
        /// <summary>
        /// System disk type. for restrictions on the system disk type, see [cloud block storage types](https://intl.cloud.tencent.com/document/product/362/2353?from_cn_redirect=1). valid values:.
        /// <Li>LOCAL_BASIC: local hard disk.</li>.
        /// <Li>LOCAL_SSD: local ssd.</li>.
        /// <Li>CLOUD_BASIC: general cloud disk.</li>.
        /// <Li>CLOUD_PREMIUM: high-performance cloud block storage</li>.
        /// <Li>CLOUD_SSD: cloud ssd</li>.
        /// <Li>CLOUD_BSSD: universal ssd cloud disk</li>.
        /// <Li>CLOUD_HSSD: enhanced ssd cloud disk</li>.
        /// <Li>CLOUD_TSSD: ultra ssd.</li>.
        /// <li>Default value: CLOUD_PREMIUM.</li>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// System disk size, in GB. Default value: 50.
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
        }
    }
}

