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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditInstance : AbstractModel
    {
        
        /// <summary>
        /// Audit status. Valid values: `ON` (Enabled), `OFF` (Not enabled).
        /// </summary>
        [JsonProperty("AuditStatus")]
        public string AuditStatus{ get; set; }

        /// <summary>
        /// Audit log size. This parameter is only used for the free trial edition of Database Audit.
        /// </summary>
        [JsonProperty("BillingAmount")]
        public long? BillingAmount{ get; set; }

        /// <summary>
        /// Billing confirmation status. Valid values: `0` (Unconfirmed), `1` (Confirmed).
        /// </summary>
        [JsonProperty("BillingConfirmed")]
        public long? BillingConfirmed{ get; set; }

        /// <summary>
        /// Infrequent access storage period
        /// </summary>
        [JsonProperty("ColdLogExpireDay")]
        public long? ColdLogExpireDay{ get; set; }

        /// <summary>
        /// Storage size of infrequently accessed logs in MB
        /// </summary>
        [JsonProperty("ColdLogSize")]
        public long? ColdLogSize{ get; set; }

        /// <summary>
        /// Storage period of frequently accessed logs in days
        /// </summary>
        [JsonProperty("HotLogExpireDay")]
        public long? HotLogExpireDay{ get; set; }

        /// <summary>
        /// Storage size of frequently accessed logs in MB
        /// </summary>
        [JsonProperty("HotLogSize")]
        public long? HotLogSize{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Log retention period in days, which is the sum of the frequent and infrequent access storage periods.
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public long? LogExpireDay{ get; set; }

        /// <summary>
        /// Instance creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Instance details
        /// </summary>
        [JsonProperty("InstanceInfo")]
        public AuditInstanceInfo InstanceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "BillingAmount", this.BillingAmount);
            this.SetParamSimple(map, prefix + "BillingConfirmed", this.BillingConfirmed);
            this.SetParamSimple(map, prefix + "ColdLogExpireDay", this.ColdLogExpireDay);
            this.SetParamSimple(map, prefix + "ColdLogSize", this.ColdLogSize);
            this.SetParamSimple(map, prefix + "HotLogExpireDay", this.HotLogExpireDay);
            this.SetParamSimple(map, prefix + "HotLogSize", this.HotLogSize);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "InstanceInfo.", this.InstanceInfo);
        }
    }
}

