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

    public class AppTriggerSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>Application ID.</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>APP_TRIGGER_EXECUTE_TYPE_UNSPECIFIED</td><td>0</td><td>Unspecified</td></tr><tr><td>APP_TRIGGER_EXECUTE_TYPE_PROMPT</td><td>1</td><td>Command execution</td></tr><tr><td>APP_TRIGGER_EXECUTE_TYPE_WORKFLOW</td><td>2</td><td>Workflow execution</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("ExecuteType")]
        public long? ExecuteType{ get; set; }

        /// <summary>
        /// <p>Number of failures</p>
        /// </summary>
        [JsonProperty("FailedCount")]
        public string FailedCount{ get; set; }

        /// <summary>
        /// <p>Last session id</p>
        /// </summary>
        [JsonProperty("LastSessionId")]
        public string LastSessionId{ get; set; }

        /// <summary>
        /// <table> <tbody> <tr> <td>Enumeration item</td> <td>Enumeration value</td> <td>Description</td> </tr> <tr> <td>APP_TRIGGER_SCOPE_UNSPECIFIED</td> <td>0</td> <td>Unspecified</td> </tr> <tr> <td>APP_TRIGGER_SCOPE_APP</td> <td>1</td> <td>B-end admin</td> </tr> <tr> <td>APP_TRIGGER_SCOPE_USER</td> <td>2</td> <td>C-end visitor</td> </tr> </tbody> </table> <p>Value range: [0, 2]</p>
        /// </summary>
        [JsonProperty("Scope")]
        public long? Scope{ get; set; }

        /// <summary>
        /// <table> <tbody> <tr> <td>Enumeration item</td> <td>Enumeration value</td> <td>Description</td> </tr> <tr> <td>APP_TRIGGER_STATUS_UNSPECIFIED</td> <td>0</td> <td>Unspecified</td> </tr> <tr> <td>APP_TRIGGER_STATUS_ENABLED</td> <td>1</td> <td>Enablement</td> </tr> <tr> <td>APP_TRIGGER_STATUS_PAUSED</td> <td>2</td> <td>Suspension</td> </tr> <tr> <td>APP_TRIGGER_STATUS_DELETED</td> <td>3</td> <td>Deleted</td> </tr> </tbody> </table>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Number of successes</p>
        /// </summary>
        [JsonProperty("SuccessCount")]
        public string SuccessCount{ get; set; }

        /// <summary>
        /// <p>Trigger id.</p>
        /// </summary>
        [JsonProperty("TriggerId")]
        public string TriggerId{ get; set; }

        /// <summary>
        /// <p>Trigger name</p>
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// <p>Trigger execution status</p>
        /// </summary>
        [JsonProperty("TriggerStatus")]
        public TriggerStatus TriggerStatus{ get; set; }

        /// <summary>
        /// <table> <tbody> <tr> <td>Enumeration item</td> <td>Enumeration value</td> <td>Description</td> </tr> <tr> <td>APP_TRIGGER_TYPE_UNSPECIFIED</td> <td>0</td> <td>Unspecified</td> </tr> <tr> <td>APP_TRIGGER_TYPE_SCHEDULED</td> <td>1</td> <td>Scheduled trigger</td> </tr> <tr> <td>APP_TRIGGER_TYPE_WEBHOOK</td> <td>2</td> <td>Webhook trigger</td> </tr> </tbody> </table>
        /// </summary>
        [JsonProperty("TriggerType")]
        public long? TriggerType{ get; set; }

        /// <summary>
        /// <p>The number of unread logs</p>
        /// </summary>
        [JsonProperty("UnreadRunLogCount")]
        public string UnreadRunLogCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "ExecuteType", this.ExecuteType);
            this.SetParamSimple(map, prefix + "FailedCount", this.FailedCount);
            this.SetParamSimple(map, prefix + "LastSessionId", this.LastSessionId);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "TriggerId", this.TriggerId);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamObj(map, prefix + "TriggerStatus.", this.TriggerStatus);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "UnreadRunLogCount", this.UnreadRunLogCount);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

