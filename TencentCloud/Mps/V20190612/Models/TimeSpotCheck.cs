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

    public class TimeSpotCheck : AbstractModel
    {
        
        /// <summary>
        /// Duration of each loop detection, in seconds. Value range:
        /// 
        ///  - Minimum value: 10.
        ///  - Maximum value: 86400.
        /// </summary>
        [JsonProperty("CheckDuration")]
        public ulong? CheckDuration{ get; set; }

        /// <summary>
        /// Detection interval, in seconds. It indicates the duration after a detection is completed and before the next detection is conducted. Value range:
        ///  - Minimum value: 10.
        ///  - Maximum value: 3600.
        /// </summary>
        [JsonProperty("CheckInterval")]
        public ulong? CheckInterval{ get; set; }

        /// <summary>
        /// Skipped opening duration, in seconds. Value range:
        ///  - Minimum value: 1.
        ///  - Maximum value: 1800.
        /// </summary>
        [JsonProperty("SkipDuration")]
        public ulong? SkipDuration{ get; set; }

        /// <summary>
        /// Number of loops. Value range:
        ///  - Minimum value: 0.
        ///  - Maximum value: 1000.
        /// 
        /// If the value is 0 or not specified, it indicates that loops are executed until the video ends.
        /// </summary>
        [JsonProperty("CirclesNumber")]
        public ulong? CirclesNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckDuration", this.CheckDuration);
            this.SetParamSimple(map, prefix + "CheckInterval", this.CheckInterval);
            this.SetParamSimple(map, prefix + "SkipDuration", this.SkipDuration);
            this.SetParamSimple(map, prefix + "CirclesNumber", this.CirclesNumber);
        }
    }
}

