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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogInstance : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Log status, create: creating; normal: enabled; close: turning off.</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Is it possible to switch log query - Value: yes - allowed, no - not allowed. This parameter mainly controls migration of existing logs to the log platform for query usage. Only when the status is yes can you call the log API.</p>
        /// </summary>
        [JsonProperty("EnableQuery")]
        public string EnableQuery{ get; set; }

        /// <summary>
        /// <p>Start time</p>
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// <p>High frequency storage days</p>
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public long? HighLogExpireDay{ get; set; }

        /// <summary>
        /// <p>Infrequent storage days</p>
        /// </summary>
        [JsonProperty("LowLogExpireDay")]
        public long? LowLogExpireDay{ get; set; }

        /// <summary>
        /// <p>Total storage duration</p>
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public long? LogExpireDay{ get; set; }

        /// <summary>
        /// <p>High-frequency storage volume (in MB)</p>
        /// </summary>
        [JsonProperty("HighStorage")]
        public float? HighStorage{ get; set; }

        /// <summary>
        /// <p>Infrequent access storage, unit: MB</p>
        /// </summary>
        [JsonProperty("LowStorage")]
        public float? LowStorage{ get; set; }

        /// <summary>
        /// <p>Total storage</p>
        /// </summary>
        [JsonProperty("LogStorage")]
        public float? LogStorage{ get; set; }

        /// <summary>
        /// <p>Whether to enable delivery: ON, OFF</p>
        /// </summary>
        [JsonProperty("Deliver")]
        public string Deliver{ get; set; }

        /// <summary>
        /// <p>Log shipping information</p>
        /// </summary>
        [JsonProperty("DeliverSummary")]
        public DeliverSummary[] DeliverSummary{ get; set; }

        /// <summary>
        /// <p>Instance-related information on the business side varies according to business and returns different information.</p>
        /// </summary>
        [JsonProperty("InstanceInfo")]
        public InstanceInfo InstanceInfo{ get; set; }

        /// <summary>
        /// <p>Audit sub-type.</p>
        /// </summary>
        [JsonProperty("LogSubType")]
        public string LogSubType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EnableQuery", this.EnableQuery);
            this.SetParamSimple(map, prefix + "CreateAt", this.CreateAt);
            this.SetParamSimple(map, prefix + "HighLogExpireDay", this.HighLogExpireDay);
            this.SetParamSimple(map, prefix + "LowLogExpireDay", this.LowLogExpireDay);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HighStorage", this.HighStorage);
            this.SetParamSimple(map, prefix + "LowStorage", this.LowStorage);
            this.SetParamSimple(map, prefix + "LogStorage", this.LogStorage);
            this.SetParamSimple(map, prefix + "Deliver", this.Deliver);
            this.SetParamArrayObj(map, prefix + "DeliverSummary.", this.DeliverSummary);
            this.SetParamObj(map, prefix + "InstanceInfo.", this.InstanceInfo);
            this.SetParamSimple(map, prefix + "LogSubType", this.LogSubType);
        }
    }
}

