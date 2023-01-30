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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulDefenceEventTendencyResponse : AbstractModel
    {
        
        /// <summary>
        /// Trend of exploit prevention events
        /// </summary>
        [JsonProperty("DefendedList")]
        public VulDefenceEventTendency[] DefendedList{ get; set; }

        /// <summary>
        /// Trend of vulnerability attack events
        /// </summary>
        [JsonProperty("AttackList")]
        public VulDefenceEventTendency[] AttackList{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "DefendedList.", this.DefendedList);
            this.SetParamArrayObj(map, prefix + "AttackList.", this.AttackList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

