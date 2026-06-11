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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAlarmRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Alert policy ID. - Search the alert policy ID by <a href="https://www.tencentcloud.com/document/product/614/56461?from_cn_redirect=1">obtaining the alarm policy list</a>.</p>
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// <p>Alarm policy name. Supports a maximum of 255 bytes. The '|' character is unsupported.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Monitoring task execution time point.</p>
        /// </summary>
        [JsonProperty("MonitorTime")]
        public MonitorTime MonitorTime{ get; set; }

        /// <summary>
        /// <p>Trigger condition for sending alarm information.</p><p>Note:</p><ul><li>Condition and AlarmLevel are one set of configurations, and MultiConditions is another set of configurations. The two sets are mutually exclusive.</li></ul>
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// <p>Alarm level.</p><p>0: Warning (Warn); 1: Reminder (Info); 2: Emergency (Critical)</p><p>Note:</p><ul><li>Condition and AlarmLevel are one set of configurations, and MultiConditions are another set of configurations. The two sets are mutually exclusive.</li></ul>
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// <p>Multiple trigger conditions.</p><p>Note:</p><ul><li>Condition and AlarmLevel are one set of configurations, and MultiConditions are another set of configurations. The two sets of configurations are mutually exclusive.</li></ul>
        /// </summary>
        [JsonProperty("MultiConditions")]
        public MultiCondition[] MultiConditions{ get; set; }

        /// <summary>
        /// <p>Duration cycle. An alarm is triggered after the trigger conditions are constantly met for TriggerCount cycles. The minimum value is 1, and the maximum value is 2000.</p>
        /// </summary>
        [JsonProperty("TriggerCount")]
        public long? TriggerCount{ get; set; }

        /// <summary>
        /// <p>Alarm repeat cycle. In minutes. Value ranges from 0 to 1440.</p>
        /// </summary>
        [JsonProperty("AlarmPeriod")]
        public long? AlarmPeriod{ get; set; }

        /// <summary>
        /// <p>Monitoring object list.</p>
        /// </summary>
        [JsonProperty("AlarmTargets")]
        public AlarmTarget[] AlarmTargets{ get; set; }

        /// <summary>
        /// <p>Whether to enable alarm policy.</p>
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// <p>This parameter has been deprecated, please use the Status parameter to control whether to enable the alarm policy.</p>
        /// </summary>
        [JsonProperty("Enable")]
        [System.Obsolete]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>User-defined alarm content</p>
        /// </summary>
        [JsonProperty("MessageTemplate")]
        public string MessageTemplate{ get; set; }

        /// <summary>
        /// <p>user-defined callback</p>
        /// </summary>
        [JsonProperty("CallBack")]
        public CallBackInfo CallBack{ get; set; }

        /// <summary>
        /// <p>Multi-dimensional analysis</p>
        /// </summary>
        [JsonProperty("Analysis")]
        public AnalysisDimensional[] Analysis{ get; set; }

        /// <summary>
        /// <p>Group trigger status. true: enabled, false: disabled (default)</p>
        /// </summary>
        [JsonProperty("GroupTriggerStatus")]
        public bool? GroupTriggerStatus{ get; set; }

        /// <summary>
        /// <p>Group trigger conditions.</p>
        /// </summary>
        [JsonProperty("GroupTriggerCondition")]
        public string[] GroupTriggerCondition{ get; set; }

        /// <summary>
        /// <p>Tag description list, by specifying this parameter, you can simultaneously bind a tag to the corresponding alarm policy. Up to 10 tag key-value pairs are supported, and no duplicate key-value pairs are allowed.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Monitored object type. 0: Common monitoring object for execution statements; 1: Each execution statement selects its own monitored object.<br>When the value is 1, the number of elements in AlarmTargets cannot exceed 10. The Number in AlarmTargets must be consecutive positive integers starting from 1 and must be unique.</p>
        /// </summary>
        [JsonProperty("MonitorObjectType")]
        public ulong? MonitorObjectType{ get; set; }

        /// <summary>
        /// <p>Alert additional classification information list.<br>Number of Classifications Elements cannot exceed 20.<br>The Key of Classifications elements cannot be empty, must be unique, length cannot exceed 50 characters, and complies with the regular expression <code>^[a-z]([a-z0-9_]{0,49})$</code>.<br>Value of Classifications elements cannot exceed 200 characters.</p>
        /// </summary>
        [JsonProperty("Classifications")]
        public AlarmClassification[] Classifications{ get; set; }

        /// <summary>
        /// <p>List of associated CLS alarm notification channel groups. - Search the list of associated alarm notification channel groups via <a href="https://www.tencentcloud.com/document/product/614/56462?from_cn_redirect=1">Query notification channel group list</a>. It is mutually exclusive with MonitorNotice.</p>
        /// </summary>
        [JsonProperty("AlarmNoticeIds")]
        public string[] AlarmNoticeIds{ get; set; }

        /// <summary>
        /// <p>The associated observability platform notification template is mutually exclusive with the AlarmNoticeIds parameter and cannot include both.</p>
        /// </summary>
        [JsonProperty("MonitorNotice")]
        public MonitorNotice MonitorNotice{ get; set; }


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
            this.SetParamArraySimple(map, prefix + "AlarmNoticeIds.", this.AlarmNoticeIds);
            this.SetParamObj(map, prefix + "MonitorNotice.", this.MonitorNotice);
        }
    }
}

