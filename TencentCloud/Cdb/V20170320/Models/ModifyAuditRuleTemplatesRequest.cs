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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAuditRuleTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// Audit rule template ID, which can be obtained through the [DescribeAuditRuleTemplates](https://www.tencentcloud.comom/document/api/236/101811?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("RuleTemplateIds")]
        public string[] RuleTemplateIds{ get; set; }

        /// <summary>
        /// Modified audit rule.
        /// </summary>
        [JsonProperty("RuleFilters")]
        public RuleFilters[] RuleFilters{ get; set; }

        /// <summary>
        /// Modified rule template name.
        /// </summary>
        [JsonProperty("RuleTemplateName")]
        public string RuleTemplateName{ get; set; }

        /// <summary>
        /// Modified rule template description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Alarm level. Valid values: 1 - Low risk, 2 - Medium risk, 3 - High risk.
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// Alarm policy. Valid values: 0 - Alarm disabled, 1 - Alarm enabled.
        /// </summary>
        [JsonProperty("AlarmPolicy")]
        public ulong? AlarmPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RuleTemplateIds.", this.RuleTemplateIds);
            this.SetParamArrayObj(map, prefix + "RuleFilters.", this.RuleFilters);
            this.SetParamSimple(map, prefix + "RuleTemplateName", this.RuleTemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "AlarmPolicy", this.AlarmPolicy);
        }
    }
}

