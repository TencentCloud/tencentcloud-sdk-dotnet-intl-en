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

    public class FrameCaptureTemplate : AbstractModel
    {
        
        /// <summary>
        /// Name of frame capture template, limited to uppercase and lowercase letters and numbers, with a length between 1 and 20 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Width of frame capture, optional, input range is from 0 to 3000, must be a multiple of 2.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Height of frame capture, optional, input range is from 0 to 3000, must be a multiple of 2.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Interval of frame capture, an integer between 1 and 3600.
        /// </summary>
        [JsonProperty("CaptureInterval")]
        public ulong? CaptureInterval{ get; set; }

        /// <summary>
        /// Interval units of frame capture, only supports SECONDS.
        /// </summary>
        [JsonProperty("CaptureIntervalUnits")]
        public string CaptureIntervalUnits{ get; set; }

        /// <summary>
        /// Scaling behavior of frame capture, supports DEFAULT or STRETCH_TO_OUTPUT, with DEFAULT being the default option.
        /// </summary>
        [JsonProperty("ScalingBehavior")]
        public string ScalingBehavior{ get; set; }

        /// <summary>
        /// Sharpness, an integer between 0 and 100.
        /// </summary>
        [JsonProperty("Sharpness")]
        public ulong? Sharpness{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "CaptureInterval", this.CaptureInterval);
            this.SetParamSimple(map, prefix + "CaptureIntervalUnits", this.CaptureIntervalUnits);
            this.SetParamSimple(map, prefix + "ScalingBehavior", this.ScalingBehavior);
            this.SetParamSimple(map, prefix + "Sharpness", this.Sharpness);
        }
    }
}

