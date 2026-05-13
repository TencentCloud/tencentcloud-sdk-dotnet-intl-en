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

    public class InquiryPriceResizeDiskRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the size after expanding the cloud disk in GiB, which should not be less than the current disk size. for the cloud disk size range, please refer to the product type of CBS (https://www.tencentcloud.com/document/product/362/2353?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// Cloud disk ID. can be queried via the [DescribeDisks](https://www.tencentcloud.com/document/product/362/16315?from_cn_redirect=1) api. mutually exclusive with the DiskIds parameter.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// cloud disk project ID. obtain this parameter by calling the projectId field in the return value of [DescribeProject](https://www.tencentcloud.com/document/api/651/78725?from_cn_redirect=1). if input, it is only for authentication.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Cloud disk ID list. queried via the [DescribeDisks](https://www.tencentcloud.com/document/product/362/16315?from_cn_redirect=1) api. mutually exclusive with the DiskId parameter.
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
        }
    }
}

