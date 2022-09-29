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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillingDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Time granularity. Values:
        /// <ul>
        /// <li>`min`: One minute</li>
        /// <li>`5min`: Five minutes</li>
        /// <li>`hour`: One hour</li>
        /// <li>`day`: One day</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Metric item. Values:
        /// <ul>
        /// <li>`acc_flux`: Content acceleration traffic;</li>
        /// <li>`quic_request`: QUIC requests;</li>
        /// <li>`sec_flux`: Security traffic;</li>
        /// <li>`sec_request_clean`: Clean security requests.</li>
        /// </ul>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Filter item. Values:
        /// <ul>
        /// <li>`zone`: Site;</li>
        /// <li>`plan`: Service plan;</li>
        /// <li>`service`: L4 or L7;</li>
        /// <li>`tagKey`: Tag key;</li>
        /// <li>`tagValue`: Tag value.</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Filters")]
        public BillingDataFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

