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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioNormalizationSettings : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable special configuration for audio transcoding: 1: Enable 0: Disable, the default value is 0.
        /// </summary>
        [JsonProperty("AudioNormalizationEnabled")]
        public ulong? AudioNormalizationEnabled{ get; set; }

        /// <summary>
        /// Loudness value, floating-point number, rounded to one decimal place, range -5 to -70.
        /// </summary>
        [JsonProperty("TargetLUFS")]
        public float? TargetLUFS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AudioNormalizationEnabled", this.AudioNormalizationEnabled);
            this.SetParamSimple(map, prefix + "TargetLUFS", this.TargetLUFS);
        }
    }
}

