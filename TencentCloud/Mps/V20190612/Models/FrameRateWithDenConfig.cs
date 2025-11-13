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

    public class FrameRateWithDenConfig : AbstractModel
    {
        
        /// <summary>
        /// Capability configuration switch. Valid values:
        /// <li>ON: enabled.</li>
        /// <li>OFF: disabled.</li>
        /// Default value: ON.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Frame rate numerator. Value range: non-negative number, which should be less than 120 when divided by the denominator, and in the unit of Hz. The default value is 0. Note: For transcoding, this parameter will overwrite the Fps in the VideoTemplate.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FpsNum")]
        public long? FpsNum{ get; set; }

        /// <summary>
        /// Frame rate denominator.Value range: numbers equal to or greater than 1. The default value is 1. Note: For transcoding, this parameter will overwrite the FpsDenominator in the VideoTemplate.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FpsDen")]
        public long? FpsDen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "FpsNum", this.FpsNum);
            this.SetParamSimple(map, prefix + "FpsDen", this.FpsDen);
        }
    }
}

