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

    public class AigcImageTaskInputFileInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Input file type. Valid values: <li>File: on-demand media file;</li> <li>Url: accessible URL;</li> <li>Base64: Base64 string of an image or transcoded video;</li></p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Media file ID of the image file, which is the globally unique identifier of the file in VOD, assigned by the VOD backend after successful upload. You can obtain this field in the <a href="/document/product/266/7830">video upload completion event notification</a> or the <a href="https://console.cloud.tencent.com/vod/media">VOD console</a>. This parameter is valid when Type is File.<br>Description:</p><ol><li>Images less than 7M are recommended.</li><li>Image format values: jpeg, jpg, png, webp.</li></ol>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Accessible file URL. This parameter is valid when Type is Url.<br>Description:</p><ol><li>Images less than 7M are recommended.</li><li>Image format values: jpeg, jpg, png, webp.</li></ol>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>Accessible file Base64. This parameter is valid when Type is Base64. Details:</p><ol><li>The total file size of all files must not exceed 7 MB to avoid exceeding the 10 MB upper limit of message size of cloud APIs after conversion to Base64;</li><li>Image format should be: jpeg, jpg, png, webp;</li><li>Do not include prefixes such as data:image/jpeg;base64,.</li></ol>
        /// </summary>
        [JsonProperty("Base64")]
        public string Base64{ get; set; }

        /// <summary>
        /// <p>Description of the input image, used to help the model understand the image. Only valid for GEM 2.5 and GEM 3.0.</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p><strong>Valid only when ModelName is OG</strong>. Image type.</p><p>Enumeration values:</p><ul><li>mask: Image mask.</li></ul>
        /// </summary>
        [JsonProperty("ReferenceType")]
        public string ReferenceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Base64", this.Base64);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "ReferenceType", this.ReferenceType);
        }
    }
}

