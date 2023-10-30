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

    public class ImageOperation : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The scaling details. This parameter is valid only if `Type` is `Scale`.
        /// </summary>
        [JsonProperty("Scale")]
        public ImageScale Scale{ get; set; }

        /// <summary>
        /// The cropping details. This parameter is valid only if `Type` is `CenterCut`.
        /// </summary>
        [JsonProperty("CenterCut")]
        public ImageCenterCut CenterCut{ get; set; }

        /// <summary>
        /// Image blurring. This parameter is valid only if `Type` is `Blur`.
        /// </summary>
        [JsonProperty("Blur")]
        public ImageBlur Blur{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Scale.", this.Scale);
            this.SetParamObj(map, prefix + "CenterCut.", this.CenterCut);
            this.SetParamObj(map, prefix + "Blur.", this.Blur);
        }
    }
}

