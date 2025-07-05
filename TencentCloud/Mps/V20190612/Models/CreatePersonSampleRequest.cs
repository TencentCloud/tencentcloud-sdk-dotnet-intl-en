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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePersonSampleRequest : AbstractModel
    {
        
        /// <summary>
        /// Name of an image. Length limit: 20 characters
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Image usage. Valid values:
        /// 1. Recognition: used for content recognition; equivalent to `Recognition.Face`
        /// 2. Review: used for inappropriate information recognition; equivalent to `Review.Face`
        /// 3. All: equivalent to 1+2
        /// </summary>
        [JsonProperty("Usages")]
        public string[] Usages{ get; set; }

        /// <summary>
        /// Image description. Length limit: 1,024 characters
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// [Base64](https://tools.ietf.org/html/rfc4648) string converted from an image. Only JPEG and PNG images are supported. Array length limit: 5 images
        /// Note: the image must be a relatively clear facial feature photo of one person with a size of at least 200 x 200 pixels.
        /// </summary>
        [JsonProperty("FaceContents")]
        public string[] FaceContents{ get; set; }

        /// <summary>
        /// Image tag
        /// <li>Array length limit: 20 tags</li>
        /// <li>Tag length limit: 128 characters</li>
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
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "FaceContents.", this.FaceContents);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
        }
    }
}

