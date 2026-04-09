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
        /// 
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// The action. Values:
        /// <li>`drop`: Block the request</li>
        /// <li>`monitor`: Observe</li>
        /// <li>`trans`: Allow</li>
        /// <li>`redirect`: Redirect the request</li>
        /// <li>`page`: Return the specified page</li>
        /// <li>`alg`: JavaScript challenge</li>
        /// <li>`captcha`: Managed challenge</li>
        /// <li>`random`: Handle the request randomly by the weight</li>
        /// <li>`silence`: Keep the connection but do not response to the client</li>
        /// <li>`shortdelay`: Add a short latency period</li>
        /// <li>`longdelay`: Add a long latency period</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// The rule status. Values:
        /// <li>`on`: Enabled</li>
        /// <li>`off`: Disabled</li>Default value: `on`
        /// </summary>
        [JsonProperty("RuleStatus")]
        public string RuleStatus{ get; set; }

        /// <summary>
        /// Details of the rule.
        /// </summary>
        [JsonProperty("AclConditions")]
        public AclCondition[] AclConditions{ get; set; }

        /// <summary>
        /// The rule weight. Value range: 0-100.
        /// </summary>
        [JsonProperty("RulePriority")]
        public long? RulePriority{ get; set; }

        /// <summary>
        /// Rule ID, which is only used as an output parameter.
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// [Currently unavailable] Specify the random action and percentage.
        /// </summary>
        [JsonProperty("ExtendActions")]
        public BotExtendAction[] ExtendActions{ get; set; }

        /// <summary>
        /// The filter. Values:
        /// <li>`sip`: Client IP</li>
        /// This parameter is left empty by default.
        /// </summary>
        [JsonProperty("FreqFields")]
        public string[] FreqFields{ get; set; }

        /// <summary>
        /// The update time, which is only used as an output parameter.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Query scope. Values:
        /// <li>`source_to_eo`: (Response) Traffic going from the origin to EdgeOne.</li>
        /// <li>`client_to_eo`: (Request) Traffic going from the client to EdgeOne.</li>
        /// Default: `source_to_eo`.
        /// </summary>
        [JsonProperty("FreqScope")]
        public string[] FreqScope{ get; set; }

        /// <summary>
        /// Name of the custom return page. It's required when `Action=page`.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// ID of custom response. The ID can be obtained via the `DescribeCustomErrorPages` API. It's required when `Action=page`.	
        /// </summary>
        [JsonProperty("CustomResponseId")]
        public string CustomResponseId{ get; set; }

        /// <summary>
        /// The response code to trigger the return page. It's required when `Action=page`. Value: 100-600. 3xx response codes are not supported. Default value: 567.
        /// </summary>
        [JsonProperty("ResponseCode")]
        public long? ResponseCode{ get; set; }

        /// <summary>
        /// The redirection URL. It's required when `Action=redirect`.
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

