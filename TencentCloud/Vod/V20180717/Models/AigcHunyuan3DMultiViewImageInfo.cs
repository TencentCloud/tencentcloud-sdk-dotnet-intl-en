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

    public class AigcHunyuan3DMultiViewImageInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Input file type. Valid values: <li>File: on-demand media file;</li> <li>Url: accessible URL;</li></p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>File ID, the globally unique identifier of the file in VOD, is assigned by the VOD backend after successful upload. You can obtain this field in the <a href="/document/product/266/7830">video upload completion event notification</a> or the <a href="https://console.cloud.tencent.com/vod/media">VOD console</a>. This parameter is valid when Type is File. Description: Supported image formats: jpg, jpeg, png, bmp, webp.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Accessible file URL. This parameter is valid when Type is Url. Description: image format values: support jpg, jpeg, png, bmp, webp.</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>Viewing angle image type.</p><p>Enumeration values:</p><ul><li><p>front: Front view (required)</p></li><li><p>back: Back view</p></li><li><p>left: Left view</p></li><li><p>right: Right view</p></li><li><p>top: Top view</p></li><li><p>bottom: Bottom view</p></li><li><p>left_front: Left front 45°</p></li><li><p>right_front: Right front 45°</p></li><li><p>Must contain the front view;</p></li><li><p>The same ViewType cannot be duplicated.</p></li></ul>
        /// </summary>
        [JsonProperty("ViewType")]
        public string ViewType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "ViewType", this.ViewType);
        }
    }
}

