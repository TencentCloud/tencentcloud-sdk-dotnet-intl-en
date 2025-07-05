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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyIgnoreVul : AbstractModel
    {
        
        /// <summary>
        /// POC ID
        /// </summary>
        [JsonProperty("PocID")]
        public string PocID{ get; set; }

        /// <summary>
        /// IDs of images to be ignored. If it is not specified, it indicates to ignore all.
        /// </summary>
        [JsonProperty("ImageIDs")]
        public string[] ImageIDs{ get; set; }

        /// <summary>
        /// When there is an image
        /// Image type. Valid values: `LOCAL` (local image); `REGISTRY` (repository image).
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PocID", this.PocID);
            this.SetParamArraySimple(map, prefix + "ImageIDs.", this.ImageIDs);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
        }
    }
}

