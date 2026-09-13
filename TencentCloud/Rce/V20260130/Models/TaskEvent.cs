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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>The ID of the promotion</p>
        /// </summary>
        [JsonProperty("PromotionId")]
        public string PromotionId{ get; set; }

        /// <summary>
        /// <p>The name of the promotion</p>
        /// </summary>
        [JsonProperty("PromotionName")]
        public string PromotionName{ get; set; }

        /// <summary>
        /// <p>The description of the promotion</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>The ID of the inviter</p>
        /// </summary>
        [JsonProperty("InviterUserId")]
        public string InviterUserId{ get; set; }

        /// <summary>
        /// <p>The ID of the task</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>The name of the task</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Task type, such as daily check-in, ad viewing, or step accumulation</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>Task completed duration</p><p>Measurement unit: ms</p>
        /// </summary>
        [JsonProperty("TaskCostTime")]
        public long? TaskCostTime{ get; set; }

        /// <summary>
        /// <p>The custom parameters agreed with RCE. An array of objects in K:V format. e.g.[{"Key": "ApproverName", "Value": "bob"},{"Key":"ApproverPhone","Value": "+86131****5678"}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PromotionId", this.PromotionId);
            this.SetParamSimple(map, prefix + "PromotionName", this.PromotionName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InviterUserId", this.InviterUserId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TaskCostTime", this.TaskCostTime);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

