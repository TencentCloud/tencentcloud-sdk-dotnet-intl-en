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
        /// Action. Valid values: 
        /// <li>`monitor`: Observe;</li>
        /// <li>`alg`: JavaScript challenge;</li>
        /// <li>`captcha`: Managed challenge;</li>
        /// <li>`random`: Actions are executed based on the percentage specified in `ExtendActions`;</li>
        /// <li>`silence`: Silence;</li>
        /// <li>`shortdelay`: Add short latency;</li>
        /// <li>`longdelay`: Add long latency.</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// The probability for triggering the action. Value range: 0-100.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
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

