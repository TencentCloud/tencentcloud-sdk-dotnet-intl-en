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

    public class TranscriptionParam : AbstractModel
    {
        
        /// <summary>
        /// [UserId](https://www.tencentcloud.com/document/product/647/46351?from_cn_redirect=1#userid) used by the transcription service in the TRTC room. Note that this userId cannot duplicate those already used by other TRTC or transcription services etc. You may use the room ID as part of the user identification.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// User signature for the transcription service to join a TRTC room. The signature verification corresponding to the current UserId serves as the login password. For specific details, see TRTC solution for calculating [UserSig](https://www.tencentcloud.com/document/product/647/45910?from_cn_redirect=1#UserSig).
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// Allowlist of user IDs whose audio will be transcribed.
        /// Specifies which anchor audio streams to transcribe when the service starts. If left empty or omitted, audio from all anchors will be transcribed. If one or more values are provided, only audio from the specified anchors will be transcribed.
        /// 
        /// > Note: If a user ID appears in both the `SubscribeList` and `UnSubscribeList`, the `UnSubscribeList` takes precedence.
        /// </summary>
        [JsonProperty("SubscribeList")]
        public TranscriptionUserInfoParams[] SubscribeList{ get; set; }

        /// <summary>
        /// Blocklist of user IDs whose audio will be excluded from transcription. 
        /// Leave empty or omit to disable the blocklist. Provide specific values to exclude the specified anchors' audio from transcription.
        /// </summary>
        [JsonProperty("UnSubscribeList")]
        public TranscriptionUserInfoParams[] UnSubscribeList{ get; set; }

        /// <summary>
        /// Maximum idle duration before the transcription task is automatically stopped, in seconds.
        /// If all anchors being transcribed continuously leave the TRTC room or switch to the audience role for longer than this value, the transcription task stops automatically.
        /// - Default: 30
        /// - Range: 5 - 86400 (24 hours)
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// Controls whether the custom data channel is enabled. Accepted values: 0 (disabled) or 1 (enabled). Defaults to 0 if omitted.
        /// </summary>
        [JsonProperty("SendCustomMode")]
        public ulong? SendCustomMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamArrayObj(map, prefix + "SubscribeList.", this.SubscribeList);
            this.SetParamArrayObj(map, prefix + "UnSubscribeList.", this.UnSubscribeList);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "SendCustomMode", this.SendCustomMode);
        }
    }
}

