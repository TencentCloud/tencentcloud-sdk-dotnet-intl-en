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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BandwidthAlert : AbstractModel
    {
        
        /// <summary>
        /// Specifies whether to enable the bandwidth cap
        /// `on`: enable
        /// `off`: disable
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// The upper limit of bandwidth usage (in bps) or traffic usage (in bytes).
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BpsThreshold")]
        public long? BpsThreshold{ get; set; }

        /// <summary>
        /// Action taken when threshold is reached
        /// RESOLVE_DNS_TO_ORIGIN: requests will be forwarded to the origin server. This is only supported for domain names of external origin.
        /// RETURN_404: a 404 error will be returned for all requests.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CounterMeasure")]
        public string CounterMeasure{ get; set; }

        /// <summary>
        /// The last time when the usage upper limit in the Chinese mainland was reached
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastTriggerTime")]
        public string LastTriggerTime{ get; set; }

        /// <summary>
        /// Indicates whether to trigger alerts when the upper limit is reached
        /// `on`: enable
        /// `off`: disable
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlertSwitch")]
        public string AlertSwitch{ get; set; }

        /// <summary>
        /// Triggers alarms when the ratio of bandwidth or traffic usage to the usage upper limit reaches the specified value
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlertPercentage")]
        public long? AlertPercentage{ get; set; }

        /// <summary>
        /// The last time when the usage outside the Chinese mainland reached the upper limit
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastTriggerTimeOverseas")]
        public string LastTriggerTimeOverseas{ get; set; }

        /// <summary>
        /// Dimension of the usage limit
        /// `bandwidth`: bandwidth
        /// `flux`: traffic
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "BpsThreshold", this.BpsThreshold);
            this.SetParamSimple(map, prefix + "CounterMeasure", this.CounterMeasure);
            this.SetParamSimple(map, prefix + "LastTriggerTime", this.LastTriggerTime);
            this.SetParamSimple(map, prefix + "AlertSwitch", this.AlertSwitch);
            this.SetParamSimple(map, prefix + "AlertPercentage", this.AlertPercentage);
            this.SetParamSimple(map, prefix + "LastTriggerTimeOverseas", this.LastTriggerTimeOverseas);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
        }
    }
}

