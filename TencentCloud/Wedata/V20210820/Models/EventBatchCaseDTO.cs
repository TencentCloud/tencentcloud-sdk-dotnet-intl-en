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

    public class EventBatchCaseDTO : AbstractModel
    {
        
        /// <summary>
        /// Event Instance ID
        /// </summary>
        [JsonProperty("CaseId")]
        public string CaseId{ get; set; }

        /// <summary>
        /// Event
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Event Trigger Start Time
        /// </summary>
        [JsonProperty("StartDimension")]
        public string StartDimension{ get; set; }

        /// <summary>
        /// Creation Time
        /// </summary>
        [JsonProperty("CreationTs")]
        public string CreationTs{ get; set; }

        /// <summary>
        /// Consumer ID
        /// </summary>
        [JsonProperty("ConsumerId")]
        public string ConsumerId{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Event Trigger End Time
        /// </summary>
        [JsonProperty("EndDimension")]
        public string EndDimension{ get; set; }

        /// <summary>
        /// Event Cycle
        /// </summary>
        [JsonProperty("EventSubType")]
        public string EventSubType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaseId", this.CaseId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StartDimension", this.StartDimension);
            this.SetParamSimple(map, prefix + "CreationTs", this.CreationTs);
            this.SetParamSimple(map, prefix + "ConsumerId", this.ConsumerId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EndDimension", this.EndDimension);
            this.SetParamSimple(map, prefix + "EventSubType", this.EventSubType);
        }
    }
}

