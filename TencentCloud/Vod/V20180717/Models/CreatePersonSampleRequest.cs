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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePersonSampleRequest : AbstractModel
    {
        
        /// <summary>
        /// Material name, length limited to 20 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Material application scenario. Available values:
        /// 1. Recognition: Used for content recognition, equivalent to Recognition.Face.
        /// 2. Review: For inappropriate content, equivalent to Review.Face.
        /// 3. All: Include all of the above, equivalent to 1+2.
        /// </summary>
        [JsonProperty("Usages")]
        public string[] Usages{ get; set; }

        /// <summary>
        /// <b>On-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Material description, with a length limit of 1024 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The material image [Base64](https://tools.ietf.org/html/rfc4648) encoded string only supports jpeg and png image formats. Array length limit: 5 images.
        /// Note: The image must be a single portrait with clear facial features and not less than 200×200 pixels.
        /// </summary>
        [JsonProperty("FaceContents")]
        public string[] FaceContents{ get; set; }

        /// <summary>
        /// material tag
        /// <li>Array length limit: 20 tags;</li>
        /// <li>Length limit for a single tag: 128 characters.</li>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Usages.", this.Usages);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "FaceContents.", this.FaceContents);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
        }
    }
}

