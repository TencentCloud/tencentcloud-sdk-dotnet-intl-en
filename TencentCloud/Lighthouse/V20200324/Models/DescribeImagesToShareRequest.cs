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

    public class DescribeImagesToShareRequest : AbstractModel
    {
        
        /// <summary>
        /// List of CVM image IDs, which can be obtained through the ImageId in the returned value of the [DescribeImages](https://www.tencentcloud.com/document/api/213/15715?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("ImageIds")]
        public string[] ImageIds{ get; set; }

        /// <summary>
        /// Offset. The default value is 0. For more information on `Offset`, see the relevant section in API [Introduction](https://www.tencentcloud.com/document/product/1207/47578?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. The default value is 20, and the maximum value is 100. For more information on `Limit`, see the relevant section in API [Introduction](https://www.tencentcloud.com/document/product/1207/47578?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filter list.
        /// <li>image-id</li>: filter by [CVM image ID].
        /// Type: string.
        /// Required: no.
        /// <li>image-name</li>: filter by [CVM image name].
        /// Type: string.
        /// Required: no.
        /// 
        /// <li>image-type</li>: filter by [CVM image type].
        /// Type: string.
        /// Required: no.
        /// Valid values:
        /// PRIVATE_IMAGE: private image (image created by the account).
        /// PUBLIC_IMAGE: public image (Tencent Cloud official image).
        /// SHARED_IMAGE: shared image (image shared by other accounts to this account).
        /// 
        /// The maximum number of Filters per request is 10, and the maximum number of Filter.Values per request is 5.
        /// ImageIds and Filters cannot be specified simultaneously for parameters.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ImageIds.", this.ImageIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

