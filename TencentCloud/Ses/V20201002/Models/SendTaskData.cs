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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendTaskData : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// Sender address
        /// </summary>
        [JsonProperty("FromEmailAddress")]
        public string FromEmailAddress{ get; set; }

        /// <summary>
        /// Recipient group ID
        /// </summary>
        [JsonProperty("ReceiverId")]
        public ulong? ReceiverId{ get; set; }

        /// <summary>
        /// Task status. `1`: to start; `5`: sending; `6`: sending suspended today; `7`: sending error; `10`: sent
        /// </summary>
        [JsonProperty("TaskStatus")]
        public ulong? TaskStatus{ get; set; }

        /// <summary>
        /// Task type. `1`: immediate; `2`: scheduled; `3`: recurring
        /// </summary>
        [JsonProperty("TaskType")]
        public ulong? TaskType{ get; set; }

        /// <summary>
        /// Number of emails requested to be sent
        /// </summary>
        [JsonProperty("RequestCount")]
        public ulong? RequestCount{ get; set; }

        /// <summary>
        /// Number of emails sent
        /// </summary>
        [JsonProperty("SendCount")]
        public ulong? SendCount{ get; set; }

        /// <summary>
        /// Number of emails cached
        /// </summary>
        [JsonProperty("CacheCount")]
        public ulong? CacheCount{ get; set; }

        /// <summary>
        /// Task creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Task update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Email subject
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// Template and template data
        /// Note: This field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("Template")]
        public Template Template{ get; set; }

        /// <summary>
        /// Parameters of a recurring task
        /// Note: This field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("CycleParam")]
        public CycleEmailParam CycleParam{ get; set; }

        /// <summary>
        /// Parameters of a scheduled task
        /// Note: This field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("TimedParam")]
        public TimedEmailParam TimedParam{ get; set; }

        /// <summary>
        /// Task exception information
        /// Note: This field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// Recipient group name
        /// </summary>
        [JsonProperty("ReceiversName")]
        public string ReceiversName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "FromEmailAddress", this.FromEmailAddress);
            this.SetParamSimple(map, prefix + "ReceiverId", this.ReceiverId);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "RequestCount", this.RequestCount);
            this.SetParamSimple(map, prefix + "SendCount", this.SendCount);
            this.SetParamSimple(map, prefix + "CacheCount", this.CacheCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamObj(map, prefix + "Template.", this.Template);
            this.SetParamObj(map, prefix + "CycleParam.", this.CycleParam);
            this.SetParamObj(map, prefix + "TimedParam.", this.TimedParam);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "ReceiversName", this.ReceiversName);
        }
    }
}

