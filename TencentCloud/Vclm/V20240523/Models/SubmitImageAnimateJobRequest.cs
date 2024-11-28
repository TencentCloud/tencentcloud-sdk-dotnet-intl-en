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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitImageAnimateJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Image format: PNG, JPG, and JPEG formats are supported.
        /// Image resolution: The long edge resolution should not exceed 2056.
        /// Image size: The size should not exceed 10 MB.
        /// Image aspect ratio: The ratio of width to height should be in the range of 1:2 to 1:1.2.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Image information after Base64 encoding. Image format: PNG, JPG, and JPEG formats are supported. Image resolution: The long side resolution should not exceed 2056. Image size: The size should not exceed 10 MB. Image aspect ratio: The ratio of width to height should be in the range of 1:2 to 1:1.2.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// Action template ID. ke3: kemusan; tuziwu: rabbit dance; huajiangwu: paddling dance.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Whether the generated video retains the audio in the template. The default value is true.
        /// </summary>
        [JsonProperty("EnableAudio")]
        public bool? EnableAudio{ get; set; }

        /// <summary>
        /// Whether to detect 12 body parts in the input image (head, neck, right shoulder, right elbow, right wrist, left shoulder, left elbow, left wrist, right hip, left hip, left knee, and right knee). They are not detected by default.
        /// </summary>
        [JsonProperty("EnableBodyJoins")]
        public bool? EnableBodyJoins{ get; set; }

        /// <summary>
        /// Whether the final video retains the background of the original image. (This parameter does not take effect when TemplateId is set to tuziwu or huajiangwu.)
        /// </summary>
        [JsonProperty("EnableSegment")]
        public bool? EnableSegment{ get; set; }

        /// <summary>
        /// Whether to add a mark to the generated video. The default value is 0.
        /// 1: A mark is added.
        /// 0: No mark is added.
        /// Other values: A mark is added by default.
        /// It is recommended to use an obvious mark to indicate that the video is synthesized by AI.
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// Mark text settings.
        /// By default, the text "Synthesized by AI" is added to the bottom right corner of the generated video. You can also use other text images.
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "EnableAudio", this.EnableAudio);
            this.SetParamSimple(map, prefix + "EnableBodyJoins", this.EnableBodyJoins);
            this.SetParamSimple(map, prefix + "EnableSegment", this.EnableSegment);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
        }
    }
}

