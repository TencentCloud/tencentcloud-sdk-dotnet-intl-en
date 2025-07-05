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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePolicyConditionListEventMetric : AbstractModel
    {
        
        /// <summary>
        /// Event ID.
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// Event name.
        /// </summary>
        [JsonProperty("EventShowName")]
        public string EventShowName{ get; set; }

        /// <summary>
        /// Whether to recover.
        /// </summary>
        [JsonProperty("NeedRecovered")]
        public bool? NeedRecovered{ get; set; }

        /// <summary>
        /// Event type, which is a reserved field. Currently, it is fixed to 2.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "EventShowName", this.EventShowName);
            this.SetParamSimple(map, prefix + "NeedRecovered", this.NeedRecovered);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

