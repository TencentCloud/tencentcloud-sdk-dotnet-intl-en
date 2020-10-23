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

    public class CreateBasicDDoSAlarmThresholdRequest : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type (`basic`: Anti-DDoS Basic)
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// `get`: read alarm threshold, `set`: set alarm threshold
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// Alarm threshold type. 1: inbound traffic, 2: cleansed traffic. This field is required if `Method` is `set`;
        /// </summary>
        [JsonProperty("AlarmType")]
        public ulong? AlarmType{ get; set; }

        /// <summary>
        /// Alarm threshold. It is required if `Method` is `set`. If it is set to 0, it means to clear the alarm threshold configuration;
        /// </summary>
        [JsonProperty("AlarmThreshold")]
        public ulong? AlarmThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "AlarmThreshold", this.AlarmThreshold);
        }
    }
}

