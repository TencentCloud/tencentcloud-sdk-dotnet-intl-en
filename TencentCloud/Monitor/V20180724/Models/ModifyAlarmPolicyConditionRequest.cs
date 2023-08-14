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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAlarmPolicyConditionRequest : AbstractModel
    {
        
        /// <summary>
        /// Module name, which is fixed at "monitor"
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// Alarm policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// ID of trigger condition template. This parameter can be left empty.
        /// </summary>
        [JsonProperty("ConditionTemplateId")]
        public long? ConditionTemplateId{ get; set; }

        /// <summary>
        /// Metric trigger condition
        /// </summary>
        [JsonProperty("Condition")]
        public AlarmPolicyCondition Condition{ get; set; }

        /// <summary>
        /// Event trigger condition
        /// </summary>
        [JsonProperty("EventCondition")]
        public AlarmPolicyEventCondition EventCondition{ get; set; }

        /// <summary>
        /// Global filter.
        /// </summary>
        [JsonProperty("Filter")]
        public AlarmPolicyFilter Filter{ get; set; }

        /// <summary>
        /// Aggregation dimension list, which is used to specify which dimension keys data is grouped by.
        /// </summary>
        [JsonProperty("GroupBy")]
        public string[] GroupBy{ get; set; }

        /// <summary>
        /// Log alarm creation request parameters
        /// </summary>
        [JsonProperty("LogAlarmReqInfo")]
        public LogAlarmReq LogAlarmReqInfo{ get; set; }

        /// <summary>
        /// Template ID, which is dedicated to TencentCloud Managed Service for Prometheus.
        /// </summary>
        [JsonProperty("NoticeIds")]
        public string[] NoticeIds{ get; set; }

        /// <summary>
        /// Status (`0`: Disabled; `1`: Enabled)
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// Name of the policy dedicated to TMP
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// The alert configured for an event
        /// </summary>
        [JsonProperty("EbSubject")]
        public string EbSubject{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "ConditionTemplateId", this.ConditionTemplateId);
            this.SetParamObj(map, prefix + "Condition.", this.Condition);
            this.SetParamObj(map, prefix + "EventCondition.", this.EventCondition);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArraySimple(map, prefix + "GroupBy.", this.GroupBy);
            this.SetParamObj(map, prefix + "LogAlarmReqInfo.", this.LogAlarmReqInfo);
            this.SetParamArraySimple(map, prefix + "NoticeIds.", this.NoticeIds);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "EbSubject", this.EbSubject);
        }
    }
}

