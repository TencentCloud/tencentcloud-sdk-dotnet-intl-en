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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateApmInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Business system name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Business system description information.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Retention period of trace data (unit: days, the default storage duration is 3 days).
        /// </summary>
        [JsonProperty("TraceDuration")]
        public long? TraceDuration{ get; set; }

        /// <summary>
        /// Business system tag list.
        /// </summary>
        [JsonProperty("Tags")]
        public ApmTag[] Tags{ get; set; }

        /// <summary>
        /// The report quota value of the business system. the default value is 0, indicating no limit on the report quota. (obsolete).
        /// </summary>
        [JsonProperty("SpanDailyCounters")]
        public ulong? SpanDailyCounters{ get; set; }

        /// <summary>
        /// Billing model of the business system (0: pay-as-you-go, 1: prepaid).
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Whether it is a free edition business system (0 = paid edition; 1 = tsf restricted free edition; 2 = free edition).
        /// </summary>
        [JsonProperty("Free")]
        public long? Free{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TraceDuration", this.TraceDuration);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "SpanDailyCounters", this.SpanDailyCounters);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Free", this.Free);
        }
    }
}

