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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportOverviewData : AbstractModel
    {
        
        /// <summary>
        /// Total count
        /// </summary>
        [JsonProperty("TotalTimes")]
        public string TotalTimes{ get; set; }

        /// <summary>
        /// Success rate
        /// </summary>
        [JsonProperty("SuccessPercent")]
        public float? SuccessPercent{ get; set; }

        /// <summary>
        /// Timeout rate
        /// </summary>
        [JsonProperty("TimeoutPercent")]
        public float? TimeoutPercent{ get; set; }

        /// <summary>
        /// Failure rate
        /// </summary>
        [JsonProperty("FailPercent")]
        public float? FailPercent{ get; set; }

        /// <summary>
        /// Average matching time
        /// </summary>
        [JsonProperty("AverageSec")]
        public float? AverageSec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalTimes", this.TotalTimes);
            this.SetParamSimple(map, prefix + "SuccessPercent", this.SuccessPercent);
            this.SetParamSimple(map, prefix + "TimeoutPercent", this.TimeoutPercent);
            this.SetParamSimple(map, prefix + "FailPercent", this.FailPercent);
            this.SetParamSimple(map, prefix + "AverageSec", this.AverageSec);
        }
    }
}

