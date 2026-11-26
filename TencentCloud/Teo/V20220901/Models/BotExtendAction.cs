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

    public class BotExtendAction : AbstractModel
    {
        
        /// <summary>
        /// Disposal actions. Valid values:
        /// <li>monitor: observation;</li>
        /// <li>alg: JavaScript challenge;</li>
        /// <li>captcha: hosted challenge;</li>
        /// <li>random: random, allocate handling actions and proportions according to ExtendActions;</li>
        /// <li>silence: silence;</li>
        /// <li>shortdelay: short-term response;</li>
        /// <li>longdelay: long-time response.</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Probability for triggering the handling method. Value range: 0-100.
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
        }
    }
}

