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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MessageEnrichmentRuleItem : AbstractModel
    {
        
        /// <summary>
        /// Rule ID.
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// MQTT cluster ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Specifies the rule name.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule matching conditions, in JSON format, must be Base64-encoded. 
        /// Specifies the client id, username, and topic. example: {"clientId":"client-1","username":"client-1","topic":"home/room1"}.
        /// Specifies the Base64-encoded string "eyJjbGllbnRJZCI6ImNsaWVudC0xIiwidXNlcm5hbWUiOiJjbGllbnQtMSIsInRvcGljIjoiaG9tZS9yb29tMSJ9".
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// Specifies the action of rule execution in JSON format, which must be Base64 encoded.
        ///  Creating a Billing Resource Order
        /// {"messageExpiryInterval":360,"response Topic":"replies/devices/${clientid}","correlationData":"${traceid}","userProperty":[{"key":"trace-id","value":"${traceid}"},{"key":"data-source","value":"rule-engine"}]}
        /// Specifies the BASE64-encoded string "eyJtZXNzYWdlRXhwaXJ5SW50ZXJ2YWwiOjM2MCwicmVzcG9uc2UgVG9waWMiOiJyZXBsaWVzL2RldmljZXMvJHtjbGllbnRpZH0iLCJjb3JyZWxhdGlvbkRhdGEiOiIke3RyYWNlaWR9IiwidXNlclByb3BlcnR5IjpbeyJrZXkiOiJ0cmFjZS1pZCIsInZhbHVlIjoiJHt0cmFjZWlkfSJ9LHsia2V5IjoiZGF0YS1zb3VyY2UiLCJ2YWx1ZSI6InJ1bGUtZW5naW5lIn1dfQ==".
        /// </summary>
        [JsonProperty("Actions")]
        public string Actions{ get; set; }

        /// <summary>
        /// Rule priority. a smaller number indicates a higher priority. high priority overrides low priority. the UserProperty field will be merged.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// Rule status. valid values: 0 (undefined), 1 (activate), 2 (deactivate). default: deactivate.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Creation time. millisecond-level timestamp.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// Update time. millisecond-level timestamp.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "Actions", this.Actions);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

