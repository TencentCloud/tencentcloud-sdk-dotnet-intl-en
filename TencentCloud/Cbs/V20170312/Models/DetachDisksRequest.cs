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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetachDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// IDs of the cloud disks to be unmounted, which can be queried via the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API. Up to 10 elastic cloud disks can be unmounted in a single request.
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// Indicates the CVM from which you want to unmount the disks. This parameter is only available for shared cloud disks.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

