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

    public class StatisticItem : AbstractModel
    {
        
        /// <summary>
        /// Type of usage limit. `total`: Cumulative usage; `moment`: Instantaneous usage.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Unblocking time
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UnBlockTime")]
        public ulong? UnBlockTime{ get; set; }

        /// <summary>
        /// Bandwidth/Traffic threshold
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BpsThreshold")]
        public ulong? BpsThreshold{ get; set; }

        /// <summary>
        /// Specifies how to disable CDN service when the threshold is exceeded. `RETURN_404`: Return 404; `RESOLVE_DNS_TO_ORIGIN`: Forward to origin server.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CounterMeasure")]
        public string CounterMeasure{ get; set; }

        /// <summary>
        /// Threshold (in percentage) that triggers alarms
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlertPercentage")]
        public ulong? AlertPercentage{ get; set; }

        /// <summary>
        /// Whether to enable alerts for cumulative usage limit. Values:
        /// `on`: Enable
        /// `off`: Disable
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlertSwitch")]
        public string AlertSwitch{ get; set; }

        /// <summary>
        /// Metric type. `flux`: Traffic; `bandwidth`: Bandwidth.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Cycle")]
        public ulong? Cycle{ get; set; }

        /// <summary>
        /// Whether to enable cumulative usage limit. Values:
        /// `on`: Enable
        /// `off`: Disable
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "UnBlockTime", this.UnBlockTime);
            this.SetParamSimple(map, prefix + "BpsThreshold", this.BpsThreshold);
            this.SetParamSimple(map, prefix + "CounterMeasure", this.CounterMeasure);
            this.SetParamSimple(map, prefix + "AlertPercentage", this.AlertPercentage);
            this.SetParamSimple(map, prefix + "AlertSwitch", this.AlertSwitch);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Cycle", this.Cycle);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
        }
    }
}

