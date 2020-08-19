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
        /// Image ID such as `img-gvbnzy6f`. You can obtain the image IDs in two ways: <br><li>Call [DescribeImages](https://intl.cloud.tencent.com/document/api/213/15715?from_cn_redirect=1) and look for `ImageId` in the response. <br><li>Look for the information in the [Image Console](https://console.cloud.tencent.com/cvm/image).
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// New image name, which must meet the following requirements: <br> <li>No more than 20 characters. <br> <li>Must be unique.
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// New image description, which must meet the following requirement: <br> <li> No more than 60 characters.
        /// </summary>
        [JsonProperty("ImageDescription")]
        public string ImageDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
        }
    }
}

