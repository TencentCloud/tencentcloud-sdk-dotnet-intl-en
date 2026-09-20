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

    public class AigcHunyuan3DTaskInput : AbstractModel
    {
        
        /// <summary>
        /// <p>Generate 3D reference image information.</p>
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcHunyuan3DReferenceImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// <p>Multi-perspective image information used to generate a 3D model.</p><p>The array length must be between 2 and 8, and must contain the front perspective.</p>
        /// </summary>
        [JsonProperty("MultiViewImageInfos")]
        public AigcHunyuan3DMultiViewImageInfo[] MultiViewImageInfos{ get; set; }

        /// <summary>
        /// <p>Prompt for generating a 3D model.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Generation Type.</p><p>Enumeration values:</p><ul><li>Normal: Generate a complete 3D asset (geometry + texture);</li><li>Geometry: Generate only geometry (no texture, faster output speed);</li><li>Texture: Generate only texture (requires filling in MeshInfos)</li></ul>
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// <p>Reference 3D model used to generate a 3D model.</p>
        /// </summary>
        [JsonProperty("MeshInfos")]
        public AigcHunyuan3DMeshInfo[] MeshInfos{ get; set; }

        /// <summary>
        /// <p>Whether to enable output of PBR materials.</p><p>Enumeration values:</p><ul><li>Enabled: enable;</li><li>Disabled: disable.</li></ul>
        /// </summary>
        [JsonProperty("EnablePBR")]
        public string EnablePBR{ get; set; }

        /// <summary>
        /// <p>Number of patches. This parameter is valid only when the value of GenerateType is Normal or Geometry.</p>
        /// </summary>
        [JsonProperty("FaceCount")]
        public long? FaceCount{ get; set; }

        /// <summary>
        /// <p>Whether to retain UV unfold.</p><p>Enumeration values:</p><ul><li>Enabled: reserved;</li><li>Disabled: not retain.</li></ul>
        /// </summary>
        [JsonProperty("KeepUV")]
        public string KeepUV{ get; set; }

        /// <summary>
        /// <p>Result format. In addition to the default return of obj and glb, an extra output format.</p><p>Enumeration values:</p><ul><li>FBX: FBX format file.</li></ul>
        /// </summary>
        [JsonProperty("ResultFormat")]
        public string ResultFormat{ get; set; }

        /// <summary>
        /// <p>Random Seed. Results can be reproduced with the same Seed input.</p>
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

        /// <summary>
        /// <p>Style control words.</p>
        /// </summary>
        [JsonProperty("Style")]
        public string Style{ get; set; }

        /// <summary>
        /// <p>Configuration of the output media file of the task.</p>
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcHunyuan3DOutputConfig OutputConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ImageInfos.", this.ImageInfos);
            this.SetParamArrayObj(map, prefix + "MultiViewImageInfos.", this.MultiViewImageInfos);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "GenerateType", this.GenerateType);
            this.SetParamArrayObj(map, prefix + "MeshInfos.", this.MeshInfos);
            this.SetParamSimple(map, prefix + "EnablePBR", this.EnablePBR);
            this.SetParamSimple(map, prefix + "FaceCount", this.FaceCount);
            this.SetParamSimple(map, prefix + "KeepUV", this.KeepUV);
            this.SetParamSimple(map, prefix + "ResultFormat", this.ResultFormat);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "Style", this.Style);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
        }
    }
}

