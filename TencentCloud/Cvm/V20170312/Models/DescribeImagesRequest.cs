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

    public class DescribeImagesRequest : AbstractModel
    {
        
        /// <summary>
        /// List of image IDs, such as `img-gvbnzy6f`. For the format of array-type parameters, see [API Introduction](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1). You can obtain the image IDs in two ways: <br><li>Call [DescribeImages](https://intl.cloud.tencent.com/document/api/213/15715?from_cn_redirect=1) and look for `ImageId` in the response. <br><li>View the image IDs in the [Image Console](https://console.cloud.tencent.com/cvm/image).
        /// </summary>
        [JsonProperty("ImageIds")]
        public string[] ImageIds{ get; set; }

        /// <summary>
        /// Filters. Each request can have up to 10 `Filters`, and 5 `Filters.Values` for each filter. `ImageIds` and `Filters` cannot be specified at the same time. See details:
        /// 
        /// <li><strong>image-id</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>image ID</strong>.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p>
        /// <li><strong>image-type</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>image type</strong>.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p><p style="padding-left: 30px;">Options:</p><p style="padding-left: 30px;">`PRIVATE_IMAGE`: Private images (images created by this account)</p><p style="padding-left: 30px;">`PUBLIC_IMAGE`: Public images (Tencent Cloud official images)</p><p style="padding-left: 30px;">`SHARED_IMAGE`: Shared images (images shared by other accounts to this account)</p>
        /// <li><strong>image-name</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>image name</strong>.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p>
        /// <li><strong>platform</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>image operating system</strong>, such as `CentOS`.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p>
        /// <li><strong>tag-key</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>tag key</strong>.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p>
        /// <li><strong>tag-value</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>tag value</strong>.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p>
        /// <li><strong>tag:tag-key</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>tag key-value pair</strong>. Replace "tag-key" with the actual value. </p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset; default value: 0. For more information on `Offset`, see [API Introduction](https://intl.cloud.tencent.com/document/api/213/568?from_cn_redirect=1#.E8.BE.93.E5.85.A5.E5.8F.82.E6.95.B0.E4.B8.8E.E8.BF.94.E5.9B.9E.E5.8F.82.E6.95.B0.E9.87.8A.E4.B9.89).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of results returned; default value: 20; maximum: 100. For more information on `Limit`, see [API Introduction](https://intl.cloud.tencent.com/document/api/213/568?from_cn_redirect=1#.E8.BE.93.E5.85.A5.E5.8F.82.E6.95.B0.E4.B8.8E.E8.BF.94.E5.9B.9E.E5.8F.82.E6.95.B0.E9.87.8A.E4.B9.89).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Instance type, e.g. `SA5.MEDIUM2`
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ImageIds.", this.ImageIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
        }
    }
}

