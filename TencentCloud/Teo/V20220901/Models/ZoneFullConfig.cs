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

    public class ZoneFullConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Syntax version. It defaults to 1.0. An error will be reported if you input other values.</p>
        /// </summary>
        [JsonProperty("FormatVersion")]
        public string FormatVersion{ get; set; }

        /// <summary>
        /// <p>Site-level configuration, including all configuration items in "Site Acceleration". All items are required; otherwise, the configuration is invalid.</p>
        /// </summary>
        [JsonProperty("ZoneConfig")]
        public ZoneConfig ZoneConfig{ get; set; }

        /// <summary>
        /// <p>Site-level custom variable configuration, including variable definition and variable operations.</p>
        /// </summary>
        [JsonProperty("ZoneCustomVariables")]
        public ZoneCustomVariables ZoneCustomVariables{ get; set; }

        /// <summary>
        /// <p>Rule-level configuration, including all rules in the rule engine. The array can be empty, indicating that no rules are enabled.</p>
        /// </summary>
        [JsonProperty("Rules")]
        public ConfigGroupRuleEngineItem[] Rules{ get; set; }

        /// <summary>
        /// <p>Web security protection settings, corresponding to the functions supported in "Security Protection - Web Protection" in the console.</p>
        /// </summary>
        [JsonProperty("WebSecurity")]
        public WebSecurity WebSecurity{ get; set; }

        /// <summary>
        /// <p>Edge function trigger rule configuration, including all rules in the edge function. The array can be empty, indicating that no rules are enabled.</p>
        /// </summary>
        [JsonProperty("FunctionTriggers")]
        public ConfigGroupFunctionTrigger[] FunctionTriggers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FormatVersion", this.FormatVersion);
            this.SetParamObj(map, prefix + "ZoneConfig.", this.ZoneConfig);
            this.SetParamObj(map, prefix + "ZoneCustomVariables.", this.ZoneCustomVariables);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamObj(map, prefix + "WebSecurity.", this.WebSecurity);
            this.SetParamArrayObj(map, prefix + "FunctionTriggers.", this.FunctionTriggers);
        }
    }
}

