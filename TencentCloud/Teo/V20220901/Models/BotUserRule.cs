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

    public class BotUserRule : AbstractModel
    {
        
        /// <summary>
        /// Rule name can only contain English characters, digits, and underscores, and cannot begin with an underscore.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Disposal actions. Valid values:
        /// <li>drop: block;</li>
        /// <li>monitor: observation;</li>
        /// <li>trans: pass;</li>
        /// <li>redirect: Redirection;</li>
        /// <li>page: Specified page;</li>
        /// <li>alg: JavaScript challenge;</li>
        /// <li>captcha: hosted challenge;</li>
        /// <li>random: Random disposal;</li>
        /// <li>silence: silence;</li>
        /// <li>shortdelay: short-term response;</li>
        /// <li>longdelay: long-time response.</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Rule status. Valid values:
        /// <li>`on`: Take effect;</li>
        /// <li>off: Not effective.</li>Default on takes effect.
        /// </summary>
        [JsonProperty("RuleStatus")]
        public string RuleStatus{ get; set; }

        /// <summary>
        /// Rule details.
        /// </summary>
        [JsonProperty("AclConditions")]
        public AclCondition[] AclConditions{ get; set; }

        /// <summary>
        /// Rule weight. Value range: 0-100.
        /// </summary>
        [JsonProperty("RulePriority")]
        public long? RulePriority{ get; set; }

        /// <summary>
        /// Rule Id. Output only.
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// Disposal method and proportion of random disposal. Optional for non-random disposal. Not currently supported.
        /// </summary>
        [JsonProperty("ExtendActions")]
        public BotExtendAction[] ExtendActions{ get; set; }

        /// <summary>
        /// Filter word. Valid values:
        /// <li>sip: Client IP.</li>
        /// Defaults to an empty string.
        /// </summary>
        [JsonProperty("FreqFields")]
        public string[] FreqFields{ get; set; }

        /// <summary>
        /// Update time. For output usage only.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Statistical scope. Valid values:
        /// <li>source_to_eo: (Response) Origin server to EdgeOne;</li>
        /// <li>client_to_eo: (request) Client to EdgeOne.</li>
        /// Default value: source_to_eo.
        /// </summary>
        [JsonProperty("FreqScope")]
        public string[] FreqScope{ get; set; }

        /// <summary>
        /// Name of the custom return page. Required when Action is page, and cannot be empty.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Custom response Id, which can be obtained through the customized error page list interface. The default value is `default`, which uses the system default page. Required and cannot be empty when Action is `page`.	
        /// </summary>
        [JsonProperty("CustomResponseId")]
        public string CustomResponseId{ get; set; }

        /// <summary>
        /// Custom response code for the return to page. Required when Action is page, and cannot be empty. Value range: 100–600. 3xx response codes are not supported. Default value: 567.
        /// </summary>
        [JsonProperty("ResponseCode")]
        public long? ResponseCode{ get; set; }

        /// <summary>
        /// Address for redirection. Required when Action is `redirect` and cannot be empty.
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RuleStatus", this.RuleStatus);
            this.SetParamArrayObj(map, prefix + "AclConditions.", this.AclConditions);
            this.SetParamSimple(map, prefix + "RulePriority", this.RulePriority);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArrayObj(map, prefix + "ExtendActions.", this.ExtendActions);
            this.SetParamArraySimple(map, prefix + "FreqFields.", this.FreqFields);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArraySimple(map, prefix + "FreqScope.", this.FreqScope);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CustomResponseId", this.CustomResponseId);
            this.SetParamSimple(map, prefix + "ResponseCode", this.ResponseCode);
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
        }
    }
}

