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

    public class SubmitHunyuan3DTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Prompt for text-to-3D</p><p>Input limit: up to 1024 utf-8 characters</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Image URL (http/https) for image-to-3D</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>Generate 3D from multi-perspective images. At least 2 images are required, and a front view must be included.</p>
        /// </summary>
        [JsonProperty("MultiViewImages")]
        public ViewImage[] MultiViewImages{ get; set; }

        /// <summary>
        /// <p>Generation Type</p><p>Enumeration values:</p><ul><li>Normal: Generate a complete 3D asset (geometry + texture)</li><li>Geometry: Generate only the geometry (no texture, faster output speed)</li><li>Texture: Generate only the texture (MeshUrl is required)</li></ul><p>Default value: Normal</p>
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// <p>URL of the existing 3D model (only .glb / .obj supported). If MeshUrl is passed, GenerateType=Texture is mandatory (texture scenario)</p>
        /// </summary>
        [JsonProperty("MeshUrl")]
        public string MeshUrl{ get; set; }

        /// <summary>
        /// <p>Whether to output the PBR material</p><p>Default value: false</p>
        /// </summary>
        [JsonProperty("EnablePBR")]
        public bool? EnablePBR{ get; set; }

        /// <summary>
        /// <p>Patch count in the range of [3000, 1500000]. This parameter takes effect only for the Normal/Geometry branch.</p><p>Parameter value range: [3000, 1500000]</p><p>Default value: 500000</p>
        /// </summary>
        [JsonProperty("FaceCount")]
        public ulong? FaceCount{ get; set; }

        /// <summary>
        /// <p>Reserve UV unfolding or not</p><p>Default value: false</p>
        /// </summary>
        [JsonProperty("KeepUV")]
        public bool? KeepUV{ get; set; }

        /// <summary>
        /// <p>A format attached to the output in addition to the default obj + glb. Currently only support FBX</p>
        /// </summary>
        [JsonProperty("ResultFormat")]
        public string ResultFormat{ get; set; }

        /// <summary>
        /// <p>Random Seed. The result can be reproduced with identical Seed input.</p>
        /// </summary>
        [JsonProperty("Seed")]
        public ulong? Seed{ get; set; }

        /// <summary>
        /// <p>Style control words</p>
        /// </summary>
        [JsonProperty("Style")]
        public string Style{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamArrayObj(map, prefix + "MultiViewImages.", this.MultiViewImages);
            this.SetParamSimple(map, prefix + "GenerateType", this.GenerateType);
            this.SetParamSimple(map, prefix + "MeshUrl", this.MeshUrl);
            this.SetParamSimple(map, prefix + "EnablePBR", this.EnablePBR);
            this.SetParamSimple(map, prefix + "FaceCount", this.FaceCount);
            this.SetParamSimple(map, prefix + "KeepUV", this.KeepUV);
            this.SetParamSimple(map, prefix + "ResultFormat", this.ResultFormat);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "Style", this.Style);
        }
    }
}

