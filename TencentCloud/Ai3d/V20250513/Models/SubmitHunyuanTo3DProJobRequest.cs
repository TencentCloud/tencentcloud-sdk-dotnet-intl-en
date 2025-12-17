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

namespace TencentCloud.Ai3d.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitHunyuanTo3DProJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Generates 3D content, describes 3D content, chinese forward prompt content.
        /// Supports up to 1024 utf-8 characters.
        /// Text-To-3D. specifies image, image_url, or prompt is required. prompt and image/image_url cannot coexist.
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// Enter the Base64 code of the image.
        /// Size: specifies the unilateral resolution requirement, not less than 128 and not greater than 5000. size should not exceed 8m (after encoding, it increases by about 30%, recommend actual input image size no more than 6m).
        /// Valid values: jpg, png, jpeg, webp.
        /// ImageBase64, ImageUrl, or Prompt is required. Prompt and ImageBase64/ImageUrl cannot coexist.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// Input image Url.
        /// Size: specifies the unilateral resolution requirement, not less than 128 and not greater than 5000. size should not exceed 8m (after encoding, it increases by about 30%, recommend actual input image size no more than 6m).
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
        /// Each viewing angle allows only one image.
        /// Image size limit: must not exceed 8M after encoding.
        /// Image resolution limitation: specifies the unilateral resolution should be less than 5000 and greater than 128.
        /// ●Supported image format: JPG or PNG
        /// </summary>
        [JsonProperty("MultiViewImages")]
        public ViewImage[] MultiViewImages{ get; set; }

        /// <summary>
        /// Specifies whether PBR material generation is enabled, false by default.
        /// </summary>
        [JsonProperty("EnablePBR")]
        public bool? EnablePBR{ get; set; }

        /// <summary>
        /// Specifies the face count of the generated 3D model. default value is 500000.
        /// Specifies the supported face count range. value range: 40000-1500000.
        /// </summary>
        [JsonProperty("FaceCount")]
        public long? FaceCount{ get; set; }

        /// <summary>
        /// Generation task type. default: Normal. valid values:.
        /// Generates a textured geometry model.
        /// LowPoly: specifies whether to generate a model with smart polygon reduction.
        /// Geometry: specifies whether to generate a Geometry model without texture (white model). when this task is selected, the EnablePBR parameter does not take effect.
        /// Sketch: enter a Sketch or line art to generate a model. in this mode, prompt and ImageUrl/ImageBase64 can be input together.
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// This parameter only takes effect when LowPoly mode is selected from GenerateType.
        /// 
        /// Polygon type, indicates the model surface is composed of polygon grids, defaults to triangle. valid values:.
        /// Specifies the triangle face.
        /// quadrilateral: generates a mix of quadrangle and triangle faces.
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

