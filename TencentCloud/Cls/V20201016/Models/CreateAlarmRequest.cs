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

    public class CreateAlarmRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Alarm policy name. Supports a maximum of 255 bytes. Unsupported '|'.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Monitoring object list.</p>
        /// </summary>
        [JsonProperty("AlarmTargets")]
        public AlarmTarget[] AlarmTargets{ get; set; }

        /// <summary>
        /// <p>Monitoring task execution time point.</p>
        /// </summary>
        [JsonProperty("MonitorTime")]
        public MonitorTime MonitorTime{ get; set; }

        /// <summary>
        /// <p>Duration cycle. An alarm is triggered after trigger conditions are constantly met for TriggerCount cycles. Minimum value is 1. Maximum value is 2000.</p>
        /// </summary>
        [JsonProperty("TriggerCount")]
        public long? TriggerCount{ get; set; }

        /// <summary>
        /// <p>Alarm repeat cycle in minutes. Value ranges from 0 to 1440.</p>
        /// </summary>
        [JsonProperty("AlarmPeriod")]
        public long? AlarmPeriod{ get; set; }

        /// <summary>
        /// <p>Trigger conditions for sending alarm notifications<br> Note: </p><ul><li>Condition and AlarmLevel are one set of configurations, and MultiConditions are another set of configurations. The two sets are mutually exclusive.</li></ul>
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// <p>Alarm level<br>0: Warning; 1: Info; 2: Critical.<br>Note:</p><ul><li>Defaults to 0 if left empty.</li><li>Condition and AlarmLevel are one set of configurations, and MultiConditions are another set of configurations. The two sets are mutually exclusive.</li></ul>
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// <p>Multiple trigger conditions<br> Note: </p><ul><li>Condition and AlarmLevel are one set of configurations, and MultiConditions are another set of configurations. These two sets are mutually exclusive.</li></ul>
        /// </summary>
        [JsonProperty("MultiConditions")]
        public MultiCondition[] MultiConditions{ get; set; }

        /// <summary>
        /// <p>Whether to enable alarm policy.<br>Default value is true</p>
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// <p>Please use the Status parameter to control whether to enable the alarm policy.</p>
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
        /// <p>Group trigger status.<br>false by default</p>
        /// </summary>
        [JsonProperty("GroupTriggerStatus")]
        public bool? GroupTriggerStatus{ get; set; }

        /// <summary>
        /// <p>Group trigger conditions.</p>
        /// </summary>
        [JsonProperty("GroupTriggerCondition")]
        public string[] GroupTriggerCondition{ get; set; }

        /// <summary>
        /// <p>Tag description list. Tags can be bound to the corresponding alarm policy simultaneously by specifying this parameter.</p><p>It supports up to 10 tag key-value pairs, which cannot be duplicate.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Monitored object type. 0: Common monitoring object for execution statements; 1: Each execution statement selects its own monitored object.<br>Defaults to 0 if left blank.<br>When the value is 1, the number of elements in AlarmTargets must not exceed 10, and the Numbers in AlarmTargets must be consecutive positive integers starting from 1 without duplication.</p>
        /// </summary>
        [JsonProperty("MonitorObjectType")]
        public ulong? MonitorObjectType{ get; set; }

        /// <summary>
        /// <p>Alert additional classification information list.<br>Number of Classifications elements must not exceed 20.<br>The Key of Classifications elements cannot be empty, must be unique, length cannot exceed 50 characters, and complies with the regular expression <code>^[a-z]([a-z0-9_]{0,49})$</code>.<br>Value of Classifications elements cannot exceed 200 characters.</p>
        /// </summary>
        [JsonProperty("Classifications")]
        public AlarmClassification[] Classifications{ get; set; }

        /// <summary>
        /// <p>List of associated log service alarm notification channel groups. - Search the associated alarm notification channel group list via <a href="https://www.tencentcloud.com/document/product/614/56462?from_cn_redirect=1">Get Notification Channel Group List</a>, mutually exclusive with MonitorNotice.</p>
        /// </summary>
        [JsonProperty("AlarmNoticeIds")]
        public string[] AlarmNoticeIds{ get; set; }

        /// <summary>
        /// <p>The associated observability platform notification template is mutually exclusive with the AlarmNoticeIds parameter and cannot be used simultaneously.</p>
        /// </summary>
        [JsonProperty("MonitorNotice")]
        public MonitorNotice MonitorNotice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "AlarmTargets.", this.AlarmTargets);
            this.SetParamObj(map, prefix + "MonitorTime.", this.MonitorTime);
            this.SetParamSimple(map, prefix + "TriggerCount", this.TriggerCount);
            this.SetParamSimple(map, prefix + "AlarmPeriod", this.AlarmPeriod);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamArrayObj(map, prefix + "MultiConditions.", this.MultiConditions);
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

