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

    public class DescribeImagesRequest : AbstractModel
    {
        
        /// <summary>
        /// List of image IDs, such as `img-gvbnzy6f`. For the format of array-type parameters, see [API Introduction](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1). You can obtain the image IDs in two ways: <br><li>Call [DescribeImages](https://intl.cloud.tencent.com/document/api/213/15715?from_cn_redirect=1) and look for `ImageId` in the response. <br><li>View the image IDs in the [Image Console](https://console.cloud.tencent.com/cvm/image).
        /// </summary>
        [JsonProperty("ImageIds")]
        public string[] ImageIds{ get; set; }

        /// <summary>
        /// Filters. Each request can have up to 10 `Filters` and 5 `Filters.Values`. You cannot specify `ImageIds` and `Filters` at the same time. Specific filters:
        /// <li>`image-id` - String - Optional - Filter results by image ID</li>
        /// <li>`image-type` - String - Optional - Filter results by image type. Valid values:
        ///     PRIVATE_IMAGE: private image created by the current account 
        ///     PUBLIC_IMAGE: public image created by Tencent Cloud
        ///    SHARED_IMAGE: image shared with the current account by another account.</li>
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
        /// Instance type, e.g. `S1.SMALL1`
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

