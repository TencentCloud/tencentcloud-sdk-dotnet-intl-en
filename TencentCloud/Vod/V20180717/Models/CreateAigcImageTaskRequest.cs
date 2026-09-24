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

    public class CreateAigcImageTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services from December 25, 2023, this field must be set to the app ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Model name. Parameter Value:</p><li>OG</li><li>GG</li><li>Hunyuan</li><li>Vidu</li><li>Kling</li>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Model version. Value:</p><li>When ModelName is OG, optional values: image2_low, image2_medium, image2_high;</li><li>When ModelName is GG, optional values: 2.5, 3.0, 3.1, 3.1-lite;</li><li>When ModelName is Hunyuan, optional values: 3.0, 3d_2.0, 3.5-preview;</li><li>When ModelName is Vidu, optional values: q2;</li><li>When ModelName is Kling, optional values: 2.1, 3.0, 3.0-Omni, O1, scene;</li><li>When ModelName is Mingmou, optional values: 1.0;</li>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>File information of the input image for the AIGC image generation task. Maximum number of reference images supported by each model:</p><ul><li>GG 2.5: 3</li><li>GG 3.0: 14</li><li>GG 3.1: 14</li><li>Kling 2.1: 4</li><li>Kling 3.0: 1</li><li>Kling 3.0-Omni: 10</li><li>Kling O1: 10</li><li>Vidu q2: 7</li><li>Hunyuan 3.0: 3</li></ul>
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcImageTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// <p>Prompt for image generation. When FileInfos is empty, this parameter is required.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Prompt to prevent the model from image generation.</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>Whether to optimize Prompt content automatically. When Enabled, the passed in Prompt content will be optimized automatically to enhance generation quality. Valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li></p>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public string EnhancePrompt{ get; set; }

        /// <summary>
        /// <p>Output media file configuration for an image generation task.</p>
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcImageOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// <p>Input region information. Available values:</p><ul><li>Mainland: Chinese mainland;</li><li>Oversea: overseas;</li><li>OverseaUSWest: overseas - western United States;</li></ul>
        /// </summary>
        [JsonProperty("InputRegion")]
        public string InputRegion{ get; set; }

        /// <summary>
        /// <p>Scenario type. Values are as follows:</p><li>When ModelName is Hunyuan: 3d_panorama refers to panoramic view;</li><li>When ModelName is Kling: image_expand refers to image expansion;</li><li>Other ModelName values are not currently supported.</li>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>Random seed of the model.</p>
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass user request information. The audio and video quality revival completion callback returns the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Task priority. The higher the value, the higher the priority. The value range is from -10 to 10. If this is not specified, the default value is 0.</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// <p>Reserved field for special usage.</p><ul><li><p>Hunyuan 3.0</p><ul><li>Support setting resolution width and height freely. Both width and height are in the range of [512, 2048] pixels, and the product of width and height <= 1024x1024 pixels. Example: <code>{"AdditionalParameters": "{\"size\":\"728x1024\"}"}</code></li></ul></li><li><p>OG</p><ul><li>Support setting resolution width and height freely:<ul><li>Calculate the pixel size, which must be divisible by 16</li><li>The total pixels must be at least 655,360 and should not exceed 8,294,400</li><li>Example: <code>{"AdditionalParameters": "{\"size\":\"728x1024\"}"}</code></li></ul></li><li>Support setting a transparent layer:<ul><li>Example: <code>{"AdditionalParameters": "{\"background\":\"transparent\"}"}</code></li></ul></li></ul></li><li><p>Kling</p><ul><li>Support setting expansion parameters. Example: <code>{"AdditionalParameters":"{\"down_expansion_ratio\":0.2,\"left_expansion_ratio\":0.3,\"right_expansion_ratio\":0.4,\"up_expansion_ratio\":0.1}}</code><ul><li>Common constraints:<ul><li>Value range: [0, 2];</li><li>The overall area of the new image should not exceed 3 times that of the original image;</li><li>Forward Prompt content can be input through the <code>Prompt</code> field.</li><li>Example description:<ul><li>up_expansion_ratio: expand upward, calculated based on a multiple of the original image height. If the original image height is 20 and the parameter value is 0.1, the distance from the top edge of the original image to the top edge of the new image is 20 x 0.1 = 2. This region is the expansion range.</li><li>down_expansion_ratio: expand downward, calculated based on a multiple of the original image height. If the original image height is 20 and the parameter value is 0.2, the distance from the bottom edge of the original image to the bottom edge of the new image is 20 x 0.2 = 4. This region is the expansion range.</li><li>left_expansion_ratio: expand to the left, calculated based on a multiple of the original image width. If the original image width is 30 and the parameter value is 0.3, the distance from the left edge of the original image to the left edge of the new image is 30 x 0.3 = 9. This region is the expansion range.</li><li>right_expansion_ratio: expand to the right, calculated based on a multiple of the original image width. If the original image width is 30 and the parameter value is 0.4, the distance from the right edge of the original image to the right edge of the new image is 30 x 0.4 = 12. This region is the expansion range.</li></ul></li></ul></li></ul></li></ul></li></ul>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "InputRegion", this.InputRegion);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

