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
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Model name. valid values: <li>Hailuo: conch;</li><li>Kling: Kling;</li><li>Jimeng: Jimeng;</li><li>Vidu;</li><li>Hunyuan: Hunyuan;</li><li>Mingmou: bright eyes;</li>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Model version. parameter value: <li>when ModelName is Hailuo, optional values are 02, 2.3, 2.3-fast;</li><li>when ModelName is Kling, optional values are 1.6, 2.0, 2.1, 2.5, O1;</li><li>when ModelName is Jimeng, optional values are 3.0pro;</li><li>when ModelName is Vidu, optional values are q2, q2-pro, q2-turbo;</li><li>when ModelName is GV, optional values are 3.1, 3.1-fast;</li><li>when ModelName is OS, optional values are 2.0;</li><li>when ModelName is Hunyuan, optional values are 1.5;</li><li>when ModelName is Mingmou, optional values are 1.0;</li>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// List of up to three material resources for description of resource images to be used by the model in video generation.
        /// 
        /// Video generation with first and last frame: use the first table in FileInfos to represent the first frame (FileInfos contains at most one image at this point). LastFrameFileId or LastFrameUrl represents the last frame.
        /// 
        /// Model supporting multi-image input.
        /// 1. GV, when entering multiple images, LastFrameFileId and LastFrameUrl are unavailable.
        /// 2. Vidu supports multi-image reference for video generation. the q2 model accepts 1-7 images. use the ObjectId in FileInfos as the subject id for input.
        /// 
        /// Note:.
        /// 1. Image size: the size should not exceed 10 mb.
        /// 2. supported image formats: jpeg, png.
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcVideoTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// The media file ID used as the end frame to generate video. this file has a globally unique ID on vod, assigned by the vod backend after successful upload. you can get this field in the [video upload completion event notification](https://www.tencentcloud.com/document/product/266/7830?from_cn_redirect=1) or [vod console](https://console.cloud.tencent.com/vod/media). description:.
        /// 1. only models GV, Kling, and Vidu are supported. other models are not currently supported. when ModelName is GV, if you specify this parameter, you must simultaneously specify FileInfos as the first frame of the video to be generated. when ModelName is Kling and ModelVersion is 2.1 and specify output Resolution Resolution as 1080P, you can specify this parameter. when ModelName is Vidu and ModelVersion is q2-pro or q2-turbo, you can specify this parameter.
        /// 2. Image size: the size should be less than 5 mb.
        /// 3. image format value is jpeg, jpg, png, webp.
        /// </summary>
        [JsonProperty("LastFrameFileId")]
        public string LastFrameFileId{ get; set; }

        /// <summary>
        /// Media file URL used as frames to generate video. description:.
        /// 1. only models GV, Kling, and Vidu are supported. other models are not currently supported. when ModelName is GV, if you specify this parameter, you must simultaneously specify FileInfos as the first frame of the video to be generated. when ModelName is Kling and ModelVersion is 2.1 and specify output Resolution Resolution as 1080P, you can specify this parameter. when ModelName is Vidu and ModelVersion is q2-pro or q2-turbo, you can specify this parameter.
        /// 2. Image size: the size should be less than 5 mb.
        /// 3. image format value is jpeg, jpg, png, webp.
        /// </summary>
        [JsonProperty("LastFrameUrl")]
        public string LastFrameUrl{ get; set; }

        /// <summary>
        /// Prompt content for video generation. this parameter is required when FileInfos is empty.
        /// Example value: move the picture.
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// Prevent the model from generating video prompts.
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// Whether to optimize Prompt content automatically. when Enabled, the passed-in Prompt will be optimized automatically to enhance generation quality. valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li>.
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public string EnhancePrompt{ get; set; }

        /// <summary>
        /// Specifies the output media file configuration for the video task.
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcVideoOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// An identifier for deduplication. if there has been a request with the same identifier within the past 3 days, an error will be returned for the current request. the maximum length is 50 characters. leaving it blank or using an empty string indicates no deduplication.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Source context, used to pass through user request information. the audio and video quality revival complete callback will return the value of this field, up to 1000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Task priority. the higher the value, the higher the priority. the value range is from -10 to 10. if left blank, the default value is 0.
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// Reserved field, used for special purpose.
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

        /// <summary>
        /// Specifies the region information of the input image. when the image url is a foreign address, selectable Oversea. default Mainland.
        /// </summary>
        [JsonProperty("InputRegion")]
        public string InputRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "LastFrameFileId", this.LastFrameFileId);
            this.SetParamSimple(map, prefix + "LastFrameUrl", this.LastFrameUrl);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamSimple(map, prefix + "InputRegion", this.InputRegion);
        }
    }
}

