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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResizeDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// Cloud disk ID list, which can be queried via the [DescribeDisks](https://www.tencentcloud.com/document/api/1207/66093?from_cn_redirect=1) API. The maximum length of the list is 15.
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// Size of the cloud disk after scale-out, in GB. The value range of the Premium Disk size is [10, 4000], and that of the Cloud SSD size is [20, 4000]. The cloud disk size after scale-out must be greater than the current disk size.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
        }
    }
}

