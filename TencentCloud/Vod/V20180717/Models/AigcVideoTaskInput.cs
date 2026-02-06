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
        /// Model name.
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Model version. 
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// File information of the input video for the AIGC video generation task. 
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcVideoTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// The media file ID used as the end frame to generate video. 
        /// </summary>
        [JsonProperty("LastFrameFileId")]
        public string LastFrameFileId{ get; set; }

        /// <summary>
        /// Prompt content for video generation. 
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
        /// 
        /// </summary>
        [JsonProperty("GenerationMode")]
        public string GenerationMode{ get; set; }

        /// <summary>
        /// Specifies the output media file configuration for the video task.
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcVideoOutputConfig OutputConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "LastFrameFileId", this.LastFrameFileId);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamSimple(map, prefix + "GenerationMode", this.GenerationMode);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
        }
    }
}

