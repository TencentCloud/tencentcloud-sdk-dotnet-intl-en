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

    public class TerrorismConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// Parameters for recognition of terrorism content in images
        /// Note: This field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("ImgReviewInfo")]
        public TerrorismImgReviewTemplateInfo ImgReviewInfo{ get; set; }

        /// <summary>
        /// Parameters for OCR-based recognition of terrorism content
        /// Note: This field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("OcrReviewInfo")]
        public TerrorismOcrReviewTemplateInfo OcrReviewInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ImgReviewInfo.", this.ImgReviewInfo);
            this.SetParamObj(map, prefix + "OcrReviewInfo.", this.OcrReviewInfo);
        }
    }
}

