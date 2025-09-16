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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CronScaleJob : AbstractModel
    {
        
        /// <summary>
        /// Cron expression, which identifies the task execution time, and is accurate to minutes.
        /// </summary>
        [JsonProperty("Schedule")]
        public string Schedule{ get; set; }

        /// <summary>
        /// Scheduled task name.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Number of target instances.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetReplicas")]
        public long? TargetReplicas{ get; set; }

        /// <summary>
        /// Minimum target.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinReplicas")]
        public long? MinReplicas{ get; set; }

        /// <summary>
        /// Maximum target.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxReplicas")]
        public long? MaxReplicas{ get; set; }

        /// <summary>
        /// Exception periods, defined by Cron expressions, during which tasks are not executed. Up to 3 Cron expressions are supported.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExcludeDates")]
        public string[] ExcludeDates{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Schedule", this.Schedule);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TargetReplicas", this.TargetReplicas);
            this.SetParamSimple(map, prefix + "MinReplicas", this.MinReplicas);
            this.SetParamSimple(map, prefix + "MaxReplicas", this.MaxReplicas);
            this.SetParamArraySimple(map, prefix + "ExcludeDates.", this.ExcludeDates);
        }
    }
}

