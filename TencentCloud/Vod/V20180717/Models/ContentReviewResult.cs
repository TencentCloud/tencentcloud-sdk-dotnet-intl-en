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

    public class ContentReviewResult : AbstractModel
    {
        
        /// <summary>
        /// Result type. Valid values:
        /// <li>Porn.Image: Authentication result for offensive content in the image;</li>
        /// <li>Terrorism.Image: authentication result of unsafe information in the image;</li>
        /// <li>Political.Image: authentication of inappropriate information results in images;</li>
        /// <li>Porn.Ocr: Authentication result for offensive content in image OCR text;</li>
        /// <li>Terrorism.Ocr: Authentication result of unsafe information in image OCR text;</li>
        /// <li>Political.Ocr: Authentication result of inappropriate information in image OCR text.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Authentication result for offensive content in the image. Valid when Type is Porn.Image.
        /// </summary>
        [JsonProperty("PornImageResult")]
        public PornImageResult PornImageResult{ get; set; }

        /// <summary>
        /// Authentication result of unsafe information in the image. Valid when Type is Terrorism.Image.
        /// </summary>
        [JsonProperty("TerrorismImageResult")]
        public TerrorismImageResult TerrorismImageResult{ get; set; }

        /// <summary>
        /// Authentication result for inappropriate information in the image. Valid when Type is Political.Image.
        /// </summary>
        [JsonProperty("PoliticalImageResult")]
        public PoliticalImageResult PoliticalImageResult{ get; set; }

        /// <summary>
        /// Authentication result for offensive content in image OCR text. Valid when Type is Porn.Ocr.
        /// </summary>
        [JsonProperty("PornOcrResult")]
        public ContentReviewOcrResult PornOcrResult{ get; set; }

        /// <summary>
        /// Authentication result of unsafe information in image OCR. Valid when Type is Terrorism.Ocr.
        /// </summary>
        [JsonProperty("TerrorismOcrResult")]
        public ContentReviewOcrResult TerrorismOcrResult{ get; set; }

        /// <summary>
        /// Authentication result of inappropriate information in image OCR text. Valid when Type is Political.Ocr.
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

