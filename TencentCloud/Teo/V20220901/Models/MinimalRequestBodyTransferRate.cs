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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MinimalRequestBodyTransferRate : AbstractModel
    {
        
        /// <summary>
        /// Minimum body transfer rate threshold, the measurement unit is only supported in bps.
        /// </summary>
        [JsonProperty("MinimalAvgTransferRateThreshold")]
        public string MinimalAvgTransferRateThreshold{ get; set; }

        /// <summary>
        /// Minimum body transfer rate statistical time range, valid values: <li>10s: 10 seconds;</li> <li>30s: 30 seconds;</li> <li>60s: 60 seconds;</li> <li>120s: 120 seconds.</li>.
        /// </summary>
        [JsonProperty("CountingPeriod")]
        public string CountingPeriod{ get; set; }

        /// <summary>
        /// Specifies whether the minimum body transfer rate threshold is enabled. valid values: <li>on: enable;</li> <li>off: disable.</li>.
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinimalAvgTransferRateThreshold", this.MinimalAvgTransferRateThreshold);
            this.SetParamSimple(map, prefix + "CountingPeriod", this.CountingPeriod);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

