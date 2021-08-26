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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CronHorizontalAutoscaler : AbstractModel
    {
        
        /// <summary>
        /// Name of a scheduled scaling policy
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Policy period
        /// "* * *" indicates three ranges. The first is day, the second month, and the third week. The three parts are separated by spaces.
        /// Examples:
        /// * * * (every day)
        /// * * 0-3 (every Sunday through Wednesday)
        /// 1,11,21 * * (1st, 11th, and 21st of every month)
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }

        /// <summary>
        /// Details of a scheduled scaling policy
        /// </summary>
        [JsonProperty("Schedules")]
        public CronHorizontalAutoscalerSchedule[] Schedules{ get; set; }

        /// <summary>
        /// Enabled or not
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// Policy priority. The higher the value, the higher the priority. The minimum value is 0.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArrayObj(map, prefix + "Schedules.", this.Schedules);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

