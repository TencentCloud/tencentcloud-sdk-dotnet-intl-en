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

    public class SubmitHunyuanTo3DProJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Generates 3D content, describes 3D content.
        /// Supports up to 1024 utf-8 characters.
        /// Text-To-3D. Specifies either ImageBase64/ImageUrl or Prompt is required. Prompt and ImageBase64/ImageUrl cannot coexist.
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// Enter the Base64 code of the image.
        /// Size: specifies the unilateral resolution requirement, not less than 128 and not greater than 5000. size should not exceed 8m (after encoding, it increases by about 30%, recommend actual input image size no more than 6m).
        /// Input image suggestion:
        /// 1.Simple background (solid-color background) 
        /// 2.No text or blended colors
        /// 3.Single object
        /// 4.The object occupies over 50% of the frame
        /// Valid values: jpg, png, jpeg, webp.
        /// Specifies either ImageBase64/ImageUrl or Prompt is required. Prompt and ImageBase64/ImageUrl cannot coexist.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// Input image Url.
        /// Size: specifies the unilateral resolution requirement, not less than 128 and not greater than 5000. size should not exceed 8m (after encoding, it increases by about 30%, recommend actual input image size no more than 6m).
        /// Input image suggestion:
        /// 1.Simple background (solid-color background) 
        /// 2.No text or blended colors
        /// 3.Single object
        /// 4.The object occupies over 50% of the frame
        /// Valid values: jpg, png, jpeg, webp.
        /// Specifies either ImageBase64/ImageUrl or Prompt is required. Prompt and ImageBase64/ImageUrl cannot coexist.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Multi-Perspective model image. reference value for viewing angle:.
        /// left view.
        /// right view.
        /// back view.
        /// 
        /// Each perspective is limited to one image.
        /// Image size limit. the value must not exceed 8 mb after encoding.
        /// Image resolution limitation: the unilateral resolution should be less than 5000 and greater than 128.
        /// Supported image format: JPG or PNG
        /// </summary>
        [JsonProperty("MultiViewImages")]
        public ViewImage[] MultiViewImages{ get; set; }

        /// <summary>
        /// Specifies whether PBR material generation is enabled. default false.
        /// </summary>
        [JsonProperty("EnablePBR")]
        public bool? EnablePBR{ get; set; }

        /// <summary>
        /// Specifies the face count for 3D model generation. default value is 500000.
        /// Specifies the supported face count generation range. value range: 40000-1500000.
        /// </summary>
        [JsonProperty("FaceCount")]
        public long? FaceCount{ get; set; }

        /// <summary>
        /// Generation task type. default: Normal. valid values:.
        /// Normal: generates a geometric model with textures.
        /// LowPoly: specifies the model generated after intelligent polygon reduction.
        /// Geometry: specifies whether to generate a Geometry model without textures (white model). when this task is selected, the EnablePBR parameter does not take effect.
        /// Specifies the Sketch for the generative model, allowing input of a Sketch or line drawing. in this mode, both prompt and ImageUrl/ImageBase64 can be entered together.
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// This parameter only takes effect when LowPoly mode is selected from GenerateType.
        /// 
        /// Polygon type, indicates the number of sides in the model's surface grid, defaults to triangle. valid values:.
        /// triangle. specifies the triangular face.
        /// quadrilateral: mix quadrangle and triangle faces to generate.
        /// </summary>
        [JsonProperty("PolygonType")]
        public string PolygonType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamArrayObj(map, prefix + "MultiViewImages.", this.MultiViewImages);
            this.SetParamSimple(map, prefix + "EnablePBR", this.EnablePBR);
            this.SetParamSimple(map, prefix + "FaceCount", this.FaceCount);
            this.SetParamSimple(map, prefix + "GenerateType", this.GenerateType);
            this.SetParamSimple(map, prefix + "PolygonType", this.PolygonType);
        }
    }
}

