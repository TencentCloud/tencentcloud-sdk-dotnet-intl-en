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

    public class CreateAigcAudioTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Model name.</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Specify the model version number. By default, the system uses the supported stable version of the model.</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>Designated scenarios currently support sfx (sound effects).</p>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>Description of the generated audio</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Reference video info</p>
        /// </summary>
        [JsonProperty("VideoInfos")]
        public AigcAudioReferenceVideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// <p>Input the reference audio content.</p><p>For example, input is required for music generation.</p>
        /// </summary>
        [JsonProperty("AudioInfos")]
        public AigcAudioReferenceAudioInfo[] AudioInfos{ get; set; }

        /// <summary>
        /// <p>Output parameter</p>
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcAudioOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// <p>Special scenario parameters required by the model, formatted as a JSON serialized string.<br>Example:<br>{"camera_control":{"type":"simple"}}.</p>
        /// </summary>
        [JsonProperty("AdditionalParameters")]
        public string AdditionalParameters{ get; set; }


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
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
        }
    }
}

