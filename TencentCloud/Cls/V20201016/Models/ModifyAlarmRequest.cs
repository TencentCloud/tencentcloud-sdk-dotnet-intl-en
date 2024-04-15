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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAlarmRequest : AbstractModel
    {
        
        /// <summary>
        /// Alarm policy ID
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// Alarm policy name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Monitoring task running time point
        /// </summary>
        [JsonProperty("MonitorTime")]
        public MonitorTime MonitorTime{ get; set; }

        /// <summary>
        /// Trigger condition. Note: - Condition and AlarmLevel are one set of configurations, MultiConditions is another set of configurations. The two sets of configurations are mutually exclusive.
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// Alarm level.0: Warning (Warn); 1: Reminder (Info); 2: Urgent (Critical)
        /// 
        /// Note: - Condition and AlarmLevel are one set of configurations, MultiConditions is another set of configurations. The two sets of configurations are mutually exclusive.
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// Multiple trigger conditions. Note: - Condition and AlarmLevel are one set of configurations, MultiConditions is another set of configurations. The two sets of configurations are mutually exclusive.
        /// </summary>
        [JsonProperty("MultiConditions")]
        public MultiCondition[] MultiConditions{ get; set; }

        /// <summary>
        /// Alarm persistence cycle. An alarm will be triggered only after the corresponding trigger condition is met for the number of times specified by `TriggerCount`. Value range: 1 to 10
        /// </summary>
        [JsonProperty("TriggerCount")]
        public long? TriggerCount{ get; set; }

        /// <summary>
        /// Repeated alarm interval in minutes. Value range: 0 to 1440
        /// </summary>
        [JsonProperty("AlarmPeriod")]
        public long? AlarmPeriod{ get; set; }

        /// <summary>
        /// List of associated alarm notification templates
        /// </summary>
        [JsonProperty("AlarmNoticeIds")]
        public string[] AlarmNoticeIds{ get; set; }

        /// <summary>
        /// Monitoring object list
        /// </summary>
        [JsonProperty("AlarmTargets")]
        public AlarmTarget[] AlarmTargets{ get; set; }

        /// <summary>
        /// Whether to enable the alarm policy
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// This parameter has been deprecated. Use the Status parameter to control whether to enable the alarm policy.
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// Custom alarm content
        /// </summary>
        [JsonProperty("MessageTemplate")]
        public string MessageTemplate{ get; set; }

        /// <summary>
        /// Custom callback
        /// </summary>
        [JsonProperty("CallBack")]
        public CallBackInfo CallBack{ get; set; }

        /// <summary>
        /// Multi-Dimensional analysis
        /// </summary>
        [JsonProperty("Analysis")]
        public AnalysisDimensional[] Analysis{ get; set; }

        /// <summary>
        /// Group trigger status. true: enabled; false: disabled (default)
        /// </summary>
        [JsonProperty("GroupTriggerStatus")]
        public bool? GroupTriggerStatus{ get; set; }

        /// <summary>
        /// Grouping trigger conditions.
        /// </summary>
        [JsonProperty("GroupTriggerCondition")]
        public string[] GroupTriggerCondition{ get; set; }

        /// <summary>
        /// Tag description list, by specifying this parameter, you can simultaneously bind a Tag to the corresponding alarm policy. Up to 10 Tag key-value pairs are supported, and they must be unique.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Monitored Object Type. 0: common monitoring objects for execution statements; 1: separately selected monitoring objects for each execution statement.When the value is 1, the number of AlarmTargets Elements (XML) cannot exceed 10, and the Numbers in AlarmTargets must be continuous positive integers starting from 1, without duplication.
        /// </summary>
        [JsonProperty("MonitorObjectType")]
        public ulong? MonitorObjectType{ get; set; }

        /// <summary>
        /// Alarm additional classification information list.
        /// The number of Classifications elements cannot exceed 20.The Key of Classifications element must not be empty and duplicated, and its length cannot exceed 50 characters, complying with the regular expression ^[a-z]([a-z0-9_]{0,49})$.The Value length of Classifications element cannot exceed 200 characters.
        /// </summary>
        [JsonProperty("Classifications")]
        public AlarmClassification[] Classifications{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "MonitorTime.", this.MonitorTime);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamArrayObj(map, prefix + "MultiConditions.", this.MultiConditions);
            this.SetParamSimple(map, prefix + "TriggerCount", this.TriggerCount);
            this.SetParamSimple(map, prefix + "AlarmPeriod", this.AlarmPeriod);
            this.SetParamArraySimple(map, prefix + "AlarmNoticeIds.", this.AlarmNoticeIds);
            this.SetParamArrayObj(map, prefix + "AlarmTargets.", this.AlarmTargets);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "MessageTemplate", this.MessageTemplate);
            this.SetParamObj(map, prefix + "CallBack.", this.CallBack);
            this.SetParamArrayObj(map, prefix + "Analysis.", this.Analysis);
            this.SetParamSimple(map, prefix + "GroupTriggerStatus", this.GroupTriggerStatus);
            this.SetParamArraySimple(map, prefix + "GroupTriggerCondition.", this.GroupTriggerCondition);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "MonitorObjectType", this.MonitorObjectType);
            this.SetParamArrayObj(map, prefix + "Classifications.", this.Classifications);
        }
    }
}

