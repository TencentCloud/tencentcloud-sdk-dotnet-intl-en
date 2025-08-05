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
        /// Duration of each loop detection in the spot check policy, in seconds. Valid values:
        /// 
        ///  - Minimum value: 10.
        ///  - Maximum value: 86400.
        /// </summary>
        [JsonProperty("CheckDuration")]
        public ulong? CheckDuration{ get; set; }

        /// <summary>
        /// Detection interval of the spot check policy, which indicates how long to wait before conducting the next detection after one detection is completed.
        /// </summary>
        [JsonProperty("CheckInterval")]
        public ulong? CheckInterval{ get; set; }

        /// <summary>
        /// Duration for which the opening clip is skipped.
        /// </summary>
        [JsonProperty("SkipDuration")]
        public ulong? SkipDuration{ get; set; }

        /// <summary>
        /// Number of loops. When this field is empty or set to 0, the default behavior is to loop until the video ends.
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

