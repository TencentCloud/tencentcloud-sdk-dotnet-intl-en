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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventInfo : AbstractModel
    {
        
        /// <summary>
        /// Event ID.
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// Diagnosis type.
        /// </summary>
        [JsonProperty("DiagType")]
        public string DiagType{ get; set; }

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
        /// Summary.
        /// </summary>
        [JsonProperty("Outline")]
        public string Outline{ get; set; }

        /// <summary>
        /// Severity, which can be divided into 5 levels: 1: fatal, 2: severe, 3: warning, 4: notice, 5: healthy.
        /// </summary>
        [JsonProperty("Severity")]
        public long? Severity{ get; set; }

        /// <summary>
        /// Deduction.
        /// </summary>
        [JsonProperty("ScoreLost")]
        public long? ScoreLost{ get; set; }

        /// <summary>
        /// Reserved field.
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// Number of alarms.
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "DiagType", this.DiagType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Outline", this.Outline);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "ScoreLost", this.ScoreLost);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Count", this.Count);
        }
    }
}

