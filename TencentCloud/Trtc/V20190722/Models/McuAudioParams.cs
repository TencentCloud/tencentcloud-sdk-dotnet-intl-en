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
        /// The users whose audios are mixed. For the `StartPublishCdnStream` API, if you do not pass this parameter or leave it empty, the audios of all anchors will be mixed. For the `UpdatePublishCdnStream` API, if you do not pass this parameter, TRTC will not change the users whose audios are mixed; if you pass in an empty string, the audios of all anchors will be mixed.
        /// </summary>
        [JsonProperty("SubscribeAudioList")]
        public McuUserInfoParams[] SubscribeAudioList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AudioEncode.", this.AudioEncode);
            this.SetParamArrayObj(map, prefix + "SubscribeAudioList.", this.SubscribeAudioList);
        }
    }
}

