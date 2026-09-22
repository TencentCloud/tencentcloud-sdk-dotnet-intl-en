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

    public class AigcVideoTaskInput : AbstractModel
    {
        
        /// <summary>
        /// <p>Model name.</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Model version.</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>Input file information for an AIGC video generation task.</p>
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcVideoTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// <p>Fixed subject input information for the AIGC task.</p>
        /// </summary>
        [JsonProperty("SubjectInfos")]
        public AigcVideoTaskInputSubjectInfo[] SubjectInfos{ get; set; }

        /// <summary>
        /// <p>Media file ID used as the tail frame to generate a video. This globally unique identifier of the file in VOD is assigned by the VOD backend after successful upload. You can obtain this field in the <a href="https://www.tencentcloud.com/document/product/266/7830?from_cn_redirect=1">video upload completion event notification</a> or the <a href="https://console.cloud.tencent.com/vod/media">VOD console</a>.</p>
        /// </summary>
        [JsonProperty("LastFrameFileId")]
        public string LastFrameFileId{ get; set; }

        /// <summary>
        /// <p>URL of the media file used as the last frame to generate video. Description:</p><ol><li>Only GV, Kling, and Vidu models are supported. Other models are not currently supported. When ModelName is GV, if you specify this parameter, you must also specify FileInfos as the first frame of the video to be generated. When ModelName is Kling, ModelVersion is 2.1, and the output resolution Resolution is 1080P, you can specify this parameter. When ModelName is Vidu and ModelVersion is q2-pro or q2-turbo, you can specify this parameter.</li><li>The image size must be less than 5M.</li><li><ol start="3"><li>The value of the image format is: jpeg, jpg, png, webp.</li></ol></li></ol>
        /// </summary>
        [JsonProperty("LastFrameUrl")]
        public string LastFrameUrl{ get; set; }

        /// <summary>
        /// <p>Prompt for video generation. Supports up to 1000 characters. This parameter is required when FileInfos is empty.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Prompt to prevent the model from generating video. Supports up to 1000 characters.</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>Whether to optimize Prompt content automatically. When Enabled, the passed-in Prompt will be optimized automatically to enhance generation quality. Valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li></p>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public string EnhancePrompt{ get; set; }

        /// <summary>
        /// <p>Generation mode. Valid values: <li>Standard: standard mode;</li> <li>Professional: high-quality mode;</li></p>
        /// </summary>
        [JsonProperty("GenerationMode")]
        public string GenerationMode{ get; set; }

        /// <summary>
        /// <p>Output result file output for AIGC image generation.</p>
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcVideoOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// <p>Region information of the input file. If the file url is a foreign address, selectable Oversea. Default: Mainland.</p>
        /// </summary>
        [JsonProperty("InputRegion")]
        public string InputRegion{ get; set; }

        /// <summary>
        /// <p>Scenario type. Values are as follows: <li>When ModelName is Kling, the value motion_control means action control;</li><li>Not currently supported for other ModelName.</li></p>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>Random seed of the model.</p>
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

        /// <summary>
        /// <p>Pass-through parameter.</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArrayObj(map, prefix + "SubjectInfos.", this.SubjectInfos);
            this.SetParamSimple(map, prefix + "LastFrameFileId", this.LastFrameFileId);
            this.SetParamSimple(map, prefix + "LastFrameUrl", this.LastFrameUrl);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamSimple(map, prefix + "GenerationMode", this.GenerationMode);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "InputRegion", this.InputRegion);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

