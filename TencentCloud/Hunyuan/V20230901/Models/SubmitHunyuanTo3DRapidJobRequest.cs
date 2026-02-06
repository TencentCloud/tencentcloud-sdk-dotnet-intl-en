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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitHunyuanTo3DRapidJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Text-To-3D, description of 3D content, forward Prompt content
        /// Supports up to 200 utf-8 characters
        /// Either ImageBase64, ImageUrl, or Prompt is required, and Prompt cannot coexist with ImageBase64/ImageUrl
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// Input image Base64 data
        /// Size: unilateral resolution requirement not less than 128, not greater than 5000, size not greater than 6mb (after encoding, size increases by approximately 30%). format:
        /// jpg, png, jpeg, webp
        /// Imagebase64, imageurl, and Prompt are required, but Prompt and imagebase64/imageurl cannot coexist
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// Input image Url size: 
        /// Unilateral resolution requirement not less than 128, not greater than 5000. size not greater than 8mb
        /// Format: jpg, png, jpeg, webp
        /// Imagebase64, imageurl, and Prompt are required, and Prompt cannot coexist with imagebase64/imageurl	
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Specifies whether PBR material generation is enabled, false by default.	
        /// </summary>
        [JsonProperty("EnablePBR")]
        public bool? EnablePBR{ get; set; }

        /// <summary>
        /// Specifies whether to enable the single geometry generation option
        /// When enabled, it generates a 3D model without textures (white model)
        /// When enabled, the generative model does not support OBJ format
        /// Default model file format is GLB
        /// </summary>
        [JsonProperty("EnableGeometry")]
        public bool? EnableGeometry{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "EnablePBR", this.EnablePBR);
            this.SetParamSimple(map, prefix + "EnableGeometry", this.EnableGeometry);
        }
    }
}

