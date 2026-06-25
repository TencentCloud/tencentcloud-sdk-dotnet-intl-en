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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAigcAudioTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Model name. Currently supported models for music generation: GL, MinimaxMusic.Example value: MiniMaxMusic
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Specifies the model version. By default, the system uses the supported stable version of the model.Supported versions for GL: 2.0, 3.0-clip, 3.0-pro.Supported versions for MinimaxMusic: 2.0, 2.5, 2.6.Example value: 2.0
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// Specifies the audio generation scene. Music: music.Example value: music
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// Description of the generated audio. (Note: Supports up to 2000 characters.) This parameter is required when no reference image is passed in.Example value: generate a piece of music
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// Reference video information. Only supported by certain models.
        /// </summary>
        [JsonProperty("VideoInfos")]
        public AigcAudioReferenceVideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// Reference audio information.For example, this parameter is required when generating music from a reference audio.
        /// </summary>
        [JsonProperty("AudioInfos")]
        public AigcAudioReferenceAudioInfo[] AudioInfos{ get; set; }

        /// <summary>
        /// Output audio format. Empty by default. Supported values: mp3, wav.Example value: wav
        /// </summary>
        [JsonProperty("OutputAudioFormat")]
        public string OutputAudioFormat{ get; set; }

        /// <summary>
        /// COS bucket information for the file result. Note: COS is required and the MPS_QcsRole role needs to be created and authorized.
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public AigcStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// Additional parameters required for the model.
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public AigcAudioExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// Used to input some special scene parameters required by the model, serialized into a string in JSON format.Example: when passing lyrics to the MinimaxMusic model:{"lyric":{"The pony runs happily, flowers are blooming"}}Example value: {"sequential_image_generation":"auto"}
        /// </summary>
        [JsonProperty("AdditionalParameters")]
        public string AdditionalParameters{ get; set; }

        /// <summary>
        /// API operator name.Example value: admin
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamArrayObj(map, prefix + "VideoInfos.", this.VideoInfos);
            this.SetParamArrayObj(map, prefix + "AudioInfos.", this.AudioInfos);
            this.SetParamSimple(map, prefix + "OutputAudioFormat", this.OutputAudioFormat);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamObj(map, prefix + "ExtraParameters.", this.ExtraParameters);
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

