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

    public class LogoParam : AbstractModel
    {
        
        /// <summary>
        /// Coordinates of the logo image in the fusion result image. The logo image will be stretched according to the coordinates.
        /// </summary>
        [JsonProperty("LogoRect")]
        public FaceRect LogoRect{ get; set; }

        /// <summary>
        /// Logo image URL
        /// ●Either the Base64 code or URL must be provided. If both are provided, URL prevails.
        /// ●Supported image format: JPG or PNG
        /// </summary>
        [JsonProperty("LogoUrl")]
        public string LogoUrl{ get; set; }

        /// <summary>
        /// Logo image Base64 code
        /// ●Either the Base64 code or URL must be provided. If both are provided, URL prevails.
        /// ●Supported image format: JPG or PNG
        /// </summary>
        [JsonProperty("LogoImage")]
        public string LogoImage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "LogoRect.", this.LogoRect);
            this.SetParamSimple(map, prefix + "LogoUrl", this.LogoUrl);
            this.SetParamSimple(map, prefix + "LogoImage", this.LogoImage);
        }
    }
}
