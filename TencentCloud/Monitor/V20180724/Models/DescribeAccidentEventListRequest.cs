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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccidentEventListRequest : AbstractModel
    {
        
        /// <summary>
        /// API component name. The value for the current API is monitor.
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// Start time, which is the timestamp one day prior by default.
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// End time, which is the current timestamp by default.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Number of parameters that can be returned on each page. Value range: 1 - 100. Default value: 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Parameter offset on each page. The value starts from 0 and the default value is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Sorting rule by UpdateTime. Valid values: asc and desc.
        /// </summary>
        [JsonProperty("UpdateTimeOrder")]
        public string UpdateTimeOrder{ get; set; }

        /// <summary>
        /// Sorting rule by OccurTime. Valid values: asc or desc. Sorting by UpdateTimeOrder takes priority.
        /// </summary>
        [JsonProperty("OccurTimeOrder")]
        public string OccurTimeOrder{ get; set; }

        /// <summary>
        /// Filter by event type. The value 1 indicates service issues. The value 2 indicates other subscriptions.
        /// </summary>
        [JsonProperty("AccidentType")]
        public long?[] AccidentType{ get; set; }

        /// <summary>
        /// Filter by event. The value 1 indicates CVM storage issues. The value 2 indicates CVM network connection issues. The value 3 indicates that the CVM has an exception. The value 202 indicates that an ISP network jitter occurs.
        /// </summary>
        [JsonProperty("AccidentEvent")]
        public long?[] AccidentEvent{ get; set; }

        /// <summary>
        /// Filter by event status. The value 0 indicates that the event has been recovered. The value 1 indicates that the event has not been recovered.
        /// </summary>
        [JsonProperty("AccidentStatus")]
        public long?[] AccidentStatus{ get; set; }

        /// <summary>
        /// Filter by region where the event occurs. The value gz indicates Guangzhou. The value sh indicates Shanghai.
        /// </summary>
        [JsonProperty("AccidentRegion")]
        public string[] AccidentRegion{ get; set; }

        /// <summary>
        /// Filter by affected resource, such as ins-19a06bka.
        /// </summary>
        [JsonProperty("AffectResource")]
        public string AffectResource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "UpdateTimeOrder", this.UpdateTimeOrder);
            this.SetParamSimple(map, prefix + "OccurTimeOrder", this.OccurTimeOrder);
            this.SetParamArraySimple(map, prefix + "AccidentType.", this.AccidentType);
            this.SetParamArraySimple(map, prefix + "AccidentEvent.", this.AccidentEvent);
            this.SetParamArraySimple(map, prefix + "AccidentStatus.", this.AccidentStatus);
            this.SetParamArraySimple(map, prefix + "AccidentRegion.", this.AccidentRegion);
            this.SetParamSimple(map, prefix + "AffectResource", this.AffectResource);
        }
    }
}

