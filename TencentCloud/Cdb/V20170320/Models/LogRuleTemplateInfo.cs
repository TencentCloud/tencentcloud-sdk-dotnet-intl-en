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

    public class LogRuleTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Template ID. 
        /// Note: The return value may be null, indicating that no valid data can be obtained.
        /// </summary>
        [JsonProperty("RuleTemplateId")]
        public string RuleTemplateId{ get; set; }

        /// <summary>
        /// Template name.
        /// Note: The return value may be null, indicating that no valid data can be obtained.
        /// </summary>
        [JsonProperty("RuleTemplateName")]
        public string RuleTemplateName{ get; set; }

        /// <summary>
        /// Alarm level. Valid values: 1: Low risk; 2: Medium risk; 3: High risk. 
        /// Note: The return value may be null, indicating that no valid data can be obtained.
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public string AlarmLevel{ get; set; }

        /// <summary>
        /// Template change status. Valid values: 0: Unchanged; 1: Changed; 2: Deleted.
        /// Note: The return value may be null, indicating that no valid data can be obtained.
        /// </summary>
        [JsonProperty("RuleTemplateStatus")]
        public long? RuleTemplateStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleTemplateId", this.RuleTemplateId);
            this.SetParamSimple(map, prefix + "RuleTemplateName", this.RuleTemplateName);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "RuleTemplateStatus", this.RuleTemplateStatus);
        }
    }
}

