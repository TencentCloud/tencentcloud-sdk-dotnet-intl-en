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

    public class ModifyImageAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Image ID, such as `img-gvbnzy6f`. You can obtain the image ID in the following ways:<li>Call the [DescribeImages](https://intl.cloud.tencent.com/document/api/213/15715?from_cn_redirect=1) API and find the value of `ImageId` in the response.</li><li>Obtain it in the [Image console](https://console.cloud.tencent.com/cvm/image).</li>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// New image name, which should meet the following requirements:<li>It should not exceed 60 characters.</li><li>It should be unique.</li>
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// New image description, which should meet the following requirement:<li>It should not exceed 256 characters.</li>
        /// </summary>
        [JsonProperty("ImageDescription")]
        public string ImageDescription{ get; set; }

        /// <summary>
        /// Sets the image family;
        /// </summary>
        [JsonProperty("ImageFamily")]
        public string ImageFamily{ get; set; }

        /// <summary>
        /// Sets whether the image is deprecated;
        /// </summary>
        [JsonProperty("ImageDeprecated")]
        public bool? ImageDeprecated{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
            this.SetParamSimple(map, prefix + "ImageFamily", this.ImageFamily);
            this.SetParamSimple(map, prefix + "ImageDeprecated", this.ImageDeprecated);
        }
    }
}

