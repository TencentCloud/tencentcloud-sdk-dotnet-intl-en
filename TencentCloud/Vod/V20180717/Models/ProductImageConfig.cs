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

    public class ProductImageConfig : AbstractModel
    {
        
        /// <summary>
        /// Prompt content for image generation background. if this field is default, inspiration is automatically generated internally.
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// Prevent the model from generating image prompts.
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// Product description describes in detail, helping generate images that meet requirements.
        /// </summary>
        [JsonProperty("ProductDesc")]
        public string ProductDesc{ get; set; }

        /// <summary>
        /// Special requirements. if any, import them through this field.
        /// </summary>
        [JsonProperty("MoreRequirement")]
        public string MoreRequirement{ get; set; }

        /// <summary>
        /// Specifies the number of images to generate. defaults to 1 if left empty. valid value: 10.
        /// </summary>
        [JsonProperty("OutputImageCount")]
        public ulong? OutputImageCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "ProductDesc", this.ProductDesc);
            this.SetParamSimple(map, prefix + "MoreRequirement", this.MoreRequirement);
            this.SetParamSimple(map, prefix + "OutputImageCount", this.OutputImageCount);
        }
    }
}

