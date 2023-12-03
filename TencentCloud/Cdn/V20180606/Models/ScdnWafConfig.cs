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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScdnWafConfig : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable SCDN WAF configuration. Values:
        /// `on`: Enable
        /// `off`: Disable
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// WAF protection mode. Valid values: `intercept` and `observe`. Default value: `intercept`.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Redirection error page
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorPage")]
        public ScdnErrorPage ErrorPage{ get; set; }

        /// <summary>
        /// Whether to enable webshell blocking. Values:
        /// `on`: Enable
        /// `off`: Disable
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WebShellSwitch")]
        public string WebShellSwitch{ get; set; }

        /// <summary>
        /// Attack blocking rules
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Rules")]
        public ScdnWafRule[] Rules{ get; set; }

        /// <summary>
        /// WAF rule level. Valid values: 100, 200, and 300.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// Whether to enable WAF sub-rules. Values:
        /// `on`: Enable
        /// `off`: Disable
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubRuleSwitch")]
        public WafSubRuleStatus[] SubRuleSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamObj(map, prefix + "ErrorPage.", this.ErrorPage);
            this.SetParamSimple(map, prefix + "WebShellSwitch", this.WebShellSwitch);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamArrayObj(map, prefix + "SubRuleSwitch.", this.SubRuleSwitch);
        }
    }
}

