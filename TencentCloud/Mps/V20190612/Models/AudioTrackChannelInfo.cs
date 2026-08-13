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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioTrackChannelInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether audio mixing is enabled. Value range:
        /// 0: Disable audio mixing
        /// 1: Enable audio mixing
        /// Default value: 0
        /// </summary>
        [JsonProperty("ChannelsRemix")]
        public long? ChannelsRemix{ get; set; }

        /// <summary>
        /// Merge audio track input type, available values:
        /// track: Indicates usage of the audio track id.
        /// track_channel: Indicates usage of audio track id and sound channel id.
        /// Default: track.
        /// Note: If the original video is multichannel, recommend using track_channel.
        /// </summary>
        [JsonProperty("SelectType")]
        public string SelectType{ get; set; }

        /// <summary>
        /// Audio track info
        /// </summary>
        [JsonProperty("InputTrackInfo")]
        public TrackInfo[] InputTrackInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelsRemix", this.ChannelsRemix);
            this.SetParamSimple(map, prefix + "SelectType", this.SelectType);
            this.SetParamArrayObj(map, prefix + "InputTrackInfo.", this.InputTrackInfo);
        }
    }
}

