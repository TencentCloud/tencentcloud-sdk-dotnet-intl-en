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

    public class SubscribeStreamUserIds : AbstractModel
    {
        
        /// <summary>
        /// The allowlist for audio subscription. For example, `["1", "2", "3"]` means to subscribe to the audios of users 1, 2, and 3. If this parameter is left empty, the audios of all anchors (max 32) in the room will be received.
        /// </summary>
        [JsonProperty("SubscribeAudioUserIds")]
        public string[] SubscribeAudioUserIds{ get; set; }

        /// <summary>
        /// The blocklist for audio subscription. For example, `["1", "2", "3"]` means to not subscribe to the audios of users 1, 2, and 3. If this parameter is left empty, the audios of all anchors (max 32) in the room will be received.
        /// </summary>
        [JsonProperty("UnSubscribeAudioUserIds")]
        public string[] UnSubscribeAudioUserIds{ get; set; }

        /// <summary>
        /// The allowlist for video subscription. For example, `["1", "2", "3"]` means to subscribe to the videos of users 1, 2, and 3. If this parameter is left empty, the videos of all anchors (max 32) in the room will be received.
        /// </summary>
        [JsonProperty("SubscribeVideoUserIds")]
        public string[] SubscribeVideoUserIds{ get; set; }

        /// <summary>
        /// The blocklist for video subscription. For example, `["1", "2", "3"]` means to not subscribe to the videos of users 1, 2, and 3. If this parameter is left empty, the videos of all anchors (max 32) in the room will be received.
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

