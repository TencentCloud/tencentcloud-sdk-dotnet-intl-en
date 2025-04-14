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

    public class TrackInfo : AbstractModel
    {
        
        /// <summary>
        /// Audio track and sound channel serial number, description:
        /// When the SelectType value is trask, this value is of the integer type, for example: 1.
        /// When the SelectType value is trask_channel, this value is of the decimal type, for example: 1.0.
        /// Default value: `1.0`.
        /// The integer part represents the audio track serial number, and the decimal part represents the sound channel. The audio track serial number is the stream index of the audio track, and input of 0 and positive integers is supported. The decimal part supports up to 2 decimal places, and only 0 - 63 is supported. However, when the Codec is aac/eac3/ac3, only 0 - 15 is supported for the decimal part. For example: for an audio track with a stream index of 1, 1.0 represents the first sound channel of this audio track, and 1.1 represents the second sound channel of this audio track.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TrackNum")]
        public string TrackNum{ get; set; }

        /// <summary>
        /// Sound channel volume. specifies the volume of the sound channel.
        /// Specifies that when the value of AudioChannel is 1, the length of this array is 1, for example: [6].
        /// Specifies that when the value of AudioChannel is 2, the array length is 2. for example: [0,6].
        /// When the value of AudioChannel is 6, the length of this array is greater than 2 and less than 16, for example: [-60,0,0,6].
        /// Specifies the value array of this parameter. the value range is [-60, 6]. among them, -60 indicates mute, 0 indicates keeping the original volume, and 6 indicates doubling the original volume. the default value is -60.
        /// Note: supports 3 decimal places.
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
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

