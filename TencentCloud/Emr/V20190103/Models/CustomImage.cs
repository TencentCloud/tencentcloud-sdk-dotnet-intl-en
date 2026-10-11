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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomImage : AbstractModel
    {
        
        /// <summary>
        /// Image source. Valid values: tcr (public image), ccrPersonal (custom image), and ccrAllPersonal (shared image).
        /// </summary>
        [JsonProperty("ImageSourceType")]
        public string ImageSourceType{ get; set; }

        /// <summary>
        /// Image information.
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// Key used for obtaining an image.
        /// </summary>
        [JsonProperty("ImagePullSecret")]
        public ImagePullSecret ImagePullSecret{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageSourceType", this.ImageSourceType);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamObj(map, prefix + "ImagePullSecret.", this.ImagePullSecret);
        }
    }
}

