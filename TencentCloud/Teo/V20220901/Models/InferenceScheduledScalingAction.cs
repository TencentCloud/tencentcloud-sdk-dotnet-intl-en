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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceScheduledScalingAction : AbstractModel
    {
        
        /// <summary>
        /// Cron expression for description of scheduled scaling trigger time. Use 5-field standard cron format: minute hour date month week. No support for second and year fields.
        /// </summary>
        [JsonProperty("CronExpression")]
        public string CronExpression{ get; set; }

        /// <summary>
        /// After hitting the scheduled scaling action, the minimum number of instances to which the inference service can be adjusted. If multiple scheduled scaling actions hit at the same time within the identical evaluation window, use the maximum MinInstanceCount.
        /// </summary>
        [JsonProperty("MinInstanceCount")]
        public long? MinInstanceCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CronExpression", this.CronExpression);
            this.SetParamSimple(map, prefix + "MinInstanceCount", this.MinInstanceCount);
        }
    }
}

