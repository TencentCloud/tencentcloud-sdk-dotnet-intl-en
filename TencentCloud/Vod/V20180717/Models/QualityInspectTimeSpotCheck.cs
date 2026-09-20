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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QualityInspectTimeSpotCheck : AbstractModel
    {
        
        /// <summary>
        /// <p>Duration of each loop detection.</p><p>Value range: [10, 86400]</p><p>Unit: seconds.</p>
        /// </summary>
        [JsonProperty("CheckDuration")]
        public long? CheckDuration{ get; set; }

        /// <summary>
        /// <p>Detection interval, in seconds. It indicates the duration after a detection is completed and before the next detection is conducted.</p><p>Value range: [10, 3600]</p><p>Unit: seconds.</p>
        /// </summary>
        [JsonProperty("CheckInterval")]
        public long? CheckInterval{ get; set; }

        /// <summary>
        /// <p>Skipped opening duration.</p><p>Value range: [1, 1800]</p><p>Unit: seconds.</p>
        /// </summary>
        [JsonProperty("SkipDuration")]
        public long? SkipDuration{ get; set; }

        /// <summary>
        /// <p>Number of loops.</p><p>Value range: [0, 1000]</p>
        /// </summary>
        [JsonProperty("CirclesNumber")]
        public long? CirclesNumber{ get; set; }


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

