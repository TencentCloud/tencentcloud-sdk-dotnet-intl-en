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
        /// <p>Model name. Supported models for music generation: GL, MiniMaxMusic, EL, and Mureka.</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Specifies the model version. By default, the system uses the supported stable version of the model. Supported versions for GL: 3.0-clip and 3.0-pro. Supported versions for MiniMaxMusic: 2.0, 2.5, 2.6, and 3.0. Supported versions for EL: compose_v2 and sound_t2s_v2. Supported versions for Mureka: song_8, song_9, song_9.5, instrumental_8, instrumental_9, and instrumental_9.5.</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>Description of the generated music. (Note: supports up to 2,000 characters).</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Reference video information. Only partially supported by some models.</p><ol><li>Kling generates sound effects for videos.</li><li>EL adds background music to videos.</li></ol>
        /// </summary>
        [JsonProperty("VideoInfos")]
        public AigcAudioReferenceVideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// <p>Specify the reference audio information.</p><ol><li>Use of the cover feature in MiniMaxMusic.</li></ol><p>For example, this is required for music generation.</p>
        /// </summary>
        [JsonProperty("AudioInfos")]
        public AigcAudioReferenceAudioInfo[] AudioInfos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public AigcStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public AigcAudioExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// <p>Used to pass in some special scene parameters required by the model, serialized into strings in Json format. <br>Example MinimaxMusic model When lyrics are passed in:<br> {"lyric":{"ponies are running happily, flowers are blooming"}}</p><ol><li>MiniMaxMusic raw pure music parameters use example:&quot; AdditionalParameters&quot;:&quot; {"is_instrumental":true}&quot;. <br>Supported transparent transmission parameters are: lyrics, is_instrumental, aigc_watermark, sample_rate, bitrate. </li><li>EL Health Music supports transparent transmission parameters:<br> PromptInfluence, WithTimestamps, CompositionPlan, ForceInstrumental and other parameters. </li></ol>
        /// </summary>
        [JsonProperty("AdditionalParameters")]
        public string AdditionalParameters{ get; set; }

        /// <summary>
        /// 
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
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamObj(map, prefix + "ExtraParameters.", this.ExtraParameters);
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

