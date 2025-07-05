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

namespace TencentCloud.Vm.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioSegments : AbstractModel
    {
        
        /// <summary>
        /// This field is used to return the start time of an audio segment in seconds. For audio on demand files, this parameter indicates the time offset of the audio from the complete audio track, such as 0 (no offset), 5 (5 seconds after the start of the audio track), and 10 (10 seconds after the start of the audio track). For live audio stream files, this parameter returns the Unix timestamp of the start of the audio segment, such as `1594650717`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OffsetTime")]
        public string OffsetTime{ get; set; }

        /// <summary>
        /// This field is used to return the specific moderation result of an audio segment. For details, see the description of the `AudioResult` data structure.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Result")]
        public AudioResult Result{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OffsetTime", this.OffsetTime);
            this.SetParamObj(map, prefix + "Result.", this.Result);
        }
    }
}

