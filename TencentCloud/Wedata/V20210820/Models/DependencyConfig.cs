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

    public class DependencyConfig : AbstractModel
    {
        
        /// <summary>
        /// Only five types of periodic execution dependency configurations: HOUR, DAY, WEEK, MONTH, YEAR, CRONTAB, MINUTE
        /// </summary>
        [JsonProperty("DependConfType")]
        public string DependConfType{ get; set; }

        /// <summary>
        /// Dependency Configuration Subordinate Period Type, CURRENT_HOUR, PREVIOUS_HOUR, CURRENT_DAY, PREVIOUS_DAY, PREVIOUS_WEEK, PREVIOUS_FRIDAY, PREVIOUS_WEEKEND, CURRENT_MONTH, PREVIOUS_MONTH, PREVIOUS_END_OF_MONTH
        ///      * PREVIOUS_BEGIN_OF_MONTH,ALL_MONTH_OF_YEAR,ALL_DAY_OF_YEAR,CURRENT_YEAR,CURRENT,CURRENT_MINUTE,PREVIOUS_MINUTE_CYCLE,PREVIOUS_HOUR_CYCLE
        /// </summary>
        [JsonProperty("SubordinateCyclicType")]
        public string SubordinateCyclicType{ get; set; }

        /// <summary>
        /// WAITING, waiting (default policy) EXECUTING: executing
        /// </summary>
        [JsonProperty("DependencyStrategy")]
        public string DependencyStrategy{ get; set; }

        /// <summary>
        /// Parent Task Information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ParentTask")]
        public TaskInnerInfo ParentTask{ get; set; }

        /// <summary>
        /// Subtask Information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SonTask")]
        public TaskInnerInfo SonTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DependConfType", this.DependConfType);
            this.SetParamSimple(map, prefix + "SubordinateCyclicType", this.SubordinateCyclicType);
            this.SetParamSimple(map, prefix + "DependencyStrategy", this.DependencyStrategy);
            this.SetParamObj(map, prefix + "ParentTask.", this.ParentTask);
            this.SetParamObj(map, prefix + "SonTask.", this.SonTask);
        }
    }
}

