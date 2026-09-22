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
        /// Subject name. It cannot exceed 20 characters.
        /// </summary>
        [JsonProperty("ElementName")]
        public string ElementName{ get; set; }

        /// <summary>
        /// Subject description.
        /// 
        /// Cannot exceed 100 characters.
        /// </summary>
        [JsonProperty("ElementDescription")]
        public string ElementDescription{ get; set; }

        /// <summary>
        /// Front reference image of the subject.
        /// Support input image URL (underwrite accessibility)
        /// Image format: .jpg, .jpeg, and .png are supported.
        /// The image file size must not exceed 10 MB. The image width and height must not be less than 300 px. The image aspect ratio must be between 1:2.5 and 2.5:1.
        /// </summary>
        [JsonProperty("ElementFrontalImage")]
        public string ElementFrontalImage{ get; set; }

        /// <summary>
        /// Other reference lists of the subject. You can upload multiple reference images of the subject from different angles to define its appearance. Upload at least 1 reference image and up to 3 reference images.
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

