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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BruteAttackRuleList : AbstractModel
    {
        
        /// <summary>
        /// <p>Time range of the brute force cracking event (unit: second)</p>
        /// </summary>
        [JsonProperty("TimeRange")]
        public ulong? TimeRange{ get; set; }

        /// <summary>
        /// <p>Number of failed blasting incidents</p>
        /// </summary>
        [JsonProperty("LoginFailTimes")]
        public ulong? LoginFailTimes{ get; set; }

        /// <summary>
        /// <p>Whether the rule is empty. If yes, fill in the default rule.</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>Occurrence time range of brute force cracking events, in seconds (default rule)</p>
        /// </summary>
        [JsonProperty("TimeRangeDefault")]
        public ulong? TimeRangeDefault{ get; set; }

        /// <summary>
        /// <p>Number of failed blasting incidents (default rule)</p>
        /// </summary>
        [JsonProperty("LoginFailTimesDefault")]
        public ulong? LoginFailTimesDefault{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeRange", this.TimeRange);
            this.SetParamSimple(map, prefix + "LoginFailTimes", this.LoginFailTimes);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "TimeRangeDefault", this.TimeRangeDefault);
            this.SetParamSimple(map, prefix + "LoginFailTimesDefault", this.LoginFailTimesDefault);
        }
    }
}

