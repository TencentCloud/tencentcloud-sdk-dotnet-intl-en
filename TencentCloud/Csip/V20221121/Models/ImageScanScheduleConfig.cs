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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageScanScheduleConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Cycle type</p><p>Enumeration values:</p><ul><li>DAILY: Daily</li><li>WEEKLY: Weekly</li><li>MONTHLY: Monthly</li></ul>
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// <p>Specific date. For weekly type: 1-7 (Monday to Sunday); for monthly type: 1-31; disabled for daily type.</p>
        /// </summary>
        [JsonProperty("CycleDays")]
        public ulong?[] CycleDays{ get; set; }

        /// <summary>
        /// <p>Scan start time</p><p>Parameter format: hh:mm</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>Time zone</p>
        /// </summary>
        [JsonProperty("Timezone")]
        public string Timezone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamArraySimple(map, prefix + "CycleDays.", this.CycleDays);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Timezone", this.Timezone);
        }
    }
}

