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
        /// Input video File type. valid values: <li>File: on-demand media File;</li> <li>Url: accessible Url;</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

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
        /// Reference type. Used for the GV model.
        /// Note:
        /// When using the GV model, can be used as a reference method, selectable asset (material), style.
        /// </summary>
        [JsonProperty("ReferenceType")]
        public string ReferenceType{ get; set; }

        /// <summary>
        /// Object id.
        /// Applicable model: Vidu-q2.
        /// When an image identifier is required, each image must have a subject id. the subject id can be used via @subject id in subsequent generation.
        /// </summary>
        [JsonProperty("ObjectId")]
        public string ObjectId{ get; set; }

        /// <summary>
        /// Suitable for the Vidu-q2 model.
        /// When all images carry object ids, you can set the timbre id for the object. timbre list: https://shengshu.feishu.cn/sheets/EgFvs6DShhiEBStmjzccr5gonOg.
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "ReferenceType", this.ReferenceType);
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
        }
    }
}

