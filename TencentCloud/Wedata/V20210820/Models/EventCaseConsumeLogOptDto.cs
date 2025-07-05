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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventCaseConsumeLogOptDto : AbstractModel
    {
        
        /// <summary>
        /// Consumer ID\nNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ConsumeLogId")]
        public string ConsumeLogId{ get; set; }

        /// <summary>
        /// Event Case ID\nNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EventCaseId")]
        public string EventCaseId{ get; set; }

        /// <summary>
        /// Consumer ID\nNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ConsumerId")]
        public string ConsumerId{ get; set; }

        /// <summary>
        /// Consumption Timestamp\nNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CreationTimestamp")]
        public string CreationTimestamp{ get; set; }

        /// <summary>
        /// Task DetailsNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ConsumerDetail")]
        public TaskOpsDto ConsumerDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsumeLogId", this.ConsumeLogId);
            this.SetParamSimple(map, prefix + "EventCaseId", this.EventCaseId);
            this.SetParamSimple(map, prefix + "ConsumerId", this.ConsumerId);
            this.SetParamSimple(map, prefix + "CreationTimestamp", this.CreationTimestamp);
            this.SetParamObj(map, prefix + "ConsumerDetail.", this.ConsumerDetail);
        }
    }
}

