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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourceScheduleResponse : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable the resource scheduling feature
        /// </summary>
        [JsonProperty("OpenSwitch")]
        public bool? OpenSwitch{ get; set; }

        /// <summary>
        /// The resource scheduler in service
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// Fair Scheduler information
        /// </summary>
        [JsonProperty("FSInfo")]
        public string FSInfo{ get; set; }

        /// <summary>
        /// Capacity Scheduler information
        /// </summary>
        [JsonProperty("CSInfo")]
        public string CSInfo{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenSwitch", this.OpenSwitch);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "FSInfo", this.FSInfo);
            this.SetParamSimple(map, prefix + "CSInfo", this.CSInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

