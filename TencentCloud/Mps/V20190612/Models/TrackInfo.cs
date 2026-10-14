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

    public class TrackInfo : AbstractModel
    {
        
        /// <summary>
        /// Audio track and number of sound channels. Description:
        /// When SelectType is track, this value is an integer, for example: 1;
        /// When SelectType is track_channel, this value is a decimal, for example: 1.0;
        /// Default value: 1.0.
        /// Note: The integer part represents the audio track serial number, and the decimal part represents the sound channel. The audio track serial number is the stream index of the audio track, and supports input of 0 and positive integers. The decimal part supports up to 2 decimal places and only supports 0-63. However, if Codec is aac/eac3/ac3, the decimal part only supports 0-15. For example: For an audio track with stream index 1, 1.0 represents the first sound channel of this audio track, and 1.1 represents the second sound channel of this audio track.
        /// </summary>
        [JsonProperty("TrackNum")]
        public string TrackNum{ get; set; }

        /// <summary>
        /// Sound channel volume. Description:
        /// When the value of AudioChannel is 1, the length of this array is 1, for example: [6];
        /// When the value of AudioChannel is 2, the length of this array is 2, for example: [0,6];
        /// When the value of AudioChannel is 6, the length of this array is greater than 2 and less than 16, for example: [-60,0,0,6].
        /// Value range: [-60, 6]. -60 means mute, 0 means keep the original volume, and 6 means double the original volume. Default value: -60.
        /// Note: Supports 3 decimal places.
        /// </summary>
        [JsonProperty("ChannelVolume")]
        public float?[] ChannelVolume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrackNum", this.TrackNum);
            this.SetParamArraySimple(map, prefix + "ChannelVolume.", this.ChannelVolume);
        }
    }
}

