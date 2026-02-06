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

    public class SubmitHunyuanTo3DTextureEditJobRequest : AbstractModel
    {
        
        /// <summary>
        /// File URL of the 3D model file that requires texture edit
        /// Supported formats: FBX, OBJ, GLB
        /// 3D model limit: less than 100000 faces
        /// </summary>
        [JsonProperty("File3D")]
        public InputFile3D File3D{ get; set; }

        /// <summary>
        /// Reference image for 3D model texture editing: Base64 data and image Url
        /// Either Base64 or Url must be provided. if both are provided, Url prevails
        /// Image restrictions: unilateral resolution less than 4096 and greater than 128, converted into Base64 string less than 10MB
        /// Format support: jpg, jpeg, png
        /// </summary>
        [JsonProperty("Image")]
        public ImageInfo Image{ get; set; }

        /// <summary>
        /// Describes texture editing, forward prompt content
        /// Supports up to 1024 utf-8 characters
        /// Either image or prompt is required, and prompt and image cannot coexist
        /// Example value: a kitten
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// Whether to enable the PBR texture parameter, only supports enabling when entering the Prompt
        /// Example value: true
        /// </summary>
        [JsonProperty("EnablePBR")]
        public bool? EnablePBR{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "File3D.", this.File3D);
            this.SetParamObj(map, prefix + "Image.", this.Image);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "EnablePBR", this.EnablePBR);
        }
    }
}

