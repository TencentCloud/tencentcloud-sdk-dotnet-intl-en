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

    public class OutputParams : AbstractModel
    {
        
        /// <summary>
        /// Custom live stream ID, which must be different from the ID of relayed stream.
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// Value range: [0, 1]. If it is 0, live streams are audio and video; if it is 1, live streams are only audio. Default value: 0.
        /// </summary>
        [JsonProperty("PureAudioStream")]
        public ulong? PureAudioStream{ get; set; }

        /// <summary>
        /// Custom recording file name. Please enable the recording feature in the TRTC console first. https://intl.cloud.tencent.com/document/product/647/50768?from_cn_redirect=1
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// Value range: [0, 1]. If it is 0, the recording template configured in the console will be used; if it is 1, streams are recorded as .mp3 files.
        /// </summary>
        [JsonProperty("RecordAudioOnly")]
        public ulong? RecordAudioOnly{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "PureAudioStream", this.PureAudioStream);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "RecordAudioOnly", this.RecordAudioOnly);
        }
    }
}

