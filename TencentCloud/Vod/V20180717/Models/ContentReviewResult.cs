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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ContentReviewResult : AbstractModel
    {
        
        /// <summary>
        /// The result type. Valid values:
        /// <li>Porn.Image: Recognition of pornographic content in the image</li>
        /// <li>Terrorism.Image: Recognition of terrorism content in the image</li>
        /// <li>Political.Image: Recognition of politically sensitive content in the image</li>
        /// <li>Porn.Ocr: OCR-based recognition of pornographic content in the image</li>
        /// <li>Terrorism.Ocr: OCR-based recognition of terrorism content in the image</li>
        /// <li>Political.Ocr: OCR-based recognition of politically sensitive content in the image</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The pornographic content detected in the image. This parameter is valid if `Type` is `Porn.Image`.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PornImageResult")]
        public PornImageResult PornImageResult{ get; set; }

        /// <summary>
        /// The terrorism content detected in the image. This parameter is valid if `Type` is `Terrorism.Image`.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("TerrorismImageResult")]
        public TerrorismImageResult TerrorismImageResult{ get; set; }

        /// <summary>
        /// The politically sensitive content detected in the image. This parameter is valid if `Type` is `Political.Image`.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PoliticalImageResult")]
        public PoliticalImageResult PoliticalImageResult{ get; set; }

        /// <summary>
        /// The pornographic content detected in the image based on OCR. This parameter is valid if `Type` is `Porn.Ocr`.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PornOcrResult")]
        public ContentReviewOcrResult PornOcrResult{ get; set; }

        /// <summary>
        /// The terrorism content detected in the image based on OCR. This parameter is valid if `Type` is `Terrorism.Ocr`.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("TerrorismOcrResult")]
        public ContentReviewOcrResult TerrorismOcrResult{ get; set; }

        /// <summary>
        /// The politically sensitive content detected in the image based on OCR. This parameter is valid if `Type` is `Political.Ocr`.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PoliticalOcrResult")]
        public ContentReviewOcrResult PoliticalOcrResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "PornImageResult.", this.PornImageResult);
            this.SetParamObj(map, prefix + "TerrorismImageResult.", this.TerrorismImageResult);
            this.SetParamObj(map, prefix + "PoliticalImageResult.", this.PoliticalImageResult);
            this.SetParamObj(map, prefix + "PornOcrResult.", this.PornOcrResult);
            this.SetParamObj(map, prefix + "TerrorismOcrResult.", this.TerrorismOcrResult);
            this.SetParamObj(map, prefix + "PoliticalOcrResult.", this.PoliticalOcrResult);
        }
    }
}

