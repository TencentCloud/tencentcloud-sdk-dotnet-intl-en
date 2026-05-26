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

    public class TranscriptionParams : AbstractModel
    {
        
        /// <summary>
        /// The transcription robot's UserId is used to enter the room and trigger a transcription task. note that this UserId cannot be the same as the host or audience [UserId](https://www.tencentcloud.com/document/product/647/46351?from_cn_redirect=1#UserId) in the current room. if multiple transcription tasks are initiated in a room, the robot's UserId must also be unique to avoid interrupting the previous task. ensure the transcription robot's UserId is unique in the room.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Verification signature corresponding to the transcription bot's UserId, namely, the UserId and UserSig serve as the login password for the transcription bot to enter the room. for specific calculation methods, see TRTC solution for calculating.
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// After all push users exit the room and exceed MaxIdleTime seconds, the backend automation shuts down the transcription task. default value is 60s.
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// 1 means the robot subscribes to the stream of an individual, and 0 means the robot subscribes to the stream of the entire room. if left empty, it defaults to subscribing to the stream of the entire room.
        /// </summary>
        [JsonProperty("TranscriptionMode")]
        public ulong? TranscriptionMode{ get; set; }

        /// <summary>
        /// Required when TranscriptionMode is 1, the robot only pulls streams from this userid and ignores other users in the room.
        /// </summary>
        [JsonProperty("TargetUserId")]
        public string TargetUserId{ get; set; }

        /// <summary>
        /// Voiceprint configuration.
        /// </summary>
        [JsonProperty("VoicePrint")]
        public VoicePrint VoicePrint{ get; set; }

        /// <summary>
        /// Semantic sentence segmentation detection.
        /// </summary>
        [JsonProperty("TurnDetection")]
        public TurnDetection TurnDetection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "TranscriptionMode", this.TranscriptionMode);
            this.SetParamSimple(map, prefix + "TargetUserId", this.TargetUserId);
            this.SetParamObj(map, prefix + "VoicePrint.", this.VoicePrint);
            this.SetParamObj(map, prefix + "TurnDetection.", this.TurnDetection);
        }
    }
}

