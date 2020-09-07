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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartOnlineRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// SdkAppId of the customer
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// ID of the room for recording. Value range: (1, 4294967295)
        /// </summary>
        [JsonProperty("RoomId")]
        public long? RoomId{ get; set; }

        /// <summary>
        /// User ID used by the real-time recording service for entering a room. Its format is `tic_record_user_${RoomId}_${Random}`, where `${RoomId}` indicates the ID of the room for recording and `${Random}` is a random string.
        /// The ID must be an unused ID in the SDK. The real-time recording service uses the user ID to enter the room for audio, video, and whiteboard recording. If this ID is already used in the SDK, the SDK and recording service will conflict, affecting the recording operation.
        /// </summary>
        [JsonProperty("RecordUserId")]
        public string RecordUserId{ get; set; }

        /// <summary>
        /// Signature corresponding to RecordUserId
        /// </summary>
        [JsonProperty("RecordUserSig")]
        public string RecordUserSig{ get; set; }

        /// <summary>
        /// (Disused) IM group ID of the whiteboard. By default, it is the same as the room ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Real-time recording video splicing parameter
        /// </summary>
        [JsonProperty("Concat")]
        public Concat Concat{ get; set; }

        /// <summary>
        /// Real-time recording whiteboard parameter, such as the whiteboard width and height
        /// </summary>
        [JsonProperty("Whiteboard")]
        public Whiteboard Whiteboard{ get; set; }

        /// <summary>
        /// Real-time recording stream mixing parameter
        /// Notes:
        /// 1. The stream mixing feature needs to be enabled separately. If you need the feature, contact TIW customer service.
        /// 2. To use the stream mixing feature, the Extras parameter is required and must contain "MIX_STREAM".
        /// </summary>
        [JsonProperty("MixStream")]
        public MixStream MixStream{ get; set; }

        /// <summary>
        /// List of advanced features used
        /// List of possible values:
        /// MIX_STREAM - Stream mixing feature
        /// </summary>
        [JsonProperty("Extras")]
        public string[] Extras{ get; set; }

        /// <summary>
        /// Whether to return the audio-only recording file of different streams in the result callback. The file format is mp3.
        /// </summary>
        [JsonProperty("AudioFileNeeded")]
        public bool? AudioFileNeeded{ get; set; }

        /// <summary>
        /// A group of real-time recording parameters. It specifies the streams to be recorded, whether to disable the audio recording, and whether to record only low-resolution videos, etc.
        /// </summary>
        [JsonProperty("RecordControl")]
        public RecordControl RecordControl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "RecordUserId", this.RecordUserId);
            this.SetParamSimple(map, prefix + "RecordUserSig", this.RecordUserSig);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamObj(map, prefix + "Concat.", this.Concat);
            this.SetParamObj(map, prefix + "Whiteboard.", this.Whiteboard);
            this.SetParamObj(map, prefix + "MixStream.", this.MixStream);
            this.SetParamArraySimple(map, prefix + "Extras.", this.Extras);
            this.SetParamSimple(map, prefix + "AudioFileNeeded", this.AudioFileNeeded);
            this.SetParamObj(map, prefix + "RecordControl.", this.RecordControl);
        }
    }
}

