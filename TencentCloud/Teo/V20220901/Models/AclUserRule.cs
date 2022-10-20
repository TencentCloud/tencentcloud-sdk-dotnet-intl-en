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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AclUserRule : AbstractModel
    {
        
        /// <summary>
        /// The rule name.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// The rule action. Values:
        /// <li>`trans`: Allow the request.</li>
        /// <li>`drop`: Block the request.</li>
        /// <li>`monitor`: Observe the request.</li>
        /// <li>`ban`: Block the IP.</li>
        /// <li>`redirect`: Redirect the request.</li>
        /// <li>`page`: Return the specified page.</li>
        /// <li>`alg`: Verify the request by Javascript challenge.</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// The rule status. Values:
        /// <li>`on`: Enabled</li>
        /// <li>`off`: Disabled</li>
        /// </summary>
        [JsonProperty("RuleStatus")]
        public string RuleStatus{ get; set; }

        /// <summary>
        /// The custom rule.
        /// </summary>
        [JsonProperty("AclConditions")]
        public AclCondition[] AclConditions{ get; set; }

        /// <summary>
        /// The rule priority. Value range: 0-100.
        /// </summary>
        [JsonProperty("RulePriority")]
        public long? RulePriority{ get; set; }

        /// <summary>
        /// The rule ID, which is only used as an output parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// The update time, which is only used as an output parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// The IP blocking duration. Value range: 0 seconds - 2 days. Default value: 0 seconds.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PunishTime")]
        public long? PunishTime{ get; set; }

        /// <summary>
        /// The unit of the IP blocking duration. Values:
        /// <li>`second`: Second</li>
        /// <li>`minutes`: Minute</li>
        /// <li>`hour`: Hour</li>Default value: second.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PunishTimeUnit")]
        public string PunishTimeUnit{ get; set; }

        /// <summary>
        /// The name of the custom page, which defaults to an empty string.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The ID of the custom page, which defaults to 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PageId")]
        public long? PageId{ get; set; }

        /// <summary>
        /// The redirection URL, which must be a subdomain name of the site. It defaults to an empty string.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }

        /// <summary>
        /// The response code returned after redirection, which defaults to 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResponseCode")]
        public long? ResponseCode{ get; set; }


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
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "PunishTime", this.PunishTime);
            this.SetParamSimple(map, prefix + "PunishTimeUnit", this.PunishTimeUnit);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
            this.SetParamSimple(map, prefix + "ResponseCode", this.ResponseCode);
        }
    }
}

