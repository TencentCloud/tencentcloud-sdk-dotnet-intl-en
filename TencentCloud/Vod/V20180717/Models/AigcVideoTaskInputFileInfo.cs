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

    public class AigcVideoTaskInputFileInfo : AbstractModel
    {
        
        /// <summary>
        /// Input video file type. Valid values: <li>File: on-demand media file;</li> <li>Url: accessible URL;</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// File category. Valid values:
        /// <li>Image: image.</li>
        /// <li>Video: video.</li>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// The media File ID, which is the globally unique identifier (guid) of the File in vod, is assigned by the vod backend after successful upload. you can retrieve this field in the [video upload completion event notification](https://www.tencentcloud.com/document/product/266/7830?from_cn_redirect=1) or [vod console](https://console.cloud.tencent.com/vod/media). this parameter is valid when the Type value is File. description:.
        /// 1. recommended image size: less than 10 mb.
        /// 2. image format value is jpeg, jpg, png.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Accessible file URL. this parameter is valid when Type value is URL.
        /// Note:.
        /// 1. recommended image size: less than 10 mb.
        /// 2. image format value is jpeg, jpg, png.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Reference Type. The GV Model applies.
        /// Note:
        /// When using the GV model, this can be used as the reference method. Available values: asset means material, style means style.
        /// When using the Kling model and Category as Video, the reference video type is distinguishable: feature indicates feature reference video, and base indicates video for editing.
        /// </summary>
        [JsonProperty("ReferenceType")]
        public string ReferenceType{ get; set; }

        /// <summary>
        /// Subject Id.
        /// Applicable model: Vidu-q2.
        /// When identifying the subject in an Image, each Image must include a subject Id, which can be used via @subject Id in subsequent generation. Valid when Category is Image.
        /// </summary>
        [JsonProperty("ObjectId")]
        public string ObjectId{ get; set; }

        /// <summary>
        /// Suitable for the Vidu-q2 model.
        /// When all images carry the subject Id, you can set the timbre Id targeting the subject. Valid when Category is Image. Timbre list: https://shengshu.feishu.cn/sheets/EgFvs6DShhiEBStmjzccr5gonOg
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// Whether to retain the original sound. Valid when Category is Video. Values as follows:
        /// <li>Enabled: Reserved</li>
        /// <li>Disabled: not retain</li>
        /// </summary>
        [JsonProperty("KeepOriginalSound")]
        public string KeepOriginalSound{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "ReferenceType", this.ReferenceType);
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "KeepOriginalSound", this.KeepOriginalSound);
        }
    }
}

