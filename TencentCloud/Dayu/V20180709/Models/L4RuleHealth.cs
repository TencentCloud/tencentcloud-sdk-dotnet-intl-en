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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class L4RuleHealth : AbstractModel
    {
        
        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 1: enabled, 0: disabled
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// Response timeout period in seconds
        /// </summary>
        [JsonProperty("TimeOut")]
        public ulong? TimeOut{ get; set; }

        /// <summary>
        /// Detection interval in seconds, which must be greater than the response timeout period
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// Unhealthy threshold in times
        /// </summary>
        [JsonProperty("KickNum")]
        public ulong? KickNum{ get; set; }

        /// <summary>
        /// Healthy threshold in times.
        /// </summary>
        [JsonProperty("AliveNum")]
        public ulong? AliveNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "TimeOut", this.TimeOut);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "KickNum", this.KickNum);
            this.SetParamSimple(map, prefix + "AliveNum", this.AliveNum);
        }
    }
}

