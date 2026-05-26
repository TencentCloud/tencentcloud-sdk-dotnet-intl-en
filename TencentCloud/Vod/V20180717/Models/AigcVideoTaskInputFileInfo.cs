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
        /// <p>Input video file type. Valid values: <li>File: On-demand media file;</li> <li>Url: Accessible URL;</li></p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>File category. Value is:</p><ul><li>Image: image. <strong>Note that the Usage field defines the image type.</strong></li><li>Video: video.</li></ul>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>Media file ID, the globally unique identifier of the file in VOD, is assigned by the VOD backend after successful upload. You can obtain this field in the <a href="/document/product/266/7830?from_cn_redirect=1">video upload completion event notification</a> or the <a href="https://console.cloud.tencent.com/vod/media">VOD console</a>. This parameter is valid when the Type value is File. Description:</p><ol><li>Images less than 10M are recommended;</li><li>Image format values: jpeg, jpg, png.</li></ol>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Accessible file URL. This parameter is valid when the Type value is URL.<br>Description:</p><ol><li>Images less than 10M are recommended.</li><li>Image format values: jpeg, jpg, png.</li></ol>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Base64")]
        public string Base64{ get; set; }

        /// <summary>
        /// <p>Reference Type, applicable to GV, Kling, and PixVerse models.<br>Note:<br>When using the GV model, it can be used as a reference method, available values: asset means material, style means style;<br>When using the Kling model and Category is Video, distinct reference video types can be identified, feature means feature reference video, base means video to be edited;<br>When using the PixVerse model, applicable to multi-image (subject) reference generation mode, available values: subject means subject, background means background;</p>
        /// </summary>
        [JsonProperty("ReferenceType")]
        public string ReferenceType{ get; set; }

        /// <summary>
        /// <p>Usage: Vidu subject Id.<br>Vidu subject Id: prompt can be used via @subject Id. Valid at that time when Category is Image.</p>
        /// </summary>
        [JsonProperty("ObjectId")]
        public string ObjectId{ get; set; }

        /// <summary>
        /// <p>Suitable for the Vidu-q2 model.<br>When all images carry the subject Id, you can set the timbre Id targeting the subject. Valid when Category is Image. Supported timbre list: https://shengshu.feishu.cn/sheets/EgFvs6DShhiEBStmjzccr5gonOg</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>Whether to retain the original sound of the video. Valid when Category is Video. Values are as follows:</p><li>Enabled: Retain</li><li>Disabled: Not retain</li>
        /// </summary>
        [JsonProperty("KeepOriginalSound")]
        public string KeepOriginalSound{ get; set; }

        /// <summary>
        /// <p>Used to distinguish whether the input image is for <strong>first (last) frame to video</strong>, <strong>image to video</strong>, or <strong>reference to video</strong>. Available values:</p><ul><li>FirstFrame: For first (last) frame to video or image to video;</li><li>Reference: For reference to video;</li></ul><p><strong>Note: FirstFrame is selected by default</strong></p>
        /// </summary>
        [JsonProperty("Usage")]
        public string Usage{ get; set; }

        /// <summary>
        /// <p><strong>Only the multi-image (subject) reference mode of the PixVerse model takes effect</strong>. Specify a name for the image to achieve more precise results. Usage: When the field value is "kitten", use @kitten in the Prompt to accurately describe the scenario. There must be a space after @Text, for example, @kitten run. The name referenced in the Prompt must be the same as the field value.</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Base64", this.Base64);
            this.SetParamSimple(map, prefix + "ReferenceType", this.ReferenceType);
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "KeepOriginalSound", this.KeepOriginalSound);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "Text", this.Text);
        }
    }
}

