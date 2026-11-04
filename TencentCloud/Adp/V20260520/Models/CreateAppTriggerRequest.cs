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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAppTriggerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Application ID.</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>Application trigger execution configuration</p>
        /// </summary>
        [JsonProperty("ExecuteConfig")]
        public ExecuteConfig ExecuteConfig{ get; set; }

        /// <summary>
        /// <table> <tbody> <tr> <td>Enumeration item</td> <td>Enumeration value</td> <td>Description</td> </tr> <tr> <td>APP_TRIGGER_EXECUTE_TYPE_UNSPECIFIED</td> <td>0</td> <td>Unspecified</td> </tr> <tr> <td>APP_TRIGGER_EXECUTE_TYPE_PROMPT</td> <td>1</td> <td>Command execution</td> </tr> <tr> <td>APP_TRIGGER_EXECUTE_TYPE_WORKFLOW</td> <td>2</td> <td>Workflow execution</td> </tr> </tbody> </table>
        /// </summary>
        [JsonProperty("ExecuteType")]
        public long? ExecuteType{ get; set; }

        /// <summary>
        /// <p>Third-party push configuration</p>
        /// </summary>
        [JsonProperty("PushConfig")]
        public TimerPushConfig PushConfig{ get; set; }

        /// <summary>
        /// <table> <tbody> <tr> <td>Enumeration item</td> <td>Enumeration value</td> <td>Description</td> </tr> <tr> <td>APP_TRIGGER_SCOPE_UNSPECIFIED</td> <td>0</td> <td>Unspecified</td> </tr> <tr> <td>APP_TRIGGER_SCOPE_APP</td> <td>1</td> <td>B-end admin</td> </tr> <tr> <td>APP_TRIGGER_SCOPE_USER</td> <td>2</td> <td>C-end visitor</td> </tr> </tbody> </table>
        /// </summary>
        [JsonProperty("Scope")]
        public long? Scope{ get; set; }

        /// <summary>
        /// <p>Trigger configuration</p>
        /// </summary>
        [JsonProperty("TriggerConfig")]
        public TriggerConfig TriggerConfig{ get; set; }

        /// <summary>
        /// <p>Trigger name.</p>
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// <table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>APP_TRIGGER_TYPE_UNSPECIFIED</td><td>0</td><td>Unspecified</td></tr><tr><td>APP_TRIGGER_TYPE_SCHEDULED</td><td>1</td><td>Scheduled trigger</td></tr><tr><td>APP_TRIGGER_TYPE_WEBHOOK</td><td>2</td><td>Webhook trigger</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("TriggerType")]
        public long? TriggerType{ get; set; }

        /// <summary>
        /// <p>Visitor ID.</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamObj(map, prefix + "ExecuteConfig.", this.ExecuteConfig);
            this.SetParamSimple(map, prefix + "ExecuteType", this.ExecuteType);
            this.SetParamObj(map, prefix + "PushConfig.", this.PushConfig);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamObj(map, prefix + "TriggerConfig.", this.TriggerConfig);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

