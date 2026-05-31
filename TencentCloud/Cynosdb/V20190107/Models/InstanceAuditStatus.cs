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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceAuditStatus : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AuditStatus")]
        public string AuditStatus{ get; set; }

        /// <summary>
        /// Specifies the log retention period.
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public ulong? LogExpireDay{ get; set; }

        /// <summary>
        /// High-Frequency storage duration.
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public ulong? HighLogExpireDay{ get; set; }

        /// <summary>
        /// Specifies the duration of low-frequency storage.
        /// </summary>
        [JsonProperty("LowLogExpireDay")]
        public ulong? LowLogExpireDay{ get; set; }

        /// <summary>
        /// Specifies the log storage volume.
        /// </summary>
        [JsonProperty("BillingAmount")]
        public float? BillingAmount{ get; set; }

        /// <summary>
        /// Specifies the high-frequency storage volume.
        /// </summary>
        [JsonProperty("HighRealStorage")]
        public float? HighRealStorage{ get; set; }

        /// <summary>
        /// Specifies the infrequent access storage size.
        /// </summary>
        [JsonProperty("LowRealStorage")]
        public float? LowRealStorage{ get; set; }

        /// <summary>
        /// Specifies whether it is a full audit. true - indicates a full audit.
        /// </summary>
        [JsonProperty("AuditAll")]
        public bool? AuditAll{ get; set; }

        /// <summary>
        /// Specifies the audit activation time.
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// Instance-Related information.
        /// </summary>
        [JsonProperty("InstanceInfo")]
        public AuditInstanceInfo InstanceInfo{ get; set; }

        /// <summary>
        /// Specifies the total storage capacity.
        /// </summary>
        [JsonProperty("RealStorage")]
        public float? RealStorage{ get; set; }

        /// <summary>
        /// The rule template applied to the instance.
        /// </summary>
        [JsonProperty("RuleTemplateIds")]
        public string[] RuleTemplateIds{ get; set; }

        /// <summary>
        /// Specifies whether to enable log delivery: ON, OFF.
        /// </summary>
        [JsonProperty("Deliver")]
        public string Deliver{ get; set; }

        /// <summary>
        /// Log shipping type.
        /// </summary>
        [JsonProperty("DeliverSummary")]
        public DeliverSummary[] DeliverSummary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
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
            this.SetParamArraySimple(map, prefix + "RuleTemplateIds.", this.RuleTemplateIds);
            this.SetParamSimple(map, prefix + "Deliver", this.Deliver);
            this.SetParamArrayObj(map, prefix + "DeliverSummary.", this.DeliverSummary);
        }
    }
}

