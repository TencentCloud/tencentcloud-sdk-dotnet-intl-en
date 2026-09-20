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

    public class AigcVideoRedrawTaskInputFileInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Input video file type. Valid values: <li>File: on-demand media file;</li> <li>Url: accessible URL;</li></p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Media file ID, the globally unique identifier of the file on VOD, assigned by the VOD backend after successful upload. This field can be obtained from <a href="/document/product/266/7830">video upload completion event notification</a> or the <a href="https://console.cloud.tencent.com/vod/media">VOD console</a>. This parameter is valid when Type is File. Notes: 1. Images less than 10M are recommended; 2. Image format values: jpeg, jpg, png.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Accessible file URL. This parameter is valid when Type is Url. Note: 1. Images less than 10M are recommended; 2. Supported image formats: jpeg, jpg, png.</p>
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

