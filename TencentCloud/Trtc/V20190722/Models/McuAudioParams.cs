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

    public class McuAudioParams : AbstractModel
    {
        
        /// <summary>
        /// The audio encoding parameters.
        /// </summary>
        [JsonProperty("AudioEncode")]
        public AudioEncode AudioEncode{ get; set; }

        /// <summary>
        /// The audio mix allowlist. For the `StartPublishCdnStream` API, if you do not pass this parameter or leave it empty, the audios of all anchors will be mixed. For the `UpdatePublishCdnStream` API, if you do not pass this parameter, no changes will be made to the current allowlist; if you pass in an empty string, the audios of all anchors will be mixed.
        /// In cases where `SubscribeAudioList` and `UnSubscribeAudioList` are used at the same time, you need to specify both parameters. If you pass neither `SubscribeAudioList` nor `UnSubscribeAudioList`, no changes will be made. If a user is included in both parameters, the user’s audio will not be mixed.
        /// </summary>
        [JsonProperty("SubscribeAudioList")]
        public McuUserInfoParams[] SubscribeAudioList{ get; set; }

        /// <summary>
        /// The audio mix blocklist. If you do not pass this parameter or leave it empty, there won’t be a blocklist. For the `UpdatePublishCdnStream` API, if you do not pass this parameter, no changes will be made to the current blocklist; if you pass in an empty string, the blocklist will be reset.
        /// In cases where `SubscribeAudioList` and `UnSubscribeAudioList` are used at the same time, you need to specify both parameters. If you pass neither `SubscribeAudioList` nor `UnSubscribeAudioList`, no changes will be made. If a user is included in both parameters, the user’s audio will not be mixed.
        /// </summary>
        [JsonProperty("UnSubscribeAudioList")]
        public McuUserInfoParams[] UnSubscribeAudioList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AudioEncode.", this.AudioEncode);
            this.SetParamArrayObj(map, prefix + "SubscribeAudioList.", this.SubscribeAudioList);
            this.SetParamArrayObj(map, prefix + "UnSubscribeAudioList.", this.UnSubscribeAudioList);
        }
    }
}

