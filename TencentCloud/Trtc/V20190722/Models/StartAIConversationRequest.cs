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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartAIConversationRequest : AbstractModel
    {
        
        /// <summary>
        /// [SdkAppId](https://www.tencentcloud.com/document/product/647/46351?from_cn_redirect=1#SdkAppId) of TRTC, which is the same as the SdkAppId used by the room with transcription task enabled.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// [RoomId](https://www.tencentcloud.com/document/product/647/46351?from_cn_redirect=1#RoomId) of TRTC refers to the room number that enables the conversation task.
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// Bot parameters.
        /// </summary>
        [JsonProperty("AgentConfig")]
        public AgentConfig AgentConfig{ get; set; }

        /// <summary>
        /// The unique Id passed by the caller can be used to prevent duplication of task initiation on the client side as well as query task status through this field.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Type of the TRTC room number. 0 indicates digit room number, 1 indicates string room number. by default if left blank, it is digit room number.
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// Speech recognition configuration.
        /// </summary>
        [JsonProperty("STTConfig")]
        public STTConfig STTConfig{ get; set; }

        /// <summary>
        /// Required parameter, LLM configuration. it must comply with the openai standard and be a JSON String. example: <pre> { <br> &emsp;  "LLMType": "Model type",  // String required, for example: "openai" <br> &emsp;  "Model": "your Model name", // String required, specifies the Model to be used<br>    "APIKey": "your LLM API key", // String required <br> &emsp;  "APIUrl": "https://API.xxx.com/chat/completions", // String required, the URL for LLM API access<br> &emsp;  "History": 10, // Integer optional, sets the context rounds for LLM, default value is 0, maximum value is 50<br> &emsp;  "HistoryMode": 1, // Integer optional, 1 means the content in the LLM context will synchronize with playback audio, and text corresponding to unplayed audio will not appear in the context. 0 means no synchronization, default value is 0<br> &emsp;  "Streaming": true // Boolean optional, whether to use Streaming<br> &emsp;} </pre>.
        /// </summary>
        [JsonProperty("LLMConfig")]
        public string LLMConfig{ get; set; }

        /// <summary>
        /// Required parameter, TTS configuration. it is a JSON string: TRTC TTS configuration as follows:.  
        /// <pre> { <br> &emsp;  "TTSType": "flow",  // [required] fixed to this value.  <br> &emsp;  "VoiceId": "v-female-R2s4N9qJ", // [required] premium timbre ID/clone voice ID. selectable different timbres. refer to the following timbre list for ID library.   <br> &emsp;  "Model": "flow_01_turbo", // (required) current default TTS Model version (corresponds to Flash version).  <br> &emsp;  "Speed": 1.0,    // [option] adjust the speaking rate. value range [0.5-2.0]. default 1.0. the larger the value, the faster the speech speed. <br> &emsp;  "Volume": 1.0,   // [optional] adjust volume [0,10]. default: 1.0. a larger value indicates higher volume.   <br> &emsp;  "Pitch": 0,   // [optional] adjusts the tone [-12,12]. default value is 0. among them, 0 outputs the original voice type. <br> &emsp;  "Language": "zh" // [optional] recommend filling in. currently supports filling in chinese: zh, english: en, cantonese dialect: yue. parameter reference: (ISO 639-1). <br> &emsp;} </pre>
        /// </summary>
        [JsonProperty("TTSConfig")]
        public string TTSConfig{ get; set; }

        /// <summary>
        /// Experimental parameter, contact for background usage.
        /// </summary>
        [JsonProperty("ExperimentalParams")]
        public string ExperimentalParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamObj(map, prefix + "AgentConfig.", this.AgentConfig);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamObj(map, prefix + "STTConfig.", this.STTConfig);
            this.SetParamSimple(map, prefix + "LLMConfig", this.LLMConfig);
            this.SetParamSimple(map, prefix + "TTSConfig", this.TTSConfig);
            this.SetParamSimple(map, prefix + "ExperimentalParams", this.ExperimentalParams);
        }
    }
}

