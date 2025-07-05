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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JobResponseInfo : AbstractModel
    {
        
        /// <summary>
        /// Job name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// Statistics
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatisticInfo")]
        public StatisticInfo StatisticInfo{ get; set; }

        /// <summary>
        /// Job configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JobConfiguration")]
        public string JobConfiguration{ get; set; }

        /// <summary>
        /// The current status of the job: 0: initializing; 1: running; 2: executed; 3: writing data; 4: queuing; -1: execution failed; -3: manually terminated. The job execution result is returned only when the job is successfully executed.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JobStatus")]
        public long? JobStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamObj(map, prefix + "StatisticInfo.", this.StatisticInfo);
            this.SetParamSimple(map, prefix + "JobConfiguration", this.JobConfiguration);
            this.SetParamSimple(map, prefix + "JobStatus", this.JobStatus);
        }
    }
}

