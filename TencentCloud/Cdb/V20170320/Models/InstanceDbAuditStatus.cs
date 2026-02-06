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

    public class InstanceDbAuditStatus : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Audit status. ON - Audit is enabled, OFF - Audit is disabled.
        /// </summary>
        [JsonProperty("AuditStatus")]
        public string AuditStatus{ get; set; }

        /// <summary>
        /// Task status. Valid values: 0 - No task; 1 - Enabling audit; 2 - Disabling audit.
        /// </summary>
        [JsonProperty("AuditTask")]
        public ulong? AuditTask{ get; set; }

        /// <summary>
        /// Log retention period. Valid values:7 - One week;30 - One month;90 - Three months;180 - Six months;365 - One year;1095 - Three years;1825 - Five years.
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public ulong? LogExpireDay{ get; set; }

        /// <summary>
        /// High-frequency storage period. Valid values:3 - 3 days;7 - One week;30 - One month;90 - Three months;180 - Six months;365 - One year;1095 - Three years;1825 - Five years.
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public ulong? HighLogExpireDay{ get; set; }

        /// <summary>
        /// Low-frequency storage period (in days). This equals the log retention period minus the high-frequency storage period.
        /// </summary>
        [JsonProperty("LowLogExpireDay")]
        public ulong? LowLogExpireDay{ get; set; }

        /// <summary>
        /// Log storage volume (in GB).
        /// </summary>
        [JsonProperty("BillingAmount")]
        public float? BillingAmount{ get; set; }

        /// <summary>
        /// High-frequency storage volume (in GB).
        /// </summary>
        [JsonProperty("HighRealStorage")]
        public float? HighRealStorage{ get; set; }

        /// <summary>
        /// Low-frequency storage volume (in GB).
        /// </summary>
        [JsonProperty("LowRealStorage")]
        public float? LowRealStorage{ get; set; }

        /// <summary>
        /// Whether full audit is enabled. true - Full audit.
        /// </summary>
        [JsonProperty("AuditAll")]
        public bool? AuditAll{ get; set; }

        /// <summary>
        /// Time when the audit service was activated.
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// Related information about the instance.
        /// </summary>
        [JsonProperty("InstanceInfo")]
        public AuditInstanceInfo InstanceInfo{ get; set; }

        /// <summary>
        /// Total storage volume (in GB).
        /// </summary>
        [JsonProperty("RealStorage")]
        public float? RealStorage{ get; set; }

        /// <summary>
        /// Whether an audit policy is configured.
        /// </summary>
        [JsonProperty("OldRule")]
        public bool? OldRule{ get; set; }

        /// <summary>
        /// Rule template applied to the instance.
        /// </summary>
        [JsonProperty("RuleTemplateIds")]
        public string[] RuleTemplateIds{ get; set; }

        /// <summary>
        /// Trial status.
        /// </summary>
        [JsonProperty("TrialStatus")]
        public string TrialStatus{ get; set; }

        /// <summary>
        /// Trial start time.
        /// </summary>
        [JsonProperty("TrialStartTime")]
        public long? TrialStartTime{ get; set; }

        /// <summary>
        /// Trial duration.
        /// </summary>
        [JsonProperty("TrialDuration")]
        public long? TrialDuration{ get; set; }

        /// <summary>
        /// Trial end time.
        /// </summary>
        [JsonProperty("TrialCloseTime")]
        public long? TrialCloseTime{ get; set; }

        /// <summary>
        /// Log query time limit during the trial period.
        /// </summary>
        [JsonProperty("TrialDescribeLogHours")]
        public long? TrialDescribeLogHours{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "AuditTask", this.AuditTask);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HighLogExpireDay", this.HighLogExpireDay);
            this.SetParamSimple(map, prefix + "LowLogExpireDay", this.LowLogExpireDay);
            this.SetParamSimple(map, prefix + "BillingAmount", this.BillingAmount);
            this.SetParamSimple(map, prefix + "HighRealStorage", this.HighRealStorage);
            this.SetParamSimple(map, prefix + "LowRealStorage", this.LowRealStorage);
            this.SetParamSimple(map, prefix + "AuditAll", this.AuditAll);
            this.SetParamSimple(map, prefix + "CreateAt", this.CreateAt);
            this.SetParamObj(map, prefix + "InstanceInfo.", this.InstanceInfo);
            this.SetParamSimple(map, prefix + "RealStorage", this.RealStorage);
            this.SetParamSimple(map, prefix + "OldRule", this.OldRule);
            this.SetParamArraySimple(map, prefix + "RuleTemplateIds.", this.RuleTemplateIds);
            this.SetParamSimple(map, prefix + "TrialStatus", this.TrialStatus);
            this.SetParamSimple(map, prefix + "TrialStartTime", this.TrialStartTime);
            this.SetParamSimple(map, prefix + "TrialDuration", this.TrialDuration);
            this.SetParamSimple(map, prefix + "TrialCloseTime", this.TrialCloseTime);
            this.SetParamSimple(map, prefix + "TrialDescribeLogHours", this.TrialDescribeLogHours);
        }
    }
}

