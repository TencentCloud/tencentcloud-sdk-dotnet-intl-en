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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioTrackChannelInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable the feature of multi-audio track mixing. valid values:
        /// 0: indicates not enabling multi-audio track mix.
        /// 1: Indicates enabling multi-audio track mixing.
        /// Default value: 0
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ChannelsRemix")]
        public long? ChannelsRemix{ get; set; }

        /// <summary>
        /// Set the selector type for the input audio track. valid values:
        /// Track: indicates the usage of audio track id;.
        /// Track_channel: indicates the usage of the audio track id and sound channel id.
        /// Default: track.
        /// If the original video has multiple channels, it is recommended to use track_channel.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SelectType")]
        public string SelectType{ get; set; }

        /// <summary>
        /// Audio track information.
        /// Note: This field may return null, indicating that no valid value can be obtained.
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

