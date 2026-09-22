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
        /// <p><b>Video-on-demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services from December 25, 2023, this field must be filled in as the app ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Model name. Parameter Value:<br>Kling: Kling;<br>Vidu;<br>Hailuo: Hailuo;<br>Hunyuan: Hunyuan;<br>Mingmou: Mingmou;<br>GV;<br>OS;<br>PixVerse;</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Model version. Value: <br>When ModelName is Hailuo, available values are 02, 2.3, 2.3-fast, H3, H3_regen, and H3-Max; <br>When ModelName is Kling, available values are 1.6, 2.0, 2.1, 2.5, 2.6, O1, 3.0, 3.0-Omni, 3.0-turbo, and scene; <br>When ModelName is Vidu, available values are q2, q2-pro, q2-turbo, q3, q3-pro, q3-turbo, q3-mix, q3-drama, q3-ad, scene, avatar-q2-pro, avatar-q2-turbo, and lip-sync; <br>When ModelName is GV, available values are 3.1, 3.1-fast, 3.1-lite, and omni; <br>When ModelName is OS, available values are 2.0; <br>When ModelName is Hunyuan, available values are 1.5 and 3d_2.0; <br>When ModelName is Mingmou, available values are 1.0; <br>When ModelName is PixVerse, available values are v5.6, v6, and c1;</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>Used to describe the resource file to be used by the model when generating a video, divided into <strong>first and last frame mode, reference image/video/sound generation, video editing, and other modes</strong>.</p><p><strong>First and last frame video generation</strong>: <strong>The Usage field of the first frame image is FirstFrame, and the Usage field of the last frame image is LastFrame</strong>. One image is supported for each. The first frame can be passed in separately, but the last frame cannot be passed in separately. <strong>First and last frame generation uses the image ratio for reference</strong>.<br><strong>Reference image/video/sound generation</strong>: Single or multiple images/videos/sounds can be passed in as references, with the <strong>Usage field set to Reference</strong>. <strong>In reference mode, the display aspect ratio of the generated video can be adjusted</strong>.<br><strong>Video editing</strong>: Vidu and Kling can input a video for editing. Images can also be passed in along with the input video, with the <strong>Usage field of the image set to Reference</strong>.</p><p>Note:</p><ol><li>Image size cannot exceed 10M.</li><li>Supported image formats: jpeg, jpg, png. x0b</li><li>For whether a model version supports reference image/video/sound, first and last frame, video editing, and other features, you can request the document from us or refer to the original vendor's document information.</li></ol>
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcVideoTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// <p>Subject input information.</p>
        /// </summary>
        [JsonProperty("SubjectInfos")]
        public AigcVideoTaskInputSubjectInfo[] SubjectInfos{ get; set; }

        /// <summary>
        /// <p>Media file ID used as the last frame to generate a video. The globally unique identifier of the file on VOD, assigned by the VOD backend after successful upload. You can obtain this field in the <a href="https://www.tencentcloud.com/document/product/266/7830?from_cn_redirect=1">video upload completion event notification</a> or the <a href="https://console.cloud.tencent.com/vod/media">VOD console</a>.</p><ol><li>When specifying this parameter, you must also specify the first frame through FileInfos.</li><li>The image size must be less than 10M.</li><li>The image format values are: jpeg, jpg, png, webp.</li></ol>
        /// </summary>
        [JsonProperty("LastFrameFileId")]
        public string LastFrameFileId{ get; set; }

        /// <summary>
        /// <p>URL of the media file used as the last frame to generate video. Description:</p><ol><li>When you specify this parameter, specify the first frame via FileInfos at the same time.</li><li>Image size must be less than 5M.</li><li>Image format values: jpeg, jpg, png, webp.</li></ol>
        /// </summary>
        [JsonProperty("LastFrameUrl")]
        public string LastFrameUrl{ get; set; }

        /// <summary>
        /// <p>Prompt for video generation.<br>When no reference file is passed in, no scenario type is used, ExtInfo is not empty, Prompt is required.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Prompt to prevent the model from generating videos.</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>Whether to optimize Prompt content automatically. When Enabled, the passed-in Prompt will be optimized automatically to enhance generation quality. Valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li></p>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public string EnhancePrompt{ get; set; }

        /// <summary>
        /// <p>Configuration of the output media file for the video task.</p>
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcVideoOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// <p>Region information of the input file. Values are as follows:</p><ul><li>If the input file is stored overseas: Oversea;</li><li>If the input file is stored in the western United States: OverseaUSWest;</li><li>If the input file is stored in the Chinese mainland: Mainland.</li></ul><p>Default value: Mainland</p>
        /// </summary>
        [JsonProperty("InputRegion")]
        public string InputRegion{ get; set; }

        /// <summary>
        /// <p>Scenario type. Values are as follows:</p><li>When ModelName is Kling: motion_control means action control; avatar_i2v means digital human; lip_sync means lip-sync;</li><li>When ModelName is Vidu: template_effect means special effect template;</li><li>Other ModelName values are not currently supported.</li>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p><a href="https://www.tencentcloud.com/document/product/266/33475?from_cn_redirect=1#.E4.BB.BB.E5.8A.A1.E6.B5.81">Task flow name</a>. Fill in when you need to execute a task flow on the generated new video.</p>
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
        /// <p>Reserved field, used for special purposes.<br>Can be used to import special model parameters, storyboard prompts, etc.</p>
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

