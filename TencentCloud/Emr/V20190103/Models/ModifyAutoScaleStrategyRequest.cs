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

    public class ModifyAutoScaleStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Automatic scaling rule type. 1: Scaling by load metrics; 2: Scaling by time
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// Metric for load-based scaling.
        /// </summary>
        [JsonProperty("LoadAutoScaleStrategies")]
        public LoadAutoScaleStrategy[] LoadAutoScaleStrategies{ get; set; }

        /// <summary>
        /// Rule for time-based scaling
        /// </summary>
        [JsonProperty("TimeAutoScaleStrategies")]
        public TimeAutoScaleStrategy[] TimeAutoScaleStrategies{ get; set; }

        /// <summary>
        /// Scaling group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamArrayObj(map, prefix + "LoadAutoScaleStrategies.", this.LoadAutoScaleStrategies);
            this.SetParamArrayObj(map, prefix + "TimeAutoScaleStrategies.", this.TimeAutoScaleStrategies);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
        }
    }
}

