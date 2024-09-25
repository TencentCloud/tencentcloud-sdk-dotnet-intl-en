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

namespace TencentCloud.Facefusion.V20220927.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MergeInfo : AbstractModel
    {
        
        /// <summary>
        /// Enter the image Base64 code.
        /// ●Either the Base64 code or URL must be provided. If both are provided, URL prevails.
        /// ●Material image limitation: face size in the image greater than 34×34 pixels; image size greater than 64×64 pixels. (After encoding, the image size may increase by about 30%. It is recommended to control the image size reasonably.)
        /// ●Supported image format: JPG or PNG
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// Enter the image URL.
        /// ●Either the Base64 code or URL must be provided. If both are provided, URL prevails.
        /// ●Material image limitation: face size in the image greater than 34×34 pixels; image size greater than 64×64 pixels. (After encoding, the image size may increase by about 30%. It is recommended to control the image size reasonably.)
        /// ●Supported image format: JPG or PNG
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Face position information (face box) on the uploaded image
        /// Width and height are no less than 30.
        /// </summary>
        [JsonProperty("InputImageFaceRect")]
        public FaceRect InputImageFaceRect{ get; set; }

        /// <summary>
        /// Material face ID. If this parameter is left blank, the largest face is used by default.
        /// </summary>
        [JsonProperty("TemplateFaceID")]
        public string TemplateFaceID{ get; set; }

        /// <summary>
        /// Face position information (face box) on the template. If this parameter is left blank, the largest face is used by default. This parameter applies to scenes where custom material templates are used for fusion.
        /// Width and height are no less than 30.
        /// </summary>
        [JsonProperty("TemplateFaceRect")]
        public FaceRect TemplateFaceRect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamObj(map, prefix + "InputImageFaceRect.", this.InputImageFaceRect);
            this.SetParamSimple(map, prefix + "TemplateFaceID", this.TemplateFaceID);
            this.SetParamObj(map, prefix + "TemplateFaceRect.", this.TemplateFaceRect);
        }
    }
}

