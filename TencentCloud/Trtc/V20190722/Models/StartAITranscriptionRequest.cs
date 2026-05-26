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

    public class StartAITranscriptionRequest : AbstractModel
    {
        
        /// <summary>
        /// [SdkAppId](https://www.tencentcloud.com/document/product/647/46351?from_cn_redirect=1#SdkAppId) of TRTC, which is the same as the SdkAppId used by the room with transcription task enabled.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// [RoomId](https://www.tencentcloud.com/document/product/647/46351?from_cn_redirect=1#RoomId) of TRTC refers to the room number that enables the transcription task.
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// Transcription robot parameters.
        /// </summary>
        [JsonProperty("TranscriptionParams")]
        public TranscriptionParams TranscriptionParams{ get; set; }

        /// <summary>
        /// Unique Id passed by the caller, used by the server for task deduplication. duplicate tasks will fail to initiate. the server uses SdkAppId+RoomId+RoomIdType+RobotUserId for deduplication by default. if SessionId is provided, it will also be used for deduplication.
        /// Note:.
        /// When TranscriptionMode is 0, ensure only one task is initiated in a room. if multiple tasks are initiated, robots will subscribe to each other. unless the task is stopped proactively, it will timeout exit after 10 hours. in such cases, it is advisable to fill in SessionId to ensure subsequent repeated tasks fail.
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
        [JsonProperty("RecognizeConfig")]
        public RecognizeConfig RecognizeConfig{ get; set; }

        /// <summary>
        /// Translate configuration details.
        /// </summary>
        [JsonProperty("TranslationConfig")]
        public TranslationConfig TranslationConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamObj(map, prefix + "TranscriptionParams.", this.TranscriptionParams);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamObj(map, prefix + "RecognizeConfig.", this.RecognizeConfig);
            this.SetParamObj(map, prefix + "TranslationConfig.", this.TranslationConfig);
        }
    }
}

