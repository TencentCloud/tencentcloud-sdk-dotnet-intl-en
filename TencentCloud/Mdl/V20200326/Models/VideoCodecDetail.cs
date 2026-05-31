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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoCodecDetail : AbstractModel
    {
        
        /// <summary>
        /// Three image quality levels for H264, options include: BASELINE, HIGH, MAIN. The default option is MAIN.
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// Decoding performance of the profile. Options include 1, 1.1, 1.2, 1.3, 2, 2.1, 2.2, 2.3, 3, 3.1, 3.2, 4, 4.1, 4.2, 5, 5.1, AUTO. The default option is AUTO.
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Encoding/decoding includes entropy encoding and lossless encoding. Options include CABAC and CAVLC. The default option is CABAC.
        /// </summary>
        [JsonProperty("EntropyEncoding")]
        public string EntropyEncoding{ get; set; }

        /// <summary>
        /// Mode, options include: AUTO, HIGH, HIGHER, LOW, MAX, MEDIUM, OFF. Default option: AUTO.
        /// </summary>
        [JsonProperty("AdaptiveQuantization")]
        public string AdaptiveQuantization{ get; set; }

        /// <summary>
        /// Analyze subsequent coding frames in advance. Options include HIGH, LOW, and MEDIUM. Default option is MEDIUM.
        /// </summary>
        [JsonProperty("LookAheadRateControl")]
        public string LookAheadRateControl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "EntropyEncoding", this.EntropyEncoding);
            this.SetParamSimple(map, prefix + "AdaptiveQuantization", this.AdaptiveQuantization);
            this.SetParamSimple(map, prefix + "LookAheadRateControl", this.LookAheadRateControl);
        }
    }
}

