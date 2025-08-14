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

    public class SubscribeModerationUserIds : AbstractModel
    {
        
        /// <summary>
        /// Subscription audio stream allowlist. It specifies which UserIds' audio streams to subscribe to, for example, ["1", "2", "3"] indicates subscriptions to the audio streams of UserId 1, 2, and 3; ["1.*$"] indicates subscription to audio streams with UserId prefixes starting with 1. If this parameter is left unspecified, all audio streams in the room are subscribed to by default. The number of users in the subscription list should not exceed 32.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubscribeAudioUserIds")]
        public string[] SubscribeAudioUserIds{ get; set; }

        /// <summary>
        /// Subscription audio stream blocklist. It specifies which UserIds' audio streams not to subscribe to, for example, ["1", "2", "3"] indicates that the audio streams of UserId 1, 2, and 3 are not subscribed to; ["1.*$"] indicates that audio streams with UserId prefixes starting with 1 are not subscribed to. If this parameter is left unspecified, all audio streams in the room are subscribed to by default. The number of users in the subscription list should not exceed 32.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnSubscribeAudioUserIds")]
        public string[] UnSubscribeAudioUserIds{ get; set; }

        /// <summary>
        /// Subscription video stream allowlist. It specifies which UserIds' video streams to subscribe to, for example, ["1", "2", "3"] indicates subscriptions to the video streams of UserId 1, 2, and 3; ["1.*$"] indicates subscription to video streams with UserId prefixes starting with 1. If this parameter is left unspecified, all video streams in the room are subscribed to by default. The number of users in the subscription list should not exceed 32.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubscribeVideoUserIds")]
        public string[] SubscribeVideoUserIds{ get; set; }

        /// <summary>
        /// Subscription video stream blocklist. It specifies which UserIds' video streams not to subscribe to, for example, ["1", "2", "3"] indicates that the video streams of UserId 1, 2, and 3 are not subscribed to; ["1.*$"] indicates that video streams with UserId prefixes starting with 1 are not subscribed to. If this parameter is left unspecified, all video streams in the room are subscribed to by default. The number of users in the subscription list should not exceed 32.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnSubscribeVideoUserIds")]
        public string[] UnSubscribeVideoUserIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SubscribeAudioUserIds.", this.SubscribeAudioUserIds);
            this.SetParamArraySimple(map, prefix + "UnSubscribeAudioUserIds.", this.UnSubscribeAudioUserIds);
            this.SetParamArraySimple(map, prefix + "SubscribeVideoUserIds.", this.SubscribeVideoUserIds);
            this.SetParamArraySimple(map, prefix + "UnSubscribeVideoUserIds.", this.UnSubscribeVideoUserIds);
        }
    }
}

