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
        /// <p>Model name. Supported models for music generation: GL and MiniMaxMusic.</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Specifies the model version. By default, the system uses the supported stable version of the model.<br>Supported versions for GL: 3.0-clip and 3.0-pro.<br>Supported versions for MinimaxMusic: 2.0, 2.5, and 2.6.</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>Specifies the scenario for audio generation. Music: music.</p>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>Description of the generated video. (Note: A maximum of 2000 characters is supported.) This parameter is required when no reference image is specified.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Reference video information, which is supported by some models.</p>
        /// </summary>
        [JsonProperty("VideoInfos")]
        public AigcAudioReferenceVideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// <p>Specify the reference audio information.</p><p>For example, this is required for music generation.</p>
        /// </summary>
        [JsonProperty("AudioInfos")]
        public AigcAudioReferenceAudioInfo[] AudioInfos{ get; set; }

        /// <summary>
        /// <p>Output audio format. By default, this is not specified. Valid values: mp3 and wav.</p>
        /// </summary>
        [JsonProperty("OutputAudioFormat")]
        public string OutputAudioFormat{ get; set; }

        /// <summary>
        /// <p>COS bucket information for the file result. Note: COS is required and the MPS_QcsRole role needs to be created and authorized.</p>
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public AigcStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// <p>Additional parameters required.</p>
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public AigcAudioExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// <p>This is used to specify special scenario parameters required by the model, in the format of a serialized JSON string.<br>Example to specify lyrics for the MinimaxMusic model:<br>{"lyric":{"The pony is running with joy. The flowers are blooming."}}</p>
        /// </summary>
        [JsonProperty("AdditionalParameters")]
        public string AdditionalParameters{ get; set; }

        /// <summary>
        /// <p>API operator name.</p>
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

