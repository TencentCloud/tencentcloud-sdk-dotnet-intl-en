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

    public class PornConfigureInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Parameters for recognition of pornographic content in images
        /// </summary>
        [JsonProperty("ImgReviewInfo")]
        public PornImgReviewTemplateInfoForUpdate ImgReviewInfo{ get; set; }

        /// <summary>
        /// Parameters for ASR-based recognition of pornographic content
        /// </summary>
        [JsonProperty("AsrReviewInfo")]
        public PornAsrReviewTemplateInfoForUpdate AsrReviewInfo{ get; set; }

        /// <summary>
        /// Parameters for OCR-based recognition of pornographic content
        /// </summary>
        [JsonProperty("OcrReviewInfo")]
        public PornOcrReviewTemplateInfoForUpdate OcrReviewInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ImgReviewInfo.", this.ImgReviewInfo);
            this.SetParamObj(map, prefix + "AsrReviewInfo.", this.AsrReviewInfo);
            this.SetParamObj(map, prefix + "OcrReviewInfo.", this.OcrReviewInfo);
        }
    }
}

