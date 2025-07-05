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

    public class LogAlarmReq : AbstractModel
    {
        
        /// <summary>
        /// APM instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Search condition
        /// </summary>
        [JsonProperty("Filter")]
        public LogFilterInfo[] Filter{ get; set; }

        /// <summary>
        /// The switch to enable/disable alarm merging
        /// </summary>
        [JsonProperty("AlarmMerge")]
        public string AlarmMerge{ get; set; }

        /// <summary>
        /// Alarm merging time
        /// </summary>
        [JsonProperty("AlarmMergeTime")]
        public string AlarmMergeTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "AlarmMerge", this.AlarmMerge);
            this.SetParamSimple(map, prefix + "AlarmMergeTime", this.AlarmMergeTime);
        }
    }
}

