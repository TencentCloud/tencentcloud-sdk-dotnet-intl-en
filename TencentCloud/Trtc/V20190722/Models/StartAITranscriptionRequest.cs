/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// TRTC's [SdkAppId](https://cloud.tencent.com/document/product/647/46351#sdkappid) is the same as the SdkAppId used by the room that starts the transcription task.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// TRTC's [RoomId](https://cloud.tencent.com/document/product/647/46351#roomid), which indicates the room number where the transcription task is started.
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// Parameters of the transcription robot.
        /// </summary>
        [JsonProperty("TranscriptionParams")]
        public TranscriptionParams TranscriptionParams{ get; set; }

        /// <summary>
        /// The unique ID passed by the caller is used by the server to deduplicate. Note: If this parameter is passed, the server will use it first to deduplicate. If this parameter is not passed, the server's deduplication strategy is as follows: 
        /// - If the TranscriptionMode field is 0, only one task can be opened in a room
        /// - If the TranscriptionMode field is 1, only one task can be opened in a TargetUserId
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// The type of TRTC room number. 0 represents a numeric room number, and 1 represents a string room number. If not filled in, the default is a numeric room number.
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// Speech recognition configuration.
        /// </summary>
        [JsonProperty("RecognizeConfig")]
        public RecognizeConfig RecognizeConfig{ get; set; }


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
        }
    }
}

