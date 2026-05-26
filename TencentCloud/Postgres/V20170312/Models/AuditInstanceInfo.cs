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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Enabled</p><p>Enumeration value:</p><ul><li>OFF: Off</li><li>ON: On</li></ul>
        /// </summary>
        [JsonProperty("AuditStatus")]
        public string AuditStatus{ get; set; }

        /// <summary>
        /// <p>Log storage validity period</p><p>Unit: day</p>
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public ulong? LogExpireDay{ get; set; }

        /// <summary>
        /// <p>Hot storage period</p><p>Unit: day</p>
        /// </summary>
        [JsonProperty("HotLogExpireDay")]
        public ulong? HotLogExpireDay{ get; set; }

        /// <summary>
        /// <p>Cold storage period</p><p>Unit: day</p>
        /// </summary>
        [JsonProperty("ColdLogExpireDay")]
        public ulong? ColdLogExpireDay{ get; set; }

        /// <summary>
        /// <p>Hot storage size</p><p>Unit: MB</p>
        /// </summary>
        [JsonProperty("HotLogSize")]
        public float? HotLogSize{ get; set; }

        /// <summary>
        /// <p>Cold storage size</p><p>Unit: MB</p>
        /// </summary>
        [JsonProperty("ColdLogSize")]
        public float? ColdLogSize{ get; set; }

        /// <summary>
        /// <p>Start time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Delivery status</p>
        /// </summary>
        [JsonProperty("Deliver")]
        public string Deliver{ get; set; }

        /// <summary>
        /// <p>Shipping information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeliverSummary")]
        public DeliverSummary[] DeliverSummary{ get; set; }

        /// <summary>
        /// <p>Instance information</p>
        /// </summary>
        [JsonProperty("InstanceInfo")]
        public LogInstanceInfo InstanceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HotLogExpireDay", this.HotLogExpireDay);
            this.SetParamSimple(map, prefix + "ColdLogExpireDay", this.ColdLogExpireDay);
            this.SetParamSimple(map, prefix + "HotLogSize", this.HotLogSize);
            this.SetParamSimple(map, prefix + "ColdLogSize", this.ColdLogSize);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Deliver", this.Deliver);
            this.SetParamArrayObj(map, prefix + "DeliverSummary.", this.DeliverSummary);
            this.SetParamObj(map, prefix + "InstanceInfo.", this.InstanceInfo);
        }
    }
}

