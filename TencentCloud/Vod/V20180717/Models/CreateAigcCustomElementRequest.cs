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

    public class CreateAigcCustomElementRequest : AbstractModel
    {
        
        /// <summary>
        /// Subject name cannot exceed 20 characters.
        /// </summary>
        [JsonProperty("ElementName")]
        public string ElementName{ get; set; }

        /// <summary>
        /// Subject description.
        /// 
        /// Up to 100 characters.
        /// </summary>
        [JsonProperty("ElementDescription")]
        public string ElementDescription{ get; set; }

        /// <summary>
        /// Front reference image of the subject.
        /// Support input image URL (underwrite accessible).
        /// Image format. Valid values: .jpg, .jpeg, and .png.
        /// The image file size must not exceed 10MB, with image width and height not less than 300px and image aspect ratio between 1:2.5 and 2.5:1.
        /// </summary>
        [JsonProperty("ElementFrontalImage")]
        public string ElementFrontalImage{ get; set; }

        /// <summary>
        /// Reference list of other subjects. Upload multiple subject reference images from different angles to define the subject appearance. Upload at least 1 reference image, up to 3 reference images.
        /// </summary>
        [JsonProperty("ElementReferList")]
        public ElementReferInfo[] ElementReferList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ElementName", this.ElementName);
            this.SetParamSimple(map, prefix + "ElementDescription", this.ElementDescription);
            this.SetParamSimple(map, prefix + "ElementFrontalImage", this.ElementFrontalImage);
            this.SetParamArrayObj(map, prefix + "ElementReferList.", this.ElementReferList);
        }
    }
}

