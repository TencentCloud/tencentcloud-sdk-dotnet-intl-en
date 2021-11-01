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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAlarmRequest : AbstractModel
    {
        
        /// <summary>
        /// Alarm policy name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Monitoring object list
        /// </summary>
        [JsonProperty("AlarmTargets")]
        public AlarmTarget[] AlarmTargets{ get; set; }

        /// <summary>
        /// Monitoring task running time point
        /// </summary>
        [JsonProperty("MonitorTime")]
        public MonitorTime MonitorTime{ get; set; }

        /// <summary>
        /// Trigger condition
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// Alarm persistence cycle. An alarm will be triggered only after the corresponding trigger condition is met for the number of times specified by `TriggerCount`. Value range: 1–10.
        /// </summary>
        [JsonProperty("TriggerCount")]
        public long? TriggerCount{ get; set; }

        /// <summary>
        /// Repeated alarm interval in minutes. Value range: 0–1440.
        /// </summary>
        [JsonProperty("AlarmPeriod")]
        public long? AlarmPeriod{ get; set; }

        /// <summary>
        /// List of associated alarm notification templates
        /// </summary>
        [JsonProperty("AlarmNoticeIds")]
        public string[] AlarmNoticeIds{ get; set; }

        /// <summary>
        /// Whether to enable the alarm policy. Default value: true
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// Custom alarm content
        /// </summary>
        [JsonProperty("MessageTemplate")]
        public string MessageTemplate{ get; set; }

        /// <summary>
        /// Custom callback
        /// </summary>
        [JsonProperty("CallBack")]
        public CallBackInfo CallBack{ get; set; }

        /// <summary>
        /// Multi-Dimensional analysis
        /// </summary>
        [JsonProperty("Analysis")]
        public AnalysisDimensional[] Analysis{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "AlarmTargets.", this.AlarmTargets);
            this.SetParamObj(map, prefix + "MonitorTime.", this.MonitorTime);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "TriggerCount", this.TriggerCount);
            this.SetParamSimple(map, prefix + "AlarmPeriod", this.AlarmPeriod);
            this.SetParamArraySimple(map, prefix + "AlarmNoticeIds.", this.AlarmNoticeIds);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MessageTemplate", this.MessageTemplate);
            this.SetParamObj(map, prefix + "CallBack.", this.CallBack);
            this.SetParamArrayObj(map, prefix + "Analysis.", this.Analysis);
        }
    }
}

