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

    public class SceneAigcImageTaskInputFileInfo : AbstractModel
    {
        
        /// <summary>
        /// Input video File type. valid values: <li>File: on-demand media File;</li> <li>Url: accessible Url;</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The media File ID of the image File, which is the globally unique identifier of the File in vod, is assigned by the vod backend after successful upload. you can obtain this field in the [video upload completion event notification](https://www.tencentcloud.com/document/product/266/7830?from_cn_redirect=1) or [vod console](https://console.cloud.tencent.com/vod/media). this parameter is valid when the Type value is File.
        /// Note:
        /// 1. recommended for use with images less than 7 mb.
        /// 2. image format value is jpeg, jpg, png, webp.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Accessible file URL. this parameter is valid when Type value is Url.
        /// Note:
        /// 1. recommended for use with images less than 7 MB.
        /// 2. image format value is jpeg, jpg, png, webp.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

