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

    public class AppTriggerRunLog : AbstractModel
    {
        
        /// <summary>
        /// <p>Session id</p>
        /// </summary>
        [JsonProperty("ConversationId")]
        public string ConversationId{ get; set; }

        /// <summary>
        /// <p>Execution time</p>
        /// </summary>
        [JsonProperty("DurationMs")]
        public string DurationMs{ get; set; }

        /// <summary>
        /// <p>End time</p><p>Parameter format: YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <table> <tbody> <tr> <td>Enumeration item</td> <td>Enumeration value</td> <td>Description</td> </tr> <tr> <td>APP_TRIGGER_FIRE_TYPE_UNSPECIFIED</td> <td>0</td> <td>Unspecified</td> </tr> <tr> <td>APP_TRIGGER_FIRE_TYPE_SCHEDULED</td> <td>1</td> <td>Scheduled trigger</td> </tr> <tr> <td>APP_TRIGGER_FIRE_TYPE_WEBHOOK</td> <td>2</td> <td>Webhook trigger</td> </tr> <tr> <td>APP_TRIGGER_FIRE_TYPE_MANUAL_RUN</td> <td>3</td> <td>Manual immediate execution</td> </tr> <tr> <td>APP_TRIGGER_FIRE_TYPE_TEST_RUN</td> <td>4</td> <td>Test execution</td> </tr> </tbody> </table>
        /// </summary>
        [JsonProperty("FireType")]
        public long? FireType{ get; set; }

        /// <summary>
        /// <p>Trigger instance id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <table> <tbody> <tr> <td>Enumeration item</td> <td>Enumeration value</td> <td>Description</td> </tr> <tr> <td>TIMER_RUN_PUSH_STATUS_UNSPECIFIED</td> <td>0</td> <td>Unspecified</td> </tr> <tr> <td>TIMER_RUN_PUSH_STATUS_NONE</td> <td>1</td> <td>Push notification not configured</td> </tr> <tr> <td>TIMER_RUN_PUSH_STATUS_WAITING</td> <td>2</td> <td>Pending</td> </tr> <tr> <td>TIMER_RUN_PUSH_STATUS_SUCCESS</td> <td>3</td> <td>Push successful</td> </tr> <tr> <td>TIMER_RUN_PUSH_STATUS_FAILED</td> <td>4</td> <td>Push failure</td> </tr> </tbody> </table>
        /// </summary>
        [JsonProperty("PushStatus")]
        public long? PushStatus{ get; set; }

        /// <summary>
        /// <p>Result code</p>
        /// </summary>
        [JsonProperty("ResultCode")]
        public string ResultCode{ get; set; }

        /// <summary>
        /// <p>Result Overview</p>
        /// </summary>
        [JsonProperty("ResultSummary")]
        public string ResultSummary{ get; set; }

        /// <summary>
        /// <p>Single dialogue id</p>
        /// </summary>
        [JsonProperty("RunId")]
        public string RunId{ get; set; }

        /// <summary>
        /// <p>Trigger time</p><p>Parameter format: YYYY:MM:DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("ScheduledFireTime")]
        public string ScheduledFireTime{ get; set; }

        /// <summary>
        /// <table> <tbody> <tr> <td>Enumeration item</td> <td>Enumeration value</td> <td>Description</td> </tr> <tr> <td>APP_TRIGGER_SCOPE_UNSPECIFIED</td> <td>0</td> <td>Unspecified</td> </tr> <tr> <td>APP_TRIGGER_SCOPE_APP</td> <td>1</td> <td>B-end admin</td> </tr> <tr> <td>APP_TRIGGER_SCOPE_USER</td> <td>2</td> <td>C-end visitor</td> </tr> </tbody> </table>
        /// </summary>
        [JsonProperty("Scope")]
        public long? Scope{ get; set; }

        /// <summary>
        /// <p>Execution start time</p><p>Parameter format: YYYY:MM:DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <table> <tbody> <tr> <td>Enumeration item</td> <td>Enumeration value</td> <td>Description</td> </tr> <tr> <td>TIMER_RUN_STATUS_UNSPECIFIED</td> <td>0</td> <td>Unspecified</td> </tr> <tr> <td>TIMER_RUN_STATUS_PENDING</td> <td>1</td> <td>Waiting to execute</td> </tr> <tr> <td>TIMER_RUN_STATUS_RUNNING</td> <td>2</td> <td>Executing</td> </tr> <tr> <td>TIMER_RUN_STATUS_RETRY_WAIT</td> <td>3</td> <td>Wait for retry</td> </tr> <tr> <td>TIMER_RUN_STATUS_SUCCESS</td> <td>4</td> <td>Successful</td> </tr> <tr> <td>TIMER_RUN_STATUS_DEAD</td> <td>5</td> <td>Failed final state (retry exhausted / non-retriable)</td> </tr> <tr> <td>TIMER_RUN_STATUS_CANCELLED</td> <td>6</td> <td>Cancelled due to task pause/deletion/modification</td> </tr> </tbody> </table>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Trigger id</p>
        /// </summary>
        [JsonProperty("TriggerId")]
        public string TriggerId{ get; set; }

        /// <summary>
        /// <p>Whether it has been read</p>
        /// </summary>
        [JsonProperty("Unread")]
        public bool? Unread{ get; set; }

        /// <summary>
        /// <p>Visitor Id</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>Workflow run id</p>
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConversationId", this.ConversationId);
            this.SetParamSimple(map, prefix + "DurationMs", this.DurationMs);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "FireType", this.FireType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PushStatus", this.PushStatus);
            this.SetParamSimple(map, prefix + "ResultCode", this.ResultCode);
            this.SetParamSimple(map, prefix + "ResultSummary", this.ResultSummary);
            this.SetParamSimple(map, prefix + "RunId", this.RunId);
            this.SetParamSimple(map, prefix + "ScheduledFireTime", this.ScheduledFireTime);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TriggerId", this.TriggerId);
            this.SetParamSimple(map, prefix + "Unread", this.Unread);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
        }
    }
}

