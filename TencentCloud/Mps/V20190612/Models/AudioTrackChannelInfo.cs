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
        /// Whether to enable the feature of multi-audio track mixing. Valid values:
        /// <li>0: To disable the multi-audio track mixing feature.
        /// <li>1: To enable the multi-audio track mixing feature. 
        /// <li>Default value: 0.
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ChannelsRemix")]
        public long? ChannelsRemix{ get; set; }

        /// <summary>
        /// Set the selector type for the input audio track. Valid values:
        /// <li>track: indicates the usage of audio track id to identify the track to be used.
        /// <li>track_channel: indicates the usage of both the audio track id and sound channel id to identify the track and channel to be used.
        /// <li>Default value: track.
        /// If the original audio track has multiple sound channels, please use track_channel.
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SelectType")]
        public string SelectType{ get; set; }

        /// <summary>
        /// Audio track information.
        /// 
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

