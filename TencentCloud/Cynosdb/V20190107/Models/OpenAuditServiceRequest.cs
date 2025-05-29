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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenAuditServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Log retention period
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public ulong? LogExpireDay{ get; set; }

        /// <summary>
        /// Frequent log retention period
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public ulong? HighLogExpireDay{ get; set; }

        /// <summary>
        /// Audit rule. If both this parameter and `RuleTemplateIds` are left empty, full audit will be applied.
        /// </summary>
        [JsonProperty("AuditRuleFilters")]
        [System.Obsolete]
        public AuditRuleFilters[] AuditRuleFilters{ get; set; }

        /// <summary>
        /// Rule template ID. If both this parameter and `AuditRuleFilters` are left empty, full audit will be applied.
        /// </summary>
        [JsonProperty("RuleTemplateIds")]
        public string[] RuleTemplateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HighLogExpireDay", this.HighLogExpireDay);
            this.SetParamArrayObj(map, prefix + "AuditRuleFilters.", this.AuditRuleFilters);
            this.SetParamArraySimple(map, prefix + "RuleTemplateIds.", this.RuleTemplateIds);
        }
    }
}

