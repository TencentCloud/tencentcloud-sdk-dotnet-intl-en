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

    public class OpenAuditServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// CDB instance ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Audit log retention period. Supported values include:
        /// 7 - A week;
        /// 30 - one month
        /// 90 - three months;
        /// 180 - 6 months;
        /// 365 - One year;
        /// 1095 - Three years;
        /// 1825 - Five years.
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public ulong? LogExpireDay{ get; set; }

        /// <summary>
        /// High frequency audit log retention period. Default value is 7. This item must take value less than or equal to LogExpireDay. Supported values include:
        /// 3 - 3 days;
        /// 7 - A week;
        /// 30 - one month
        /// 90 - three months;
        /// 180 - 6 months;
        /// 365 - One year;
        /// 1095 - Three years;
        /// 1825 - Five years.
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public ulong? HighLogExpireDay{ get; set; }

        /// <summary>
        /// Audit rule (deprecated, no longer effective).
        /// </summary>
        [JsonProperty("AuditRuleFilters")]
        [System.Obsolete]
        public AuditRuleFilters[] AuditRuleFilters{ get; set; }

        /// <summary>
        /// Rule template ID.
        /// </summary>
        [JsonProperty("RuleTemplateIds")]
        public string[] RuleTemplateIds{ get; set; }

        /// <summary>
        /// Audit type. true - full audit; default false - rule audit.
        /// </summary>
        [JsonProperty("AuditAll")]
        public bool? AuditAll{ get; set; }


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
            this.SetParamSimple(map, prefix + "AuditAll", this.AuditAll);
        }
    }
}

