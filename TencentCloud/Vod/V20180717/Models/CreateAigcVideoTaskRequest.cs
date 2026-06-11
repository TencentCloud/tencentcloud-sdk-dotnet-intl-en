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

    public class CreateAigcVideoTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>VOD <a href="/document/product/266/14574?from_cn_redirect=1">application</a> ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether it is the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Model name. Parameter Value:<br>Kling: Keling;<br>Vidu;<br>Hailuo: Hailuo;<br>Hunyuan: Hunyuan;<br>Mingmou: Mingmou;<br>GV;<br>OS;<br>PixVerse;</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Model version. Parameter value:<br>When ModelName is Hailuo, optional values are 02, 2.3, and 2.3-fast.<br>When ModelName is Kling, optional values are 1.6, 2.0, 2.1, 2.5, 2.6, O1, 3.0, and 3.0-Omni.<br>When ModelName is Vidu, optional values are q2, q2-pro, q2-turbo, q3, q3-pro, and q3-turbo.<br>When ModelName is GV, optional values are 3.1 and 3.1-fast.<br>When ModelName is OS, optional value is 2.0.<br>When ModelName is Hunyuan, optional value is 1.5.<br>When ModelName is Mingmou, optional value is 1.0.<br>When ModelName is PixVerse, optional values are v5.6, v6, and c1.</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>Describes the resource file to be used by the model for video generation, divided into <strong>first and last frame mode, reference image, video reference, video editing, and other modes</strong>.</p><p><strong>First and last frame video generation</strong>: The first frame supports only a <strong>single image</strong>, with the <strong>Usage field of the image set to FirstFrame</strong>. LastFrameFileId or LastFrameUrl represents the last frame. The first frame can be imported separately, but the last frame cannot. <strong>First and last frame generation refers to the image aspect ratio</strong>.<br><strong>Reference image generation</strong>: Allows input of a single image or multiple images, with the <strong>Usage field of the image set to Reference</strong>. Reference images can adjust the aspect ratio of the generated video.<br><strong>Video editing and video reference</strong>: Vidu and Kling can input a video as a reference or proceed with editing. Images can also be imported along with the video, with the <strong>Usage field of the image set to Reference</strong>.</p><p>Note:</p><ol><li>Image size should be no more than 10M.</li><li>Supported image formats: jpeg, jpg, png. x0b</li><li>To check whether a specific model version supports reference images, first and last frames, video editing, and other features, request the document from us or refer to the original document information.</li></ol>
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcVideoTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// <p>Subject input information.</p>
        /// </summary>
        [JsonProperty("SubjectInfos")]
        public AigcVideoTaskInputSubjectInfo[] SubjectInfos{ get; set; }

        /// <summary>
        /// <p>Media file ID used as the last frame to generate video. This file's globally unique ID on VOD is assigned by the VOD backend after successful upload. You can retrieve this field in the <a href="https://www.tencentcloud.com/document/product/266/33950">video upload completion event notification</a> or the <a href="https://console.cloud.tencent.com/vod/media">VOD console</a>.</p><ol><li>When specifying this parameter, you must simultaneously designate the first frame via FileInfos.</li><li>Image size must be less than 10M.</li><li>Image format value is: jpeg, jpg, png, webp.</li></ol>
        /// </summary>
        [JsonProperty("LastFrameFileId")]
        public string LastFrameFileId{ get; set; }

        /// <summary>
        /// <p>URL of the media file used as the last frame to generate video. Description:</p><ol><li>When you specify this parameter, you must also specify the first frame through FileInfos.</li><li>Image size must be less than 5M.</li><li>Image format value is: jpeg, jpg, png, webp.</li></ol>
        /// </summary>
        [JsonProperty("LastFrameUrl")]
        public string LastFrameUrl{ get; set; }

        /// <summary>
        /// <p>Prompt for video generation.<br>When no reference file is passed in, no usage scenario is specified, ExtInfo is not empty, Prompt is required.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>To prevent the model from generating video prompts.</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>Whether to optimize Prompt content automatically. When Enabled, the passed in Prompt will be optimized automatically to enhance generation quality. Valid values: <li>Enabled: Enable;</li> <li>Disabled: Disable;</li></p>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public string EnhancePrompt{ get; set; }

        /// <summary>
        /// <p>Output media file configuration for the video generation task.</p>
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcVideoOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// <p>Region information of the input file. When the file url is an overseas address, selectable Oversea. Default Mainland.</p>
        /// </summary>
        [JsonProperty("InputRegion")]
        public string InputRegion{ get; set; }

        /// <summary>
        /// <p>Scenario type. Values are as follows:</p><li>When ModelName is Kling: motion_control means action control; avatar_i2v means digital human; lip_sync means lip-sync;</li><li>When ModelName is Vidu: template_effect means special effect Template;</li><li>Other ModelNames are not currently supported.</li>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p><a href="https://www.tencentcloud.com/document/product/266/33475?from_cn_redirect=1#.E4.BB.BB.E5.8A.A1.E6.B5.81">Task flow name</a>. Fill in when you need to execute task flow for the generated new video.</p>
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

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
        /// <p>Source context. This is used to pass through user request information. The audio and video quality revival complete callback returns the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Task priority. The higher the value, the higher the priority. The value range is from -10 to 10. If this is not specified, the default value is 0.</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// <p>Reserved field, used when special purpose.<br>Can be used to input special parameters and storyboard prompts to the model.</p>
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
            this.SetParamArrayObj(map, prefix + "SubjectInfos.", this.SubjectInfos);
            this.SetParamSimple(map, prefix + "LastFrameFileId", this.LastFrameFileId);
            this.SetParamSimple(map, prefix + "LastFrameUrl", this.LastFrameUrl);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "InputRegion", this.InputRegion);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "Procedure", this.Procedure);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

